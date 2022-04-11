using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfeitoDigitando
{
    public partial class Form1 : Form
    {
        int letra;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDigitando.Text = string.Empty;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTexto.Text))
            {
                if(btnIniciar.Text == "Iniciar")
                {
                    lblDigitando.Text = string.Empty;
                    letra = 0;
                    timer1.Enabled = true;
                    txtTexto.Enabled = false;
                    btnIniciar.Text = "Cancelar";
                }
                else
                {
                    EstadoInicial();
                }
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (letra == txtTexto.TextLength - 1)
                {
                    EstadoInicial();
                }

                lblDigitando.Text += txtTexto.Text.Substring(letra, 1);
                letra++;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void EstadoInicial()
        {
            timer1.Enabled = false;
            txtTexto.Enabled = true;
            btnIniciar.Text = "Iniciar";
            txtTexto.Focus();
            txtTexto.SelectAll();
        }
    }
}
