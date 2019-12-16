

using System.Data;

namespace Project_SQLBuilder.Interfaces
{
    public interface IConversionDataGetter
    {
        string ConnectionString { get; set; }

        void SetConnectionString(string host, string port, string database, string user, string password, string schema);
        DataTable SelectTables();
        DataTable SelectColumns(string table);
    }
}
