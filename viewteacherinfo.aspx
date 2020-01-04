<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher_master.Master" AutoEventWireup="true" CodeBehind="viewteacherinfo.aspx.cs" Inherits="mas.viewteacherinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="text-align: center; margin-left: 378px" Width="746px">
        <HeaderStyle BackColor="#66CCFF" BorderStyle="Double" />
    </asp:GridView>
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:stes_projectConnectionString %>" ProviderName="<%$ ConnectionStrings:stes_projectConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [admin]"></asp:SqlDataSource>
</asp:Content>
