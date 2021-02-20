using System;

namespace GotoRemover
{
    class Program
    {

        public static void printFor()
        {
            DoLoop();

            Console.WriteLine("Terminé");

        }

        private static void DoLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 50; j++)
                {

                    Console.WriteLine("Lol");
                    if (j == 3)
                    {
                        //goto endloop
                        return;
                    }
                }
            }
            //endloop:
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    //goto finish
                    break;
                }
                Console.WriteLine("i value : {0}", i);
            }

            //finish:
            Console.WriteLine("The end");

            printFor();
            Console.ReadLine();
        }
    }
}
