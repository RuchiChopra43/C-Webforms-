<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPost.aspx.cs" Inherits="Bulletin.AddPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

<asp:Content ID="Content15" ContentPlaceHolderID="AddPostPlaceHolder" runat="server">

    <table style="width: 100%;">
        <tr>
            <td style="width: 311px">
                <asp:Label ID="AddPostLabel" runat="server" Text="Add your post"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 311px">
                &nbsp;</td>
            <td>
                <asp:TextBox ID="AddPostTextBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 311px">
                <asp:Button ID="AddpostButton" OnClick="AddpostButton_Click" runat="server" Text="Save" style="width: 48px"  />
            &nbsp;&nbsp;
                <br />
            </td>
            <td>
                <asp:Label ID="ErrorLabel" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
