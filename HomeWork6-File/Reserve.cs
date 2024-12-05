using System;

namespace HomeWork6_File
{
    abstract class Reserve
    {
        public string Name { get; set; }
     
        /// <summary>
        /// Местомоложение заповедника (страна, область, и т.д)
        /// </summary>
        public string Geography { get; set; }

        /// <summary>
        /// Площадь территории
        /// </summary>
        public double landArea;
        public double LandArea
        {
            get { return landArea; }
            set
            {
                if (landArea < 0)
                {
                    landArea = 0;
                }
                else
                {
                    landArea = value;
                }
            }
        }

        public abstract void Describe();
        public void GetMainInfo()
        {
            Console.WriteLine($"Заповедник: {Name}\nРасположение: {Geography}\nПлощадь: {landArea} км2");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="geography"></param>
        /// <param name="landArea"></param>
        protected Reserve(string name, string geography, double landArea)
        {
            Name = name;
            Geography = geography;
            LandArea = landArea;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="landArea"></param>
        protected Reserve(string name, double landArea)
        {
            Name = name;
            LandArea = landArea;
        }

    }
}
