FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app
COPY ./*.csproj ./
WORKDIR /app
RUN dotnet restore
WORKDIR /app
COPY ./. ./
WORKDIR /app
RUN dotnet build -c Release -o out

FROM build as publish
RUN dotnet publish -c Release -o out

FROM base as final
WORKDIR /app
COPY --from=publish /app/out .
RUN rm appsettings.json

ENTRYPOINT ["dotnet", "chord.io-service.dll"]
