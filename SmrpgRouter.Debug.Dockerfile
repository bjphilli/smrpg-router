FROM microsoft/dotnet:sdk

ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_URLS=http://+:5000

EXPOSE 5000

RUN apt-get -qq update && apt-get -qqy --no-install-recommends install wget gnupg \
    git \
    unzip

RUN curl -sL https://deb.nodesource.com/setup_6.x |  bash -
RUN apt-get install -y nodejs

WORKDIR /var/www/aspnetcoreapp

ENTRYPOINT ["/bin/bash", "-c", "cd src && dotnet restore && cd SmrpgRouter.Web && dotnet watch run"]
