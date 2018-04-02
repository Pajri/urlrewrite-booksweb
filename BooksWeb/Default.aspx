<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="ContentPlaceholderContent" ContentPlaceHolderID="ContentPlaceholderContent">
    <div class="section-title">
        Categories
    </div>
    <div class="section-item-wrapper">
        <asp:Repeater runat="server" ID="RptCategory">
            <ItemTemplate>
                <div class="section-item">
                    <a href='<%#Server.HtmlEncode(Eval("CategoryUrl").ToString()) %>'>
                        <img src= '<%#Server.HtmlEncode(Eval("CategoryImageUrl").ToString()) %>' />
                        <%#Eval("Category") %>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div class="section-title">
        Books
    </div>
    <div class="section-item-wrapper">
        <div class="section-item-row">
            <asp:Repeater runat="server" ID="RptBooks">
                <ItemTemplate>
                    <div class="section-item book">
                        <img src='<%#Server.HtmlEncode(Eval("BooksImageUrl").ToString()) %>' alt="Alternate Text" />
                        <p><asp:HyperLink runat="server" ID="HypTitle" NavigateUrl='<%#String.Format("book/{0}", Eval("ItemUrl"))%>'> <%#Eval("Title") %></asp:HyperLink> </p>
                        <p><%#Eval("Writer") %> </p>
                        <p runat="server" id="PCategory"></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
