using System;
using RPG.src.modules;


namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Founder founder = new Founder("Eren", 50, "Attack-Fundador");
            Armored armored = new Armored("Reiner", 30, "Armored Titan ");
            Colossal colossal = new Colossal("Berthold", 60, "colossal titan");
            femaleTitan female = new femaleTitan("Anie", 70, " Female Titan");

           
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {   
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine(founder);
                        Console.WriteLine(colossal);
                        Console.WriteLine(armored);
                        Console.WriteLine(female);
                        Console.WriteLine();
                        break;
                    
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine(founder.Attack());
                        Console.WriteLine(colossal.Attack());
                        Console.WriteLine(armored.Attack());
                        Console.WriteLine(female.Attack());
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine(founder.Attack(100));
                        Console.WriteLine(colossal.Attack(85));
                        Console.WriteLine(armored.Attack(85));
                        Console.WriteLine(female.Attack(89));
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine(founder.Hp());
                        Console.WriteLine(colossal.Hp());
                        Console.WriteLine(armored.Hp());
                        Console.WriteLine(female.Hp());
                        Console.WriteLine();
                        break;
                    
                    case "5":
                        Console.WriteLine(founder.Hp(50));
                        Console.WriteLine(colossal.Hp(60));
                        Console.WriteLine(armored.Hp(69));
                        Console.WriteLine(female.Hp(80));
                        Console.WriteLine();
                        break;
                    case "6":
                        Console.WriteLine(founder.Defender(50));
                        Console.WriteLine(colossal.Defender(60));
                        Console.WriteLine(armored.Defender(69));
                        Console.WriteLine(female.Defender(80));
                        Console.WriteLine();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException("Erro");

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
            

            //Console.WriteLine(founder.Defender());
            //Console.WriteLine(colossal.Defender(30));
            //Console.WriteLine(armored.Nivel());
            
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opcão desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Exibir personagens, level e seus titans");
            Console.WriteLine();
            Console.WriteLine("2 - Exibir ataque dos personagens");
            Console.WriteLine();
            Console.WriteLine("3 - Exibir ataque Bonus");
            Console.WriteLine();
            Console.WriteLine("4 - Exibir o HP dos personagens");
            Console.WriteLine();
            Console.WriteLine("5 - Exibir Hp depois de receber dano");
            Console.WriteLine();
            Console.WriteLine("6 - Exibir Defesa + dano de HP");
            Console.WriteLine("x para sair!");
            Console.WriteLine();
                
            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }   
    }
}

