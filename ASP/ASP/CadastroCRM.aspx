<%@ Page Title="" Language="C#" MasterPageFile="~/CadastroCRM.Master" AutoEventWireup="true" CodeBehind="CadastroCRM.aspx.cs" Inherits="ASP.CadastroCRM1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            display:inline-block;

        }
        .auto-style2 {
            text-align: center;
            width:100%;
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
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;"><h2>Descrição do atendimento</h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:TextBox ID="txtDescAtend" runat="server" MaxLength="40" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:Button ID="btnCadSitAtend" runat="server" Text="Cadastrar" Font-Bold="True" Font-Size="Medium" OnClick="btnCadSitAtend_Click" />
                <input id="Reset1" type="reset" class="btn-Reset" value="reset" /></td>
        </tr>
    </table>&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="auto-style1" style="color: #800000; text-align: center; border-spacing: inherit" border="0">
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;"><h2>Tipo do atendimento</h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:TextBox ID="txtTipoAtend" runat="server" MaxLength="40" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:Button ID="btnCadastrarTipoAtendimento" runat="server" Text="Cadastrar" Font-Bold="True" Font-Size="Medium" OnClick="btnCadastrarTipoAtendimento_Click"/>
                <input id="Reset2" type="reset" class="btn-Reset" value="reset" />
            </td>
        </tr>
    </table>&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="auto-style1" style="color: #800000; text-align: center; border-spacing: inherit" border="0">
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;"><h2>Situação de pedido</h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:TextBox ID="txtSitPed" runat="server" MaxLength="40" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:Button ID="btnCadSit" runat="server" Text="Cadastrar" Font-Bold="True" Font-Size="Medium" OnClick="btnCadSit_Click"/>
                <input id="Reset3" type="reset" class="btn-Reset" value="reset" />
            </td>
        </tr>
    </table>&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="auto-style1" style="color: #800000; text-align: center; border-spacing: inherit" border="0">
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;"><h2>Descrição do produto</h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:TextBox ID="txtDescProd" runat="server" MaxLength="40" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:Button ID="btnCadDescProd" runat="server" Text="Cadastrar" Font-Bold="True" Font-Size="Medium" OnClick="btnCadDescProd_Click"/>
                <input id="Reset4" type="reset" class="btn-Reset" value="reset" />
            </td>
        </tr>
    </table>&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="auto-style1" style="color: #800000; text-align: center; border-spacing: inherit" border="0">
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;"><h2>Descrição do serviço</h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:TextBox ID="txtDescServ" runat="server" MaxLength="40" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:Button ID="btnCadDescServ" runat="server" Text="Cadastrar" Font-Bold="True" Font-Size="Medium" OnClick="btnCadDescServ_Click" />
                <input id="Reset5" type="reset" class="btn-Reset" value="reset" />
            </td>
        </tr>
    </table>
    </center>
</asp:Content>
