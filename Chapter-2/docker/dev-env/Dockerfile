# [Choice] .NET version: 7.0, 6.0, 5.0, 3.1, 6.0-bullseye, 5.0-bullseye, 3.1-bullseye, 6.0-focal, 5.0-focal, 3.1-focal
ARG VARIANT="7.0"
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:0-${VARIANT}
# [Choice] Node.js version: none, lts/*, 16, 14, 12, 10
ARG NODE_VERSION="none"
RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi
# [Optional] Uncomment this section to install additional OS packages.
RUN apt-get update && \
    export DEBIAN_FRONTEND=noninteractive && \
    apt-get -qy full-upgrade && \
    apt-get install -qy curl && \
    apt-get -y install --no-install-recommends vim && \
    curl -sSL https://get.docker.com/ | sh

    RUN wget -O dotnet.tar.gz https://download.visualstudio.microsoft.com/download/pr/14e4bb95-1b59-441e-87b9-58e9feb93426/b61087ddece464f4dc1a3d4e0f31aab3/dotnet-sdk-8.0.202-linux-x64.tar.gz \
    && dotnet_sha512='e0e790c7cc6f8129913317d326c599ff8e8ed4927d4e0adccbe55c50be5c353fe3d83043e529973ced2b302b8432c2ab31533b94ffe9c363eaa9964a7160643a' \
    && echo "$dotnet_sha512 dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -zxf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz

RUN dotnet tool install -g dotnet-ef --version 8.0.2
ENV PATH $PATH:/root/.dotnet/tools

# configure for https
RUN dotnet dev-certs https