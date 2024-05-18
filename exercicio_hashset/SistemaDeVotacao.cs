using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_hashset
{
    public class SistemaDeVotacao
    {
        HashSet<Voto> lista = new();
        internal void RegistrarVoto(string filme, string usuario)
        {
            if (!lista.Add(new Voto(filme, usuario)))
                Console.WriteLine($"Voto duplicado - Filme: {filme}, Usuário: {usuario}");
        }

        public void RemoverVoto(Voto voto)
        {
            if (!lista.Remove(voto))
            {
                Console.WriteLine($"Voto não encontrado - Filme: {voto.Filme}, Usuário: {voto.Usuario}");
            }
            else
            {
                Console.WriteLine($"Voto removido - Filme: {voto.Filme}, Usuário: {voto.Usuario}");
            }
        }

        public void ListarVotos()
        {
            foreach (var item in lista.ToList())
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ImprimirRanking()
        {
            var listaRanking = lista.ToList().GroupBy(voto => voto.Filme)
                                             .Select(grupo => new
                                             {
                                                 Filme = grupo.Key,
                                                 QtdeVotos = grupo.Count()
                                             }).OrderByDescending(rank => rank.QtdeVotos).ToList();

            int Contador = 0;
            foreach (var item in listaRanking)
            {
                Contador++;
                Console.WriteLine($"{Contador} - Filme: {item.Filme}, Qtde de votos: {item.QtdeVotos}");
            }
        }
    }

    public class Voto
    {
        public string Filme { get; set; }
        public string Usuario { get; set; }
        public Voto(string filme, string usuario)
        {
            this.Filme = filme;
            this.Usuario = usuario;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Voto voto = (Voto)obj;
            return this.Filme == voto.Filme && this.Usuario == voto.Usuario;
        }

        public override int GetHashCode()
        {
            return this.Usuario.GetHashCode();
        }

        public override string ToString()
        {
            return $"[Voto - Filme: {this.Filme}, Usuário: {this.Usuario}]";
        }
    }
}