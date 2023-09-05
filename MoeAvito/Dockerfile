FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MoeAvito/MoeAvito.csproj", "MoeAvito/"]
RUN dotnet restore "MoeAvito/MoeAvito.csproj"
COPY . .
WORKDIR "/src/MoeAvito"
RUN dotnet build "MoeAvito.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MoeAvito.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MoeAvito.dll"]
