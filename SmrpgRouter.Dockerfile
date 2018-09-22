# FROM microsoft/dotnet:sdk AS build-env

# WORKDIR /

# COPY ./SmrpgRouter.sln ./smrpgrouter/

# # Copy all the csproj files and restore to cache the layer for faster builds
# # The dotnet_build.sh script does this anyway, so superfluous, but docker can
# # cache the intermediate images so _much_ faster
# COPY ./src/SmrpgRouter.Domain/SmrpgRouter.Domain.csproj  ./smrpgrouter/src/SmrpgRouter.Domain/SmrpgRouter.Domain.csproj
# COPY ./src/SmrpgRouter.DAL/SmrpgRouter.DAL.csproj  ./smrpgrouter/src/SmrpgRouter.DAL/SmrpgRouter.DAL.csproj
# COPY ./src/SmrpgRouter.Web/SmrpgRouter.Web.csproj  ./smrpgrouter/src/SmrpgRouter.Web/SmrpgRouter.Web.csproj

# RUN cd ./smrpgrouter/ && dotnet restore

# # Copy everything else and build
# COPY . ./smrpgrouter/
# RUN cd ./smrpgrouter/ && dotnet publish -c Release -o out

# FROM node:10.10.0
# WORKDIR /
# COPY --from=build-env ./smrpgrouter/ ./smrpgrouter/
# RUN ls
# RUN cd ./smrpgrouter/src/SmrpgRouter.Web && yarn install && ./node_modules/.bin/webpack

# # Build runtime image
# FROM microsoft/dotnet:aspnetcore-runtime
# WORKDIR /
# COPY --from=node:10.10.0 . /smrpgrouter/
# RUN ls ./smrpgrouter
# ENTRYPOINT ["dotnet", "./smrpgrouter/src/SmrpgRouter.Web/SmrpgRouter.Web.dll"]

# Build Image
FROM microsoft/dotnet:2.1-sdk AS build-env
COPY src /app
WORKDIR /app
RUN dotnet restore SmrpgRouter.sln
RUN dotnet publish -c Release -o out SmrpgRouter.sln
# Runtime Image
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/SmrpgRouter.Web/out ./
ENTRYPOINT ["dotnet", "SmrpgRouter.Web.dll"]
