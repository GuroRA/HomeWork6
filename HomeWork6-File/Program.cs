using System;
using System.Collections.Generic;

namespace HomeWork6_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Написать программу, содержащую решение следующих
                задач: Вы получили тему, по которой должны составить
                классы.
                Цель задания: Написать программу, в которой реализованы все принципы ООП. Для этого
                необходимо реализовать не менее 4 классов:
                    ● Один должен быть абстрактным
                    ● Должно быть не менее 2 наследников
                    ● Не менее 5 методов в каждом классе (необходимо показать свойство на чтение и на чтение-запись)
                    ● Не менее 4 свойств
                    ● Должно быть не менее 2 конструкторов в классах наследниках

                    В Main создать объекты классов, показать работу методов. В программе для ваших
                    объектов используйте какие-то данные, который необходимо читать с файла/введены с
                    клавиатуры/прописано в коде. Например, класс человек, создаете экземпляры для
                    человека, а имена, фамилии читаете с файла/вводите с клавиатуры/заранее прописано в
                    коде .
                    Необходимо быть готовым к тому, что каждый принцип нужно объяснять. Ваша программа
                    должна объяснять человеку то, о чем у вас тема и показать основные моменты вашей
                    темы, то, что считаете важным.
             */
            NationalReserve Taganai = new NationalReserve("Таганай", "Россия", 523.5, "Кулинский", 45000);
            Taganai.Describe();
            Taganai.GetMainInfo();

            List<string> ForestGangAnimals = new List<string>()
            { 
                "Белый Медведь", "Белка", "Сайгак"
            };
            List<string> ShulganTashAnimals = new List<string>()
            {
                "Серый волк", "Белка", "Пчёлы"
            };

            NatureReserve ForestGang = new NatureReserve("Лесная братва", 543, ForestGangAnimals);
            NatureReserve ShulganTash = new NatureReserve("Сшулган Таш", 3533, ShulganTashAnimals);

            ForestGang.Describe();
            ForestGang.GetMainInfo();
            Console.WriteLine();

            ShulganTash.GetMainInfo();
            ShulganTash.Describe();

            Console.ReadKey();
        }
    }
}