# Koieng-dotnet
# Run locally
```
dotnet run --project hello-world-api
```
Then launch your browser and access http://localhost:5000

# Run on web app
```
cd hello-world-api

dotnet publish -c Release -o ./publish

cd publish

zip -r ../app.zip .

cd ..
```

```
az webapp deploy --name koieng-app --resource-group koieng-app --src-path app.zip --type zip
```