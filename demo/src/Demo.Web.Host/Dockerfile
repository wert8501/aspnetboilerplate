FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Demo.Web.Host/Demo.Web.Host.csproj", "src/Demo.Web.Host/"]
COPY ["src/Demo.Web.Core/Demo.Web.Core.csproj", "src/Demo.Web.Core/"]
COPY ["src/Demo.Application/Demo.Application.csproj", "src/Demo.Application/"]
COPY ["src/Demo.Core/Demo.Core.csproj", "src/Demo.Core/"]
COPY ["src/Demo.EntityFrameworkCore/Demo.EntityFrameworkCore.csproj", "src/Demo.EntityFrameworkCore/"]
WORKDIR "/src/src/Demo.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Demo.Web.Host", "src/Demo.Web.Host"]
COPY ["src/Demo.Web.Core", "src/Demo.Web.Core"]
COPY ["src/Demo.Application", "src/Demo.Application"]
COPY ["src/Demo.Core", "src/Demo.Core"]
COPY ["src/Demo.EntityFrameworkCore", "src/Demo.EntityFrameworkCore"]
WORKDIR "/src/src/Demo.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Demo.Web.Host.dll"]
