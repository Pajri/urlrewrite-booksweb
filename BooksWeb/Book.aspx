<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Book.aspx.cs" Inherits="Book" %>

<asp:Content runat="server" ID="ContentPlaceholderContent" ContentPlaceHolderID="ContentPlaceholderContent">
    <div class="item-title">
        <asp:Literal runat="server" ID="LitTitle" />
    </div>

    <div class="item-detail">
        <asp:Image runat="server" ID="ImgBook" />
        <p class="item-writer"><asp:Literal runat="server" ID="LitWriter" /></p>
        <p class="item-category"><asp:Literal runat="server" ID="LitCategory" /></p>
        <p class="item-description">Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
            Nulla finibus leo finibus aliquam lacinia. Fusce turpis ante, gravida eu egestas sit amet, tempus sagittis nisl. 
            Curabitur at pretium neque. Aenean ut tortor ut metus vestibulum pulvinar. 
            Aenean interdum placerat nibh. 
            Phasellus enim neque, ullamcorper at massa non, consequat convallis risus. 
            Cras lacus felis, molestie in neque quis, facilisis lobortis purus. 
            Suspendisse in est quis dolor ullamcorper dapibus vitae sit amet sapien. 
            Vivamus tellus lacus, sagittis eu neque sit amet, volutpat laoreet tellus. 
            Phasellus lobortis est vel mi tempor, quis vestibulum elit aliquam. 
            Aliquam erat volutpat. Integer imperdiet tellus a lectus maximus, eu vehicula justo scelerisque. 
            Curabitur posuere facilisis rutrum. Nam eu efficitur dolor.</p>
    </div>
</asp:Content>