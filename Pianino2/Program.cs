namespace petruska
{
    internal class Practic3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирете аккорд клавишими f1..f7");
            Console.WriteLine("Чтобы выйти из программы нажмите Enter");
            int[] array = new int[12];
            bool l = true;
            while (l)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2 || key.Key == ConsoleKey.F3 || key.Key == ConsoleKey.F4 || key.Key == ConsoleKey.F5 || key.Key == ConsoleKey.F6 || key.Key == ConsoleKey.F7)
                {
                    array = Octavs(key);
                }
                if ((key.Key == ConsoleKey.A) || (key.Key == ConsoleKey.W) || (key.Key == ConsoleKey.S) || (key.Key == ConsoleKey.E) || (key.Key == ConsoleKey.D) || (key.Key == ConsoleKey.F) || (key.Key == ConsoleKey.T) || (key.Key == ConsoleKey.G) || (key.Key == ConsoleKey.Y) || (key.Key == ConsoleKey.H) || (key.Key == ConsoleKey.U) || (key.Key == ConsoleKey.J))
                {
                    Soundpad(key, array);
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    l = false;
                }
            }
        }


        static void Soundpad(ConsoleKeyInfo r, int[] h) 
        {


             if (r.Key == ConsoleKey.A) Console.Beep(h[0], 200);
             if (r.Key == ConsoleKey.W) Console.Beep(h[1], 200);
             if (r.Key == ConsoleKey.S) Console.Beep(h[2], 200);
             if (r.Key == ConsoleKey.E) Console.Beep(h[3], 200);
             if (r.Key == ConsoleKey.D) Console.Beep(h[4], 200);
             if (r.Key == ConsoleKey.F) Console.Beep(h[5], 200);
             if (r.Key == ConsoleKey.T) Console.Beep(h[6], 200);
             if (r.Key == ConsoleKey.G) Console.Beep(h[7], 200);
             if (r.Key == ConsoleKey.Y) Console.Beep(h[8], 200);
             if (r.Key == ConsoleKey.H) Console.Beep(h[9], 200);
             if (r.Key == ConsoleKey.U) Console.Beep(h[10], 200);
             if (r.Key == ConsoleKey.J) Console.Beep(h[11], 200);


        }
        static int[] Octavs(ConsoleKeyInfo kall)
        {
            int[] frangue1 = new int[12] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 116, 123 };
            int[] frangue2 = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 246 };
            int[] frangue3 = new int[12] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            int[] frangue4 = new int[12] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            int[] frangue5 = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] frangue6 = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] frangue7 = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

            if (kall.Key == ConsoleKey.F1)
            {
                Console.WriteLine(" 1 Октава ");
                return frangue1;
            }
             if (kall.Key == ConsoleKey.F2)
            {
                Console.WriteLine(" 2 Октава ");
                return frangue2;
            }
             if (kall.Key == ConsoleKey.F3)
            {
                Console.WriteLine(" 3 Октава ");
                return frangue3;
            }
             if (kall.Key == ConsoleKey.F4)
            {
                Console.WriteLine(" 4 Октава ");
                return frangue4;
            }
             if (kall.Key == ConsoleKey.F5)
            {
                Console.WriteLine(" 5 Октава ");
                return frangue5;
            }
             if (kall.Key == ConsoleKey.F6)
            {
                Console.WriteLine(" 6 Октава ");
                return frangue6;
            }
             if (kall.Key == ConsoleKey.F7)
            {
                Console.WriteLine(" 7 Октава ");
                return frangue7;
            }
            return frangue7;


        }
        static void Undrtale_song()
        {
            // d d d a g# g f d f g
           // c# c# c# g# g f# e c# e f#

        }
    }
}