using System;

namespace CRUDPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            string menu = "";
            Controladora controle = new Controladora();

            while (true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Digite 1 para cadastrar um novo equipamento");
                Console.WriteLine("Digite 2 para visualizar os equipamentos");
                Console.WriteLine("Digite 3 para editar algum equipamentos");
                Console.WriteLine("Digite 4 para excluir algum equipamento");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Digite 5 para cadastrar uma nova chamada");
                Console.WriteLine("Digite 6 para visualizar as chamadas");
                Console.WriteLine("Digite 7 para editar uma chamada");
                Console.WriteLine("Digite 8 para excluir uma chamada");
                Console.WriteLine("-------------------------------------------------");

                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        controle.CadastraEquipamento();
                        break;

                    case "2":
                        controle.MostraEquipamentos();
                        break;

                    case "3":
                        controle.EditarEquipamento();
                        break;

                    case "4":
                        controle.ExcluirEquipamento();
                        break;

                    case "5":
                        controle.CadastraChamada();
                        break;

                    case "6":
                        controle.MostraChamadas();
                        break;

                    case "7":
                        controle.EditarChamada();
                        break;

                    case "8":
                        controle.ExcluirChamada();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida!\n");
                        break;

                }
            }
        }
    }
}