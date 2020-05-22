<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bulletin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="LoginPlaceHolder" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="modal-lg" style="width: 678px">
                <asp:Image ID="Image1" runat="server" Height="397px" ImageUrl="~/Images/Travelling.jpg" Width="802px" />
            </td>
            <td>
                &nbsp;</td>
           
        </tr>
        <tr>
            <td class="modal-lg" style="width: 678px">User Name</td>
            <td>
                <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
                
            </td>
           
        </tr>
        <tr>
            <td class="modal-lg" style="width: 678px">Password</td>
            <td>
                <asp:TextBox ID="PassTextBox" runat="server"></asp:TextBox>
                
            </td>
            
        </tr>
        <tr>
            <td class="modal-lg" style="width: 678px">
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
                <asp:HyperLink ID="RegisterLink" href="Register.aspx" runat="server">Register here</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="modal-lg" style="width: 678px">&nbsp;</td>
            <td>&nbsp;</td>
            
        </tr>

        <td style="height: 26px">
             <asp:PlaceHolder runat="server" ID="helperText"></asp:PlaceHolder>
        </td>
                 

    </table>
</asp:Content>
