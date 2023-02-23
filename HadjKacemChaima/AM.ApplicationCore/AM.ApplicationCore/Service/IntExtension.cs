using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public static class IntExtension
    {
        public static int add( this int a , int b) // this pour dire l'objet courant (win ma nhot this atheka eli baad besh naytou bih)
        {
            return a + b;
        }
    }
}
