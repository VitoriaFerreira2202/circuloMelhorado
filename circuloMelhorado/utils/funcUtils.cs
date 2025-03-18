using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuloMelhorado.utils
{
    internal class funcUtils
    {
        //metodo startico que retorna icone
        public static MessageBoxIcon ObterIcone(string message) 
        {
            if (message.ToLower().Contains("erro"))
            {
                return MessageBoxIcon.Error;
            }
            else 
            {
             return MessageBoxIcon.Information;

            }

        }

    }
}
