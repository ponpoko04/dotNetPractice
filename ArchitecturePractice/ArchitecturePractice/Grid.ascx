<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Grid.ascx.vb" Inherits="ArchitecturePractice.Grid" %>

<div>
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
</div>