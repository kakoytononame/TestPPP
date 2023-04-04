FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TuauorialAPI/TuauorialAPI.csproj", "TuauorialAPI/"]
RUN dotnet restore "TuauorialAPI/TuauorialAPI.csproj"
COPY . .
WORKDIR "/src/TuauorialAPI"
RUN dotnet build "TuauorialAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TuauorialAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TuauorialAPI.dll"]
