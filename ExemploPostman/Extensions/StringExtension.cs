using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtension
    {
        public static string FromBase64(this string entradaBase64)
        {
            try
            {
                var dados = Convert.FromBase64String(entradaBase64);
                return Encoding.UTF8.GetString(dados);
            }
            catch (Exception)
            {
                return null;
            }            
        }
    }
}
