FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hw0224/Hw0224.csproj", "Hw0224/"]
RUN dotnet restore "Hw0224/Hw0224.csproj"
COPY . .
WORKDIR "/src/Hw0224"
RUN dotnet build "Hw0224.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hw0224.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hw0224.dll"]
