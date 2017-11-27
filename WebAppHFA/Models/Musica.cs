using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppHFA.Models
{
    public class Musica
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titulo é obrigatorio")]
        public string Titulo { get; set; }
        public Categoria Categoria { get; set; }
        public TipoMidia TipoMidia { get; set; }
        public DateTime DataCadastro { get; set; }



    }
}