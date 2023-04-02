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

           public class Taxi : Transport
            {
                private int MaxSpeed;

                public Taxi(int Gov_number, int Year_ofcar, int Num_seats, double Price_ofTicket, int Km_count, bool Is_new, int max_speed)
                    : base(Gov_number, Year_ofcar, Num_seats, Price_ofTicket, Km_count, Is_new)
                {
                    MaxSpeed = max_speed;
                    Numseats = Math.Min(4, Num_seats); 
                }

                public override string ToString()
                {
                    return $"Taxi: Govnumber = {Govnumber}, Yearofcar = {Yearofcar}, Numseats = {Numseats}, PriceofTicket = {PriceofTicket}, Kmcount = {Kmcount}, IsNew = {IsNew}, MaxSpeed = {MaxSpeed}";
                }

                public double CalculateTicketPrice(double distance)
                {
                    return distance * PriceofTicket / Numseats;
                }
            }

            public class Bus : Transport
            {
                private bool HasAirConditioner;
                
                public Bus(int Gov_number, int Year_ofcar, int Num_seats, double Price_ofTicket, int Km_count, bool Is_new, bool has_air_conditioner)
                    : base(Gov_number, Year_ofcar, Num_seats, Price_ofTicket, Km_count, Is_new)
                {
                    HasAirConditioner = has_air_conditioner;
                }
                public override string ToString()
                {
                    return $"Bus: Govnumber = {Govnumber}, Yearofcar = {Yearofcar}, Numseats = {Numseats}, PriceofTicket = {PriceofTicket}, Kmcount = {Kmcount}, IsNew = {IsNew}, HasAirConditioner = {HasAirConditioner}";
                }

                public double CalculateTicketPrice(double distance)
                {
                    return distance * PriceofTicket / (Numseats / 2);
                }
            }