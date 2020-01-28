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

            elevadores.percentualDeUsoElevadorA();
            
            elevadores.percentualDeUsoElevadorB();

            elevadores.percentualDeUsoElevadorC();

            elevadores.percentualDeUsoElevadorD();

            elevadores.percentualDeUsoElevadorE();

        }
    }
}
