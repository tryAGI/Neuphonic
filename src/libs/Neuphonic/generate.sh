#!/usr/bin/env bash
set -euo pipefail

# Manual OpenAPI source based on Neuphonic's official docs, SDKs, and live FastAPI spec:
# - https://docs.neuphonic.com/build-group/text-to-speech
# - https://docs.neuphonic.com/build-group/voice-cloning
# - https://docs.neuphonic.com/
# - https://github.com/neuphonic/pyneuphonic
# - https://github.com/neuphonic/neuphonic-js
# - https://api.neuphonic.com/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --security-scheme ApiKey:Header:X-API-KEY \
  --namespace Neuphonic \
  --clientClassName NeuphonicClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
