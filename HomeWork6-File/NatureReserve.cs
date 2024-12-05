using System;
using System.Collections.Generic;
using System.Linq;


namespace HomeWork6_File
{
    class NatureReserve : Reserve
    {
        private readonly int pentalty = 5000;

        private List<string> RedAnimals = new List<string>()
        {
            "Белый Медведь", "Сайгак"
        };

        /// <summary>
        /// Список животных в заповеднике
        /// </summary>
        private List<string> Animals { get; set; }

        /// <summary>
        /// Возвращает список животных в зоопарке, находящихся в красной книге
        /// </summary>
        /// <returns></returns>
        public List<string> GetRedAnimals()
        {
            return Animals.Where(animal => RedAnimals.Contains(animal)).ToList();
        }

        public override void Describe()
        {

            Console.Write($"Штраф за нахождение на территории {pentalty}\nЖивотные в заповеднике: ");
            foreach (var animal in Animals)
            {
                Console.Write($"{animal}, ");
            }

            List<string> ReserveRedAnimals = GetRedAnimals();

            if (ReserveRedAnimals.Count == 0)
            {
                Console.WriteLine("\nВ заповеднике нет животных занесённых в красную книгу\n");
            }
            else
            {
                Console.Write($"\nЖивотные красной книги в заповеднике: ");
                foreach (var redAnimal in ReserveRedAnimals)
                {
                    Console.Write($"{redAnimal}, ");
                }
            }
        }
        public NatureReserve(string name, string geography, double landArea, List<string> animals, List<string> redAnimals) : base(name, geography, landArea)
        {
            RedAnimals = redAnimals;
            Animals = animals;
        }

        public NatureReserve(string name, double landArea, List<string> animals) : base(name, landArea)
        {
            Animals = animals;
        }
    }
}
