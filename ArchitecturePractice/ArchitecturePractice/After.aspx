<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="After.aspx.vb" Inherits="ArchitecturePractice.After" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManagerProxy runat="server" ID="SmpAfter">
        <Scripts>
            <asp:ScriptReference Path="~/js/After.js" />
        </Scripts>
    </asp:ScriptManagerProxy>
    <div>
        遷移後画面
    </div>
    <div>
        UpdatePanel内のキャッシュテスト
    </div>
    <div>
        <asp:UpdatePanel runat="server" ID="UdpCache" ChildrenAsTriggers="true" UpdateMode="Conditional">
            <Triggers></Triggers>
            <ContentTemplate>
                <asp:Button runat="server" ID="BtnShow" Text="Show Grid" />
                <asp:GridView runat="server" ID="GrvCache" AutoGenerateColumns="false" Visible="false" EnableViewState="false">
                    <Columns>
                        <asp:TemplateField HeaderText="KEY">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="LblKey" Text='<%# Eval("key") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="VALUE">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="LblValue" Text='<%# Eval("value") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
