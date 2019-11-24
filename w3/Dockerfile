FROM granowski/coffeetariat:dotnet-node-y1
WORKDIR /app
COPY w3.csproj ./
RUN dotnet restore
COPY . .
WORKDIR /app/ClientApp
RUN npm install
WORKDIR /app
RUN dotnet publish -c Release -o out
EXPOSE 5000/tcp 
EXPOSE 5001/tcp
ENTRYPOINT [ "dotnet", "watch", "run", "--no-restore", "--urls", "http://0.0.0.0:5000;https://0.0.0.0:5001"]
