using System.Collections;
using System.Collections.Generic;

namespace ImplementandoIEnumerable
{
    public class ListaClientes : IEnumerable
    {
        private List<string> _clientes = new List<string>();
        private int _index;

        public void Add(string cliente)
        {
            _clientes.Add(cliente);
            _index += 1;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _index; i++)
            {
                yield return _clientes[i];
            }
        }
    }
}