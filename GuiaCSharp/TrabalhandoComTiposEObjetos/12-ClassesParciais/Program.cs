using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesParciais
{
    /// <summary>
    /// Este exemplo demonstra:
    /// <para>
    ///     O uso de classes parciais. Neste tipo de estrutura, partes de codigo de uma mesma classe podem estar
    ///     em arquivos deifrentes.
    /// </para>
    /// <para>Todas as classes tem o mesmo nome, entao o compilador as une em uma unica estrutura</para>
    /// <para>Possibilita a separacao de responsabilidades e otimiza o resultado compilado</para>
    /// <para>Muito usado por projetistas de IDEs, como no Visual Studio</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario(123, "Jose", "1234");

            if (user.Autenticar())
                Console.WriteLine("Usuario autenticado com sucesso");
            else
                Console.WriteLine("Credenciais invalidas");

            Console.ReadLine();
        }
    }
}
