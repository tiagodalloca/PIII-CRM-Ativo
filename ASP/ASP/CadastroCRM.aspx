<%@ Page Title="Cadastros do CRM" Language="C#" MasterPageFile="~/CadastroCRM.Master" AutoEventWireup="true" CodeBehind="CadastroCRM.aspx.cs" Inherits="ASP.CadastroCRM1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            top: 50%;
            left: 50%;
            transform: translateY(-50%) translateX(-50%);
            z-index: 100;
            position: absolute;
            font-family: "quicksandregular";
        }
        .auto-style2 {
            text-align: center;
            width:100%;
            font-family: "quicksandregular";
        }
        .btn-Reset {
            width: 100px;
            font-size: medium;
            font-weight: bold;
        }
        table{
            display : inline-block;
            width: 15%;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <table class="auto-style1" style="color: #800000; text-align: center; border-spacing: inherit" border="0">
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000;"><h2>Cadastro de:</h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000;"><h2>
                <asp:DropDownList ID="cbxTabelas" runat="server">
                    <asp:ListItem Value="LI1">Descrição de atendimento</asp:ListItem>
                    <asp:ListItem Value="LI2">Tipo de Atendimento</asp:ListItem>
                    <asp:ListItem Value="LI3">Situação de pedido</asp:ListItem>
                    <asp:ListItem Value="LI4">Categoria de produto</asp:ListItem>
                    <asp:ListItem Value="LI5">Categoria de serviço</asp:ListItem>
                </asp:DropDownList>
                </h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000;">
                <asp:TextBox ID="txtTexto" runat="server" MaxLength="50" Width="174px"></asp:TextBox>
                <br />
                <asp:Label ID="lblGrande" runat="server" Text="Digite no máximo 40 caracteres" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000;">
                <asp:Button ID="btnCadSitAtend" runat="server" Text="Cadastrar" OnClick="btnCadSitAtend_Click" />
                <asp:Button ID="btnLimpar1" runat="server" Text="Limpar" OnClick="btnLimpar1_Click" />
            </td>
        </tr>
    </table>
    </center>
</asp:Content>
