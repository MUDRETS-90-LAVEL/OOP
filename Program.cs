using System;


namespace ConsoleApp1
{
    class MyClass
    {
        //Закрытые поля
        private string name1;
        private string firsname1;

        //Открытый метод
        public void Show()
        {
            Console.WriteLine($"Очень приятно {name1} {firsname1}");
        }

        //Открытый конструктор
        public MyClass(string name, string firsname)
        {
            //Принимем параметры и скидываем их на закрытые поля в классе
            name1 = name;
            firsname1 = firsname;
        }
    }
    //Главный класс программы
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;

            Console.Title = "Давайте познакомимся";

            Console.Write("Введите ваше имя: ");
            a = Console.ReadLine();

            Console.Write("Ведите ваше фамилию: ");
            b = Console.ReadLine();

            //Передаем параметры в конструктор
            MyClass A = new MyClass(a,b);

            //Выполняем открытый метод из класса
            A.Show();
        }
    }
}
