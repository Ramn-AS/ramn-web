# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build-env
WORKDIR /app
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
ENV DOTNET_RUNNING_IN_CONTAINER=true
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
RUN apk add --no-cache icu-libs
WORKDIR /app
COPY --from=build-env /app/out .
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "Ramn.Web.MVC.dll"]