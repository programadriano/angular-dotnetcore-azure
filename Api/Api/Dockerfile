FROM microsoft/dotnet:2.2-sdk-alpine AS build-env
WORKDIR /app

## Instalação e configuração do mongoDB
# atualizando apk do alpine
RUN apk update 

# criando diretórios para o volume do mongodb
RUN mkdir /data
RUN mkdir /data/db

# Instalando o mongodb
RUN apk add mongodb

## Voltando para o Projeto .NET

# Copiar csproj e restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Build da aplicacao
COPY . ./
RUN dotnet publish -c Release -o out

# Build da imagem
FROM tadrianonet/apinetcore:v1
WORKDIR /app
COPY --from=build-env /app/out .
CMD ["dotnet", "Api.dll"]