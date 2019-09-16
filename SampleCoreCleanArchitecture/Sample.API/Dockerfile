FROM microsoft/aspnetcore:2.0-stretch AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-stretch AS build
WORKDIR /src
COPY ["Sample.API/Sample.API.csproj", "Sample.API/"]
RUN dotnet restore "Sample.API/Sample.API.csproj"
COPY . .
WORKDIR "/src/Sample.API"
RUN dotnet build "Sample.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Sample.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Sample.API.dll"]