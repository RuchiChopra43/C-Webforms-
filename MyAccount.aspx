<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="Bulletin.MyAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

<asp:Content ID="Content11" ContentPlaceHolderID="MyAccountPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content12" ContentPlaceHolderID="MyAccountPlaceHolder2" runat="server">

    <table style="width: 100%;">
        <tr>
            <td class="modal-sm" style="width: 455px; height: 20px">Name</td>
            <td style="height: 20px">
                <asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td class="modal-sm" style="width: 455px">User Name</td>
            <td>
                <asp:Label ID="UsernameLabel" runat="server" Text="Label"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td class="modal-sm" style="width: 455px; height: 21px">New Password</td>
            <td style="height: 21px">
                <asp:TextBox ID="NewpassTextBox" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="modal-sm" style="width: 455px">
                <asp:Button ID="ChangeButton" runat="server" Text="Save" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
            
        </tr>
    </table>
</asp:Content>
