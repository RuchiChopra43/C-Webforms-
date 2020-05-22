<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Bulletin.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

<asp:Content ID="Content13" ContentPlaceHolderID="UpdateUserPlaceHolder" runat="server">

    <table style="width: 40%;">
        <tr>
            <td style="width: 304px">Name</td>
            <td>
                <asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td style="width: 304px; height: 20px">User Name</td>
            <td style="height: 20px">
                <asp:Label ID="UsernameLabel" runat="server" Text="Label"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td style="width: 304px">User Type</td>
            <td>
                <asp:RadioButtonList ID="RoleRadio" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RoleRadio_SelectedIndexChanged">
                    <asp:ListItem>ADMIN</asp:ListItem>
                    <asp:ListItem>USER</asp:ListItem>
                    <asp:ListItem>DELETED</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            
        </tr>
        <tr>
            <td style="width: 304px">
                <asp:Button ID="UpdateUserButton" runat="server" Text="Save" OnClick="UpdateUserButton_Click" />
            </td>
            <td>&nbsp;</td>
            
        </tr>
        <tr>
            <td style="width: 304px">
                <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click"  />
            </td>
            <td>&nbsp;</td>
            
        </tr>
    </table>
</asp:Content>
