using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPADI
{
    public partial class PantallaEspera : Form
    {
        Transaccion transaccion;

        public PantallaEspera(Transaccion transaccion)
        {
            this.transaccion = transaccion;
            InitializeComponent();
        }

        private void PantallaEspera_Load(object sender, EventArgs e)
        {
            reloj.Left = (reloj.Parent.Width - reloj.Width) / 2;
            reloj.Top = (reloj.Parent.Height - reloj.Height) / 2;
            label1.ForeColor = Color.FromArgb(17, 112, 176);
            label2.ForeColor = Color.FromArgb(17, 112, 176);
            label3.ForeColor = Color.FromArgb(17, 112, 176);
            label1.Left = (label1.Parent.Width - label1.Width) / 2;
            label2.Left = (label2.Parent.Width - label2.Width) / 2;
            label3.Left = (label3.Parent.Width - label3.Width) / 2;
        }

        private void Cerrar(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private async void PantallaEspera_Shown(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            this.Hide();
            PantallaElegirComprobante elegirC = new PantallaElegirComprobante(transaccion);
            elegirC.Show();
        }
    }
}
