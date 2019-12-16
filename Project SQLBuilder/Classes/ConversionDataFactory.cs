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

                newCdGetter = new OracleConversionDataGetter();
                newCdGetter.SetConnectionString(host, port, database, user, password, schema);

            }
            else if (type.Equals(Postgres))
            {
                newCdGetter = new PostgresConversionDataGetter();
                newCdGetter.SetConnectionString(host, port, database, user, password, schema);
            }

            return newCdGetter;

        }

    }
}
