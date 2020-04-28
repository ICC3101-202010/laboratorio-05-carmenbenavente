using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    class User
    {
        public void OnEmailSent(object source, EmailSentEventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\n¿Quiere verificar su correo? 1. Si, 2. No");
            Thread.Sleep(2000);
            string r = Console.ReadLine();
            if (r == "1")
            {
                source.OnEmailSent();
            }
        }
        public delegate void EmailVerifiedEventHandler(object source, EmailVerifiedEventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EmailVerifiedEventArgs() { });
            }
        }

    }
}
