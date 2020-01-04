<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="addteacher.aspx.cs" Inherits="mas.addteacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td style="height: 26px"></td>
            <td class="w3-right-align" style="height: 26px">&nbsp;</td>
            <td style="height: 26px">&nbsp;</td>
            <td style="height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="height: 26px"></td>
            <td class="w3-right-align" style="height: 26px">&nbsp;</td>
            <td style="height: 26px">&nbsp;</td>
            <td style="height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="w3-right-align">
                <asp:Label ID="Label2" runat="server" Text="Enter Teacher Name"></asp:Label>
            </td>
            <td>&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-top: 0"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="w3-right-align">&nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 0">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="w3-right-align">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="auto-style2">
        <tr>
            <td class="w3-right-align" style="width: 657px">
                <asp:Label ID="Label8" runat="server" Text="Enter UserName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="w3-right-align" style="width: 657px">
                <asp:Label ID="Label11" runat="server" Text="Enter Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="w3-center" style="width: 657px">
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
            <td class="w3-center">
                <asp:Button ID="Button2" runat="server" BackColor="#33CC33" ForeColor="White" OnClick="Button2_Click" Text="ADD" Width="139px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
