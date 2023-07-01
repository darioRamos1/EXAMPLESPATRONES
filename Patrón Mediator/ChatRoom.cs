using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Mediator
{
    internal class ChatRoom
    {
        public static void ShowMessage(Users user, string message)
        {
            Console.WriteLine(DateTime.Now + " [" + user.GetName() + "] : " + message);
        }
    }
}
