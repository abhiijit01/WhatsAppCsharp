using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.TwiML.Messaging;

namespace whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC2ca69e0be8f63f7b0be436a1660cf9db";
            const string authToken = "8525996d8758066700a84e91ec92e383";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                from:("whatsapp:+14155238886"),
                to:("whatsapp:+919437745159"),
                body:"hii Abhijit, I have successfully sended the whatsapp message by coding"
                );
            Console.WriteLine("Message SID:" + message.Sid);
        }
    }
}
