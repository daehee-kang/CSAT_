<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CSAT_.Pages.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        Select a Type:
        <asp:DropDownList ID="selectType" runat="server" AutoPostBack="True" DataSourceID="csatType" DataTextField="type" DataValueField="type" OnSelectedIndexChanged="selectType_SelectedIndexChanged1">
        </asp:DropDownList>
        <asp:SqlDataSource ID="csatType" runat="server" ConnectionString="<%$ ConnectionStrings:FoodDBConnString %>" SelectCommand="SELECT DISTINCT [type] FROM [food] ORDER BY [type]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Label ID="lblMenu" runat="server" Text="Label"></asp:Label>
    </p>

</asp:Content>
