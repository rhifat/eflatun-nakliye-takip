#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/EflatunNakliyeTakip.Web/EflatunNakliyeTakip.Web.csproj", "src/EflatunNakliyeTakip.Web/"]
COPY ["src/EflatunNakliyeTakip.Application/EflatunNakliyeTakip.Application.csproj", "src/EflatunNakliyeTakip.Application/"]
COPY ["src/EflatunNakliyeTakip.Application.Contracts/EflatunNakliyeTakip.Application.Contracts.csproj", "src/EflatunNakliyeTakip.Application.Contracts/"]
COPY ["src/EflatunNakliyeTakip.Domain.Shared/EflatunNakliyeTakip.Domain.Shared.csproj", "src/EflatunNakliyeTakip.Domain.Shared/"]
COPY ["src/EflatunNakliyeTakip.Domain/EflatunNakliyeTakip.Domain.csproj", "src/EflatunNakliyeTakip.Domain/"]
COPY ["src/EflatunNakliyeTakip.EntityFrameworkCore.DbMigrations/EflatunNakliyeTakip.EntityFrameworkCore.DbMigrations.csproj", "src/EflatunNakliyeTakip.EntityFrameworkCore.DbMigrations/"]
COPY ["src/EflatunNakliyeTakip.EntityFrameworkCore/EflatunNakliyeTakip.EntityFrameworkCore.csproj", "src/EflatunNakliyeTakip.EntityFrameworkCore/"]
COPY ["src/EflatunNakliyeTakip.HttpApi/EflatunNakliyeTakip.HttpApi.csproj", "src/EflatunNakliyeTakip.HttpApi/"]
RUN dotnet restore "src/EflatunNakliyeTakip.Web/EflatunNakliyeTakip.Web.csproj"
COPY . .
WORKDIR "/src/src/EflatunNakliyeTakip.Web"
RUN dotnet build "EflatunNakliyeTakip.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EflatunNakliyeTakip.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EflatunNakliyeTakip.Web.dll"]