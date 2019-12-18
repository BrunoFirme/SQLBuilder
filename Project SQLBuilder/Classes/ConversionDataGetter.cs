using System;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using NDbfReader;
using Oracle.DataAccess.Client;
using Project_SQLBuilder.Interfaces;

namespace Project_SQLBuilder.Classes
{
    class OracleConversionDataGetter : IConversionDataGetter
    {
        public string Type { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Schema { get; set; }
        public string ConnectionString { get; set; }

        public OracleConversionDataGetter(string host, string port, string database, string user, string password,
            string schema)
        {
            Host = host;
            Port = port;
            Database = database;
            User = user;
            Password = password;
            Schema = schema;
            Type = "Oracle";

            SetConnectionString();
        }

        public void SetConnectionString()
        {
            ConnectionString = "Data Source=" + Host + ";User Id=" + User + ";Password=" + Password + ";";
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
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable SelectColumns(string table, IQueryable<custom_field> customField)
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

                    if (customField != null)
                    {
                        foreach (custom_field field in customField)
                        {
                            ds.Rows.Add(null, field.default_value, "AS", field.column, field.columntype);
                        }
                    }

                    return ds;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }

    class PostgresConversionDataGetter : IConversionDataGetter
    {
        public string Type { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Schema { get; set; }
        public string ConnectionString { get; set; }

        public PostgresConversionDataGetter(string host, string port, string database, string user, string password,
            string schema)
        {
            Host = host;
            Port = port;
            Database = database;
            User = user;
            Password = password;
            Schema = schema;
            Type = "Postgres";

            SetConnectionString();
        }

        public void SetConnectionString()
        {
            ConnectionString = "Server=" + Host + ";Port=" + Port + ";Database=" + Database + ";User Id=" + User +
                               ";Password= " + Password + ";";
        }

        public DataTable SelectTables()
        {
            try
            {
                using (var con = new PgSqlConnection(ConnectionString))
                {
                    var cmd = new PgSqlCommand(
                        "select upper(tablename) as colTable from pg_catalog.pg_tables where schemaname = '" + Schema +
                        "';",
                        con);

                    var oda = new PgSqlDataAdapter(cmd);

                    var ds = new DataTable();

                    oda.Fill(ds);

                    return ds;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable SelectColumns(string table, IQueryable<custom_field> customField)
        {
            try
            {
                using (var con = new PgSqlConnection(ConnectionString))
                {
                    var cmd = new PgSqlCommand(
                        "select null as colNullValue,  upper(column_default) as colDefaultValue, " +
                        "'AS' as colAs,  upper(column_name) as colColumn,  upper(data_type) as colColumnType from information_schema.COLUMNS " +
                        "where table_name = '" + table.ToLower() + "' and table_schema = '" + Schema + "'", con);

                    var oda = new PgSqlDataAdapter(cmd);

                    var ds = new DataTable();

                    oda.Fill(ds);

                    if (customField != null)
                    {
                        foreach (custom_field field in customField)
                        {
                            ds.Rows.Add(null, field.default_value, "AS", field.column, field.columntype);
                        }
                    }

                    return ds;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }

    class DbfConversionDataGetter : IConversionDataGetter
    {
        public string Type { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Schema { get; set; }
        public string ConnectionString { get; set; }

        public DbfConversionDataGetter(string host, string port, string database, string user, string password,
            string schema)
        {
            Host = host;
            Port = port;
            Database = database;
            User = user;
            Password = password;
            Schema = schema;
            Type = "DBF";

            SetConnectionString();
        }

        public void SetConnectionString()
        {
            ConnectionString = "Driver={Microsoft dBase Driver (*.dbf)};DBQ=" + Host;
        }

        public DataTable SelectTables()
        {
            try
            {
                using (var con = new OdbcConnection(ConnectionString))
                {
                    con.Open();

                    var ds = con.GetSchema(OdbcMetaDataCollectionNames.Tables);

                    con.Close();

                    ds.Columns["TABLE_NAME"].ColumnName = "colTable";

                    return ds;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable SelectColumns(string table, IQueryable<custom_field> customField)
        {
            try
            {
                using (var dbfTable = Table.Open(Host + "\\" + table + ".dbf"))
                {
                    var dbfdatatable = dbfTable.AsDataTable();

                    var columnNames = new DataTable();
                    columnNames.Columns.Add("colColumn");
                    columnNames.Columns.Add("colColumnType");

                    for (var columnIndex = 0; columnIndex < dbfdatatable.Columns.Count; columnIndex++)
                    {
                        columnNames.Rows.Add(dbfdatatable.Columns[columnIndex].ColumnName, "DBF Column");
                    }

                    return columnNames;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}