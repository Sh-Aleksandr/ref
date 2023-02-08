// See https://aka.ms/new-console-template for more information

namespace Lesson

{
    /*
     * ключевое слово ref
     */
    /*
     * передача аргументов по ссылке
     */

    class Program
    {
        static void Foo(int a)
        {
            a = -5;
        }



        static void Main(string[] args)

        {
            int a = 2;
            Foo(a);

            Console.WriteLine(a);
        }

        // данные с метода Main скопируются в метод Foo 
        /*  class Program
          {
              static void Foo(ref int a, ref int b, ref int c, ref int d)
              {
                  a = -5;
              }



              static void Main(string[] args)

              {
                  int a = 2;
                  Foo(ref a);

                  Console.WriteLine(a);
            */

        // благодаря ключевому слову ref используя ЗНАЧИМЫЙ ТИП мы получили поведение как у ССЫЛОЧНЫХ ТИПОВ

    }
}






