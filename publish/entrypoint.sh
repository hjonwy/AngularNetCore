#!/bin/bash
set -e
#run_cmd="dotnet run --server.urls http://*:80"

#until dotnet ef database update; do
#>&2 echo "SQL Server is starting up"
#sleep 1doc
#done

>&2 echo "SQL Server is up - executing command"
dotnet AngularCore31.dll
