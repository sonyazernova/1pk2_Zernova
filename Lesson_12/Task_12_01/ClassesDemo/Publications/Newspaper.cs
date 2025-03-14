using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    internal class Newspaper
    {
        public string PublicationDate {get;set;}
        public string Title {get;set;}
        public int PageCount {get;set;}
        public decimal Price {get;set;}
        public bool isBought {get;set;}
        public string Headline {get;set;}
        public void Purchase()
        {
            if(isBought)
            {
                Console.WriteLine(" газета уже куплена ");
            }
            else
            {
                isBought=true;
                Console.WriteLine($"газета {Title} куплена за {Price} рублей");
            }
        }
        public void ViewHeadline()
        {
            Console.WriteLine($" заголовок главной полосы газеты {Title}: {Headline}");
        }
        

    }
}
