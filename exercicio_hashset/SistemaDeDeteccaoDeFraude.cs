using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_hashset
{
    public class SistemaDeDeteccaoDeFraude
    {
        public HashSet<string> lista = new();
        internal void AdicionarTransacao(string transacao)
        {
            if (!lista.Add(transacao))
            {
                Console.WriteLine($"Item duplicado identificado: {transacao}");
            }
        }
    }
}