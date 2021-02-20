using System;
using System.Collections.Generic;

namespace testePratico
{
    class Program
    {
        public static object Petshops { get; private set; }

        static void Main(string[] args)
        {
            List<PetShops> petShops = PetShops.GerarPetshops();

            PetShops.CalcValor(petShops);
            PetShops.MelhorOpcao(petShops);
        }   
    }
 
}
