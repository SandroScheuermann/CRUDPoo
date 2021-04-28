using System;

namespace CRUDPoo
{
    class Controladora
    {
        static private Equipamento[] equipamentoArray = new Equipamento[0];
        static private Chamada[] chamadaArray = new Chamada[0];
        public void CadastraEquipamento()
        {
            string nomeConstrutor = "", fabricanteConstrutor = "";
            int nSerieConstrutor;
            double precoConstrutor;
            DateTime dataConstrutor;
            Equipamento equipamento;

            while (true)
            {
                Console.WriteLine("Digite o nome do equipamento : \n");
                nomeConstrutor = Console.ReadLine();

                if (nomeConstrutor.Length > 5)
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine("O nome precisa ter no mínimo 6 caracteres!\n");
            }

            while (true)
            {
                Console.WriteLine("Digite o preço de aquisição : \n");
                if (double.TryParse(Console.ReadLine(), out precoConstrutor))
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Digite um preço válido!\n");

            }

            while (true)
            {
                Console.WriteLine("Digite o número de série : \n");
                if (int.TryParse(Console.ReadLine(), out nSerieConstrutor))
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Digite um número de série válido!\n");
            }

            while (true)
            {
                Console.WriteLine("Digite a data de fabricação (dd/MM/yyyy) : \n");
                if (DateTime.TryParse(Console.ReadLine(), out dataConstrutor))
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Digite uma data de fabricação válida!\n");
            }

            while (true)
            {
                Console.WriteLine("Digite o nome do fabricante : \n");
                fabricanteConstrutor = Console.ReadLine();
                if (fabricanteConstrutor.Length > 0)
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Digite um nome de fabricante válido!\n");
            }

            Console.Clear();
            equipamento = new Equipamento(nomeConstrutor, fabricanteConstrutor, precoConstrutor, nSerieConstrutor, dataConstrutor);
            Array.Resize(ref equipamentoArray, equipamentoArray.Length + 1);
            equipamentoArray[equipamentoArray.Length - 1] = equipamento;
        }
        public void EditarEquipamento()
        {
            if (equipamentoArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há equipamentos cadastrados!\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite aqui o número de série do equipamento que deseja editar : ");
                int nSerieEditar = Convert.ToInt16(Console.ReadLine());

                for (int i = 0; i < equipamentoArray.Length; i++)
                {
                    if (equipamentoArray[i].NSerie == nSerieEditar)
                    {
                        string nomeConstrutor = "", fabricanteConstrutor = "";
                        int nSerieConstrutor;
                        double precoConstrutor;
                        DateTime dataConstrutor;
                        Equipamento equipamento;

                        while (true)
                        {
                            Console.WriteLine("Digite o nome do equipamento : \n");
                            nomeConstrutor = Console.ReadLine();

                            if (nomeConstrutor.Length > 5)
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("O nome precisa ter no mínimo 6 caracteres!\n");
                        }

                        while (true)
                        {
                            Console.WriteLine("Digite o preço de aquisição : \n");
                            if (double.TryParse(Console.ReadLine(), out precoConstrutor))
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("Digite um preço válido!\n");

                        }

                        while (true)
                        {
                            Console.WriteLine("Digite o número de série : \n");
                            if (int.TryParse(Console.ReadLine(), out nSerieConstrutor))
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("Digite um número de série válido!\n");
                        }

                        while (true)
                        {
                            Console.WriteLine("Digite a data de fabricação (dd/MM/yyyy) : \n");
                            if (DateTime.TryParse(Console.ReadLine(), out dataConstrutor))
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("Digite uma data de fabricação válida!\n");
                        }

                        while (true)
                        {
                            Console.WriteLine("Digite o nome do fabricante : \n");
                            fabricanteConstrutor = Console.ReadLine();
                            if (fabricanteConstrutor.Length > 0)
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("Digite um nome de fabricante válido!\n");
                        }

                        Console.Clear();
                        equipamento = new Equipamento(nomeConstrutor, fabricanteConstrutor, precoConstrutor, nSerieConstrutor, dataConstrutor);
                        equipamentoArray[i] = equipamento;
                    }
                }
            }
        }
        public void ExcluirEquipamento()
        {

            if (equipamentoArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há equipamentos cadastrados!\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite aqui o número de série do equipamento que deseja excluir : ");
                int nSerieExcluir = Convert.ToInt16(Console.ReadLine());
                int indice = 0;

                for (int i = 0; i < equipamentoArray.Length; i++)
                {
                    if (equipamentoArray[i].NSerie == nSerieExcluir)
                    {

                        indice = i;
                        break;
                    }
                }

                if (indice < equipamentoArray.Length && indice >= 0)
                {
                    for (int i = indice + 1; i < equipamentoArray.Length; i++)
                    {
                        equipamentoArray[i - 1] = equipamentoArray[i];

                    }
                    Array.Resize(ref equipamentoArray, equipamentoArray.Length - 1);
                }
            }
        }
        public void MostraEquipamentos()
        {
            Console.Clear();

            if (equipamentoArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há equipamentos cadastrados!\n");
            }
            else
            {
                for (int i = 0; i < equipamentoArray.Length; i++)
                {
                    equipamentoArray[i].mostraDados();
                    Console.WriteLine("\n");
                }
            }
        }
        public void CadastraChamada()
        {
            string tituloConstrutor = "", descConstrutor = "", equipamentoConstrutor = "";
            DateTime dataConstrutor;
            Chamada chamada;

            if (equipamentoArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há equipamentos cadastrados para abrir uma chamada!\n");
            }
            else
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o nome da chamada : \n");
                    tituloConstrutor = Console.ReadLine();
                    if (tituloConstrutor.Length > 0)
                    {
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Digite um título de chamada válido!\n");
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a descrição da chamada : \n");
                    descConstrutor = Console.ReadLine();
                    if (descConstrutor.Length > 0)
                    {
                        Console.Clear();
                        break;
                    }

                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o equipamento da chamada : \n");
                    equipamentoConstrutor = Console.ReadLine();
                    if (equipamentoConstrutor.Length > 0) { break; }
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a data de abertura da chamada (dd/MM/yyyy) : \n");
                    if (DateTime.TryParse(Console.ReadLine(), out dataConstrutor)) { break; }
                }

                Console.Clear();
                chamada = new Chamada(tituloConstrutor, descConstrutor, equipamentoConstrutor, dataConstrutor);
                Array.Resize(ref chamadaArray, chamadaArray.Length + 1);
                chamadaArray[chamadaArray.Length - 1] = chamada;
            }
        }
        public void EditarChamada()
        {
            if (chamadaArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há chamadas cadastrados!\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite aqui o título do chamado que deseja editar : ");
                string titulo = Console.ReadLine();

                for (int i = 0; i < chamadaArray.Length; i++)
                {
                    if (chamadaArray[i].Titulo.Equals(titulo))
                    {

                        string tituloConstrutor = "", descConstrutor = "", equipamentoConstrutor = "";
                        DateTime dataConstrutor;
                        Chamada chamada;

                        if (equipamentoArray.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Não há equipamentos cadastrados!!!\n");
                        }
                        else
                        {

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite o nome da chamada : \n");
                                tituloConstrutor = Console.ReadLine();
                                if (tituloConstrutor.Length > 0) { break; }
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite a descrição da chamada : \n");
                                descConstrutor = Console.ReadLine();
                                if (descConstrutor.Length > 0) { break; }
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite o número de sério do equipamento da chamada : \n");
                                equipamentoConstrutor = Console.ReadLine();
                                if (equipamentoConstrutor.Length > 0) { break; }
                            }
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite a data de abertura da chamada (dd/MM/yyyy) : \n");
                                if (DateTime.TryParse(Console.ReadLine(), out dataConstrutor)) { break; }
                            }

                            Console.Clear();
                            chamada = new Chamada(tituloConstrutor, descConstrutor, equipamentoConstrutor, dataConstrutor);
                            chamadaArray[i] = chamada;
                        }
                    }
                }
            }
        }
        public void ExcluirChamada()
        {
            if (chamadaArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há chamadas cadastrados!\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite aqui o título da chamada que deseja excluir : ");
                string titulo = Console.ReadLine();
                int indice = 0;

                for (int i = 0; i < chamadaArray.Length; i++)
                {
                    if (chamadaArray[i].Titulo.Equals(titulo))
                    {
                        indice = i;
                        break;
                    }
                }
                if (indice < chamadaArray.Length && indice >= 0)
                {
                    for (int i = indice + 1; i < chamadaArray.Length; i++)
                    {
                        chamadaArray[i - 1] = chamadaArray[i];
                    }
                    Array.Resize(ref chamadaArray, chamadaArray.Length - 1);
                }
            }
        }
        public void MostraChamadas()
        {
            Console.Clear();

            if (chamadaArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há chamadas cadastrados!\n");
            }
            else
            {
                for (int i = 0; i < chamadaArray.Length; i++)
                {
                    chamadaArray[i].mostraDados();
                    Console.WriteLine("\n");
                }
            }

        }
    }
}
