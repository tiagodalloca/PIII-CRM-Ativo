<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Filmes.aspx.cs" Inherits="Produtos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <center>
     <asp:Label ID="lb_Titulo" runat="server" Text="Escolha Genero Filme: "></asp:Label>
     &nbsp;
     <asp:DropDownList ID="ddl_Genero" runat="server" DataSourceID="sds_Genero" DataTextField="desc_Genero" DataValueField="id_Genero" AppendDataBoundItems="True" AutoPostBack="True">
    </asp:DropDownList>
        <asp:SqlDataSource ID="sds_Genero" runat="server" ConnectionString="<%$ ConnectionStrings:conexaoBD %>" SelectCommand="SELECT * FROM [GeneroFilme]"></asp:SqlDataSource>
        <br />
        <asp:Label ID="lb_TituloFilme" runat="server" Text="Escolha do Filme Desejado:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddl_Filme" runat="server" DataSourceID="sds_Filmes" DataTextField="desc_Filmes" DataValueField="id_Filmes">
        </asp:DropDownList>
        <asp:SqlDataSource ID="sds_Filmes" runat="server" ConnectionString="<%$ ConnectionStrings:conexaoBD %>" SelectCommand="SELECT gf.id_genero, f.id_Filmes, f.desc_Filmes 
FROM generoFilme AS gf INNER JOIN filmes AS f ON gf.id_Genero = f.id_Genero
WHERE (gf.id_genero = @id_Genero)
">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddl_Genero" Name="id_Genero" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Button ID="btn_Pesquia" runat="server" Text="Pesquisar" OnClick="btn_Pesquia_Click" />
        <br />
        <br />
        <asp:GridView ID="gv_FilmeSelecionado" runat="server" AutoGenerateColumns="False" DataSourceID="sds_FilmeSelecionado" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="desc_Filmes" HeaderText="desc_Filmes" SortExpression="desc_Filmes" />
                <asp:BoundField DataField="img_Filmes" HeaderText="img_Filmes" SortExpression="img_Filmes" />
                <asp:BoundField DataField="sinopse_Filmes" HeaderText="sinopse_Filmes" SortExpression="sinopse_Filmes" />
                <asp:BoundField DataField="dur_Filmes" HeaderText="dur_Filmes" SortExpression="dur_Filmes" />
                <asp:BoundField DataField="cens_Filmes" HeaderText="cens_Filmes" SortExpression="cens_Filmes" />
                <asp:ImageField DataImageUrlField="img_Filmes" DataImageUrlFormatString="imagens/{0}" HeaderText="CARTAZ">
                </asp:ImageField>
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="sds_FilmeSelecionado" runat="server" ConnectionString="<%$ ConnectionStrings:conexaoBD %>" SelectCommand="select desc_Filmes, img_Filmes, sinopse_Filmes,dur_Filmes,cens_Filmes from Filmes
where id_Filmes =@id_Filmes">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddl_Filme" DefaultValue="0" Name="id_Filmes" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    </center>
</asp:Content>

