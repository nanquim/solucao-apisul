using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvaAdmissionalCSharpApisul
{
    public class Elevador : IElevadorService
    {
        public int andar { get; set; }

        public char elevador { get; set; }

        public char turno { get; set; }
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


            return elevadoresMaisFrequentados.ToList();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            /* TODO erro se eu tento pegar direto */

            // Pega o elevador + frequentado
            List<char> elevadores = new List<char>();
            elevadores = this.elevadorMaisFrequentado();

            // Pegar 1o elevador
            char elevador;
            elevador = elevadores.First();

            // Criar lista de periodos      
            List<char> periodos = new List<char>();
            this.elevadores.ForEach(e => periodos.Add(e.turno));

            var periodo = (from p in periodos
                           where elevador == elevador
                           group p by p into grupo
                           orderby grupo.Count() descending
                           select grupo.Key).First();

            Console.WriteLine("\nO elevador mais frequentado é " + elevador + " e é mais utilizado no turno " +
                              periodo + "\n");


            /* TODO rever retorno, já que vc tá logando */
            return periodos;
        }

        public List<char> elevadorMenosFrequentado()
        {
            // Criar lista de elevadores      
            List<char> elevadores = new List<char>();
            this.elevadores.ForEach(e => elevadores.Add(e.elevador));

            // Ordernar pelo andar - frequente

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
            /* TODO erro se eu tento pegar direto */

            // Pega o elevador + frequentado
            List<char> elevadores = new List<char>();
            elevadores = this.elevadorMenosFrequentado();

            // Pegar 1o elevador
            char elevador;
            elevador = elevadores.First();

            // Criar lista de periodos      
            List<char> periodos = new List<char>();
            this.elevadores.ForEach(e => periodos.Add(e.turno));

            var periodo = (from p in periodos
                           where elevador == elevador
                           group p by p into grupo
                           orderby grupo.Count() ascending
                           select grupo.Key).First();

            Console.WriteLine("\nO elevador menos frequentado é " + elevador + " e é menos utilizado no turno " +
                              periodo + "\n");


            /* TODO rever retorno, já que vc tá logando */
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


            /* TODO rever */
            return periodos;
        }

        public float percentualDeUsoElevadorA()
        {
            List<int> andares = new List<int>();
            this.elevadores.ForEach(e => andares.Add(e.elevador));

            var percentual = ((float)andares.Count(i => i == 'A')) / andares.Count * 100;


            Console.WriteLine("O percentual do elevador A é de " + percentual);

            return percentual;
        }
        public float percentualDeUsoElevadorB()
        {
        
            List<int> andares = new List<int>();
            this.elevadores.ForEach(e => andares.Add(e.elevador));

            var percentual = ((float)andares.Count(i => i == 'B')) / andares.Count * 100;


            Console.WriteLine("O percentual do elevador B é de " + percentual);

            return percentual;
        }
        public float percentualDeUsoElevadorC()
        {
            List<int> andares = new List<int>();
            this.elevadores.ForEach(e => andares.Add(e.elevador));

            var percentual = ((float)andares.Count(i => i == 'C')) / andares.Count * 100;


            Console.WriteLine("O percentual do elevador C é de " + percentual);

            return percentual;
        }

        public float percentualDeUsoElevadorD()
        {
            List<int> andares = new List<int>();
            this.elevadores.ForEach(e => andares.Add(e.elevador));

            var percentual = ((float)andares.Count(i => i == 'D')) / andares.Count * 100;


            Console.WriteLine("O percentual do elevador D é de " + percentual);

            return percentual;
        }

        public float percentualDeUsoElevadorE()
        {
            List<int> andares = new List<int>();
            this.elevadores.ForEach(e => andares.Add(e.elevador));

            var percentual = ((float)andares.Count(i => i == 'E')) / andares.Count * 100;


            Console.WriteLine("O percentual do elevador E é de " + percentual);

            return percentual;
        }
    }
}