using System.Data;
using Microsoft.Data.SqlClient;

public class PointDB
{
    SqlConnection conn;
    SqlDataAdapter adapter;
    DataSet ds;

    public PointDB(string database, string server = @"(localdb)\MSSQLLocalDB")
    {
        string conStr = $@"Server={server};Database={database};Trusted_Connection=True;";
        conn = new SqlConnection(conStr);
        ds = new DataSet();
    }

    public bool OpenDB()
    {
        if (IsWork()) return true;
        try
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
                return true;
        }
        catch (Exception) { }
        return false;
    }

    public void CloseDB()
    {
        if (conn.State == ConnectionState.Open)
            conn.Close();
    }

    public bool IsWork() => conn.State == ConnectionState.Open;

    public void ExecuteNonQuery(SqlCommand cmd)
    {
        try
        {
            if (OpenDB())
            {
                cmd.Connection = conn;
                adapter = new SqlDataAdapter(cmd);
                adapter.TableMappings.Add("Table", "MappedTable"); 
                adapter.Fill(ds);
                SqlCommandBuilder builder = new(adapter);
                adapter.Update(ds);
            }
        }
        catch (Exception) { }
        finally
        {
            CloseDB();
        }
    }

    public DataSet ExecuteQuery(SqlCommand cmd)
    {
        try
        {
            if (OpenDB())
            {
                cmd.Connection = conn;
                adapter = new SqlDataAdapter(cmd);
                adapter.TableMappings.Add("Table", "MappedTable"); 
                adapter.Fill(ds);
            }
        }
        finally
        {
            CloseDB();
        }

        return ds;
    }

    public DataSet ExecuteQuery(string query)
    {
        try
        {
            if (OpenDB())
            {
                using SqlCommand cmd = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(cmd);
                adapter.TableMappings.Add("Table", "MappedTable"); 
                adapter.Fill(ds);
            }
        }
        finally
        {
            CloseDB();
        }
        return ds;
    }

    public void UpdateDB()
    {
        try
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds);
        }
        catch (Exception) { }
    }
}
