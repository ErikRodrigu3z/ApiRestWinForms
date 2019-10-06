using Service;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertidorMondeda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //service - ApiCambio
            ApiCambio api = new ApiCambio();
            
            //modelo
            Resultado model = new Resultado();
            model = api.modelGetCambio(cmboOrigen.Text, cmboDestino.Text, 1, txtApiKey.Text, cmboFormato.Text);

            //Lit
            //List<Result> List = new List<Result>();
            //List = api.ListGetCambio(cmboOrigen.Text, cmboDestino.Text, 1, txtApiKey.Text, cmboFormato.Text);

            //datos alabels
            lblActualizacion.Text = model.result.updated.ToShortDateString();
            lblEstatus.Text = model.status;
            lblMDestino.Text = model.result.target;
            lblMOrigen.Text = model.result.source;
            lblValor.Text = model.result.value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboOrigen.SelectedIndex = 1;
            cmboDestino.SelectedIndex = 0;
            cmboFormato.SelectedIndex = 0;
            
        }
    }
}
