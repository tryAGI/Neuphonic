#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Manual OpenAPI source based on Neuphonic's official docs, SDKs, and live FastAPI spec:
# - https://docs.neuphonic.com/build-group/text-to-speech
# - https://docs.neuphonic.com/build-group/voice-cloning
# - https://docs.neuphonic.com/
# - https://github.com/neuphonic/pyneuphonic
# - https://github.com/neuphonic/neuphonic-js
# - https://api.neuphonic.com/openapi.json
# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}
install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection
rm -rf Generated
autosdk generate openapi.yaml \
  --security-scheme ApiKey:Header:X-API-KEY \
  --namespace Neuphonic \
  --clientClassName NeuphonicClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
  --exclude-deprecated-operations

rm -rf ../../cli/Neuphonic.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Neuphonic.CLI \
  --sdk-project ../../libs/Neuphonic/Neuphonic.csproj \
  --targetFramework net10.0 \
  --namespace Neuphonic \
  --clientClassName NeuphonicClient \
  --package-id Neuphonic.CLI \
  --tool-command-name neuphonic \
  --user-secrets-id Neuphonic.CLI \
  --api-key-env-var NEUPHONIC_API_KEY \
  --base-url-env-var NEUPHONIC_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-KEY
