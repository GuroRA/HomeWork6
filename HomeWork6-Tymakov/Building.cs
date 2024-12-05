using System;


namespace HomeWork6_Tymakov
{
    internal class Building
    {
        private static uint buildingIdCounter = 1;
        private readonly uint buildingId;
        private ushort buildingHeight;
        private ushort floorCount;
        private ushort apartmentCount;
        private byte enteranceCount;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buildingHeight"></param>
        /// <param name="floorCount"></param>
        /// <param name="apartmentCount"></param>
        /// <param name="enteranceCount"></param>
        public Building(ushort buildingHeight, ushort floorCount, ushort apartmentCount, byte enteranceCount)
        {
            buildingId = SetCurrentId();
            this.buildingHeight = (ushort)(buildingHeight > 0 ? buildingHeight : 1);
            this.floorCount = (ushort)(floorCount > 0 ? floorCount : 1);
            this.apartmentCount = (ushort)(apartmentCount > 0 ? apartmentCount : 1); 
            this.enteranceCount = (byte)(enteranceCount > 0 ? enteranceCount : 1); 
        }

        private static uint SetCurrentId()
        {
            return buildingIdCounter++;
        }

        public void GetFloorHeight()
        {
            Console.WriteLine($"Высота этажа: {buildingHeight / floorCount}м");
        }

        public void GetApartmentCountInEnterance()
        {
            Console.WriteLine($"Кол-во квартир в подъезде {apartmentCount/enteranceCount}");
        }

        public void GetApartmentCountInFloor()
        {
            Console.WriteLine($"Кол-во квартир на этаже {apartmentCount / (enteranceCount * floorCount)}");
        }

        public void GetBuildingInformation()
        {
            Console.WriteLine($"ID: {string.Format("{0:D4}", buildingId)}\nВысота здания: {buildingHeight}м\nКол-во этажей: {floorCount}\nКол-во квартир: {apartmentCount}\nКол-во Подъездов: {enteranceCount}\n");
        }
    }
}
