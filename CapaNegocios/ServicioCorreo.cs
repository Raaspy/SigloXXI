using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace CapaNegocios
{
    public class ServicioCorreo
    {
        public void EnviarCorreo(string nombreCliente, string monto, string correoUsuario)
        {
            MailMessage ms = new MailMessage();
            SmtpClient smtp = new SmtpClient();


            ms.From = new MailAddress("recibossigloxxi@gmail.com");
            ms.To.Add(new MailAddress(correoUsuario)); //Correo Destinatario
            ms.Subject = "Recibo Compra en Restaurant SigloXXI";

            //Remplazamos los datos del html por los del sistema
            string textoPlantilla = string.Empty;
            using (StreamReader reader = new StreamReader(@"C:\Users\Administrator\Desktop\ProyectoSigloXXI\ProyectoSigloXXI\CapaNegocios\Plantillas\PlantillaCorreoVentas.html")) 
            {
                textoPlantilla = reader.ReadToEnd();
            }

            textoPlantilla = textoPlantilla.Replace("{Cliente}", nombreCliente);
            textoPlantilla = textoPlantilla.Replace("{Monto}", monto);

            //Adjuntamos el pdf con la boleta
            string path = @"C:\Users\Administrator\Desktop\ProyectoSigloXXI\ProyectoSigloXXI\CapaNegocios\Plantillas\ReciboSigloXXI.pdf";
            ms.Attachments.Add(new Attachment(path));


            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(textoPlantilla, Encoding.UTF8, MediaTypeNames.Text.Html);
            ms.AlternateViews.Add(htmlView);

            smtp.Host = "smtp.gmail.com"; //gmail
            smtp.Port = 587; //gmail

            smtp.Credentials = new NetworkCredential(ms.From.ToString(), "fqavycnnbzrhivih");
            smtp.EnableSsl = true;


            try
            {
                smtp.Send(ms);
                Console.WriteLine("El correo se envío de manera correcta.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el envio del correo: {0}", ex.Message);
            }
        }
    }
}
