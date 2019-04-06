# WebAPI | .net core | Docker | AWS
Web API application on .net core hosted on Dcker for Windows and on AWS ECS

https://docs.docker.com/engine/examples/dotnetcore/

Commands:
---------
docker build -t webapi .

docker run -d -p 8181:80 webapi

docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" cocky_mendeleev

Download AWS CLI

[System.Net.WebRequest]::DefaultWebProxy.Credentials = [System.Net.CredentialCache]::DefaultCredentials

Install-Module -Name AWSPowerShell

Initialize-AWSDefaults

Invoke-Expression -Command (Get-ECRLoginCommand -Region us-east-2).Command

docker build -t webapi .

docker tag webapi:latest 427920183064.dkr.ecr.us-east-2.amazonaws.com/webapi:latest

docker push 427920183064.dkr.ecr.us-east-2.amazonaws.com/webapi:latest
