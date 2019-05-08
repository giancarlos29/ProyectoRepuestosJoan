using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Configuracion : Form
    {
        private static Configuracion frmInstance = null;

        public static Configuracion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new Configuracion();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }
        public Configuracion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea aplicar los cambios", "Cambios de configuracion", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK) { 
                AplicarCambios();
            }
            
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            CargarTextBox();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void AplicarCambios() {

            Properties.Settings.Default.ITBIS = decimal.Parse(txtITBIS.Text);
            Properties.Settings.Default.CFiscalSecuencia = Convert.ToInt32(txtSFacturaFiscal.Text);
            Properties.Settings.Default.CFinalSecuencia = Convert.ToInt32(txtSFacturaFinal.Text);
            Properties.Settings.Default.FechaVencimiento = Convert.ToDateTime(dateTimePicker1.Text);
            Properties.Settings.Default.CNotaDeCredito = Convert.ToInt32(txtSNCredito.Text);
            Properties.Settings.Default.Save();

            MessageBox.Show("Los cambios se aplicaron correctamente.","Cambios Aplicados",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
        }

        private void CargarTextBox()
        {
            txtITBIS.Text = Properties.Settings.Default.ITBIS.ToString();
            txtSFacturaFiscal.Text = Properties.Settings.Default.CFiscalSecuencia.ToString();
            txtSFacturaFinal.Text = Properties.Settings.Default.CFinalSecuencia.ToString();
            dateTimePicker1.Text = Properties.Settings.Default.FechaVencimiento.ToString();
            txtSNCredito.Text = Properties.Settings.Default.CNotaDeCredito.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

   