using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AluguelVeiculo.ViewModel
{
    // É o que o usuário vai mandar pro
    // seu programa
    public class VeiculoViewModel
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Marcar { get; set; }
    }
}
