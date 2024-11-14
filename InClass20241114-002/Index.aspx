<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="InClass20241114_002.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lbPizzaCompanies" runat="server"></asp:ListBox>
            </br>
        </div>
        <p>
            <asp:Button ID="cmdSelectPizzaCompany" runat="server" Text="Select a pizza company" OnClick="cmdSelectPizzaCompany_Click" />
        </p>
        <p>
            <asp:Label ID="lblSelectPizzaCompany" runat="server" Text=""></asp:Label>
            <asp:CheckBoxList ID="cblIngredients" runat="server"></asp:CheckBoxList>
        </p>
    </form>
</body>
</html>
