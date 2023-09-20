using System;
namespace Ficha{
    class Program{

        public static void Main(string[] args){
            James james = new James();
            int opcao;
 
            while(!james.morreu){
                Console.Clear();
                Console.WriteLine($"\n          vida: {james.vida}    mana: {james.mana}    Nível atual: {james.nivelAtual}    Nível máximo liberado: {james.nivelLiberado}          ");
                Console.WriteLine("\n          1 - Conjurar poder         ");
                Console.WriteLine("          2 - Levar dano          ");
                Console.WriteLine("\n          3 - Outros          ");
                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (FormatException){
                    Console.WriteLine("Opção inválida! Por favor, digite um número de 1, 2 ou 3.");
                    Console.ReadLine();
                    continue;
                }           
                switch(opcao){
                    case 1: james.Conjurar(); break;
                    case 2: james.Dano(); break;
                    case 3: Outros(james); break;
                }                  
            }
            Console.Clear();
            Console.WriteLine($"\n          vida: {james.vida}    mana: {james.mana}    Nível atual: {james.nivelAtual}    Nível máximo liberado: {james.nivelLiberado}          ");
            Console.WriteLine("\n          A História do seu personagem chegou ao fim.");
            Console.ReadLine();
        }

        public static void Outros(James james){
            Console.Clear();
            int outros;
            Console.WriteLine($"\n          vida: {james.vida}    mana: {james.mana}    Nível atual: {james.nivelAtual}    Nível máximo liberado: {james.nivelLiberado}          ");
            Console.WriteLine("\n          1 - Upar nível          ");
            Console.WriteLine("          2 - Diminuir nível           ");
            Console.WriteLine("          3 - Curar vida         ");
            Console.WriteLine("          4 - Restaurar mana          ");
            Console.WriteLine("          5 - Drenar mana          ");

            while (!james.morreu){
                try{
                    outros = int.Parse(Console.ReadLine());

                    switch (outros){
                        case 1: 
                            james.nivelLiberado++; 
                            break;
                        case 2: 
                            james.nivelLiberado--; 
                            break;
                        case 3: 
                            james.Cura(); 
                            break;
                        case 4: 
                            james.MaisMana(); 
                            break;
                        case 5: 
                            james.MenosMana(); 
                            break;
                    }

                    break; // Sai do loop quando a opção é válida
                }
                catch (FormatException){
                    Console.WriteLine("Opção inválida! Por favor, insira o número da opção '1, 2, 3, 4 ou 5'.");
                }
            }
        }
    }
}
