using System;
using System.Collections.Generic;

namespace Aula10
{
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag : List<IStuff>, IStuff
    {

        public float Value
        {
            get
            {
                float total = 0;
                foreach (IStuff thing in this)
                {
                        total += thing.Value;
                }
                return total;
            }
        }

        public float Weight
        {
            get
            {
                float total = 0;
                foreach (IStuff thing in this)
                {
                        total += thing.Weight;
                }
                return total;
            }
        }

        public override string ToString()
        {
            return $"O nº de items {Count} com peso {Weight} e o Preço {Value}";
        }

        /// <summary>Construtor que cria uma nova instância de mochila</summary>
        /// <param name="bagSize">Número máximo de itens que é possível colocar na mochila</param>
        public Bag(int bagSize) : base(bagSize)
        {
        }

        
    }
}
