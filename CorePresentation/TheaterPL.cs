using System;
using System.Collections.Generic;
using System.Text;
using CoreData;
using CoreEntity;

namespace CorePresentation
{
    public  class TheaterPL
    {
        public void Tickets()
        {
            Console.WriteLine("Againnnnnn........");
            Console.WriteLine("enter 1 to bookseats");
            Console.WriteLine("enter 2 to delete");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                AddTheater();
            }
            else if (x == 2)
            {
                RemoveTheater();
            }
        }
        public void AddTheater()
        {
            TheaterDAL theateroperations = new TheaterDAL();
            Theater theater = new Theater();
            Console.Write("Enter  theater  name:");
            theater.Name = Console.ReadLine();
            Console.WriteLine("Enter theater Address:");
            theater.address = Console.ReadLine();
            Console.WriteLine("Enter comments:");
            theater.comments = Console.ReadLine();
            string msg = theateroperations.AddTheater(theater);
            Console.WriteLine(msg);
            Tickets();

        }
        public void RemoveTheater()
        {

        }
        

    }
}
