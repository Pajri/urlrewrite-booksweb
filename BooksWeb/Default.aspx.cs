using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var BookList = BookUtil.CreateBookList();
        var CategoryList = BookList.Select(p => new { p.Category, p.CategoryImageUrl,p.CategoryUrl }).Distinct();

        RptCategory.DataSource = CategoryList;
        RptCategory.DataBind();

        RptBooks.DataSource = BookList;
        RptBooks.DataBind();
    }
}