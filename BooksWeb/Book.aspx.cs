using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Book : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string queryString = Request.QueryString["book"];
        if((queryString != String.Empty) && (queryString != null))
        {
            var book = BookUtil.CreateBookList().Where(p => p.ItemUrl == queryString).FirstOrDefault();
            if (book != null)
            {
                LitTitle.Text = book.Title;
                ImgBook.ImageUrl = book.BooksImageUrl;
                LitWriter.Text = book.Writer;
                LitCategory.Text = book.Category;
            }
        }
    }
}