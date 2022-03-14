<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_crud.aspx.cs" Inherits="student.student_crud" %>

<!DOCTYPE html
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            border: 3px solid #FF6600;
            background-color: #CCFF99;
        }
        .auto-style4 {
            width: 543px;
        }
        .auto-style6 {
            width: 381px;
            text-align: right;
        }
        .auto-style7 {
            width: 543px;
            text-align: left;
            height: 76px;
        }
        .auto-style8 {
            width: 381px;
            text-align: right;
            height: 76px;
        }
        .TACenter { text-align:center; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="2" class="auto-style1">
                <tr>
                    <td class="auto-style6">ROll no:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtroll" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnsearch" runat="server" Text="search" OnClick="btnsearch_Click" />
&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Address</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Course</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtcourse" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Button ID="btninsert" runat="server" Text="insert" OnClick="btninsert_Click" />
                    </td>
                    <td class="auto-style7">
                       <asp:Button ID="btnupdate" runat="server" Text="update" OnClick="btnupdate_Click" />
&nbsp;
<asp:Button ID="btndelete" runat="server" Text="delete" OnClick="btndelete_Click" />
&nbsp;<asp:Button ID="btnviews" runat="server" Text="views" OnClick="btnviews_Click" />
&nbsp; </td>
                </tr>
            </table>
        </div>
     <div class="TACenter">
        <asp:Label ID="Label1" runat="server"></asp:Label>
         &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">

            <FooterStyle BackColor="White" ForeColor="#000066" />

            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />

            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />

            <RowStyle ForeColor="#000066" />

            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />

            <SortedAscendingCellStyle BackColor="#F1F1F1" />

            <SortedAscendingHeaderStyle BackColor="#007DBB" />

            <SortedDescendingCellStyle BackColor="#CAC9C9" />

            <SortedDescendingHeaderStyle BackColor="#00547E" />

        </asp:GridView>
            </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    </form>
</body>
</html>