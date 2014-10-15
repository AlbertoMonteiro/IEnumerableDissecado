using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDissecado
{
    public class MaquinaEstado : IEnumerator<int>, IEnumerator
    {
        private readonly int i;
        private int estado;

        public MaquinaEstado(int i)
        {
            this.i = i;
            estado = 0;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            switch (estado)
            {
                case 0: Current = 1; estado++; return true;
                case 1: Current = 2; estado++; return true;
                case 2: Current = 3 / i; estado++; return true;
                case 3: Current = 4; estado++; return true;
                case 4: Current = 5; estado++; return true;
                case 5: Current = 6; estado++; return true;
                case 6: Current = 7; estado++; return true;
                case 7: Current = 8; estado++; return true;
                case 8: Current = 9; estado++; return true;
                default: return false;
            }
        }

        public void Reset()
        {
            throw new NotSupportedException("Crie uma nova instância.");
        }

        public int Current { get; private set; }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
