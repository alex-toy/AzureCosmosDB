using Microsoft.Azure.Cosmos;

namespace CosmosDbApp.Utils
{
    public static class CosmosHelper
    {
        public static async Task<Database> GetCosmosDb(string cosmosUrl, string cosmosKey, string dbName)
        {
            CosmosClient client = new CosmosClient(cosmosUrl, cosmosKey);
            Database database = await client.CreateDatabaseIfNotExistsAsync(dbName);
            return database;
        }
    }
}
