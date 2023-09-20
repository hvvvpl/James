namespace Ficha{
    public class James{

        public int vida, vidaTemp, mana, nivelAtual, nivelLiberado;
        public bool transformado, morreu;

        public James(){
            vida = 250;
            mana = 120;
            vidaTemp = vida;
            nivelAtual = 0;
            nivelLiberado = 1;
            transformado = false;
            morreu = false;
        }
        public void Conjurar(){
            int transformar = 0, conjuracao = 0;
            Console.Clear();
            Console.WriteLine($"\n          vida: {vida}    mana: {mana}    Nível atual: {nivelAtual}    Nível: {nivelLiberado}          ");
            Console.WriteLine("\n          1 - Me transformar\n          2 - Transformar seres vivos e objetos          ");
            
            transformar = int.Parse(Console.ReadLine());
            
                if (transformado && transformar == 1){
                Console.Clear();
                Console.WriteLine("          você já está transformado\n          Enter para continuar:\n\n\n"); 
                Console.ReadLine();
                return;
                }
            
            Console.Clear();
            Console.WriteLine($"\n          vida: {vida}    mana: {mana}    Nível atual: {nivelAtual}    Nível: {nivelLiberado}          ");
            Console.WriteLine("\n          Níveis de Metamorfose habilitados:          ");            
            if (transformar == 1)
            {
                if (nivelLiberado == 1)
                {
                    if(vida >= 15){
                        Console.WriteLine("\n          Nível 1 - animais e objetos pequenos");
                        Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                    }
                    else{
                        Console.WriteLine($"\n          vida: {vida}    mana: {mana}    Nível atual: {nivelAtual}    Nível: {nivelLiberado}          ");
                        Console.Clear();
                        Console.WriteLine("          Você precisa de 15 ou mais de vida para se transformar");
                        Console.WriteLine("          Enter para continuar");
                        Console.ReadLine();
                        return;
                    }
                }
                else if (nivelLiberado == 2)
                {
                    if(vida >= 15){
                        Console.WriteLine("\n          Nível 1 - animais e objetos pequenos\n          Nível 2 - animais e objetos médios");
                        Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                    }
                    else{
                        Console.WriteLine("Você precisa de 15 ou mais de vida para se transformar");
                        Console.WriteLine("Enter para continuar");
                        Console.ReadLine();
                        return;
                    }
                }
                else if (nivelLiberado == 3)
                {
                    if(vida >= 15){
                        Console.WriteLine("\n          Nível 1 - animais e objetos pequenos\n          Nível 2 - animais e objetos médios\n          Nível 3 - animais e objetos grandes");
                        Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                    }
                    else{
                        Console.WriteLine("Você precisa de 15 ou mais de vida para se transformar");
                        Console.WriteLine("Enter para continuar");
                        Console.ReadLine();
                        return;
                    }
                }
                else if (nivelLiberado == 4)
                {
                    Console.WriteLine("\n          Nível 1 - animais e objetos pequenos\n          Nível 2 - animais e objetos médios\n          Nível 3 - animais e objetos grandes\n          Nível 4 - transformar partes do corpo");
                    Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                }
            }
            else if (transformar == 2)
            {
                if (nivelLiberado == 1)
                {
                    Console.WriteLine("          Transformar seres vivos e objetos\n          Nível 1 - animais e objetos pequenos");
                    Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                }
                else if (nivelLiberado == 2)
                {
                    Console.WriteLine("          Transformar seres vivos e objetos\n          Nível 1 - animais e objetos pequenos\n          Nível 2 - animais e objetos médios");
                    Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                }
                else if (nivelLiberado == 3)
                {
                    Console.WriteLine("          Transformar seres vivos e objetos\n          Nível 1 - animais e objetos pequenos\n          Nível 2 - animais e objetos médios\n          Nível 3 - animais e objetos grandes");
                    Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                }
                else if (nivelLiberado == 4)
                {
                    Console.WriteLine("          Transformar seres vivos e objetos\n          Nível 1 - animais e objetos pequenos\n          Nível 2 - animais e objetos médios\n          Nível 3 - animais e objetos grandes\n          Nível 4 - transformar partes do corpo");
                    Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                }
                if (nivelLiberado == 5)
                {
                    Console.WriteLine("          Transformar seres vivos e objetos\n          Nível 1 - animais e objetos pequenos\n          Nível 2 - animais e objetos médios\n          Nível 3 - animais e objetos grandes\n          Nível 4 - transformar partes do corpo\n          Nível 5 - transformar ao toque em qualquer animail e objeto");
                    Console.WriteLine("\n\n          Digite o nível de transformação desejada:  ");
                }
            }
            conjuracao = int.Parse(Console.ReadLine());
            
                if (conjuracao > nivelLiberado){
                    conjuracao = 0;
                    transformar = 0;
                    Console.WriteLine("     X     Nível ainda bloqueado      X    ");
                    return;
                }
                if(transformar == 1 && (conjuracao == 1 || conjuracao == 2 || conjuracao == 3)){
                    transformado = true;
                    vidaTemp = vida;
                }
                if(conjuracao == 1){
                    if(transformar == 1){
                        vida = (int)(vidaTemp * 0.70f); 
                        nivelAtual = 1;
                    }
                    mana -= 5;
                }
                else if(conjuracao == 2){
                    if(transformar == 1){
                        vida = (int)(vidaTemp * 0.90f); 
                        nivelAtual = 2;
                    }
                    mana -= 10;
                }
                else if(conjuracao == 3){
                    if(transformar == 1){
                        vida = (int)(vidaTemp * 100f);     //mantido o padrão de multiplicação por comodidade para possiveis atualizações
                        nivelAtual = 3;
                        }
                    mana -= 15;
                    }
                else if(conjuracao == 4){
                    if(transformar == 1){
                        nivelAtual = 4; 
                    } 
                    mana -= 20;
                }
                else if(conjuracao == 5){
                    if(transformar == 1){
                        nivelAtual = 5; 
                        } 
                    mana -= 25;
                }        
        }

        public void Dano(){
            int dano = 0;
            Console.Clear();
            Console.WriteLine($"\n          vida: {vida}    mana: {mana}    Nível atual: {nivelAtual}    NívelLiberado: {nivelLiberado}          ");
            Console.Write("\n          insira o dano:  ");
            dano = int.Parse(Console.ReadLine());
                vida -= dano; 
                vida = Math.Max(0, vida);
                if(nivelAtual == 0 || nivelAtual == 4 || nivelAtual == 5){
                    vidaTemp = vida;
                }
                if(vida <= 0){
                    if(transformado){
                        Destransformar();
                    }
                    else{
                        vida = 0;
                        morreu = true;
                    }
                }  
            
            
            
        }

        public void Cura(){
            Console.Clear();
            int cura;
            Console.WriteLine($"\n          vida: {vida}    mana: {mana}    Nível atual: {nivelAtual}    Nível máximo liberado: {nivelLiberado}          ");
            Console.Write("\n          Digite a quantidade de cura:  ");
            string? input = Console.ReadLine();
            if(int.TryParse(input, out cura)){
                vida += cura;
            }
        }

        public void Destransformar(){
            switch(nivelAtual){
                case 1: vida = (int)(vidaTemp * 0.30f); break;
                case 2: vida = (int)(vidaTemp * 0.20f); break;
                case 3: vida = (int)(vidaTemp * 0.20f); break;
            }
            vida = Math.Max(0, vida);
            vidaTemp = vida;
            transformado = false;
            nivelAtual = 0;
        }

        public void MaisMana(){
            Console.Clear();
            int maisMana;
            Console.WriteLine($"\n          vida: {vida}    mana: {mana}    Nível atual: {nivelAtual}    Nível máximo liberado: {nivelLiberado}          ");
            Console.Write("\n          Digite a quantidade de mana restaurada:  ");
            string? input = Console.ReadLine();
            if(int.TryParse(input, out maisMana)){
                mana += maisMana;
            }
        }

        public void MenosMana(){
            Console.Clear();
            int menosMana;
            Console.WriteLine($"\n          vida: {vida}    mana: {mana}    Nível atual: {nivelAtual}    Nível máximo liberado: {nivelLiberado}          ");
            Console.Write("\n          Digite a quantidade de mana drenada:  ");
            string? input = Console.ReadLine();
            if(int.TryParse(input, out menosMana)){
                mana += menosMana;
            }
        }
    }       
}