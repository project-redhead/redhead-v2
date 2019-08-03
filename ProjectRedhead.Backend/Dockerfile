FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ProjectRedhead.Backend/ProjectRedhead.Backend.csproj", "ProjectRedhead.Backend/"]
RUN dotnet restore "ProjectRedhead.Backend/ProjectRedhead.Backend.csproj"
COPY . .
WORKDIR "/src/ProjectRedhead.Backend"
RUN dotnet build "ProjectRedhead.Backend.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ProjectRedhead.Backend.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjectRedhead.Backend.dll"]