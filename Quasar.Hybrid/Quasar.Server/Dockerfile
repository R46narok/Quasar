#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Quasar.Server/Quasar.Server.csproj", "Quasar.Server/"]
COPY ["Quasar.Core.DataAccess/Quasar.Core.DataAccess.csproj", "Quasar.Core.DataAccess/"]
COPY ["Quasar.Core/Quasar.Core.csproj", "Quasar.Core/"]
COPY ["Quasar.Hybrid.Shared/Quasar.Hybrid.Shared.csproj", "Quasar.Hybrid.Shared/"]
RUN dotnet restore "Quasar.Server/Quasar.Server.csproj"
COPY . .
WORKDIR "/src/Quasar.Server"
RUN dotnet build "Quasar.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Quasar.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Quasar.Server.dll"]