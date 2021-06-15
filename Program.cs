using System;

namespace tower_of_hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            char t1, t2, t3;
            Console.WriteLine("Combien de disques ?");
            numb = int.Parse(Console.ReadLine());
            if (numb >= 3)
            {
                t1 = 'a';
                t3 = 'c';
                t2 = 'b';
                solveIt(numb, t1, t3, t2);
            }
            else
            {
                Console.WriteLine("Nombre de disques insuffisants !!!");
            }

        }
        public static void solveIt(int numberD, char startTw, char endTw, char tempTw)
        {
            if (numberD > 0){
                solveIt(numberD - 1, startTw, tempTw, endTw);
                Console.WriteLine("Mettre le disque de la tour " + startTw + " à la tour " + endTw);
                solveIt(numberD - 1, tempTw, endTw, startTw);
            }
        }
    }
}
