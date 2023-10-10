using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

namespace Topic_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void house()
            {
                Console.WriteLine("     ':.");
                Console.WriteLine("         []_____");
                Console.WriteLine("        /\\      \\");
                Console.WriteLine("    ___/  \\__/\\__\\__");
                Console.WriteLine("---/\\___\\ |''''''|__\\-- ---");
                Console.WriteLine("   ||'''| |''||''|''|");
                Console.WriteLine("   ``\"\"\"`\"`\"\"))\"\"`\"\"`");
            }
            static void cow()
            {
                Console.WriteLine("                                       /;    ;\\");
                Console.WriteLine("                                   __  \\____//");
                Console.WriteLine("                                  /{_\\_/   `'\\____");
                Console.WriteLine("                                  \\___   (o)  (o  }");
                Console.WriteLine("       _____________________________/          :--'  ");
                Console.WriteLine("   ,-,'`@@@@@@@@       @@@@@@         \\_    `__\\");
                Console.WriteLine("  ;:(  @@@@@@@@@        @@@             \\___(o'o)\r\n");
                Console.WriteLine("  :: )  @@@@          @@@@@@        ,'@@(  `===='   ");
                Console.WriteLine("  :: : @@@@@:          @@@@         `@@@:");
                Console.WriteLine("  :: \\  @@@@@:       @@@@@@@)    (  '@@@'");
                Console.WriteLine("  ;; /\\      /`,    @@@@@@@@@\\   :@@@@@)");
                Console.WriteLine("  ::/  )    {_----------------:  :~`,~~;");
                Console.WriteLine(" ;;'`; :   )                  :  / `; ;");
                Console.WriteLine(";;;; : :   ;                  :  ;  ; :              ");
                Console.WriteLine("`'`' / :  :                   :  :  : :");
                Console.WriteLine("    )_ \\__;      \";\"          :_ ;  \\_\\       `,','");
                Console.WriteLine("    :__\\  \\    * `,'*         \\  \\  :  \\   *  8`;'*  *");
                Console.WriteLine("        `^'     \\ :/           `^'  `-^-'   \\v/ :  \\/ ");
            }
            static void flower()
            {
                Console.WriteLine("                _..");
                Console.WriteLine("       ;-._   .'   `\\");
                Console.WriteLine("     .'    `\\/       ;");
                Console.WriteLine("     |       `\\.---._|");
                Console.WriteLine("  .--;   . ( .'      '.");
                Console.WriteLine(" / _  \\_  './ _.       `-._");
                Console.WriteLine("( = \\  )`\"\"'\\;--.         /");
                Console.WriteLine("{= (|  )     /`.         /     .'|");
                Console.WriteLine("( =_/  )__..-\\         .'     / /");
                Console.WriteLine(" \\    }/    / ;.____.-;/\\   .` /");
                Console.WriteLine("  '--' |  .'   |       \\ \\  |  ;");
                Console.WriteLine("       \\  '    /       |. ;  \\/");
                Console.WriteLine("        )    .'`-.    / ; |  /\\");
                Console.WriteLine("       /__.-'   , \\_.'  | | ;  ;");
                Console.WriteLine("                |\\      |`| |  |");
                Console.WriteLine("                 \\`\\    | | |  |");
                Console.WriteLine("                  \\ `\\  | | ;  ;");
                Console.WriteLine("                   |  ; | | /  /");
                Console.WriteLine("                   |  | | |/  /");
                Console.WriteLine("                   ;  | | /  /");
                Console.WriteLine("                    \\  \\;/  /");
                Console.WriteLine("                     \\  \\  /");
                Console.WriteLine("                      \\  Y/");
                Console.WriteLine("                       |  |");
                Console.WriteLine("                       |  |");
                Console.WriteLine("                       |  |");
                Console.WriteLine("                       \\  |");
                Console.WriteLine("                        \\_/");
            }
            int loop = 0;
            while (loop == 0)
            {
                Console.WriteLine("Write what you want to see, house, cow or flower.");
                Console.WriteLine();
                String response1 = Console.ReadLine();
                if (response1 == "cow")
                {
                    cow();
                    loop++;
                }
                else if (response1 == "Cow")
                {
                    cow();
                    loop++;
                }
                else if (response1 == "house")
                {
                    house();
                    loop++;
                }
                else if (response1 == "House")
                {
                    house();
                    loop++;
                }
                else if (response1 == "flower")
                {
                    flower();
                    loop++;
                }
                else if (response1 == "Flower")
                {
                    flower();
                    loop++;
                }
                else
                {
                    Console.WriteLine("Try Again.");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                static void police()
                {
                    Console.WriteLine("            ,");
                    Console.WriteLine("     __  _.-\"` `'-.");
                    Console.WriteLine("    /||\'._ __{}_(");
                    Console.WriteLine("    ||||  |'--.__\\");
                    Console.WriteLine("    |  L.(   ^_\\^");
                    Console.WriteLine("    \\ .-' |   _ |");
                    Console.WriteLine("    | |   )\\___/");
                    Console.WriteLine("    |  \\-'`:._]");
                    Console.WriteLine("    \\__/;      '-.");
                    Console.WriteLine("     |  |o     __ \\");
                    Console.WriteLine("     \\  |o     )( |");
                    Console.WriteLine("      |  |o     \\/ \\");
                    Console.WriteLine();
                    Console.WriteLine("You're Under Arrest!");

                }
                static void door() 
                {
                    Console.WriteLine("      ______");
                    Console.WriteLine("   ,-' ;  ! `-.");
                    Console.WriteLine("  / :  !  :  . \\");
                    Console.WriteLine(" |_ ;   __:  ;  |");
                    Console.WriteLine(" )| .  :)(.  !  |");
                    Console.WriteLine(" |\"    (##)  _  |");
                    Console.WriteLine(" |  :  ;`'  (_) (");
                    Console.WriteLine(" |  :  :  .     |");
                    Console.WriteLine(" )_ !  ,  ;  ;  |");
                    Console.WriteLine(" || .  .  :  :  |");
                    Console.WriteLine(" |\" .  |  :  .  |");
                    Console.WriteLine(" |mt-2_;----.___|");
                }
                static void goat()
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Goat.");
                    Console.WriteLine();
                    Console.WriteLine("Goat who?");
                    Console.WriteLine();
                    Console.WriteLine("Goat to the door and find out.");
                    Console.WriteLine();
                }
                Console.WriteLine("Knock Knock...");
                Console.WriteLine("Press 'Enter' to answer the door.");
                door();
                Console.ReadLine();
                goat();
                Console.WriteLine("Press 'Enter' to open the door.");
                Console.ReadLine();
                police();
            }
        }
    }
}