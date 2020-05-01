using System;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 200, Stream);
        }
        static void Stream(int x){            
            Random random = new Random();
            int limit = random.Next(3, 9);
            int top = random.Next(1, 10);
            int left = random.Next(1, 50);
            Console.CursorTop = top;
            Console.CursorLeft = left;
            
            for(int i = 3; i < limit; i++){
                if(i == 3)
                    Console.ForegroundColor = ConsoleColor.White;
                else if(i == 4)
                    Console.ForegroundColor = ConsoleColor.Gray;
                else if(i == 5)
                    Console.ForegroundColor = ConsoleColor.Green;
                else 
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                x = random.Next(0, 35);
                switch(x){
                    case 0: System.Console.WriteLine("A");break;
                    case 1: System.Console.WriteLine("B");break;
                    case 2: System.Console.WriteLine("C");break;
                    case 3: System.Console.WriteLine("D");break;
                    case 4: System.Console.WriteLine("E");break;
                    case 5: System.Console.WriteLine("F");break;
                    case 6: System.Console.WriteLine("G");break;
                    case 7: System.Console.WriteLine("H");break;
                    case 8: System.Console.WriteLine("I");break;
                    case 9: System.Console.WriteLine("J");break;
                    case 10: System.Console.WriteLine("K");break;
                    case 11: System.Console.WriteLine("L");break;
                    case 12: System.Console.WriteLine("M");break;
                    case 13: System.Console.WriteLine("N");break;
                    case 14: System.Console.WriteLine("O");break;
                    case 15: System.Console.WriteLine("P");break;
                    case 16: System.Console.WriteLine("Q");break;
                    case 17: System.Console.WriteLine("R");break;
                    case 18: System.Console.WriteLine("S");break;
                    case 19: System.Console.WriteLine("T");break;
                    case 20: System.Console.WriteLine("U");break;
                    case 21: System.Console.WriteLine("V");break;
                    case 22: System.Console.WriteLine("W");break;
                    case 23: System.Console.WriteLine("X");break;
                    case 24: System.Console.WriteLine("Y");break;
                    case 25: System.Console.WriteLine("Z");break;
                    case 26: System.Console.WriteLine("0");break;
                    case 27: System.Console.WriteLine("1");break;
                    case 28: System.Console.WriteLine("2");break;
                    case 29: System.Console.WriteLine("3");break;
                    case 30: System.Console.WriteLine("4");break;
                    case 31: System.Console.WriteLine("5");break;
                    case 32: System.Console.WriteLine("6");break;
                    case 33: System.Console.WriteLine("7");break;
                    case 34: System.Console.WriteLine("8");break;
                    case 35: System.Console.WriteLine("9");break;
                }
            }
            
        }
    }
}
