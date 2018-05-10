using System;
using System.Collections.Generic;

namespace Aula10
{
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag : IStuff
    {
        /// <summary>Array que contém os itens da mochila</summary>
        private List<IStuff> stuff;

        /// <summary>Número de itens na mochila</summary>
        public int StuffCount { get { return stuff.Count; } }

        public float Value
        {
            get
            {
                float total = 0;
                foreach (IStuff thing in stuff)
                {
                    if (thing != null)
                    {
                        total += thing.Value;
                    }
                }
                return total;
            }
        }

        public float Weight
        {
            get
            {
                float total = 0;
                foreach (IStuff thing in stuff)
                {
                    if (thing != null)
                    {
                        total += thing.Weight;
                    }
                }
                return total;
            }
        }

        public override string ToString()
        {
            return $"O nº de items {StuffCount} com peso {Weight} e o Preço {Value}";
        }

        /// <summary>Construtor que cria uma nova instância de mochila</summary>
        /// <param name="bagSize">Número máximo de itens que é possível colocar na mochila</param>
        public Bag(int bagSize)
        {
            stuff = new List<IStuff>(bagSize);
        }

        /// <summary>Colocar um item na mochila</summary>
        /// <param name="aThing">Item a colocar na mochila</param>
        public void AddThing(IStuff aThing)
        {
            // Adicionar o item à mochila e depois incrementar o
            // número de coisas na mochila
            stuff.Add(aThing);
        }

        /// <summary>Observar um item da mochila sem o remover da mesma</summary>
        /// <param name="index">Local onde está o item a observar</param>
        /// <returns>Item a ser observado</returns>
        public IStuff GetThing(int index)
        {
            if (index >= StuffCount)
            {
                // Senão existir um item no local indicado, "lançar" uma exceção
                throw new InvalidOperationException("Bag doesn't have that much stuff!");
            }
            return stuff[index];
        }
    }
}
