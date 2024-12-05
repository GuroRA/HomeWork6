using System;

namespace HomeWork6_File
{
    class NationalReserve : Reserve
    {
        /// <summary>
        /// Юредическое лицо (государство, компания или владелец компании)
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// Цена туристического похода на территорию
        /// </summary>
        public int tourismCost;
        public int TourismCost
        {
            set
            {
                if (tourismCost < 0)
                {
                    tourismCost = 0;
                }
                else
                {
                    tourismCost = value;
                }
            }
        }

        public NationalReserve(string name, double landArea, string owner) : base(name, landArea)
        {
            Owner = owner;
        }

        public NationalReserve(string name, string geography, double landArea, string owner, int tourismCost) : base(name, geography, landArea)
        {
            Owner = owner;
            TourismCost = tourismCost;
        }

        /// <summary>
        /// Выводит особую информацию об объекте (Отличительные поля конкретно данного класса)
        /// </summary>
        public override void Describe()
        {
            Console.WriteLine($"Хозяин заповедника {Name} - {Owner}\nЦена туристического похода: {tourismCost}\n");
        }
    }
}
