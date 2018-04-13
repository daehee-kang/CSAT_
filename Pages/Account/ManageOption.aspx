<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageOption.aspx.cs" Inherits="CSAT.Pages.Account.ManageOption" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblChooseOp" runat="server" Text="Choose from following options:"></asp:Label><br />
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Pages/Account/Menu_Overview.aspx">Manage Menu</asp:LinkButton><br />
    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Pages/Account/Admin.aspx">Manage Account</asp:LinkButton><br />
    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Pages/Account/Registration.aspx">Add Account</asp:LinkButton><br />
</asp:Content>
