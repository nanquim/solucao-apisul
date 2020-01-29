using System;
using System.Collections.Generic;

namespace ProvaAdmissionalCSharpApisul
{
    class Program
    {
        static void Main(string[] args)
        {
            Input i = new Input();

            List<ElevadorModel> elevadoresModel = new List<ElevadorModel>();

            elevadoresModel = i.pegaInputs();

            Elevador elevadores = new Elevador(elevadoresModel);

            elevadores.andarMenosUtilizado();

            elevadores.elevadorMaisFrequentado();

            elevadores.elevadorMenosFrequentado();

            elevadores.periodoMaiorFluxoElevadorMaisFrequentado();

            elevadores.periodoMenorFluxoElevadorMenosFrequentado();

            elevadores.periodoMaiorUtilizacaoConjuntoElevadores();



            var pa = elevadores.percentualDeUsoElevadorA();
            Console.WriteLine("O percentual do elevador A é de " + pa);
            
            var pb = elevadores.percentualDeUsoElevadorB();
            Console.WriteLine("O percentual do elevador B é de " + pb);
            
            var pc = elevadores.percentualDeUsoElevadorC();
            Console.WriteLine("O percentual do elevador C é de " + pc);

            var pd = elevadores.percentualDeUsoElevadorD();
            Console.WriteLine("O percentual do elevador D é de " + pd);
            
            var pe = elevadores.percentualDeUsoElevadorE();
            Console.WriteLine("O percentual do elevador E é de " + pe);
            
        }
    }
}
