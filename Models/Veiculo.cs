using AluguelVeiculo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelVeiculo.Models
{
    public class Veiculo : Item
    {
       

        public Veiculo(VeiculoViewModel veiculoRecebido)
        {
            Modelo = veiculoRecebido.Modelo;
            Ano = veiculoRecebido.Ano;
            Marcar = veiculoRecebido.Marcar;
            IdVeiculo = Guid.NewGuid();
        }


        public Guid IdVeiculo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Marcar { get; set; }



    }
}
