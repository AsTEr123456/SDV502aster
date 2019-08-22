using System;

namespace Cinema
{
    /// <summary>
    /// Cineam ticket purchasing tests 
    /// </summary>
    public class CinemaDetails
    {
        public double adult_before_5_price { get; set; }
        public double adult_after_5_price { get; set; }

        public double adult_tuesday_price { get; set;}

        public double child_price { get; set;}

        public double senior_price { get; set; }

        public double student_price { get; set; }

        public double family_price { get; set; }

        public double chick_flick_thursdays_price { get; set; }

        public double kids_and_carers_price { get; set; }

        public int Quantity = 0;
        public string Person = "";
        public string Day = "";
        public int Time = 0;

        public double total_price;

        public CinemaDetails(int prQuantity, string prPerson, string prDay, int prTime)
        {
            Quantity = prQuantity;
            Person = prPerson;
            Day = prDay;
            Time = prTime; 
        }

        public CinemaDetails()
        {
        }

        public double Adult_before_5pm(int quantity, string person, string day, int time)
        {

            adult_before_5_price = 14.5;
            return total_price = adult_before_5_price * quantity;
        }

        public double Adult_after_5pm(int quantity, string person, string day, int time)
        {

            adult_after_5_price = 17.5;
            return total_price = adult_after_5_price * quantity;
        }

        public double Adult_tuesday(int quantity, string person, string day)
        {
            adult_tuesday_price = 13;
            return total_price = adult_tuesday_price * quantity;

        }

        public double Child_price(int quantity, string person)
        {
            child_price = 12;
            return total_price = child_price * quantity;
        
        }

        public double Senior_price(int quantity, string person)
        {
            senior_price = 12.50;
            return total_price = senior_price * quantity;
        }

        public double Student_price(int quantity, string person)
        {
            student_price = 14;
            return total_price = student_price * quantity;
        }

        public double Family_price(int quantity, string person)
        {
            family_price = 46;
            return total_price = family_price * quantity;
        }

        public double Chick_flick_thursdays_price(int quantity, string person, string day)
        {
            chick_flick_thursdays_price = 21.5;
            return total_price = chick_flick_thursdays_price * quantity;
        }

        public double Kids_and_carers_price(int quantity, string person, string day)
        {
            kids_and_carers_price = 12;
            return total_price = kids_and_carers_price * quantity;
        }

        public static void Main()
        {
             //Adult_before_5pm test

            CinemaDetails tp = new CinemaDetails(3,"asd","monday",0400);

            double result = tp.Adult_before_5pm(tp.Quantity, tp.Person, tp.Day, tp.Time);

            Console.WriteLine("total price for all ticks: $" + result);

    
        }

    }
}