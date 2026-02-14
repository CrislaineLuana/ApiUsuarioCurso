# =========================
# Runtime (.NET 8)
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# =========================
# Build (.NET 8 SDK)
# =========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copia o csproj com o caminho correto
COPY ["ApiUsuarioCurso/ApiUsuarioCurso.csproj", "ApiUsuarioCurso/"]
RUN dotnet restore "ApiUsuarioCurso/ApiUsuarioCurso.csproj"

# Copia o restante do código
COPY . .

# Entra na pasta do projeto
WORKDIR /src/ApiUsuarioCurso

# Build
RUN dotnet build "ApiUsuarioCurso.csproj" -c $BUILD_CONFIGURATION -o /app/build

# =========================
# Publish
# =========================
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ApiUsuarioCurso.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# =========================
# Final
# =========================
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiUsuarioCurso.dll"]
