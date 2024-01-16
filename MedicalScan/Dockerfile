FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MedicalScan/MedicalScan.csproj", "MedicalScan/"]
RUN dotnet restore "MedicalScan/MedicalScan.csproj"
COPY . .
WORKDIR "/src/MedicalScan"
RUN dotnet build "MedicalScan.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MedicalScan.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MedicalScan.dll"]