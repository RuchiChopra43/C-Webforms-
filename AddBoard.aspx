<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBoard.aspx.cs" Inherits="Bulletin.AddBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

<asp:Content ID="Content14" ContentPlaceHolderID="AddBoardPlaceHolder" runat="server">
    <asp:Label ID="newBoardLabel" runat="server" Text="Label"></asp:Label>

    <asp:TextBox ID="NewBoardTextBox" runat="server"></asp:TextBox>

    <asp:Label ID="ErrorLabel" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="AddBoardButton" runat="server" Text="Button" OnClick="AddBoardButton_Click" />
</asp:Content>
