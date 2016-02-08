using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.LoginImplInterface.interfaces
{
    /** 
     * Interface ini meng-Extend interface lain 
     * jadi setiap class yang meng-Implementasikan interface ini
     * harus juga meng-Implementasikan interface yang di turunkannya
     * 
     * setiap class diperbolehkan meng-Extend interface lebih dari satu atau banyak
     **/
    interface Other_interface : Auth_interface
    {
        void sayInterfaceOther();
    }
}
