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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
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
                case 0:

                    obj.CalcularAreaCirculo(Convert.ToDouble(txtradio.Text));
                    lblarea.Text = obj.ObtenerArea().ToString("N2");
                    Reset();

                    break;

                case 1:

                    obj.CalcularAreaCuadrado(Convert.ToDouble(txtbase.Text), Convert.ToDouble(txtaltura.Text));
                    lblarea.Text = obj.ObtenerArea().ToString("N2");
                    Reset();

                    break;

                case 2:

                    obj.CalcularAreaTriangulo(Convert.ToDouble(txtbase.Text), Convert.ToDouble(txtaltura.Text));
                    lblarea.Text = obj.ObtenerArea().ToString("N2");
                    Reset();

                    break;
            }
        }

        private void Reset()
        {
            txtaltura.Text = string.Empty;
            txtbase.Text = string.Empty;
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
                Reset();
                lblarea.Text = "00.0";
            }
            else if (indice == 1)
            {
                txtradio.Enabled = false;
                txtaltura.Enabled = true;
                txtbase.Enabled = true;
                Reset();
                lblarea.Text = "00.0";
            }
            else
            {
                txtradio.Enabled = false;
                txtaltura.Enabled = true;
                txtbase.Enabled = true;
                Reset();
                lblarea.Text = "00.0";
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
                    lblareatri.Text = obj.ObtenerArea().ToString("N2");
                    Reset2();

                    break;

                case 1:
                    obj.CalcularAreaCubo(Convert.ToDouble(txtlado.Text));
                    lblareatri.Text = obj.ObtenerArea().ToString("N2");
                    Reset2();
                    break;

                case 2:
                    obj.CalcularAreaTetraedro(Convert.ToDouble(txtlado.Text));
                    lblareatri.Text = obj.ObtenerArea().ToString("N2");
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
                Reset2();
                lblareatri.Text = "00.0";
            }
            else if (indice == 1)
            {
                txtradioTri.Enabled = false;
                txtlado.Enabled = true;
                Reset2();
                lblareatri.Text = "00.0";
            }
            else
            {
                txtradioTri.Enabled = false;
                txtlado.Enabled = true;
                Reset2();
                lblareatri.Text = "00.0";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtbase_TextChanged(object sender, EventArgs e)
        {
            if (txtbase.Text == "0")
            {
                MessageBox.Show("La base no puede ser cero");
                txtbase.Text = txtbase.Text.Remove(txtbase.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbase.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtbase.Text = txtbase.Text.Remove(txtbase.Text.Length - 1);
            }
        }

        private void txtaltura_TextChanged(object sender, EventArgs e)
        {
            if (txtaltura.Text == "0")
            {
                MessageBox.Show("La altura no puede ser cero");
                txtaltura.Text = txtaltura.Text.Remove(txtaltura.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtaltura.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtaltura.Text = txtaltura.Text.Remove(txtaltura.Text.Length - 1);
            }
        }

        private void txtradio_TextChanged(object sender, EventArgs e)
        {
            if (txtradio.Text == "0")
            {
                MessageBox.Show("El radio no puede ser cero");
                txtradio.Text = txtradio.Text.Remove(txtradio.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtradio.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtradio.Text = txtradio.Text.Remove(txtradio.Text.Length - 1);
            }
        }

        private void txtradioTri_TextChanged(object sender, EventArgs e)
        {
            if (txtradioTri.Text == "0")
            {
                MessageBox.Show("El radio no puede ser cero");
                txtradioTri.Text = txtradioTri.Text.Remove(txtradioTri.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtradioTri.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtradioTri.Text = txtradioTri.Text.Remove(txtradioTri.Text.Length - 1);
            }
        }

        private void txtlado_TextChanged(object sender, EventArgs e)
        {
            if (txtlado.Text == "0")
            {
                MessageBox.Show("El lado no puede ser cero");
                txtlado.Text = txtlado.Text.Remove(txtlado.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtlado.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtlado.Text = txtlado.Text.Remove(txtlado.Text.Length - 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;

            if (indice == 0)
            {
                txtradioperi.Enabled = true;
                txtlado1.Enabled = false;
                txtlado2.Enabled = false;
                txtlado3.Enabled = false;
                Reset3();
                lblperimetro.Text = "00.0";
            }
            else if (indice == 1)
            {
                txtlado1.Enabled = true;
                txtlado2.Enabled = false;
                txtlado3.Enabled = false;
                txtradioperi.Enabled = false;
                Reset3();
                lblperimetro.Text = "00.0";
            }
            else
            {
                txtlado1.Enabled = true;
                txtlado2.Enabled = true;
                txtlado3.Enabled = true;
                txtradioperi.Enabled = false;
                Reset3();
                lblperimetro.Text = "00.0";
            }
        }

        private void Reset3()
        {
            txtradioperi.Text = string.Empty;
            txtlado1.Text = string.Empty;
            txtlado2.Text = string.Empty;
            txtlado3.Text = string.Empty;
        }

        private void btnperi_Click(object sender, EventArgs e)
        {
            FiguraBidimensional obj = new FiguraBidimensional();
            int indice = comboBox1.SelectedIndex;

            switch (indice)
            {
                case 0:
                    obj.CalcularPerimetroCirculo(Convert.ToDouble(txtradioperi.Text));
                    lblperimetro.Text = obj.ObtenerPerimetro().ToString("N2");
                    Reset3();
                    break;

                case 1:
                    obj.CalcularPerimetroCuadrado(Convert.ToDouble(txtlado1.Text));
                    lblperimetro.Text = obj.ObtenerPerimetro().ToString("N2");
                    Reset3();
                    break;

                case 2:
                    if (Convert.ToDouble(txtlado1.Text) + Convert.ToDouble(txtlado2.Text) <= Convert.ToDouble(txtlado3.Text) || Convert.ToDouble(txtlado1.Text) + Convert.ToDouble(txtlado2.Text) <= Convert.ToDouble(txtlado2.Text) || Convert.ToDouble(txtlado2.Text) + Convert.ToDouble(txtlado3.Text) <= Convert.ToDouble(txtlado1.Text))
                    {
                        MessageBox.Show("No es un triángulo válido. La suma de dos lados debe ser mayor que el tercer lado.");
                    }
                    else
                    {
                        obj.CalcularPerimetroTriangulo(Convert.ToDouble(txtlado1.Text), Convert.ToDouble(txtlado2.Text), Convert.ToDouble(txtlado3.Text));
                        lblperimetro.Text = obj.ObtenerPerimetro().ToString("N2");
                        Reset3();
                    }
                    break;
            }
        }

        private void txtlado1_TextChanged(object sender, EventArgs e)
        {
            if (txtlado1.Text == "0")
            {
                MessageBox.Show("Los lados no pueden ser cero");
                txtlado1.Text = txtlado1.Text.Remove(txtlado1.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtlado1.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtlado1.Text = txtlado1.Text.Remove(txtlado1.Text.Length - 1);
            }
        }

        private void txtlado2_TextChanged(object sender, EventArgs e)
        {
            if (txtlado2.Text == "0")
            {
                MessageBox.Show("Los lados no pueden ser cero");
                txtlado2.Text = txtlado2.Text.Remove(txtlado2.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtlado2.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtlado2.Text = txtlado2.Text.Remove(txtlado2.Text.Length - 1);
            }
        }

        private void txtlado3_TextChanged(object sender, EventArgs e)
        {
            if (txtlado3.Text == "0")
            {
                MessageBox.Show("Los lados no pueden ser cero");
                txtlado3.Text = txtlado3.Text.Remove(txtlado3.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtlado3.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtlado3.Text = txtlado3.Text.Remove(txtlado3.Text.Length - 1);
            }
        }

        private void txtradioperi_TextChanged(object sender, EventArgs e)
        {
            if (txtradioperi.Text == "0")
            {
                MessageBox.Show("Los lados no pueden ser cero");
                txtradioperi.Text = txtradioperi.Text.Remove(txtradioperi.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtradioperi.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtradioperi.Text = txtradioperi.Text.Remove(txtradioperi.Text.Length - 1);
            }
        }

    }
}
