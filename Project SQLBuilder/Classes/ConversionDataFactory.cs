using Project_SQLBuilder.Interfaces;

namespace Project_SQLBuilder.Classes
{
    public class ConversionDataFactory
    {
        private string host;
        private string port;
        private string database;
        private string user;
        private string password;
        private string schema;

        public static string Oracle = "Oracle";
        public static string Postgres = "Postgres";
        public static string Dbf = "DBF";
        public static string Firebird = "Firebird";

        public ConversionDataFactory(string host, string port, string database, string user, string password,
            string schema)
        {
            this.host = host;
            this.port = port;
            this.database = database;
            this.user = user;
            this.password = password;
            this.schema = schema;
        }

        public IConversionDataGetter GetConversionDataGetter(string type)
        {
            IConversionDataGetter newCdGetter = null;

            if (type.Equals(Oracle))
            {
                newCdGetter = new OracleConversionDataGetter(host, port, database, user, password, schema);
                newCdGetter.SetConnectionString();
            }
            else if (type.Equals(Postgres))
            {
                newCdGetter = new PostgresConversionDataGetter(host, port, database, user, password, schema);
                newCdGetter.SetConnectionString();
            }
            else if (type.Equals(Firebird))
            {
                newCdGetter = new FirebirdConversionDataGetter(host, port, database, user, password, schema);
                newCdGetter.SetConnectionString();
            }
            else if (type.Equals(Dbf))
            {
                newCdGetter = new DbfConversionDataGetter(host, port, database, user, password, schema);
                newCdGetter.SetConnectionString();
            }
            return newCdGetter;
        }
    }
}
