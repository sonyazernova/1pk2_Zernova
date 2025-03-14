using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    internal class Journal
    {
        public string PublicationDate {get;set;}
        public string Subject {get;set;}
        public string Title {get;set;}
        public int PageCount {get;set;}
        public decimal Price {get;set;}
        public bool isBought {get;set;}
        
        public void Purchase()
        {
            if(isBought)
            {
                Console.WriteLine("журнал уже куплен");
            }
            else
            {
                isBought=true;
                Console.WriteLine($"журнал {Title} куплен за {Price} рублей");
            }
        }
        public void ViewContent()
        {
            Console.WriteLine($"содержание журнала {Title}: {Subject}");
        }


    }
}
