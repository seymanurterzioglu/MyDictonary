using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int,string> uyeler= new MyDictonary<int, string>();

            uyeler.Add(10,"Seyma");
            uyeler.Add(13, "Salih");
            uyeler.Add(14, "Semih");
            uyeler.Add(17, "Suna");
            uyeler.Add(21, "Sena");
            uyeler.Add(25, "Selim");

            //Verileri dogru aktarabildigimizi kontrol icin;

            uyeler.Control(10);
            uyeler.Control(13);
            uyeler.Control(14);
            uyeler.Control(17);
            uyeler.Control(21);
            uyeler.Control(25);

        }
    }
}
