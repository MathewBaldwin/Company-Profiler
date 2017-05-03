<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <style type="text/css">
        #domainTextBoxLbl{
            margin-left: 150px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:ListBox ID="ListBox1" runat="server" Height="408px" style="margin-left: 0px" Width="972px"></asp:ListBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="domainTextBoxLbl" class="label label-info" runat="server">Enter a WebSite: </asp:Label>
            <asp:TextBox ID="domainTextBox" runat="server" Height="27px" OnTextChanged="domainTextBox_TextChanged" style="margin-left: 0px" Width="400px"></asp:TextBox>
            
            <asp:Button ID="ok" class="btn btn-success" runat="server" OnClick="ok_Click" Text="Get Info" />
            
        </p>
    </form>
</body>
</html>
