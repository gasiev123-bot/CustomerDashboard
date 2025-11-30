# Use official Microsoft IIS image for ASP.NET 4.8
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019

# Set working directory inside container
WORKDIR /inetpub/wwwroot

# Copy everything in this folder into the container
COPY . .

# Expose HTTP port
EXPOSE 80

# IIS serves the app automatically from wwwroot
