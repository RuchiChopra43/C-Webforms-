<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Boards.aspx.cs" Inherits="Bulletin.Boards" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="BoardsPlaceHolder" runat="server">

      
    <br />
    <br />

    <td>
           <asp:HyperLink ID="NewBoardLink" href="AddBoard.aspx" runat="server">Add new Board</asp:HyperLink>
    </td>
    
    <br />
</asp:Content>



