<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Logar.aspx.cs" Inherits="_Default"  EnableEventValidation = "false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="estilo.css" rel="stylesheet" /> 
    <center>
   <form>
     <p>
    </p>
    <p>
        <asp:Label ID="lb_Login" CssClass="txtLabel" runat="server" Text="LOGIN"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_Login" runat="server" MaxLength="10"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lb_Senha" CssClass="txtLabel" runat="server" Text="SENHA"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_Senha" runat="server" MaxLength="8" TextMode="Password" Width="92px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn_Logar" runat="server" Text="Logar" OnClick="btn_Logar_Click" Width="51px" Height="24px" />
    &nbsp;&nbsp;
        <asp:Button ID="btn_Limpar" runat="server" Text="Limpar Campos" Width="111px" OnClick="btn_Limpar_Click" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Inserir" runat="server" OnClick="btn_Inserir_Click" Text="Novo Cadastro" Width="106px" />
    </p>
    <p>
        <asp:Label ID="lb_mensagem" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Login ID="Acesso" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" LoginButtonText="ACESSO" OnAuthenticate="Acesso_Authenticate" PasswordLabelText="Senha:" RememberMeText="Deseja que guarde sua senha." TextLayout="TextOnTop" TitleText="ACESSO SISTEMA" UserNameLabelText="Login:">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
        </asp:Login>
    </p>
   </form>
        </center>
</asp:Content>



