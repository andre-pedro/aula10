﻿namespace Aula10
{
    /// <summary>Esta classe representa um jogador num jogo</summary>
    public class Player : IHasWeight, IHasKarma
    {

        /// <summary>Máximo de items na mochila (variável de classe, constante, implicitamente static)</summary>
        private const int maxBagItems = 5;

        /// <summary>Peso base do jogador (variável de instância, read-only) </summary>
        private readonly float baseWeight;

        /// <summary>Mochila de itens do jogador (variável de instância)</summary>
        public Bag BagOfStuff { get; }

        public float Karma
        {
            get
            {
                return BagOfStuff.Karma;
            }
        }

        /// <summary> Propriedade Weight respeita o contrato com IHasWeight </summary>
        public float Weight
        {
            get
            {
                // Seria porreiro adicionar o peso de todas as coisas no saco
                return baseWeight + BagOfStuff.Weight;
            }
        }


        public override string ToString()
        {
            return $" O Peso total é {Weight};" +
                $" o nº de items é {BagOfStuff.Count}," +
                $" a porcentagem que corresponde à mochila é {(BagOfStuff.Weight / Weight):p2} (Karma={Karma}).";
        }
        /// <summary>Construtor, cria nova instância de jogador</summary>
        /// <param name="baseWeight">Peso base do jogador</param>
        public Player(float baseWeight)
        {
            this.baseWeight = baseWeight;
            BagOfStuff = new Bag(maxBagItems);
        }
    }
}
