using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJM_methodology_picker
{
    internal class ConnectToDb
    {
        private const string connectionString = "mongodb://localhost:27017";
        private const string databaseName = "RezultateMetodologiiProiecte";
        private const string projectsCollectionName = "Proiecte";
        private MongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<ProjectModel> projectsCollection;

        public ConnectToDb()
        {
            this.dbClient = new MongoClient(connectionString);
            this.db = this.dbClient.GetDatabase(databaseName);
            this.projectsCollection = this.db.GetCollection<ProjectModel>(projectsCollectionName);
        }

        // getters        
        public MongoClient getDbClient() { return this.dbClient; }
        public IMongoDatabase getDb() { return this.db; }
        public IMongoCollection<ProjectModel> getProjectsCollection() { return this.projectsCollection; }
    }
}
