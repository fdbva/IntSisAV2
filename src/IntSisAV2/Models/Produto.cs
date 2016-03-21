using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntSisAV2.Models
{
    public class Produto
    {
        [ScaffoldColumn(false)]
        public int ProdutoID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public int Quantidade { get; set; }

        [ScaffoldColumn(false)]
        public int AuthorID { get; set; }

        // Navigation property
        public virtual Loja Loja { get; set; }
    }
}
