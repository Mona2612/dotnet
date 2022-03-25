<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Linqtoentities.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>  
<form id="form2" runat="server">  
<div class="GridviewDiv">  
<asp:GridView ID="gvDetails" CssClass="Gridview" runat="server" AutoGenerateColumns="False">  
<HeaderStyle CssClass="headerstyle" />  
<Columns>  
<asp:BoundField HeaderText="Name" DataField="Name" />  
<asp:BoundField HeaderText="Location" DataField="Location" />  
<asp:BoundField HeaderText="Gender" DataField="Gender" />  
</Columns>  
</asp:GridView>  
</div>  
</form>  
</body>  
</html>
