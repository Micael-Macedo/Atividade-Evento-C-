using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_1
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        private double? valor;
        public double? Valor
        {
            get{
                return valor;
            }
        }
        public bool Gratuito { get; set; }
        private ICollection<Pessoa> pessoas;
        public ICollection<Pessoa> Pessoas
        {
            get
            {
                return pessoas;
            }
            set
            {
                ICollection<Pessoa> newPessoas = value;
                if (newPessoas.Count <= 20)
                {
                    this.pessoas = newPessoas;
                }
                else
                {
                    throw new ArgumentException("Quantidade de pessoas excedida");
                }
            }
        }

        public void AvaliarGratuidade(double? valor)
        {
            if (!Gratuito)
            {
                if (valor != null)
                {
                    this.valor = valor;
                }
                else
                {
                    throw new ArgumentException("É preciso passar o valor");
                }
            }
            else
            {
                this.valor = 0;
            }
        }

    }
}