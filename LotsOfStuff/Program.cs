using System;
using System.Collections;

namespace Aula10
{
    /// <summary>Programa para testar o projeto</summary>
    public class Program
    {
        /// <summary>O programa começa aqui no Main</summary>
        /// <param name="args">Ignoramos os argumentos de linha de comandos neste programa</param>
        public static void Main(string[] args)
        {
            // Criar uma nova instância de Program e
            // invocar o método TestProject na instância criada
            Program prog = new Program();
            prog.TestProject();

        }

        /// <summary>Método que testa este projeto</summary>
        private void TestProject()
        {

            Bag otherBag;

            // Instanciar um jogador com 70 quilos
            Player p = new Player(70.0f);
            Console.WriteLine(p);



            // Adicionar vários itens à mochila do jogador:

            // Pão com 2 dias, 500 gramas
            p.BagOfStuff.Add(new Food(FoodType.Bread, 2, 0.500f));
            // 300 gramas de vegetais com 5 dias
            p.BagOfStuff.Add(new Food(FoodType.Vegetables, 5, 0.300f));
            // Pistola com 1.5kg + 50 gramas por bala, carregada com 10 balas, com um custo de 250€
            p.BagOfStuff.Add(new Gun(1.5f, 0.050f, 10, 250));
            // 200 gramas de fruta fresca
            p.BagOfStuff.Add(new Food(FoodType.Fruit, 0, 0.200f));
            // Pistola com 1.0kg + 25 gramas por bala, carregada com 5 balas, com um custo de 125€
            p.BagOfStuff.Add(new Gun(1.0f, 0.025f, 5, 125));

            // Quantos itens tem o jogador na mochila?
            Console.WriteLine($"Nº de itens na mochila: {p.BagOfStuff.Count}");

            Console.WriteLine($"{p.BagOfStuff}");

            otherBag = new Bag(5)
            {
                new Food(FoodType.Bread, 5, 1.0f),
                new Food(FoodType.Vegetables, 1f, 0.500f)
            };

            p.BagOfStuff.Add(otherBag);

            // Percorrer itens na mochila e tentar "imprimir" cada um
            foreach (IStuff aThing in p.BagOfStuff)
            {
                Console.WriteLine($"\t=> {aThing}");
                if (aThing is Gun)
                    (aThing as Gun).Shoot();
            }
            Console.WriteLine($"O Total é: {p.BagOfStuff}");
            Console.WriteLine(p);
        }

    }
}
