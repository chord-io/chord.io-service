FROM microsoft/dotnet:3.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:3.1-sdk as build
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
