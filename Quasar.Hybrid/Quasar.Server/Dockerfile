#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Quasar.Server/Quasar.Server.csproj", "Quasar.Server/"]
COPY ["Quasar.Hybrid.Shared/Quasar.Hybrid.Shared.csproj", "Quasar.Hybrid.Shared/"]
COPY ["Quasar.Core.Native/Quasar.Core.Native.csproj", "Quasar.Core.Native/"]
COPY ["Quasar.Core/Quasar.Core.csproj", "Quasar.Core/"]
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