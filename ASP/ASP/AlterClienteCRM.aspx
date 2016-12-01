<%@ Page Title="" Language="C#" MasterPageFile="~/CadastroCRM.Master" AutoEventWireup="true" CodeBehind="AlterClienteCRM.aspx.cs" Inherits="ASP.AcessoCRM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        table{
            display : inline-block;
            }
        .btn-Reset {
            width: 100px;
            font-size: medium;
            font-weight: bold;
        }
        ul{
            position: relative;
            left: -41px;
            top: -4px;
            width: 828px;
        }
        ul2
        {
            position : relative;
            left : 570px;
        }

        .praBaixo {
            position : relative;
            top: 212px;
            left: 0px;
        }
        
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 87px;
        }
        .auto-style3 {
            width: 96px;
        }
        .auto-style4 {
            width: 61px;
        }
        .auto-style5 {
            width: 94px;
        }
        .auto-style6 {
            width: 79px;
        }
        .auto-style7 {
            width: 82px;
        }
        .auto-style8 {
            width: 81px;
        }
        .auto-style9 {
            width: 138px;
        }
        .auto-style10 {
            width: 50px;
        }
        .auto-style11 {
            width: 45px;
        }
        .auto-style12 {
            width: 56px;
        }
        .auto-style13 {
            width: 59px;
        }
        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;

        <ul2> <font size="6">Informações do cliente :<br><br></font></ul2>
        <ul>
        <asp:GridView ID="id1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="idCliente" DataSourceID="dt1" GridLines="Vertical"  Width="1px" Height="1px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="idCliente" HeaderText="idCliente" InsertVisible="False" ReadOnly="True" SortExpression="idCliente" />
                <asp:BoundField DataField="CNPJCPF" HeaderText="CNPJCPF" SortExpression="CNPJCPF" />
                <asp:BoundField DataField="descCliente" HeaderText="descCliente" SortExpression="descCliente" />
                <asp:BoundField DataField="enderecoCompleto" HeaderText="enderecoCompleto" SortExpression="enderecoCompleto" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="telefone" HeaderText="telefone" SortExpression="telefone" />
                <asp:BoundField DataField="celular" HeaderText="celular" SortExpression="celular" />
                <asp:BoundField DataField="dataNascimento" HeaderText="dataNascimento" SortExpression="dataNascimento" />
                <asp:BoundField DataField="site" HeaderText="site" SortExpression="site" />
                <asp:BoundField DataField="RG" HeaderText="RG" SortExpression="RG" />
                <asp:BoundField DataField="sexo" HeaderText="sexo" SortExpression="sexo" />
                <asp:BoundField DataField="idTipoCliente" HeaderText="idTipoCliente" SortExpression="idTipoCliente" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView></ul>
        <asp:SqlDataSource ID="dt1" runat="server" ConnectionString="<%$ ConnectionStrings:ERPConnectionString %>" SelectCommand="SELECT * FROM [Cliente] ORDER BY [idCliente]"></asp:SqlDataSource>
        <div class="col-xs-12 col-sm-12 col-md-8 col-lg-8 central">
            <table class="table auto-style1 praBaixo">
                <tr>
                    <td class="auto-style2">ID do cliente</td>
                    <td class="auto-style3">CNPJ ou CPF</td>
                    <td class="auto-style4">Nome</td>
                    <td class="auto-style5">Endereço</td>
                    <td class="auto-style6">Email</td>
                    <td class="auto-style7">Telefone</td>
                    <td class="auto-style8">Celular</td>
                    <td class="auto-style9">Data de nascimento</td>
                    <td class="auto-style10">Site</td>
                    <td class="auto-style11">RG</td>
                    <td class="auto-style12">Sexo</td>
                    <td class="auto-style13">É VIP?</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtIDCli" runat="server" OnTextChanged="txtIDCli_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtCPFCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDescCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtEndCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtEmailCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtTelCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtCelCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtDataCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtSiteCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtRGCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtSexoCli" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtVIPCli" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            &nbsp;<asp:Button class="praBaixo" ID="btnAlterarCli" runat="server" OnClick="btnAlterarCli_Click1" Text="Alterar" />
       </div>
    </p>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    </asp:Content>
