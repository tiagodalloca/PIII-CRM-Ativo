<%@ Page Title="" Language="C#" MasterPageFile="~/CadastroCRM.Master" AutoEventWireup="true" CodeBehind="CadastroCRM.aspx.cs" Inherits="ASP.CadastroCRM1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 341px;
            height: 25px;
            border: 2px solid #000000;
        }
        .auto-style2 {
            text-align: center;
        }
        #Reset1 {
            width: 75px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <table align="center" class="auto-style1" style="color: #800000; background-color: #FF9966; border-color: #FFFF00; text-align: center; border-spacing: inherit">
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;"><h2>Descrição do Atendimento</h2></td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="40" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-color: #FF9966; background-color: #FFCC99; color: #800000; font-family: Georgia;">
                <asp:Button ID="btnCadSitAtend" runat="server" Text="Cadastrar" Font-Bold="True" Font-Size="Medium" OnClick="btnCadSitAtend_Click" />
                <input id="Reset1" type="reset" value="reset" /></td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
