# Use the official .NET SDK image as a build environment
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Copy everything to the container
COPY . ./

# Restore dependencies
RUN dotnet restore

# Build the project
RUN dotnet publish -c Release -o out

# Use the runtime image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Copy the build output to the runtime container
COPY --from=build-env /app/out .

# Expose port 80 (you can change this port if needed)
EXPOSE 80

# Run the application
ENTRYPOINT ["dotnet", "OrdenarStringNumerica.dll"]
