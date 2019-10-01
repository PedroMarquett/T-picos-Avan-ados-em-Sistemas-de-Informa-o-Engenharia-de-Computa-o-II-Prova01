using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjProva1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            Figura figura = new Figura()
            {
                Descricao = txtDescricao.Text,
                Ano       = Int32.Parse(txtAno.Text)
            };

            dbProva1Entities context = new dbProva1Entities();
            context.Figura.Add(figura);
            context.SaveChanges();
            LoadGrid();
            SendMessage("Registro Inserido!");

        }

        private void LoadGrid()
        {

            gvFiguras.DataSource = new dbProva1Entities().Figura.ToList<Figura>();
            gvFiguras.DataBind();

        }

        private void SendMessage(String txt)
        {
            lblMsg.Text = txt;
        }
    }

}