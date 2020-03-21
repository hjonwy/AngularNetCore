# Build runtime image, step1: go to publish folder, step2: docker build -t angularcore31:0317 . step2: docker run -itd -p 8818:80 --name=angularcore31 angularcore31

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY . .
#ENTRYPOINT ["dotnet", "AngularCore31.dll"]
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh
