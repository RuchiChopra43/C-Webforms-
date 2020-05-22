<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Bulletin.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

<asp:Content ID="Content8" ContentPlaceHolderID="RegisterPlaceHolder" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="height: 19px; width: 217px">Name</td>
            <td style="height: 19px; width: 164px">
                <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            </td>
            <td style="height: 19px">
                <asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="height: 19px"></td>
        </tr>
        <tr>
            <td style="width: 217px; height: 22px">User Name</td>
            <td style="width: 164px; height: 22px">
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:Label ID="UsernameLabel" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="height: 20px; width: 217px">Password</td>
            <td style="height: 20px; width: 164px">
                <asp:TextBox ID="Pass1TextBox" runat="server"></asp:TextBox>
            </td>
            <td style="height: 20px">
                <asp:Label ID="Pass1Label" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="width: 217px">Password</td>
            <td style="width: 164px">
                <asp:TextBox ID="Pass2TextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Pass2Label" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 217px">
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
            </td>
            <td style="width: 164px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
