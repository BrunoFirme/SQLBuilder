using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Project_SQLBuilder.Interfaces;

namespace Project_SQLBuilder.Classes
{
    class OracleConversionDataGetter : IConversionDataGetter
    {
        public string ConnectionString { get; set; }

        public void SetConnectionString(string host, string port, string database, string user, string password, string schema)
        {
            ConnectionString = "Data Source=" + host + ";User Id=" + user + ";Password=" + password + ";";
        }

        public DataTable SelectTables()
        {
            try
            {
                using (var con = new OracleConnection(ConnectionString))
                {
                    var cmd = new OracleCommand("select table_name as colTable from user_Tables", con);

                    var oda = new OracleDataAdapter(cmd);

                    var ds = new DataTable();

                    oda.Fill(ds);

                    return ds;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public DataTable SelectColumns(string table)
        {
            {
                try
                {
                    using (var con = new OracleConnection(ConnectionString))
                    {
                        var cmd = new OracleCommand("select null as colNullValue, data_default as colDefaultValue, " +
                                                    "'AS' as colAs, column_name as colColumn, concat(data_type, data_length) as colColumnType from user_tab_columns " +
                                                    "where table_name = '" + table + "'", con);

                        var oda = new OracleDataAdapter(cmd);

                        var ds = new DataTable();

                        oda.Fill(ds);

                        return ds;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }
    }

    class PostgresConversionDataGetter : IConversionDataGetter
    {
        public string ConnectionString { get; set; }

        public void SetConnectionString(string host, string port, string database, string user, string password, string schema)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectTables()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectColumns(string table)
        {
            throw new NotImplementedException();
        }
    }
}
