﻿using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id  { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
