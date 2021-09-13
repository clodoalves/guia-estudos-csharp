using System.Collections;
using System.Text;

namespace QueueEStackSample
{
    public class LifoSample
    {
        public Stack PilhaPratos;

        public void PreencherPilha()
        {
            PilhaPratos.Push("Prato1");
            PilhaPratos.Push("Prato2");
            PilhaPratos.Push("Prato3");
            PilhaPratos.Push("Prato4");
        }

        public void RetirarProximoPrato()
        {
            if (PilhaPratos.Count > 0)
                PilhaPratos.Pop();
        }

        public string ObterProximoPrato()
        {
            string proximoPrato = string.Empty;

            if (PilhaPratos.Count > 0)
                proximoPrato = PilhaPratos.Peek().ToString();
            
            return proximoPrato;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string item in PilhaPratos)
            {
                sb.AppendLine(item);
            } 

            return sb.ToString();
        }
    }
}