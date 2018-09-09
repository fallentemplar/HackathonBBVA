using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace EMPADI
{
    public partial class PantallaElegirComprobante : Form
    {
        Transaccion transaccion;
        string link;
        public PantallaElegirComprobante(Transaccion transaccion)
        {
            InitializeComponent();
            this.transaccion = transaccion;
            transaccion.serializar();
            boton_enviarT.BackColor = Color.FromArgb(17, 112, 176);
            campo_telefono.ResetText();
            link = transaccion.get_link();
            gen_qr(link);
        }

        private void boton_enviarT_Click(object sender, EventArgs e)
        {
            if (campo_telefono.Text == "") ;
        }

        private void gen_qr(string link)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            encoder.TryEncode(link, out qrCode);
            GraphicsRenderer render = new
                GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero),
                Brushes.Black, Brushes.White);
            //Creacion de memoria
            MemoryStream ms = new MemoryStream();
            render.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);

            var temporal = new Bitmap(ms);
            var image = new Bitmap(temporal, new Size(new Point(250, 250)));
            panel1.BackgroundImage = image;
        }

        private void PantallaElegirComprobante_Load(object sender, EventArgs e)
        {
            opcionComprobante.ForeColor = Color.FromArgb(17, 112, 176);
        }
    }
}
