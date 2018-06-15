using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Time
    {
        //prop tab tab
        public string Nome {get; set;}
        public int QuantidadeGolsFeito { get; set; }
        public string Pais { get; set; }
        public int QuantidadeGolsSofridos { get; set; }
        public int QuantidadesCartaoAmarelo { get; set; }
        public int QuantidadesCartaoVermelho { get; set; }
        public int QuantidadesDeSubstituicoes { get; set; }
        public int QuantidadesFinais { get; set; }
        public int QuantidadeVitorias { get; set; }
        public int QuantidadeDerrotas { get; set; }
        public decimal Faturamento { get; set; }
        public string Serie { get; set; }

        public Time(string nome, string pais, string serie)
        {
            Nome = nome;
            Pais = pais;
            Serie = serie;
        }

        public Time(string nome, string pais) // dois construtores nao podem ter os mesmo tipos string string
        {
            Nome = nome;
            Pais = pais;
        }


    }
}
