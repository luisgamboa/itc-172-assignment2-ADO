using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for BooksAndAuthors
/// </summary>
public class BooksAndAuthors
{
    SqlConnection connect;
	public BooksAndAuthors()
	{
        connect = new SqlConnection
        (ConfigurationManager.ConnectionStrings["BookReviewBbConnectionString"].ToString());
	}

    public DataTable GetAuthors()
    {
        string sql = "SELECT AuthorKey, AuthorName FROM Author";
        SqlCommand cmd = new SqlCommand(sql, connect);
        DataTable tblAuthors = null;
        try
        {
            tblAuthors = ProcessQuery(cmd);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return tblAuthors;
    
    }

    public DataTable GetBooks(int authorKey)
    {
        string sql = "SELECT * FROM book INNER JOIN authorbook ON book.bookkey= authorbook.bookkey WHERE authorkey = @authorkey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@authorKey", authorKey);
        DataTable tblAuthors = null;
        try
        {
            tblAuthors = ProcessQuery(cmd);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return tblAuthors;
    
    }

    private DataTable ProcessQuery(SqlCommand cmd)
    {
        DataTable table = new DataTable();
        SqlDataReader reader;

        try
        {
            connect.Open();
            reader = cmd.ExecuteReader();
            table.Load(reader);
            connect.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return table;//this return the table that has data in it

    }


}