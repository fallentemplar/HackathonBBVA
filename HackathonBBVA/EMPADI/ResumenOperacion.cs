using System;
using System.Drawing;
using System.Windows.Forms;

namespace EMPADI
{
    public partial class ResumenOperacion : Form
    {
        const int depositoEfectivo = 1;

        Transaccion transaccion;
        DateTime timestamp;
        static int numeroTransaccion = 14529;

        public ResumenOperacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boton_cambiarCuenta.BackColor = Color.FromArgb(17, 112, 176);
            boton_mPrincipal.BackColor = Color.FromArgb(17, 112, 176);
            boton_continuar.BackColor = Color.FromArgb(17, 112, 176);
            boton_regresar.BackColor = Color.FromArgb(162, 203, 75);
            boton_salir.BackColor = Color.FromArgb(207, 61, 123);

            textBox1.BackColor = Color.FromArgb(17, 112, 176);
            textBox2.BackColor = Color.FromArgb(17, 112, 176);
            textBox3.BackColor = Color.FromArgb(17, 112, 176);
            textBox4.BackColor = Color.FromArgb(17, 112, 176);
            textBox5.BackColor = Color.FromArgb(17, 112, 176);
            textBox6.BackColor = Color.FromArgb(17, 112, 176);
        }

        private void boton_continuar_Click(object sender, EventArgs e)
        {
            timestamp = DateTime.Now;
            string fecha = timestamp.ToString();
            transaccion = new Transaccion(
                1,
                numeroTransaccion++,
                float.Parse(texto_importeD.Text.Substring(1)),
                fecha,
                depositoEfectivo,
                texto_cuenta.Text,
                0,
                "Ciudad de México"
                );
            PantallaEspera espere = new PantallaEspera(transaccion);
            this.Hide();
            //transaccion.serializar();
            espere.Show();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
