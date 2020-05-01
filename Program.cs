using System;
using System.Threading.Tasks;
using System.Threading;

namespace task
{
    class Program
    {
        static int GlobalLength = 21;
        static void Main(string[] args)
        {
            int[] arr = new int[]{6,23,26,7,14,2,4,30,19,5,21,8,9,22,10,11,0,1,13,12,15,24,25,20};
            Task[] tasks = new Task[24];
            for(int i = 0; i < 24; i++){
                tasks[i] = Task.Run(() => Stream(arr[i]));
                Thread.Sleep(1000);
            }
            tasks[0].Wait();
            Console.ReadKey();
            
        }
        static void Stream(int left){
            int limit = new Random().Next(3,7);
            int top = 0;
            int black = top;
            int topLim = (GlobalLength - 3)/limit;//страховка
            while(true){
                if(top >= limit * topLim ){
                    top = 0;
                }
                black = top;
                for (int i = 0; i < black; i++){
                    Console.CursorTop = i;
                    Console.CursorLeft = left;
                    System.Console.WriteLine(" ");
                }
                for(int i = 0; i < limit; i++){
                    if(i == (limit - 1))
                        Console.ForegroundColor = ConsoleColor.White;
                    else if(i == (limit - 2))
                        Console.ForegroundColor = ConsoleColor.Green;
                    else 
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.CursorTop = top++;
                    Console.CursorLeft = left;
                    switch(new Random().Next(0,35)){
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
                if(top == limit){
                    for (int i = top; i < GlobalLength; i++){
                        Console.CursorTop = i;
                        Console.CursorLeft = left;
                        System.Console.WriteLine(" ");
                    }
                }
                
                Thread.Sleep(10000);
                top = black + new Random().Next(1,limit);
            }
        }
    }
}
