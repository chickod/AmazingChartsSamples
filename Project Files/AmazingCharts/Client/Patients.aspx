<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="Client.Patients" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Amazing Charts - Patient Management</title>
    <link href="~/Style/Patients.css" rel="stylesheet" />
    <script src="Scripts/jquery-2.1.0.min.js"></script>
    <script src="Scripts/jquery.validate.min.js"></script>
    <script src="Scripts/patients.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img id="imgLogo" src="~/Images/ACLogo.png" runat="server" class="logo" />
        <h2>Patient Management Console</h2>

        <asp:DropDownList ID="ddlPatients" runat="server" OnSelectedIndexChanged="ddlPatients_SelectedIndexChanged" />
        <asp:Button ID="btnDisplay" runat="server" Text="Display Patient Information" />

        <asp:Label ID="lblPatients" runat="server" CssClass="display" />

    </div>
    </form>
</body>
</html>