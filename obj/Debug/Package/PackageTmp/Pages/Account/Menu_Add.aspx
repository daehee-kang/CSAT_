<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Menu_Add.aspx.cs" Inherits="CSAT.Pages.Menu_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Add new items</h3>
    <table cellspacing="15" class="foodTable" style="width: 1000px">
        <tr id="Name">
            <td style="width: 155px">

                Name:</td>
            <td>

                <asp:TextBox ID="txtName" runat="server" Height="25px" Width="500px"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr id="Type">
            <td style="width: 155px">

                Type:</td>
            <td>

                <asp:DropDownList ID="ddlType" runat="server" Width="500px" Height="25px">
                </asp:DropDownList>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlType" ErrorMessage="*"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr id="Price">
            <td style="width: 155px">

                Price:</td>
            <td>

                <asp:TextBox ID="txtPrice" runat="server" Height="25px" Width="500px"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPrice" ErrorMessage="*"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr id="Image">
            <td style="width: 155px">

                Image:</td>
            <td>

                <asp:DropDownList ID="ddlImage" runat="server" Height="25px" Width="500px">
                </asp:DropDownList>
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="btnUploadImg" runat="server" Text="Upload Image" OnClick="btnUploadImg_Click" CausesValidation="False" />
            </td>
        </tr>
        <tr id="Ingredient">
            <td style="width: 155px">

                Ingredient:</td>
            <td>

                <asp:TextBox ID="txtIngredient" runat="server" Height="50px" TextMode="MultiLine" Width="500px"></asp:TextBox>

            </td>
        </tr>
        <tr id="Desc">
            <td style="width: 155px">

                Description:</td>
            <td>

                <asp:TextBox ID="txtDesc" runat="server" Height="100px" TextMode="MultiLine" Width="500px"></asp:TextBox>

            </td>
        </tr>
    </table>
    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
</asp:Content>
