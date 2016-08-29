using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produtos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        gv_FilmeSelecionado.Visible = false;
    }

    protected void btn_Pesquia_Click(object sender, EventArgs e)
    {
        // montando o GRID na mão

        gv_FilmeSelecionado.Visible = true;
        



    }
}