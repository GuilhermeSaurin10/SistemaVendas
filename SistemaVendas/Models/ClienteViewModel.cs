﻿using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class ClienteViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "Informe o nome do Cliente!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ/CPF do Cliente!")]
        public string CNPJ_CPF { get; set; }

        [Required(ErrorMessage = "Informe o Email do Cliente!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Celular do Cliente!")]
        public string Celular { get; set; }
    }
}