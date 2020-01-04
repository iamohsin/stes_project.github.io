<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="addsubject.aspx.cs" Inherits="mas.addsubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td style="height: 26px"></td>
            <td class="w3-right-align" style="height: 26px; width: 322px;">
                <asp:Label ID="Label2" runat="server" Text="Select Semester"></asp:Label>
            </td>
            <td style="height: 26px; width: 322px;">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="height: 26px"></td>
            <td class="w3-right-align" style="height: 26px; width: 322px;">
                <asp:Label ID="Label3" runat="server" Text="Select Program"></asp:Label>
            </td>
            <td style="height: 26px; width: 322px;">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="w3-right-align" style="width: 322px">
                <asp:Label ID="Label4" runat="server" Text="Select  Department"></asp:Label>
            </td>
            <td style="width: 322px">
                <asp:DropDownList ID="DropDownList3" runat="server" style="margin-left: 111">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="w3-right-align" style="width: 322px">
                <asp:Label ID="Label5" runat="server" Text="Enter Course Code"></asp:Label>
            </td>
            <td style="width: 322px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="w3-right-align" style="width: 322px">
                <asp:Label ID="Label6" runat="server" Text="Enter Name"></asp:Label>
            </td>
            <td style="width: 322px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="auto-style2">
        <tr>
            <td class="w3-right-align" style="width: 657px">
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="w3-right-align" style="width: 657px">&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" BackColor="#33CC33" ForeColor="White" OnClick="Button2_Click" Text="Add" Width="96px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="w3-center" style="width: 657px">&nbsp;</td>
            <td class="w3-center">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
