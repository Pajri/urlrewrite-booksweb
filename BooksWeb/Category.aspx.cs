using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Category : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var BookList = BookUtil.CreateBookList();
        
        string queryString = Request.QueryString["category"];
        if ((queryString != String.Empty) && (queryString != null))
        {
            LitTitle.Text = "Books";
            PnlSectionItemRow.Visible=true;
            string categoryUrl = "category/" + queryString;            
            RptBooks.DataSource = BookList.Where(p => p.CategoryUrl == categoryUrl);
            RptBooks.DataBind();
        }
        else
        {
            LitTitle.Text = "Categories";
            RptCategory.Visible = true;
            var CategoryList = BookList.Select(p => new { p.Category, p.CategoryImageUrl, p.CategoryUrl }).Distinct();
            RptCategory.DataSource = CategoryList;
            RptCategory.DataBind();
        }
    }
}