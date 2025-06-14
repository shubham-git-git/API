#Base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 base
WORKDIR /app
EXPOSE

#build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

#FInal stage
FROM base as final
WORKDIR /app
COPY --from-build /app/publish
ENTRYPOINT ["dotnet","api.dll"]