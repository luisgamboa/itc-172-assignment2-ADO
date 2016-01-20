using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    BooksAndAuthors ba = new BooksAndAuthors();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        FillAuthorsDropDown();
    }
    protected void DblAuthors_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridView();
    }

    protected void FillAuthorsDropDown()
    {
        DataTable table = ba.GetAuthors();

        DdlOfAuthors.DataSource = table;
        DdlOfAuthors.DataTextField = "AuthorName";
        DdlOfAuthors.DataValueField = "AuthorKey";
        DdlOfAuthors.DataBind();

    }

    protected void FillGridView()
    {

        int key = int.Parse(DdlOfAuthors.SelectedValue.ToString());
        DataTable table = ba.GetBooks(key);

        GvBooks.DataSource = table;
        GvBooks.DataBind();
    }
}