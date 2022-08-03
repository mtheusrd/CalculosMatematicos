using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace ConsoleApp3.basicas
    {
        public class Divisao
        {
            public double Calcular(double dividendo, double divisor)
            {
                if (divisor == 0)
                {
                    return 0;
                }
                    return dividendo / divisor;
            }
        }

            public class Multiplicacao
            {
                public double Calcular(double multiplicando, double multiplicador)
                {
                    return multiplicando * multiplicador;
                }
            }
            public class Soma
            {
                public double Calcular(double valor1, double valor2)
                {
                    return valor1 + valor2;
                }
             }

            public class Subtracao
            {
                public double Calcular(double valor1, double valor2)
                {
                    return valor1 - valor2;
                }
            }

            public class Operacoes
            {
                public Soma Soma { get; private set; }
                public Subtracao Subtracao { get; private set; }
                public Multiplicacao Multiplicacao { get; private set; }
                public Divisao Divisao { get; private set; }
                public Operacoes()
                {
                    this.Soma = new Soma();
                    this.Subtracao = new Subtracao();
                    this.Multiplicacao = new Multiplicacao();
                    this.Divisao = new Divisao();
                }
            }


}




