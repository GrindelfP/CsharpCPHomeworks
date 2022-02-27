FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hw001/Hw001.csproj", "Hw001/"]
RUN dotnet restore "Hw001/Hw001.csproj"
COPY . .
WORKDIR "/src/Hw001"
RUN dotnet build "Hw001.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hw001.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hw001.dll"]
