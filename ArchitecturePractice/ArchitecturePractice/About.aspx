<%@ Page Title="Practice" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="About.aspx.vb" Inherits="ArchitecturePractice.About" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManagerProxy runat="server" ID="SmpAbout">
        <Scripts>
            <asp:ScriptReference Path="~/js/About.js" />
        </Scripts>
    </asp:ScriptManagerProxy>
    <h2>
        Practice
    </h2>
    <div>
        <ul>
            <li>
                <asp:Label runat="server" ID="LblId" Text="ID" Width="50px" />
                <asp:TextBox runat="server" ID="TxtId" />
            </li>
            <li>
                <asp:Label runat="server" ID="LblName" Text="Name" Width="50px" />
                <asp:TextBox runat="server" ID="TxtName" />
            </li>
            <li>
                <asp:Label runat="server" ID="LblSex" Text="Sex" Width="50px" />
                <asp:DropDownList runat="server" ID="DdlSex" DataTextField="Text" DataValueField="Value" AutoPostBack="true" />

                <asp:Label runat="server" ID="LblFavorite" Text="Favorite" Width="50px" />
                <asp:Button runat="server" ID="BtnNextPage" Text="次ページへ" />
                <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="BtnNextPage" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:DropDownList runat="server" ID="DdlFavorite" DataTextField="Text" DataValueField="Value" DataSourceID="OdsFavorite" />
                        <asp:ObjectDataSource runat="server" ID="OdsFavorite" SelectMethod="GetListItem" TypeName="Practice.BusinessLayer.ListItemService" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </li>
            <li>
                <asp:Label runat="server" ID="LblGridView" Text="GridView" />
                <asp:Button runat="server" ID="BtnAddRow" Text="Add Row" />
                <asp:GridView runat="server" ID="GrvGridView" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="ID">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="LblIdInGrid" Text='<%# Eval("Id") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAME">
                            <ItemTemplate>
                                <asp:TextBox runat="server" ID="TxtNameInGrid" Text='<%# Bind("Name") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </li>
            <li>
                <asp:UpdatePanel runat="server" ID="UdpGrid" UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="BtnAsync" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:Label runat="server" ID="LblGridInUpdatePanel" Text="Grid In UpdatePanel" />
                        <asp:Button runat="server" ID="BtnAddRow2" Text="Add Row" />
                        <asp:GridView runat="server" ID="GrvGridInUpdatePanel" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField HeaderText="ID">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="LblIdInGrid" Text='<%# Eval("Id") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="NAME">
                                    <ItemTemplate>
                                        <asp:TextBox runat="server" ID="TxtNameInGrid" Text='<%# Bind("Name") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </li>
        </ul>
        <div>
            <div>
                <asp:Button runat="server" ID="BtnSend" Text="Send" />
                <asp:Button runat="server" ID="BtnAsync" Text="AsyncSend" />
            </div>
        </div>
    </div>
</asp:Content>
