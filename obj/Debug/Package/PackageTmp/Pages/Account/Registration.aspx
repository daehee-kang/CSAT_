<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CSAT.Pages.Account.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td>Name: </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Height="30px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtName" ValidationGroup="require"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password: </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" Height="30px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtPassword" ValidationGroup="require"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm Password: </td>
            <td>
                <asp:TextBox ID="txtConfirm" runat="server" Height="30px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirm" ErrorMessage="*" ValidationGroup="require"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Height="30px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ValidationGroup="require"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Button ID="btnRegister" runat="server" Text="Register" Height="30px" OnClick="btnRegister_Click" ValidationGroup="require" /><br />
                <asp:comparevalidator runat="server" errormessage="Password must match" ControlToCompare="txtConfirm" ControlToValidate="txtPassword"></asp:comparevalidator><br />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
