#!/bin/bash
set -e
INTERNETIP="$(dig +short myip.opendns.com @resolver1.opendns.com)"
jq -n --arg internetip "$INTERNETIP" '{"internet_ip":$internetip}'