<%@ Page Title="" Language="C#" MasterPageFile="~/CadastroCRM.Master" AutoEventWireup="true" CodeBehind="AcessoCRM.aspx.cs" Inherits="ASP.AcessoCRM" %>
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
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="id1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="idAtendimento" DataSourceID="dt1" GridLines="Vertical"  Width="283px" Height="189px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="idAtendimento" HeaderText="idAtendimento" InsertVisible="False" ReadOnly="True" SortExpression="idAtendimento" />
                <asp:BoundField DataField="dataHoraAtendimento" HeaderText="dataHoraAtendimento" SortExpression="dataHoraAtendimento" />
                <asp:BoundField DataField="deptoEncaminhado" HeaderText="deptoEncaminhado" SortExpression="deptoEncaminhado" />
                <asp:BoundField DataField="dataPrevisaoResolucao" HeaderText="dataPrevisaoResolucao" SortExpression="dataPrevisaoResolucao" />
                <asp:BoundField DataField="transferido" HeaderText="transferido" SortExpression="transferido" />
                <asp:BoundField DataField="idTipoAtendimento" HeaderText="idTipoAtendimento" SortExpression="idTipoAtendimento" />
                <asp:BoundField DataField="idSituacaoAtendimento" HeaderText="idSituacaoAtendimento" SortExpression="idSituacaoAtendimento" />
                <asp:BoundField DataField="idFunc" HeaderText="idFunc" SortExpression="idFunc" />
                <asp:BoundField DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente" />
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
        </asp:GridView>
        <asp:SqlDataSource ID="dt1" runat="server" ConnectionString="<%$ ConnectionStrings:ERPConnectionString %>" SelectCommand="SELECT * FROM [Atendimento]"></asp:SqlDataSource>
        &nbsp;</p>
    </asp:Content>
