#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 5cdedd32-3eb4-49c2-97ae-b2e5c6f5a154 -t
    fi
    cd ../
fi

docker-compose up -d
