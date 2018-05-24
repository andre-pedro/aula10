using System;
using System.Collections.Generic;

namespace Aula10
{
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag : List<IStuff>, IStuff, IHasKarma
    {

        public float Karma
        {
            get
            {
                int itemsWithKarma = 0;
                float totalKarma = 0;
                foreach (IStuff aThing in this)
                {
                    if (aThing is IHasKarma)
                    {
                        itemsWithKarma++;
                        totalKarma += (aThing as IHasKarma).Karma;
                    }
                }
                return totalKarma / itemsWithKarma;
            }
        }


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
            return $"O nº de items {Count} com peso {Weight:f2} e o Preço {Value:c}";
        }

        /// <summary>Construtor que cria uma nova instância de mochila</summary>
        /// <param name="bagSize"> Número máximo de itens que é possível colocar na mochila</param>
        public Bag(int bagSize) : base(bagSize)
        {
        }

        public bool ContainsItemOfType<T>() where T : IStuff
        {
            foreach (IStuff cena in this)
            {
                if (cena is T)
                {
                    return true;
                }
            }
            return false;
        }
        public IEnumerable<T> GetItemsOfType<T>() where T : class, IStuff
        {
            List<T> items = new List<T>();
            foreach (IStuff cena in this)
            {
                if (cena is T)
                {
                    items.Add(cena as T);
                }
            }
            return items;
        }

        public IEnumerable<T> BetterGetItemsOfType<T>() where T : class, IStuff
        {
            foreach (IStuff cena in this)
            {
                if (cena is T)
                    yield return cena as T;
            }
        }


        //aula13

        public void GetHeavier1(out Food food, out Gun gun)
        {
            food = null; gun = null;
            foreach (IStuff stuff in this)
            {
                if (stuff is food)
                {
                    if ((food == null) || (stuff.Weight > food.Weight))
                    {
                        food = stuff as Food;
                    }

                    else if (stuff is Gun {
                        if ((gun == null) || (stuff.Weight > gun.Weight))
                            gun = stuff as Gun;
                    }

                }

                public FoodAndGun GetHeavier2()
                {
                    Food food = null;
                    Gun gun = null;


                    foreach (IStuff Stuff in this)
                    {
                        if (stuff is food)
                        {
                            if ((food == null) || (stuff.Weight > food.Weight))
                            {
                                food = stuff as Food;
                            }

                            else if (stuff is Gun {
                                if ((gun == null) || (stuff.Weight > gun.Weight))
                                    gun = stuff as Gun;
                            }

                        }
                    }

                    return new FoodAndGun(food, gun);

                }

                public Tuple<Food, Gun> GetHeavier3()
                {
                    Food food = null;
                    Gun gun = null;

                    foreach (IStuff stuff in this)
                    {
                        if (stuff is food)
                        {
                            if ((food == null) || (stuff.Weight > food.Weight))
                            {
                                food = stuff as Food;
                            }

                            else if (stuff is Gun {
                                if ((gun == null) || (stuff.Weight > gun.Weight))
                                    gun = stuff as Gun;
                            }

                        }

                    }

                }
            }
        }
    }
}

