﻿using System.Collections.Generic;

namespace Web.UI.Models
{
    public class Produto
    {
        public long Id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(200, MinimumLength = 2)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }

        public string DescricaoProduto { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime? DataValidade { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public decimal Valor { get; set; }

        public string MarcaId { get; set; }
        public Marca Marca { get; set; }

        public long SetorId { get; set; }
        public Setor Setor { get; set; }

        public long FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }

        //public long? LojaId { get; set; }
        //public Loja Loja { get; set; }
        
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}