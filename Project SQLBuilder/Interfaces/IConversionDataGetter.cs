using System.Data;
using System.Linq;
using SQLBuilderModel;

namespace Project_SQLBuilder.Interfaces
{
    public interface IConversionDataGetter
    {
        string Type { get; set; }
        string Host { get; set; }
        string Port { get; set; }
        string Database { get; set; }
        string User { get; set; }
        string Password { get; set; }
        string Schema { get; set; }
        string ConnectionString { get; set; }

        void SetConnectionString();
        DataTable SelectTables();
        DataTable SelectColumns(string table, IQueryable<CustomField> customField);
    }
}
