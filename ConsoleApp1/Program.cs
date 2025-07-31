using System;

namespace name
{
    class Class
    {
        static void Main()
        {
            List<string> tarefas = new List<string>();
            bool cond = true;
            while (cond)
            {
                Console.WriteLine("\n1- Adicionar");
                Console.WriteLine("2- Remover");
                Console.WriteLine("3- Visualizar lista");
                Console.WriteLine("4- Sair");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 4)
                {
                    cond = false;
                }
                switch (escolha)
                {
                    case 1:
                        bool cond2 = true;
                        while (cond2)
                        {
                            Console.WriteLine("\n1- Adicione coisas a lista");
                            Console.WriteLine("2- Sair");
                            string escolha2 = Console.ReadLine();
                            if (escolha2 == "2")
                            {
                                cond2 = false;
                            }
                            else if (escolha2 == "1")
                            {
                                tarefas.Add(Console.ReadLine());

                            }
                        }
                        break;
                    case 2:
                        bool cond3 = true;
                        while (cond3)
                        {
                            Console.WriteLine("\n1- Remova o item da lista");
                            Console.WriteLine("2- Sair");
                            string escolha3 = Console.ReadLine();
                            if (escolha3 == "2")
                            {
                                cond3 = false;
                            }
                            else if (escolha3 == "1")
                            {
                                tarefas.Remove(Console.ReadLine());

                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine(tarefas[i]);

                        }
                        break;
                    case 4:
                        cond = false;
                        break;
                }
            }
        }
    }
}
