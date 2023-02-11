// See https://aka.ms/new-console-template for more information
using CosmosDbApp.Utils;
using Microsoft.Azure.Cosmos;

Console.WriteLine("Hello, World!");

string cosmosUrl = "https://alexeicosmosdb.mongo.cosmos.azure.com:443/";  
string cosmosKey = "";
string dbName = "DemoDb";

Database database = await CosmosHelper.GetCosmosDb(cosmosUrl, cosmosKey, dbName);
Container container = await database.CreateContainerIfNotExistsAsync("myContainer", "partitionkey", 1000);

dynamic testItem = new { Id = Guid.NewGuid().ToString(), partitionKeyPath = "mytestPkValue" };
var response = await container.CreateItemAsync(testItem);



