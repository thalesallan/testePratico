using System;
using System.Collections.Generic;


namespace testePratico
{
    class PetShops
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Distancia { get; set; }
        public double PrecoPequeno { get; set; }
        public double PrecoGrande { get; set; }
        public double PrecoTotal { get; set; }

        public static List<PetShops> GerarPetshops()
        {
            List<PetShops> ListaPetShop = new List<PetShops>();

            PetShops PetShop;

            PetShop = new PetShops
            {
                Id = 0,
                Nome = "Vai Rex",
                Distancia = 1.70,
                PrecoPequeno = 15,
                PrecoGrande = 50,
                PrecoTotal = 0
            };

            ListaPetShop.Add(PetShop);


            PetShop = new PetShops
            {
                Id = 1,
                Nome = "Meu Canino Feliz",
                Distancia = 2,
                PrecoPequeno = 20,
                PrecoGrande = 40,
                PrecoTotal = 0
            };

            ListaPetShop.Add(PetShop);


            PetShop = new PetShops
            {
                Id = 2,
                Nome = "ChowChawgas",
                Distancia = 0.80,
                PrecoPequeno = 30,
                PrecoGrande = 45,
                PrecoTotal = 0
            };

            ListaPetShop.Add(PetShop);

            return ListaPetShop;
        }

        public static void CalcValor(List<PetShops> ListaPetShop)
        {
            Console.Write("Entre com a data no formato dd/mm/aaa: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Quantidade de cães pequenos: ");
            double qtdPequeno = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de cães grandes: ");
            double qtdGrande = double.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                for (int i = 0; i < ListaPetShop.Count; i++)
                {
                    if (ListaPetShop[i].Id == 0)
                    {
                        double tempP = (ListaPetShop[i].PrecoPequeno * 1.2) * qtdPequeno;
                        double tempG = (ListaPetShop[i].PrecoGrande * 1.2) * qtdGrande;
                        ListaPetShop[i].PrecoTotal = tempP + tempG;
                    }
                    else if (ListaPetShop[i].Id == 1)
                    {
                        double tempP = (ListaPetShop[i].PrecoPequeno + 5) * qtdPequeno;
                        double tempG = (ListaPetShop[i].PrecoGrande + 5) * qtdGrande;
                        ListaPetShop[i].PrecoTotal = tempP + tempG;
                    }
                    else
                    {
                        double tempP = ListaPetShop[i].PrecoPequeno * qtdPequeno;
                        double tempG = ListaPetShop[i].PrecoGrande * qtdGrande;
                        ListaPetShop[i].PrecoTotal = tempP + tempG;
                    }
                }

            }
            else
            {
                for (int i = 0; i < ListaPetShop.Count; i++)
                {
                    double tempP = ListaPetShop[i].PrecoPequeno * qtdPequeno;
                    double tempG = ListaPetShop[i].PrecoGrande * qtdGrande;
                    ListaPetShop[i].PrecoTotal = tempP + tempG;
                }
            }
        }

        public static void MelhorOpcao(List<PetShops> ListaPetShop)
        {
           
            ListaPetShop.Sort(delegate (PetShops x, PetShops y)
            {
                if (x.PrecoTotal < y.PrecoTotal)
                {
                    return -1;
                }
                else if (x.PrecoTotal > y.PrecoTotal)
                {
                    return 1;
                }
                else
                {
                    if (x.Distancia < y.Distancia)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            });

            Console.WriteLine(ListaPetShop[0].Nome + ": R$" + ListaPetShop[0].PrecoTotal);
        }
    }
}
