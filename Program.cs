using System;

namespace Eixo_1__Instituição_Religiosa

{

    class Casamento
    {

        public string NomeNoivo;
        public string NomeNoiva;
        public string HoraCasamento;
        public Data DataCasamento;
    }
    class Data
    {

        public string Dia;
        public string Mes;
        public string Ano;
    }

    class Batizado
    {

        public string NomeBatizando;
        public string NomePai;
        public string NomeMae;
        public string HoraBatizado;
        public Data1 DataBatizado;
    }
    class Data1
    {

        public string Dia;
        public string Mes;
        public string Ano;
    }

    class Missa
    {

        public string TipoMissa;
        public string Nome;
        public string HoraMissa;
        public Data2 DataMissa;
    }
    class Data2
    {

        public string Dia;
        public string Mes;
        public string Ano;
    }

    class Program
    {
        static void Main(string[] args)//Algoritmo para marcação de missa,casamentos e bastizados.
        {
            int QuantCasamento = 0;

            int QuantBatizado = 0;

            int QuantMissa = 0;


            Casamento[] CasaOp = new Casamento[5];           // Vetor Casamento

            Batizado[] BatiOp = new Batizado[5];             // Vetor Batizado

            Missa[] MisOp = new Missa[5];                    // Vetor Missa



            int escolha;

            do
            {
                Console.Clear();

                Console.WriteLine("Essa é a sua central de marcações. ");
                Console.WriteLine("Digite:\n 1 Agendamento de casamento:\n 2 Agendamento de batizados:\n 3 Agendamento de missas:");
                Console.WriteLine(" 4 Visualizar casamentos:\n 5 Visualizar batizados:\n 6 Visualizar missas:");
                Console.WriteLine("\nSua escolha: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {

                    case 1://Opção para marcação de casamentos.
                        MarcarCasa(CasaOp, QuantCasamento);
                        if (QuantCasamento < CasaOp.Length)
                            QuantCasamento++;



                        break;


                    case 2://Opção para marcação de batizados.
                        MarcarBati(BatiOp, QuantBatizado);
                        if (QuantBatizado < BatiOp.Length)
                            QuantBatizado++;


                        break;


                    case 3://Opção para marcação de missas.
                        MarcarMis(MisOp, QuantMissa);
                        if (QuantMissa < MisOp.Length)
                            QuantMissa++;


                        break;

                    case 4:// Ver lista de casamentos.


                        ListarCasamento(CasaOp);


                        Console.ReadKey();


                        break;

                    case 5:// Ver lista de batizados.

                        ListarBatizado(BatiOp);

                        Console.ReadKey();

                        break;

                    case 6:// Ver lista de missas.

                        ListarMissa(MisOp);

                        Console.ReadKey();

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\nOpção Inválida!!");
                        Console.WriteLine("\nDigite 1 para continuar ou enter para sair...");
                        escolha = int.Parse(Console.ReadLine());



                        break;

                }
            } while (escolha < 7);




        }

        static void MarcarCasa(Casamento[] CasaOp, int P)
        {

            Console.Clear();



            if (P == CasaOp.Length)
            {


                Console.WriteLine("Não existem datas disponíveis..");
                Console.ReadKey();
            }
            else
            {

                Casamento x = new Casamento();
                Console.WriteLine("Bem vindo!! Este é o canal para a marcação de casamentos.");

                Console.WriteLine("Nome do noivo: ");
                x.NomeNoivo = Console.ReadLine();

                Console.WriteLine("Nome da Noiva :");
                x.NomeNoiva = Console.ReadLine();

                Console.WriteLine("Hora do Casamento :");
                x.HoraCasamento = Console.ReadLine();

                x.DataCasamento = new Data();

                Console.Write("Data do Casamento - Dia: ");
                x.DataCasamento.Dia = Console.ReadLine();

                Console.Write("            Mês:  ");
                x.DataCasamento.Mes = Console.ReadLine();

                Console.Write("            Ano:  ");
                x.DataCasamento.Ano = Console.ReadLine();


                CasaOp[P] = x;


            }
        }

