using System;
using WhatsAppApi;
namespace TestP
{
    class Program
    {
        static void Main(string[] args)
        {
            string to = "7978406411";
            string msg = "Hii I am Abhijit Parida";
            string from = "9437745159";
            WhatsApp wa = new WhatsApp(from, "", "Abhijit", false, false);
            wa.OnConnectSuccess += () =>
            {
                Console.WriteLine(" Connected with whatsApp Successfully");
                wa.OnLoginSuccess += (phonenumber, data) =>
                {
                    wa.SendMessage(to, msg);
                };
                wa.OnLoginFailed += (data) =>
                {
                    Console.WriteLine("WhatsApp Login failed please check the error through stack trace", data);
                };
                wa.Login();
            };
            wa.OnConnectFailed += (data) =>
            {
                Console.WriteLine("Connection Failled");
            };
            wa.Connect();
        }
        public void SendWhatsApp()
        {
          
        }
    }
}
