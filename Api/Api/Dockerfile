##By Renato Groffe####
#Dockerfile para criar uma imagem de uma API .NET Core 2.2#

FROM microsoft/dotnet:2.2-sdk-alpine AS build-env
WORKDIR /app

# Copiar csproj e restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Build da aplicacao
COPY . ./
RUN dotnet publish -c Release -o out

# Build da imagem
FROM microsoft/dotnet:2.2-sdk-alpine
WORKDIR /app
COPY --from=build-env /app/out .
CMD ["dotnet", "Api.dll"]