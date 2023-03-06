using System;

namespace ConsoleApp1
{
    class Program
    {

        public class Transport
        {
            private int Govnumber;
            private int Yearofcar;
            public int Numseats;
            public double PriceofTicket;
            public int Kmcount;
            public bool IsNew;


            public Transport(int Gov_number, int Year_ofcar, int Num_seats, double Price_ofTicket, int Km_count, bool Is_new)
            {
                Govnumber = Gov_number;
                Yearofcar = Year_ofcar;
                Numseats = Num_seats;
                PriceofTicket = Price_ofTicket;
                Kmcount = Km_count;
                IsNew = Is_new;
        }
        public void RegisterNewTransport()
            {
                Console.WriteLine("Введіть реєстраційний номер авто: ");
                Govnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть рік випуска транспорта: ");
                Yearofcar = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть кількість сидінь: ");
                Numseats = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть вартість квитка: ");
                PriceofTicket = double.Parse(Console.ReadLine());

                Console.WriteLine("Введіть пробіг авто: ");
                Kmcount = int.Parse(Console.ReadLine());
            }

        public override string ToString()
            {
                return $"Transport: Govnumber = {Govnumber}, Yearofcar = {Yearofcar}, Numseats = {Numseats}, PriceofTicket = {PriceofTicket}, Kmcount = {Kmcount}, IsNew = {IsNew}";
            }

            public void UpdateKmcount(int km)
            {
                Kmcount += km;

                if (Kmcount >= 10000 && Kmcount <= 15000)
                {
                    IsNew = false;
                }
            }

            public double GetTicketPrice()
            {
                if (IsNew)
                {
                    return PriceofTicket;
                }
                else
                {
                    return PriceofTicket * 1.1;
                }
           