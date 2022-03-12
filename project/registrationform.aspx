<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrationform.aspx.cs" Inherits="regform.registrationform" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
<form id="form2" runat="server">
<div style="padding:5px;">
<h2>REGISTRATION FORM</h2>
<table class="table table-condensed" style="width:500px;">
<tr>
<td>
FIRST NAME:
</td>
<td>
   <asp:TextBox ID="txtfirstname" Text="FirstName" runat="server"/>
</td>
</tr>
<tr>
<td>
    LAST NAME:
</td>
<td>
    <asp:TextBox ID="txtlastname" Text="LastName" runat="server"/>
</td>
</tr>
    <tr>
        <td>
            GENDER:
        </td>
        <td>
            <asp:RadioButtonList ID="radiobtngender"  runat="server">
                <asp:ListItem>male</asp:ListItem>
                <asp:ListItem>female</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            ADDRESS:
        </td>
        <td>
            <asp:TextBox ID="txtaddress" Text="address" runat="server" TextMode="MultiLine" />
        </td>
    </tr>
    <tr>
        <td>
            CITY:
        </td>
        <td>
            <asp:DropDownList ID="ddlcity" runat="server">
                <asp:ListItem>choose city</asp:ListItem>
                <asp:ListItem>mumbai</asp:ListItem>
                <asp:ListItem>delhi</asp:ListItem>
                <asp:ListItem>bangalore</asp:ListItem>
                <asp:ListItem>ahmedabad</asp:ListItem>
                <asp:ListItem>jaipur</asp:ListItem>
                <asp:ListItem>surat</asp:ListItem>
                <asp:ListItem>lucknow</asp:ListItem>
                <asp:ListItem>indore</asp:ListItem>
                <asp:ListItem>nashik</asp:ListItem>
                <asp:ListItem>faridabad</asp:ListItem>
                <asp:ListItem>ghaziabad</asp:ListItem>
                <asp:ListItem>agra</asp:ListItem>
                <asp:ListItem>amritsar</asp:ListItem>
                <asp:ListItem>chandigarh</asp:ListItem>
                <asp:ListItem>other.....</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            STATE:
        </td>
        <td>
<asp:DropDownList ID="ddlstate" runat="server">
    <asp:ListItem>choose state</asp:ListItem>
    <asp:ListItem>maharastra</asp:ListItem>
    <asp:ListItem>delhi</asp:ListItem>
    <asp:ListItem>haryana</asp:ListItem>
    <asp:ListItem>uttar pradesh</asp:ListItem>
            <asp:ListItem>gujarat</asp:ListItem>
    <asp:ListItem>andhra pradesh</asp:ListItem>
    <asp:ListItem>karnataka</asp:ListItem>
    <asp:ListItem>tamil nadu</asp:ListItem>
    <asp:ListItem>westbengal</asp:ListItem>
    <asp:ListItem>other.....</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            USERNAME:
        </td>
        <td>
            <asp:TextBox ID="txtusername" Text="UserName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            EMAIL:
        </td>
        <td>
            <asp:TextBox ID="txtemail" Text="Email" runat="server"/>
        </td>
    </tr>
     <tr>
        <td>
            PASSWORD:
        </td>
        <td>
            <asp:TextBox ID="txtpassword" Text="Password" runat="server"/>
        </td>
    </tr>
     <tr>
        <td>
            CONFIRM PASSWORD:
        </td>
        <td>
            <asp:TextBox ID="txtconfirmpassword" Text="ConfirmPassword" runat="server"/>
        </td>
    </tr>
<tr>
<td colspan="2" align="left">
    <asp:Button ID="btnsubmit"  runat="server" Text="Submit" OnClick="btnsubmit_Click" />
</td>
</tr>
</table>
<asp:Label runat="server" ID="lblInfo" />

<br /><br />
<asp:GridView ID="progridview" runat="server"></asp:GridView>
</div>
</form>
</body>
</html>
     
