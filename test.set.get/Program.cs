
using System;

namespace test.set.get
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Hotel hotel2 = new Hotel(1,"single",9.44,true);
        }
    }
    class Hotel
    {
        public const string HotelName = "Grand Stay Hotel";
        private int RoomNumber;
        public int _roomnumber { get; set; }
        public string RoomType;
        public double PricePerNight;
        public bool isBooked;


        public Hotel() {
            RoomNumber = 1;
            RoomType = HotelName;
        }

        public Hotel(int x , string y,double z , bool a)
        {
            x=RoomNumber;
            y=RoomType;
            z=PricePerNight;
            a=isBooked;
        }


        ~Hotel() { Console.WriteLine("clear all **************************"); }

    }
}
