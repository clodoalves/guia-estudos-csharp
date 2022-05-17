using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_CriandoCustomExceptions
{
    public class CampoInvalidoException : Exception 
    {
        public CampoInvalidoException(string mensagem) : base(mensagem)
        {

        }    
    }

    public class TotalCaracteresExcedidoException : Exception 
    {
        public TotalCaracteresExcedidoException(string mensagem) : base(mensagem)
        {

        }
    }


    public class SenhaInvalidaException : Exception 
    {
        public SenhaInvalidaException(string mensagem) : base(mensagem)
        {

        }  
    
    } 

    public static class Autentificacao
    {
        private const int LIMITE_CARACTERES_CAMPO_USUARIO = 15;
        private const int LIMITE_CARACTERES_CAMPO_SENHA = 10;

        public static void Autenticar(string usuario, string senha)
        {

            if (usuario.Length > LIMITE_CARACTERES_CAMPO_USUARIO)
            {
                throw new TotalCaracteresExcedidoException("O limite de caracteres para o campo Usuário é 15");
            }

            if (usuario.Length > LIMITE_CARACTERES_CAMPO_SENHA) 
            {
                throw new TotalCaracteresExcedidoException("O limite de caracteres para o campo Senha é 10");
            }

            if (usuario != "admin" || senha != "admin")
            {
                throw new CampoInvalidoException("Usuário inválido ou Senha inválida");
            } 
        }
    }
}