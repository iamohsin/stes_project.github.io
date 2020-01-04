<%@ Page Title="" Language="C#" MasterPageFile="~/student_master.Master" AutoEventWireup="true" CodeBehind="evalution.aspx.cs" Inherits="mas.Student_home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td>&nbsp;</td>
            <td style="width: 1074px">
                <asp:Label ID="Label2" runat="server" Text="Welcome"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
            &nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td style="width: 1074px">
                <br />
                <br />
&nbsp; </td>
            <td>
                <br />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 290px">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td style="width: 1074px; height: 290px;">
                <table class="auto-style2">
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 296px">&nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Visible="False" Height="26px">
                            </asp:DropDownList>
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 26px" Text="Find Subject" Visible="False" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Give Feedback About Your Teachers" BackColor="Black" ForeColor="White" style="margin-left: 114px" Width="300px" />
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 296px">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 296px">&nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server" Visible="False" Height="35px">
                            </asp:DropDownList>
                            <asp:Label ID="Label6" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 296px">&nbsp;</td>
                        <td>
&nbsp;&nbsp;
                            </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="height: 30px"></td>
                        <td style="width: 296px; height: 30px;"></td>
                        <td style="height: 30px">
                            <asp:Button ID="Button4" runat="server" BackColor="#009933" ForeColor="White" Text="Start Evaluation" Visible="False" Width="271px" OnClick="Button4_Click1" />
                        </td>
                        <td style="height: 30px"></td>
                        <td style="height: 30px"></td>
                    </tr>
                </table>
            </td>
            <td style="height: 290px"></td>
            <td style="height: 290px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 1074px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="auto-style2">
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <br />
&nbsp;</td>
        </tr>
        
        
        </table>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <table class="auto-style2" style="height: 1457px">
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Q. The Instructor is prepared for each class"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server"  OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Q. The Instructor demonstrates knowledge of the subject"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Q. The Instructor has completed the whole course"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Q. The Instructor provides additional material apart from the textbook"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList4" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="height: 76px">
                    <asp:Label ID="Label20" runat="server" Text="Q. The Instructor gives citations regarding current situations with reference to Pakistani context"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList5" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Q. The Instructor communicates the subject matter effectively"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList6" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Q. The Instructor shows respect towards students and encourages class participation"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList7" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Q. The Instructor maintains an environment that is conducive to learning"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList8" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="Q. The Instructor arrives on time "></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList9" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="Q.The Instructor leaves on time"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList10" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="Q. The Instructor is fair in examination"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList11" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="Q. The Instructor returns the graded scripts etc. in  a reasonable amount of time"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList12" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            </tr>
            <tr>
                <td style="height: 7px">
                    <asp:Label ID="Label19" runat="server" Text="Q. The Instructor was available during the specified office hours and for after class consultations"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList13" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                    </td>
            </tr>
            <tr>
                <td style="height: 4px">
                    <asp:Button ID="Button5" runat="server" BackColor="#00CC00" ForeColor="White" OnClick="Button5_Click" Text="Submit" Width="206px" />
                </td>
            </tr>
            <tr>
                <td style="height: 9px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
