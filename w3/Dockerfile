FROM granowski/coffeetariat:dotnet-node-y1
COPY . .
WORKDIR /app/ClientApp
RUN npm install
RUN npm run build
WORKDIR /app
RUN dotnet restore
RUN dotnet publish -c Release -o out
EXPOSE 5000/tcp 
EXPOSE 5001/tcp
#ENTRYPOINT [ "dotnet", "run", "--urls", "http://0.0.0.0:5000;https://0.0.0.0:5001"]
