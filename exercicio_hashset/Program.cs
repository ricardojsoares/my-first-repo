using exercicio_hashset;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Operações
        // Criação de um HashSet de inteiros
        HashSet<int> numeros = new HashSet<int>();

        // Retorna true, 1 é adicionado
        bool adicionou = numeros.Add(1);

        Console.WriteLine("Adicionou 1? " + adicionou);

        // Retorna false, 1 já está no conjunto
        adicionou = numeros.Add(1);

        Console.WriteLine("Adicionou 1 novamente? " + adicionou);

        // Retorna true, 2 é adicionado
        adicionou = numeros.Add(2);

        Console.WriteLine("Adicionou 2? " + adicionou);

        // Retorna true, 1 é removido
        bool removeu = numeros.Remove(1);

        Console.WriteLine("Removeu 1? " + removeu);

        // Retorna false, 3 não está no conjunto
        removeu = numeros.Remove(3);

        Console.WriteLine("Removeu 3? " + removeu);

        // Retorna true, 2 está no conjunto
        bool contem = numeros.Contains(2);

        Console.WriteLine("Contém 2? " + contem);

        // Retorna false, 1 foi removido
        contem = numeros.Contains(1);

        Console.WriteLine("Contém 1? " + contem);

        #endregion

        #region Operações de Conjunto

        var produtosLoja1 = new HashSet<string> { "maçã", "banana", "cereja" };
        var produtosLoja2 = new HashSet<string> { " tâmara", "figo", "maçã" };
        // Unir os produtos (considerando itens únicos)
        Console.WriteLine("Produtos combinados (sem repetições):");
        produtosLoja1.UnionWith(produtosLoja2);


        foreach (var produto in produtosLoja1)
        {
            Console.WriteLine(produto);
        }

        var clientesCampanha1 = new HashSet<int> { 101, 102, 103 };
        var clientesCampanha2 = new HashSet<int> { 102, 104, 106 };
        // Encontrar clientes em ambas as campanhas (interseção)
        Console.WriteLine("Clientes em ambas as campanhas:");
        clientesCampanha1.IntersectWith(clientesCampanha2);

        foreach (var cliente in clientesCampanha1)
        {
            Console.WriteLine(cliente);
        }


        var produtosAtuais = new HashSet<string> { "notebook", "tablet", "smartphone" };
        var descontinuados = new HashSet<string> { "tablet" };
        // Remover produtos descontinuados da lista atual
        Console.WriteLine("Produtos atuais (sem os descontinuados):");
        produtosAtuais.ExceptWith(descontinuados);


        foreach (var produto in produtosAtuais)
        {
            Console.WriteLine(produto);
        }

        var produtosOnline = new HashSet<string> { "notebook", "smartphone", "tablet" };
        var produtosLojaFisica = new HashSet<string> { "smartphone", "câmera", "impressora" };
        // Obter produtos exclusivos de cada conjunto (diferença simétrica)
        Console.WriteLine("Produtos exclusivos (online ou loja física, mas não em ambos):");
        produtosOnline.SymmetricExceptWith(produtosLojaFisica);

        foreach (var produto in produtosOnline)
        {
            Console.WriteLine(produto);
        }

        #endregion

        #region Exercicios

        SistemaDeDeteccaoDeFraude detector = new SistemaDeDeteccaoDeFraude();

        // Simulação de adição de transações ao sistema
        string[] transacoes = { "TXN123456", "TXN123457", "TXN123458", "TXN123456", "TXN123459", "TXN123457" };

        Console.WriteLine("Testando o sistema de detecção de fraude:");
        foreach (var transacao in transacoes)
        {
            detector.AdicionarTransacao(transacao);
        }

        // Tentando adicionar uma transação anteriormente adicionada para testar a detecção de duplicatas
        Console.WriteLine("Repetindo uma transação para testar a detecção:");
        detector.AdicionarTransacao("TXN123458");

        #region Ex 2


        SistemaDeVotacao sistemaDeVotacao = new SistemaDeVotacao();

        // Simulação de votos em diferentes categorias por vários usuários
        Console.WriteLine("Testando o sistema de votação:");
        sistemaDeVotacao.RegistrarVoto("Melhor Filme", "User123");
        sistemaDeVotacao.RegistrarVoto("Melhor Filme", "User124");
        sistemaDeVotacao.RegistrarVoto("Melhor Ator", "User123");
        sistemaDeVotacao.RegistrarVoto("Melhor Ator", "User125");
        sistemaDeVotacao.RegistrarVoto("Melhor Filme", "User123");
        sistemaDeVotacao.RegistrarVoto("Melhor Ator", "User126");

        // Simulação de votação com tentativas duplicadas e checagem em categorias diferentes
        Console.WriteLine("Tentativas de votos duplicados em diferentes categorias:");
        sistemaDeVotacao.RegistrarVoto("Melhor Ator", "User123"); 
        sistemaDeVotacao.RegistrarVoto("Melhor Diretor", "User123");

        sistemaDeVotacao.ListarVotos();
        //sistemaDeVotacao.RemoverVoto(new Voto("Melhor Diretor", "User123"));
        //sistemaDeVotacao.RemoverVoto(new Voto("Melhor Diretor", "User129"));
        //sistemaDeVotacao.ListarVotos();
        //sistemaDeVotacao.RemoverVoto(new Voto("Melhor Diretor", "User123"));
        sistemaDeVotacao.ListarVotos();
        sistemaDeVotacao.ImprimirRanking();

        #endregion
        #endregion
    }
}