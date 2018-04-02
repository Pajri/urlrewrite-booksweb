<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Category" %>

<asp:Content runat="server" ID="ContentPlaceholderContent" ContentPlaceHolderID="ContentPlaceholderContent">
    <div class="section-title">
        <asp:Literal runat="server" ID="LitTitle" />
    </div>

    <div class="section-item-wrapper">
        <asp:Repeater runat="server" ID="RptCategory" Visible="false">
            <ItemTemplate>
                <div class="section-item">
                    <a href='<%#Eval("CategoryUrl") %>'>
                        <img src='<%#Server.HtmlEncode(Eval("CategoryImageUrl").ToString()) %>' />
                        <%#Eval("Category") %>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <asp:Panel runat="server" ID="PnlSectionItemRow" CssClass="section-item-row" Visible="false">
            <asp:Repeater runat="server" ID="RptBooks">
                <ItemTemplate>
                    <div class="section-item book">
                        <img src='<%#Server.HtmlEncode(Eval("BooksImageUrl").ToString()) %>' alt="Alternate Text" />
                        <p><%#Eval("Title") %> </p>
                        <p><%#Eval("Writer") %> </p>
                        <p runat="server" id="PCategory"></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </asp:Panel>
    </div>
</asp:Content>
