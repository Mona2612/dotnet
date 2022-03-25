<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Linqtoado.net.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>  
    <form id="form1" runat="server">  
        <div>  
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
