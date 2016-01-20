<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 2</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Books</h1>
        <hr />
        <p>Select an author from the dorp down menu.</p>
        <asp:DropDownList ID="DdlOfAuthors" runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="DblAuthors_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:GridView ID="GvBooks" runat="server"></asp:GridView>

    </div>
    </form>
</body>
</html>
