FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hw0217/Hw0217.csproj", "Hw0217/"]
RUN dotnet restore "Hw0217/Hw0217.csproj"
COPY . .
WORKDIR "/src/Hw0217"
RUN dotnet build "Hw0217.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hw0217.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hw0217.dll"]
