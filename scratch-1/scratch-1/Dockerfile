#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["scratch-1/scratch-1.csproj", "scratch-1/"]
RUN dotnet restore "scratch-1/scratch-1.csproj"
COPY . .
WORKDIR "/src/scratch-1"
RUN dotnet build "scratch-1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "scratch-1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "scratch-1.dll"]