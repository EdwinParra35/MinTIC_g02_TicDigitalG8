using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyPeliculas.Client.Helpers
{
    public class UtilidadesString
    {
        
        public static string funcion_convert_mayusc(string valor) => valor.ToUpper();
        public static string funcion_convert_minusc(string valor) => valor.ToLower();      
    }
}