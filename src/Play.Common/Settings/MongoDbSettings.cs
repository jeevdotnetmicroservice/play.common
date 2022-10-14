namespace Play.Common.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }

        public int Port { get; init; }

        private string connectionstring;
        public string ConnectionString
        {
            get { return string.IsNullOrWhiteSpace(connectionstring)
                    ? $"mongodb://{Host}:{Port}" : connectionstring; }
            init { connectionstring = value; }
        }
    }
}