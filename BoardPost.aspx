<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardPost.aspx.cs" Inherits="Bulletin.BoardPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="usersPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BoardsPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="PostsPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BoardPostPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="BoardPostPlaceHolder2" runat="server">

    <asp:PlaceHolder ID="newPostPH" runat="server"></asp:PlaceHolder>

<%--    <td>
           <asp:HyperLink ID="NewPostLink" href="AddPost.aspx <%# id %>" runat="server">Add new Post</asp:HyperLink>
    </td>--%>
    
</asp:Content>
