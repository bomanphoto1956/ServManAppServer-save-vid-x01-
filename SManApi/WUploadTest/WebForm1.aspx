<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WUploadTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
        <br />
        
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        
        <br />

        <asp:Button ID="Button2" runat="server" Text="Hämta" OnClick="Button2_Click" />
        
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
<br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Radera" OnClick="Button3_Click" />
<br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Lista rader" OnClick="Button4_Click" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
