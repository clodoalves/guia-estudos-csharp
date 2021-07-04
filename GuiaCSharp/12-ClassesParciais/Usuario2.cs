using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesParciais
{
    public partial class Usuario
    {
        public bool Autenticar() 
        {
            return (Nome == "Jose") & (Senha == "1234");
        }
    }
}
