using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    class User
    {
        public void OnEmailSent(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\n¿Quiere verificar su correo? 1. Si, 2. No");
            Thread.Sleep(2000);
            string r = Console.ReadLine();
            if (r == "1")
            {
                EmailVerified(source, args);
            }
        }
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;
        protected virtual void OnEmailVerified(object source, EventArgs args)
        {
            if (EmailVerified != null)
            {
                EmailVerified(this,args);
            }
        }

    }
}
