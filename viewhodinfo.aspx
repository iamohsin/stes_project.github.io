<%@ Page Title="" Language="C#" MasterPageFile="~/hod_master.Master" AutoEventWireup="true" CodeBehind="viewhodinfo.aspx.cs" Inherits="mas.viewhodinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="text-align: center; margin-left: 373px" Width="746px">
        <HeaderStyle BackColor="#66CCFF" BorderStyle="Double" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:stes_projectConnectionString %>" ProviderName="<%$ ConnectionStrings:stes_projectConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [admin]"></asp:SqlDataSource>
    <asp:Label ID="Label2" runat="server"></asp:Label>
</asp:Content>
