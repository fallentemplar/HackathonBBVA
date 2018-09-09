using System;
using System.Text;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace EMPADI
{
    public class Transaccion
    {
        int numeroInstitucion;
        int numeroTransaccion;
        float monto;
        string fecha;
        int tipoOperacion;
        string noCuenta;
        float comision;
        string ciudadOrigen;

        JavaScriptSerializer serializador;
        readonly string servidorWeb = "http://ec2-18-191-203-36.us-east-2.compute.amazonaws.com:5000/create";
        readonly int puertoD = 5000;

        public Transaccion(
            int numeroInstitucion,
            int numeroTransaccion,
            float monto,
            string fecha,
            int tipoOperacion,
            string noCuenta,
            float comision,
            string ciudadOrigen)
        {
            this.numeroInstitucion = numeroInstitucion;
            this.numeroTransaccion= numeroTransaccion;
            this.monto= monto;
            this.fecha= fecha;
            this.tipoOperacion = tipoOperacion;
            this.noCuenta = noCuenta;
            this.comision = comision;
            this.ciudadOrigen = ciudadOrigen;
        }

        public void serializar()
        {
            serializador = new JavaScriptSerializer();
            string outputJSON = serializador.Serialize(this);
            //File.WriteAllText("D:\\MiPrimerJSON.json", outputJSON);
            subir();
        }

        public void subir()//string JSON)
        {
            var httpRequest = HttpWebRequest.Create(servidorWeb);
            httpRequest.ContentType = "application/json"; 
            httpRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                string json = "{\"user\":\"test\","
                                + "\"password\":\"bla\"}";
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse httpResponse;
            try
            {
                httpResponse = httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch
            {

            }
        }

        public string get_link()
        {
            return "Enlace de prueba de conectividad";
        }
    }
}