FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ExceptionMiddleware/ExceptionMiddleware.csproj", "ExceptionMiddleware/"]
RUN dotnet restore "ExceptionMiddleware/ExceptionMiddleware.csproj"
COPY . .
WORKDIR "/src/ExceptionMiddleware"
RUN dotnet build "ExceptionMiddleware.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExceptionMiddleware.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExceptionMiddleware.dll"]
