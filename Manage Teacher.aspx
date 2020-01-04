<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="Manage Teacher.aspx.cs" Inherits="mas.Manage_Teacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style2">
        <tr>
            <td class="w3-center" style="height: 159px"></td>
            <td class="w3-center" style="height: 159px"></td>
        </tr>
        <tr>
            <td class="w3-center">
                <asp:Button ID="Button2" runat="server" BackColor="#00CC00" ForeColor="White" OnClick="Button2_Click" Text="Add New Teacher " />
            </td>
            <td class="w3-center">
                <asp:Button ID="Button3" runat="server" BackColor="Red" ForeColor="White" OnClick="Button3_Click" Text="Delete Teacher" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <table class="auto-style2">
        <tr>
            <td style="width: 159px"></td>
            <td class="w3-center">
                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" style="text-align: center ; margin-left: 261px" Width="746px">
        <HeaderStyle BackColor="#66CCFF" BorderStyle="Double" />
                </asp:GridView>
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td>
                <div class="w3-center">
                </div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:stes_projectConnectionString %>" ProviderName="<%$ ConnectionStrings:stes_projectConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [teacher]"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>