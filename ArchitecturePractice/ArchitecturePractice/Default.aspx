﻿<%@ Page Title="ホーム ページ" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="ArchitecturePractice._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ASP.NET へようこそ!
    </h2>
    <p>
        ASP.NET の詳細については、<a href="http://www.asp.net" title="ASP.NET Web サイト">www.asp.net</a> を参照してください。
    </p>
    <p>
        <a href="http://go.microsoft.com/fwlink/?LinkID=152368"
            title="MSDN ASP.NET ドキュメント">MSDN で ASP.NET に関するドキュメント</a>を参照することもできます。
        <asp:HyperLink runat="server" ID="link" Text="After" Target="_self" NavigateUrl="~/After.aspx" />

        <asp:TextBox runat="server" ID="TextBox2" />
        <asp:TextBox runat="server" ID="TextBox3" />
        <asp:TextBox runat="server" ID="TextBox4" />
        <asp:TextBox runat="server" ID="TextBox1" />
    </p>
</asp:Content>
