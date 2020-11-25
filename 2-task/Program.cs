using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write the date where index starts from");

                Console.WriteLine("Write a month, from 1 to 12");
                int month = Convert.ToInt32(Console.ReadLine());
                while (month < 1 || month > 12)
                {
                    Console.WriteLine("Write a month, from 1 to 12");
                    month = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Write a day, from 1 to 30");
                int day = Convert.ToInt32(Console.ReadLine());
                while (day < 1 || day > 30)
                {
                    Console.WriteLine("Write a day, from 1 to 30");
                    day = Convert.ToInt32(Console.ReadLine());
                }

                string date = $"{nToString(day)}.{nToString(month)}";

                DateWork dateWork = new DateWork(day, month, date);

                Console.WriteLine($"Write day that will add to {date}");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dateWork[index]);
            }
            catch
            {
                Console.WriteLine("Value has to be an integer");
            }
        }
        static string nToString(int n)
        {
            if (n < 10)
                return $"0{n}";
            else
                return $"{n}";
        }
    }
    
    class DateWork
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public string DateFrom { get; set; }
        public DateWork(int day, int month, string date)
        {
            DateFrom = date;
            Day = day;
            Month = month;
        }
        public string this[int index]
        {
            get
            {
                
                int newMonth = (Day + index) / 30 + Month;
                int newDay = 0;
                int f = Day + index;
                if (f - 30 > 0)
                {
                    do
                    {
                        f -= 30;
                    }
                    while (f > 30);
                    newDay = f;
                }
                else
                {
                    newDay = Day + index;
                }
                
                return $"{nToString(newDay)}.{nToString(newMonth)}";
            }
        }

        private string nToString(int n)
        {
            if (n < 10)
                return $"0{n}";
            else
                return $"{n}";
        }
    }
}
