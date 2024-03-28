namespace AEB_Tupiniquim_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            (int areax, int areay) = InputArea();
            (int posx, int posy, string cardeal) = InputPosicao(areax, areay);
            (posx, posy, cardeal) = Comando(areax, areay, posx, posy, cardeal);
            string resultado1 = $"{posx} {posy} {cardeal}";

            (posx, posy, cardeal) = InputPosicao(areax, areay);
            (posx, posy, cardeal) = Comando(areax, areay, posx, posy, cardeal);
            string resultado2 = $"{posx} {posy} {cardeal}";

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.ReadLine();
        }

        public static (int, int, string) Comando(int areax, int areay, int posx, int posy, string cardeal)
        {
            string frasecomando = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                frasecomando = Console.ReadLine();
                string auxcar = "";
                int verificarerro = 0;
                foreach (char comando in frasecomando)
                {
                    if (comando != ' ')
                    {
                        if (comando == 'E' || comando == 'e')
                        {
                            if (cardeal == "N" || cardeal == "n")
                            {
                                auxcar = "O";
                            }
                            else if (cardeal == "O" || cardeal == "o")
                            {
                                auxcar = "S";
                            }
                            else if (cardeal == "S" || cardeal == "s")
                            {
                                auxcar = "L";
                            }
                            else if (cardeal == "L" || cardeal == "l")
                            {
                                auxcar = "N";
                            }
                            cardeal = auxcar;
                        }
                        else if (comando == 'D' || comando == 'd')
                        {
                            if (cardeal == "N" || cardeal == "n")
                            {
                                auxcar = "L";
                            }
                            else if (cardeal == "L" || cardeal == "l")
                            {
                                auxcar = "S";
                            }
                            else if (cardeal == "S" || cardeal == "s")
                            {
                                auxcar = "O";
                            }
                            else if (cardeal == "O" || cardeal == "O")
                            {
                                auxcar = "N";
                            }
                            cardeal = auxcar;
                        }
                        if (comando == 'M' || comando == 'm')
                        {
                            if (cardeal == "N" || cardeal == "n")
                            {
                                posy++;
                            }
                            else if (cardeal == "L" || cardeal == "l")
                            {
                                posx++;
                            }
                            else if (cardeal == "S" || cardeal == "s")
                            {
                                posy--;
                            }
                            else if (cardeal == "O" || cardeal == "O")
                            {
                                posx--;
                            }
                        }
                        else if (comando != 'M' && comando != 'm' && comando != 'D' && comando != 'd' && comando != 'E' && comando != 'e' && comando == ' ')
                        {
                            verificarerro = 1;
                        }
                    }
                }
                if (verificarerro == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }

                if (posx > areax || posx < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }

                if (posy > areay || posy < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }
                break;
            }
            return (posx, posy, cardeal);
        }

        public static (int, int, string) InputPosicao(int areax, int areay)
        {
            int continput = 0, posx = 0, posy = 0;
            string cardeal = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string input = Console.ReadLine();
                foreach (char separacao in input)
                {
                    if (separacao != ' ')
                    {
                        continput++;
                        if (continput == 1)
                        {
                            short auxconversao1;
                            Int16.TryParse(separacao.ToString(), out auxconversao1);
                            posx = auxconversao1;
                        }
                        if (continput == 2)
                        {
                            short auxconversao2;
                            Int16.TryParse(separacao.ToString(), out auxconversao2);
                            posy = auxconversao2;
                        }
                        if (continput == 3)
                        {
                            cardeal = Convert.ToString(separacao);
                        }
                    }
                }
                if (posx > areax)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro");
                    continue;
                }
                if (posy > areay)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro");
                    continue;
                }
                if (cardeal != "N" && cardeal != "n" && cardeal != "S" && cardeal != "s" && cardeal != "L" && cardeal != "l" && cardeal != "O" && cardeal != "o" && cardeal == " " && cardeal == "")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }
                break;
            }
            return (posx, posy, cardeal);
        }

        public static (int, int) InputArea()
        {
            int areax = 0, areay = 0;
            while (true)
            {
                int continput = 0; 
                string input = "";
                input = Console.ReadLine();
                continput = 0;
                areax = 0;
                areay = 0;
                foreach (char separacao in input)
                {
                    if (separacao != ' ')
                    {
                        continput++;
                        if (continput == 1)
                        {
                            short auxconversao1;
                            Int16.TryParse(separacao.ToString(), out auxconversao1);
                            areax = auxconversao1;
                        }
                        if (continput == 2)
                        {
                            short auxconversao2;
                            Int16.TryParse(separacao.ToString(), out auxconversao2);
                            areay = auxconversao2;
                        }
                    }
                }
                if (areay < 0 || areax < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro");
                    continue;
                }
                break;
            }
            return (areax, areay);
        }            
    }
}