using System;

namespace week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd
            //progrramm palub kasutajal teha valikut
            //programm kuvab kasutaja valikut konsooli


            Console.WriteLine("");
            string[] food = { "omlett", "pannkoogid", "keedumuna","neljaviljapuder", "singivõileib" };



            Console.WriteLine("Menüüs: ");

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }


            Console.WriteLine("vali toit (Sisesta number 1 - 4");
            int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Oled valinud {food[userchoice]}");

        }
    }
}
