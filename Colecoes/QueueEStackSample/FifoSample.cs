using System.Collections;
using System.Text;

namespace QueueEStackSample
{
    public class FifoSample
    {   
        public FifoSample()
        {
            FilaAtendimento = new Queue();
        }
        public Queue FilaAtendimento;
    
        public void PreencherFila() 
        {
            FilaAtendimento.Enqueue("Joao");
            FilaAtendimento.Enqueue("Maria");
            FilaAtendimento.Enqueue("Francisca");
            FilaAtendimento.Enqueue("Marcelo");
        }

        public void AtenderProximoCliente()
        {
            if (FilaAtendimento.Count > 0) 
            {
                FilaAtendimento.Dequeue();
            } 
        }

        public string ObterProximoCliente()
        {
            string proximoCliente = string.Empty;

            if (FilaAtendimento.Count > 0) 
            {
                proximoCliente = FilaAtendimento.Peek().ToString();
            }
            
             return proximoCliente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (string item in FilaAtendimento)
            {
               sb.AppendLine(item);   
            }

            return sb.ToString();
        }
    }
}