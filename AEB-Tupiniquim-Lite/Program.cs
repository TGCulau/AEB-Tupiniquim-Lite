namespace AEB_Tupiniquim_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int continput = 0, areax = 0, areay = 0;
            string input = "";
            while (true)
            {
                //5 5
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
            int posx = 0, posy = 0;
            string cardeal = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //1 2 N
                input = Console.ReadLine();
                continput = 0;
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


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int posx2 = 0, posy2 = 0;
            string cardeal2 = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                input = Console.ReadLine();
                continput = 0;
                foreach (char separacao in input)
                {
                    if (separacao != ' ')
                    {
                        continput++;
                        if (continput == 1)
                        {
                            short auxconversao1;
                            Int16.TryParse(separacao.ToString(), out auxconversao1);
                            posx2 = auxconversao1;
                        }
                        if (continput == 2)
                        {
                            short auxconversao2;
                            Int16.TryParse(separacao.ToString(), out auxconversao2);
                            posy2 = auxconversao2;
                        }
                        if (continput == 3)
                        {
                            cardeal2 = Convert.ToString(separacao);
                        }
                    }
                }
                if (posx2 > areax)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro");
                    continue;
                }
                if (posy2 > areay)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro");
                    continue;
                }
                if (cardeal2 != "N" && cardeal2 != "n" && cardeal2 != "S" && cardeal2 != "s" && cardeal2 != "L" && cardeal2 != "l" && cardeal2 != "O" && cardeal2 != "o" && cardeal2 == " " && cardeal2 == "")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }
                break;
            }
            string frasecomando2 = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                frasecomando2 = Console.ReadLine();
                string auxcar2 = "";
                int verificarerro2 = 0;
                //string[] conterro = new string[frasecomando2.Length];

                foreach (char comando in frasecomando2)
                {
                    if (comando != ' ')
                    {
                        if (comando == 'E' || comando == 'e')
                        {
                            if (cardeal2 == "N" || cardeal2 == "n")
                            {
                                auxcar2 = "O";
                            }
                            else if (cardeal2 == "O" || cardeal2 == "o")
                            {
                                auxcar2 = "S";
                            }
                            else if (cardeal2 == "S" || cardeal2 == "s")
                            {
                                auxcar2 = "L";
                            }
                            else if (cardeal2 == "L" || cardeal2 == "l")
                            {
                                auxcar2 = "N";
                            }
                            cardeal2 = auxcar2;
                        }
                        else if (comando == 'D' || comando == 'd')
                        {
                            if (cardeal2 == "N" || cardeal2 == "n")
                            {
                                auxcar2 = "L";
                            }
                            else if (cardeal2 == "L" || cardeal2 == "l")
                            {
                                auxcar2 = "S";
                            }
                            else if (cardeal2 == "S" || cardeal2 == "s")
                            {
                                auxcar2 = "O";
                            }
                            else if (cardeal2 == "O" || cardeal2 == "O")
                            {
                                auxcar2 = "N";
                            }
                            cardeal2 = auxcar2;
                        }
                        if (comando == 'M' || comando == 'm')
                        {
                            if (cardeal2 == "N" || cardeal2 == "n")
                            {
                                posy2++;
                            }
                            else if (cardeal2 == "L" || cardeal2 == "l")
                            {
                                posx2++;
                            }
                            else if (cardeal2 == "S" || cardeal2 == "s")
                            {
                                posy2--;
                            }
                            else if (cardeal2 == "O" || cardeal2 == "O")
                            {
                                posx2--;
                            }
                        }
                        else if (comando != 'M' && comando != 'm' && comando != 'D' && comando != 'd' && comando != 'E' && comando != 'e' && comando == ' ')
                        {
                            verificarerro2 = 1;
                        }
                    }
                }
                if (verificarerro2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }

                if (posx2 > areax || posx2 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }

                if (posy2 > areay || posy2 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Erro");
                    continue;
                }
                break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Write($"{posx} {posy} {cardeal}");
            Console.Write($"\n{posx2} {posy2} {cardeal2}");
            Console.ReadLine();
        }
    }
}