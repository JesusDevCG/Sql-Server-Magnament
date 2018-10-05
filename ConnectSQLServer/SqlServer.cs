using System;
using System.Data;
using System.Data.SqlClient;


public class SqlServer
{
    public SqlConnectionStringBuilder SQLConnect;
    public SqlConnection connection;

    public void checkConnection()
    {
        if (this.connection.State == ConnectionState.Closed)
        {
            this.connection.ConnectionString = this.SQLConnect.ConnectionString;
            this.connection.Open();
        }
    }

    public String insertQuery(String dataBase, String table, DataTable data, String[] values, bool[] use)
    {
        String[] columns = new String[data.Rows.Count];
        uint count = 1;
        String query = "use "+ dataBase +"; insert into "+ table + " (";
        foreach (DataRow rows in data.Rows)
        {
            if (use[count - 1])
            {
                String row = rows.Field<String>("column_name");
                query += row + ",";
            }
            count++;
        }
        if(query[query.Length - 1] == ',')
        {
            query = query.Remove(query.Length - 1);
        }
        count = 0;
        query += ") values (";
        for(uint i = 0; i < data.Rows.Count; i++)
        {
            if (use[count])
            {
                if (values[i] != "")
                    query += "\'" + values[i] + "\'";
                else
                    query += "null";
                query += ",";
            }
            count++;
        }
        if (query[query.Length - 1] == ',')
        {
            query = query.Remove(query.Length - 1);
        }
        query += ");";

        return query;
    }
}
