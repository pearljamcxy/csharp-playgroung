using System;
using System.Collections.Generic;

namespace SlimeGauntlet{
    class Program{
        enum PlayerState {Idle, Attacking} //状态
        static int[] enermyHP = new int[] {10, 20, 30 ,15}; 
        static List<int> bag = new List<int>() {10}; //药水回复量
        static Random fightBack= new Random();

        static void Main(){
            Console.WriteLine("welcome to the SlimeGauntlet");
            bool PlayAgain;
            //do...while 的好处：先执行一次循环体（即 { ... } 里的内容），
            // 再判断条件是否成立决定是否继续下一次循环。
            do{
                RunGame();
                PlayAgain = AskYesNO("Play Again?");
            }while(PlayAgain);
            Console.WriteLine("thany you for joining");
        }

         static void RunGame(){






         }   


        static bool AskYesNO(string prompt){
            Console.WriteLine(prompt);
            



        }







        }










    }













}
