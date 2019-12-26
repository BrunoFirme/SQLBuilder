using System;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Forms;
using Project_SQLBuilder.Interfaces;
using SQLBuilderModel;

using Oracle.DataAccess.Client;
using Npgsql;
using FirebirdSql.Data.FirebirdClient;
using NDbfReader;


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

        public DataTable SelectColumns(string table, IQueryable<CustomField> customField)
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
                        foreach (CustomField field in customField)
                        {
                            ds.Rows.Add(null, field.DefaultValue, "AS", field.Column, field.Columntype);
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
                using (var con = new NpgsqlConnection(ConnectionString))
                {
                    var cmd = new NpgsqlCommand(
                        "select upper(tablename) as colTable from pg_catalog.pg_tables where schemaname = '" + Schema +
                        "';",
                        con);

                    var oda = new NpgsqlDataAdapter(cmd);

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

        public DataTable SelectColumns(string table, IQueryable<CustomField> customField)
        {
            try
            {
                using (var con = new NpgsqlConnection(ConnectionString))
                {
                    var cmd = new NpgsqlCommand(
                        "select null as colNullValue,  upper(column_default) as colDefaultValue, " +
                        "'AS' as colAs,  upper(column_name) as colColumn,  upper(data_type) as colColumnType from information_schema.COLUMNS " +
                        "where table_name = '" + table.ToLower() + "' and table_schema = '" + Schema + "'", con);

                    var oda = new NpgsqlDataAdapter(cmd);

                    var ds = new DataTable();

                    oda.Fill(ds);

                    if (customField != null)
                    {
                        foreach (CustomField field in customField)
                        {
                            ds.Rows.Add(null, field.DefaultValue, "AS", field.Column, field.Columntype);
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

    class FirebirdConversionDataGetter : IConversionDataGetter
    {
        public string Type { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Schema { get; set; }
        public string ConnectionString { get; set; }

        public FirebirdConversionDataGetter(string host, string port, string database, string user, string password,
            string schema)
        {
            Host = host;
            Port = port;
            Database = database;
            User = user;
            Password = password;
            Schema = schema;
            Type = "Firebird";

            SetConnectionString();
        }

        public void SetConnectionString()
        {
            ConnectionString = "DataSource=" + Host + ";Port=" + Port + ";Database=" + Database + ";User=" + User +
                               ";Password= " + Password + ";" + "Dialect=3;";
        }

        public DataTable SelectTables()
        {
            try
            {
                using (var con = new FbConnection(ConnectionString))
                {
                    var cmd = new FbCommand("select rdb$relation_name as colTable from rdb$relations " + 
                        "where rdb$view_blr is null and (rdb$system_flag is null or rdb$system_flag = 0);",
                        con);

                    var oda = new FbDataAdapter(cmd);

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

        public DataTable SelectColumns(string table, IQueryable<CustomField> customField)
        {
            try
            {
                using (var con = new FbConnection(ConnectionString))
                {
                    var cmd = new FbCommand(
                        "SELECT\r\n  R.RDB$FIELD_NAME as colColumn,\r\nR.RDB$DEFAULT_VALUE AS colDefaultValue,\r\ntrim(CASE f.RDB$FIELD_TYPE\r\n  WHEN 261 THEN \'BLOB\'\r\n  WHEN 14 THEN \'CHAR\'\r\n  WHEN 40 THEN \'CSTRING\'\r\n  WHEN 11 THEN \'D_FLOAT\'\r\n  WHEN 27 THEN \'DOUBLE\'\r\n  WHEN 10 THEN \'FLOAT\'\r\n  WHEN 16 THEN \'INT64\'\r\n  WHEN 8 THEN \'INTEGER\'\r\n  WHEN 9 THEN \'QUAD\'\r\n  WHEN 7 THEN \'SMALLINT\'\r\n  WHEN 12 THEN \'DATE\'\r\n  WHEN 13 THEN \'TIME\'\r\n  WHEN 35 THEN \'TIMESTAMP\'\r\n  WHEN 37 THEN \'VARCHAR\'\r\n  else \'\'\r\nEND) || trim(F.RDB$FIELD_LENGTH) AS colColumnType\r\nFROM\r\n  RDB$RELATION_FIELDS R\r\n  JOIN RDB$FIELDS F\r\n    ON F.RDB$FIELD_NAME = R.RDB$FIELD_SOURCE\r\n  JOIN RDB$RELATIONS RL\r\n    ON RL.RDB$RELATION_NAME = R.RDB$RELATION_NAME\r\nWHERE\r\n  R.RDB$RELATION_NAME = '"
                        + table +
                        "'\r\n  AND\r\n  COALESCE(R.RDB$SYSTEM_FLAG, 0) = 0\r\n  AND\r\n  COALESCE(RL.RDB$SYSTEM_FLAG, 0) = 0\r\n  AND\r\n  RL.RDB$VIEW_BLR IS NULL",
                        con);

                    var oda = new FbDataAdapter(cmd);

                    var ds = new DataTable();

                    oda.Fill(ds);

                    if (customField != null)
                    {
                        foreach (CustomField field in customField)
                        {
                            ds.Rows.Add(null, field.DefaultValue, "AS", field.Column, field.Columntype);
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

        public DataTable SelectColumns(string table, IQueryable<CustomField> customField)
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