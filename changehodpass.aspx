<%@ Page Title="" Language="C#" MasterPageFile="~/hod_master.Master" AutoEventWireup="true" CodeBehind="changehodpass.aspx.cs" Inherits="mas.changehodpass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td class="w3-right-align" style="width: 475px">
                <asp:Label ID="Label2" runat="server" Text="Enter Current Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" OnClick="Button4_Click" Text="Check" />
                <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="w3-right-align" style="width: 475px">
                <asp:Label ID="Label3" runat="server" Text="Enter New Password" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;<asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" OnClick="Button5_Click" Text="Save" Visible="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 475px">&nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
