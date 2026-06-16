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
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --security-scheme ApiKey:Header:X-API-KEY \
  --namespace Neuphonic \
  --clientClassName NeuphonicClient \
  --targetFramework net10.0 \
  --output Generated \
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
