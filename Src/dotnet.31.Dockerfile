# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Azihub.GlobalData.Banks/Azihub.GlobalData.Banks.csproj ./Azihub.GlobalData.Banks/
COPY ./Azihub.GlobalData.Base/Azihub.GlobalData.Base.csproj ./Azihub.GlobalData.Base/
COPY ./Azihub.GlobalData.Base.Tests/Azihub.GlobalData.Base.Tests.csproj ./Azihub.GlobalData.Base.Tests/
RUN dotnet restore Azihub.GlobalData.Base.Tests/Azihub.GlobalData.Base.Tests.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
RUN dotnet test

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "aspnetapp.dll"]