<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editorial.aspx.cs" Inherits="ws_Cliente.Editorial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />

        <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Business Casual - Start Bootstrap Theme</title>
        <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
        <!-- Font Awesome icons (free version)-->
        <script src="https://use.fontawesome.com/releases/v6.1.0/js/all.js" crossorigin="anonymous"></script>
        <!-- Google fonts-->
        <link href="https://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css?family=Lora:400,400i,700,700i" rel="stylesheet" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href="content/css/styles.css" rel="stylesheet" />
    </head>
    Tabla Editorial</p>
    <p>
        &nbsp;</p>
<p>
    Busqueda Editorial</p>
<p>
    <asp:TextBox ID="txtCriterio" runat="server"></asp:TextBox>
    &nbsp;(Texto a buscar)</p>
<p>
    <asp:TextBox ID="txtCampo" runat="server"></asp:TextBox>
    &nbsp;(Criterio: IdEditorial-Ciudad)</p>
<p>
    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Editorial" class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"/>
</p>
<p>
    <asp:TextBox ID="txtIdeditorial" runat="server"></asp:TextBox>
&nbsp;Id de Editorial</p>
<p>
    <asp:TextBox ID="txtnombreeditorial" runat="server"></asp:TextBox>
&nbsp;Nombre de editorial</p>
<p>
    <asp:TextBox ID="txtciudad" runat="server"></asp:TextBox>
    Ciudad</p>
<p>
    <asp:TextBox ID="txtestado" runat="server"></asp:TextBox>
    Estado</p>
<p>
    <asp:TextBox ID="txtpais" runat="server"></asp:TextBox>
    Pais</p>
    <p>
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar Editorial" class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"/>
        <asp:Button ID="btnActualizareditorial" runat="server" OnClick="btnActualizareditorial_Click" Text="Actualizar Editorial" class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"/>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
</asp:Content>