        static void MarcarBati(Batizado[] BatiOp, int P)
        {
            Console.Clear();

            if (P == BatiOp.Length)
            {
                Console.WriteLine("Não existem datas disponíveis..");
                Console.ReadKey();
            }

            else
            {

                Batizado x = new Batizado();

                Console.WriteLine("Bem vindo!! Este é o canal para a marcação e batizados.\n");

                Console.WriteLine("Por favor, informe o nome da criança: ");
                x.NomeBatizando = Console.ReadLine();

                Console.WriteLine("Nome da mãe: ");
                x.NomeMae = Console.ReadLine();

                Console.WriteLine("Nome do pai:");
                x.NomePai = Console.ReadLine();

                Console.Write("Informe o Horário: ");
                x.HoraBatizado = Console.ReadLine();

                x.DataBatizado = new Data1();

                Console.Write("Data do Batizado - Dia: ");
                x.DataBatizado.Dia = Console.ReadLine();

                Console.Write("            Mês:  ");
                x.DataBatizado.Mes = Console.ReadLine();

                Console.Write("            Ano:  ");
                x.DataBatizado.Ano = Console.ReadLine();

                BatiOp[P] = x;


            }
        }

        static void MarcarMis(Missa[] MisOp, int P)
        {
            Console.Clear();

            if (P == MisOp.Length)
            {
                Console.WriteLine("Não existem datas disponíveis..");
                Console.ReadKey();
            }

            else
            {

                Missa x = new Missa();

                Console.WriteLine("Bem vindo!! Gostaria de marcar uma missas? \n");

                Console.WriteLine("Informe o tipo de missa que você deseja:");
                x.TipoMissa = Console.ReadLine();

                Console.WriteLine("Qual o nome da pessoa que receberá essa celebração?");
                x.Nome = Console.ReadLine();

                Console.WriteLine("Informe o Horário:");
                x.HoraMissa = Console.ReadLine();

                x.DataMissa = new Data2();

                Console.Write("Data da Missa - Dia: ");
                x.DataMissa.Dia = Console.ReadLine();

                Console.Write("            Mês:  ");
                x.DataMissa.Mes = Console.ReadLine();

                Console.Write("            Ano:  ");
                x.DataMissa.Ano = Console.ReadLine();

                MisOp[P] = x;
            }
        }
        static void ListarCasamento(Casamento[] p)
        {
            
            Console.Clear();


            foreach (Casamento x in p)
            {
                if (x == null) 
                { 

                  Console.WriteLine($"\n Vagas disponiveis..");
                    
                    Console.ReadKey();

                }
                Console.WriteLine($"\n Noivo:{x.NomeNoivo} ");
                Console.WriteLine($" Noiva:{x.NomeNoiva}");
                Console.WriteLine($" Horário: {x.HoraCasamento}");
                Console.WriteLine($" Data: {x.DataCasamento.Dia}/{x.DataCasamento.Mes}/{x.DataCasamento.Ano} ");

                Console.ReadKey();
            
             
            }
            

        }
        static void ListarBatizado(Batizado[] p)
        {

            Console.Clear();


            foreach (Batizado x in p)
            {
                if (x == null)
                {

                    Console.WriteLine($"\n Vagas disponiveis..");

                    Console.ReadKey();

                }
                Console.WriteLine($"\n Nome:{x.NomeBatizando} ");
                Console.WriteLine($" Pai:{x.NomePai}");
                Console.WriteLine($" Mãe:{x.NomeMae}");
                Console.WriteLine($" Horário: {x.HoraBatizado}");
                Console.WriteLine($" Data: {x.DataBatizado.Dia}/{x.DataBatizado.Mes}/{x.DataBatizado.Ano} ");

                Console.ReadKey();
            }

        }
        static void ListarMissa(Missa[] p)
        {

            Console.Clear();


            foreach (Missa x in p)
            {
                if (x == null)
                {

                    Console.WriteLine($"\n Vagas disponiveis..");

                    Console.ReadKey();

                }
                Console.WriteLine($"\n Missa:{x.TipoMissa} ");
                Console.WriteLine($"Nome:{x.Nome}");
                Console.WriteLine($"Horário: {x.HoraMissa}");
                Console.WriteLine($"Data: {x.DataMissa.Dia}/{x.DataMissa.Mes}/{x.DataMissa.Ano} ");

                Console.ReadKey();

            }
        }
    }


}
