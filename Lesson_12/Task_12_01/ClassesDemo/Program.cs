using ClassesDemo.Publications;

namespace ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

            Journal journal1 = new Journal
            {
                PublicationDate = "01.10.2023",
                Subject = "Научные исследования",
                Title = "Наука и жизнь",
                PageCount = 50,
                Price = 300
            };
            journal1.Purchase();
            journal1.ViewContent();

            Newspaper newspaper1 = new Newspaper 
            {
                PublicationDate = "10.03.2025",
                Title = "Комсомольская правда",
                Headline = "Новые открытия в медицине",
                PageCount = 20,
                Price = 50
            };
            newspaper1.Purchase();
            newspaper1.ViewHeadline();

        }
    }
}
