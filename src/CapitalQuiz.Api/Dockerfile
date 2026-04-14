# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy everything
COPY . .

# Restore and publish
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

# Copy published output
COPY --from=build /app/publish .

# Render requires the app to listen on port 8080
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Replace with your actual DLL name:
ENTRYPOINT ["dotnet", "CapitalQuiz.Api.dll"]
