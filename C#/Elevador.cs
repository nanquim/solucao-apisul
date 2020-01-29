using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvaAdmissionalCSharpApisul
{
    public class Elevador : IElevadorService
    {
        public List<ElevadorModel> elevadores { get; set; }

        public Elevador(List<ElevadorModel> elevadores)
        {
            this.elevadores = elevadores;
        }

        public List<int> andarMenosUtilizado()
        {

            // Criar lista de andares      
            List<int> andares = new List<int>();
            this.elevadores.ForEach(e => andares.Add(e.andar));

            // Ordernar pelo andar - frequente
            var andaresMenosUtilizados = (from a in andares
                                          group a by a into grupo
                                          orderby grupo.Count() ascending
                                          select grupo.Key).ToList();

            Console.WriteLine("\nAndares menos utilizados:\n");

            // deverá sair, pois é retorno
            andaresMenosUtilizados.ForEach(a => Console.WriteLine(a));


            return andaresMenosUtilizados.ToList();
        }

        public List<char> elevadorMaisFrequentado()
        {
            // Criar lista de elevadores      
            List<char> elevadores = new List<char>();
            this.elevadores.ForEach(e => elevadores.Add(e.elevador));

            // Ordernar pelo andar - frequente

            var elevadoresMaisFrequentados = (from e in elevadores
                                              group e by e into grupo
                                              orderby grupo.Count() descending
                                              select grupo.Key).ToList();

            Console.WriteLine("\nElevadores mais frequentados:\n");

            // deverá sair, pois é retorno
            elevadoresMaisFrequentados.ForEach(e => Console.WriteLine(e));

            return elevadoresMaisFrequentados;
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            /*  Pega o elevador + frequentado */
            char elevadorMaisFrequentado = this.elevadorMaisFrequentado().First(); // this equals C

            var periodos = (from e in this.elevadores
                            where e.elevador == elevadorMaisFrequentado
                            group e.turno by e.turno into grupo
                            orderby grupo.Count() descending
                            select grupo.Key).ToList();


            Console.WriteLine("\nO elevador mais frequentado é " + elevadorMaisFrequentado + " e é mais utilizado no turno " +
                              periodos.First() + "\n");

            return periodos;
        }

        public List<char> elevadorMenosFrequentado()
        {
            /* Criar lista de elevadores */
            List<char> elevadores = new List<char>();
            this.elevadores.ForEach(e => elevadores.Add(e.elevador));

            /* Ordernar pelo andar - frequente */

            var elevadoresMenosFrequentados = (from e in elevadores
                                               group e by e into grupo
                                               orderby grupo.Count() ascending
                                               select grupo.Key).ToList();

            Console.WriteLine("\nElevadores menos frequentados:\n");

            // deverá sair, pois é retorno
            elevadoresMenosFrequentados.ForEach(e => Console.WriteLine(e));


            return elevadoresMenosFrequentados.ToList();
        }
        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            /*  Pega o elevador - frequentado */
            char elevadorMenosFrequentado = this.elevadorMenosFrequentado().First();

            var periodos = (from e in this.elevadores
                            where e.elevador == elevadorMenosFrequentado
                            group e.turno by e.turno into grupo
                            orderby grupo.Count() ascending
                            select grupo.Key).ToList();

            Console.WriteLine("\nO elevador menos frequentado é " + elevadorMenosFrequentado + " e é menos utilizado no turno " +
                              periodos.First() + "\n");

            return periodos;
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            // Criar lista de periodos      
            List<char> periodos = new List<char>();
            this.elevadores.ForEach(e => periodos.Add(e.turno));

            // Ordernar pelo andar - frequente

            var periodoMaiorUtilizacao = (from p in periodos
                                          group p by p into grupo
                                          orderby grupo.Count() descending
                                          select grupo.Key).First();

            Console.WriteLine("\nOs elevadores são mais utilizados no período " + periodoMaiorUtilizacao + "\n");

            return periodos;
        }

        public float percentualDeUsoElevadorA()
        {
            var percentual = calculaPercentual('A');

            return percentual;
        }
        public float percentualDeUsoElevadorB()
        {
            var percentual = calculaPercentual('B');

            return percentual;
        }
        public float percentualDeUsoElevadorC()
        {
            var percentual = calculaPercentual('C');

            return percentual;
        }

        public float percentualDeUsoElevadorD()
        {
            var percentual = calculaPercentual('D');

            return percentual;
        }

        public float percentualDeUsoElevadorE()
        {
            var percentual = calculaPercentual('E');

            return percentual;
        }

        private float calculaPercentual(char elevador)
        {
            List<int> elevadores = new List<int>();
            this.elevadores.ForEach(e => elevadores.Add(e.elevador));

            var percentual = ((float)elevadores.Count(i => i == elevador)) / elevadores.Count * 100;

            return percentual;
        }
    }
}