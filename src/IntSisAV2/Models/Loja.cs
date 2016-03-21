using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntSisAV2.Models
{
    public class Loja
    {
        [ScaffoldColumn(false)]
        public int LojaID { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
