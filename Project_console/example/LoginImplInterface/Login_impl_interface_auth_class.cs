using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_console.example.LoginImplInterface.interfaces;

namespace Project_console.example.LoginImplInterface
{
    // Cara menggunakan interface seperti meng-Extend class
    // dan dapat menggunakan lebih dari 1 interface
    class Login_impl_interface_auth_class : Auth_interface, Other_interface
    {
        public void login()
        {
            Console.WriteLine("Say Login");
        }

        public void logout()
        {
            Console.WriteLine("Say Logout");
        }

        public void sayInterfaceOther()
        {
            Console.WriteLine("Say interface others ");
        }
    }
}
