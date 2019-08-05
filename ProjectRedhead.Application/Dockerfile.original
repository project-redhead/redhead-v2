FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ProjectRedhead.Application/ProjectRedhead.Application.csproj", "ProjectRedhead.Application/"]
RUN dotnet restore "ProjectRedhead.Application/ProjectRedhead.Application.csproj"
COPY . .
WORKDIR "/src/ProjectRedhead.Application"
RUN dotnet build "ProjectRedhead.Application.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ProjectRedhead.Application.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjectRedhead.Application.dll"]