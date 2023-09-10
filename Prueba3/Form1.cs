using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseFigura;

namespace Prueba3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            cboBidi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotridi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            
            FiguraBidimensional obj = new FiguraBidimensional();
            int indice = cboBidi.SelectedIndex;
           
            switch (indice) 
            {
                case 0 :
                    
                    obj.CalcularAreaCirculo(Convert.ToDouble(txtradio.Text));
                    lblarea.Text = obj.ObtenerArea().ToString("N2");
                    Reset();

                    break;

                case 1 :
                    
                    obj.CalcularAreaCuadrado(Convert.ToDouble(txtbase.Text),Convert.ToDouble(txtaltura.Text));
                    lblarea.Text = obj.ObtenerArea().ToString("N2");
                    Reset();

                    break;

                case 2 :

                    obj.CalcularAreaTriangulo(Convert.ToDouble(txtbase.Text), Convert.ToDouble(txtaltura.Text));
                    lblarea.Text = obj.ObtenerArea().ToString("N2") ;
                    Reset();

                break;
            }
        }

        private void Reset()
        {
            txtaltura.Text = string.Empty;
            txtbase.Text= string.Empty;
            txtradio.Text = string.Empty;
        }
        private void Reset2()
        {
            txtradioTri.Text = string.Empty;
            txtlado.Text = string.Empty;
        }


        private void cboBidi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cboBidi.SelectedIndex;
            if (indice == 0)
            {
                txtradio.Enabled = true;
                txtaltura.Enabled = false;
                txtbase.Enabled = false;
            }
            else if (indice == 1)
            {
                txtradio.Enabled = false;
                txtaltura.Enabled = true;
                txtbase.Enabled = true;
            }
            else
            {
                txtradio.Enabled = false;
                txtaltura.Enabled = true;
                txtbase.Enabled = true;
            }
        }

        private void btncalctri_Click(object sender, EventArgs e)
        {
            

            FIguraTridimensional obj = new FIguraTridimensional();
            int indice = cbotridi.SelectedIndex;

            switch (indice) 
            {
                case 0:

                    obj.CalcularAreaEsfera(Convert.ToDouble(txtradioTri.Text));
                    lblareatri.Text=obj.ObtenerArea().ToString("N2");
                    Reset2();

                break;

                case 1:
                    obj.CalcularAreaCubo(Convert.ToDouble(txtlado.Text));
                    lblareatri.Text = obj.ObtenerArea().ToString("N2");
                    Reset2();
                break;

                case 2:
                    obj.CalcularAreaTetraedro(Convert.ToDouble(txtlado.Text));
                    lblareatri.Text=obj.ObtenerArea().ToString("N2");
                    Reset2();
                break;
            }
        }

        private void cbotridi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbotridi.SelectedIndex;
            if (indice == 0)
            {
                txtradioTri.Enabled = true;
                txtlado.Enabled = false;
            }
            else if (indice == 1)
            {
                txtradioTri.Enabled = false;
                txtlado.Enabled = true;
            }
            else
            {
                txtradioTri.Enabled = false;
                txtlado.Enabled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
