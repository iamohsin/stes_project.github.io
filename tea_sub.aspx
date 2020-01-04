<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="tea_sub.aspx.cs" Inherits="mas.tea_sub" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td>&nbsp;</td>
            <td class="w3-center" style="width: 802px">
                <asp:Label ID="Label2" runat="server" Text="Select Department"></asp:Label>
&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                &nbsp;
            &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Find" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 802px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 802px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 802px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px"></td>
            <td style="width: 802px; height: 26px;">
                </td>
            <td style="height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
    </table>
    <br />
    <table class="auto-style2">
        <tr>
            <td style="width: 386px">&nbsp;</td>
            <td>
                <div class="w3-center">
                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" style="text-align: center; margin-left: 0px" Width="746px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <HeaderStyle BackColor="#66CCFF" BorderStyle="Double" />
                </asp:GridView>
                </div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:stes_projectConnectionString %>" ProviderName="<%$ ConnectionStrings:stes_projectConnectionString.ProviderName %>" SelectCommand=""></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 386px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 386px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
