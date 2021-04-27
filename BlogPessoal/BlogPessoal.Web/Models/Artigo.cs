using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class Artigo
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataPublicacao { get; set; }

        public int CategoriaDeArtigoId { get; set; }

        public int AutorId { get; set; }

        public bool Removido { get; set; }

        public virtual CategoriaDeArtigo CategoriaDeArtigo { get; set; }

        public virtual Autor Autor { get; set; }
    }
}