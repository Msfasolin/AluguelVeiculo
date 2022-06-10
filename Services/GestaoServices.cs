using AluguelVeiculo.Respository;
using AluguelVeiculo.Models;
using AluguelVeiculo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelVeiculo.Services
{
    public class GestaoServices
    {
        private List<Veiculo> _listaVeiculos =
            Armazenamento.Veiculos;


        public Veiculo CadastrarVeiculo(VeiculoViewModel veiculoRecebido)
        {
            Veiculo veiculo = new Veiculo(veiculoRecebido);

            
            veiculo.Modelo = veiculoRecebido.Modelo;
            veiculo.Ano = veiculoRecebido.Ano;
            veiculo.Marcar = veiculoRecebido.Marcar;
           

            _listaVeiculos.Add(veiculo);

            return veiculo;
        }
 

        public List<object> ListarItens()
        {
            List<object> nomeQualquer =
                new List<object>();

            nomeQualquer.AddRange(_listaVeiculos);


            return nomeQualquer;
        }
    }
}
