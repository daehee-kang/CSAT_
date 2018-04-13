<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CSAT.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Login: </td>
            <td>
                <asp:textbox ID="txtLogin" runat="server"></asp:textbox>
                <asp:requiredfieldvalidator ID="rfvLogin" runat="server" errormessage="*" ControlToValidate="txtLogin" ValidationGroup="require"></asp:requiredfieldvalidator>
            </td>
        </tr>
        <tr>
            <td>Password: </td>
            <td>
                <asp:textbox ID="txtPassword" runat="server" TextMode="Password"></asp:textbox>
                <asp:requiredfieldvalidator ID="rfvPassword" runat="server" errormessage="*" ControlToValidate="txtPassword" ValidationGroup="require"></asp:requiredfieldvalidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:button ID="btnLogin" runat="server" text="Log in" OnClick="btnLogin_Click" ValidationGroup="require" /><br />
                <asp:label ID="lblError" runat="server"></asp:label><br />
            </td>
        </tr>
    </table>
</asp:Content>
