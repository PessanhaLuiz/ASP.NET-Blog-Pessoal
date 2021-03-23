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

        public DateTime data_publicacao { get; set; }

        public int categoria_artigo_id { get; set; }

        public int autor_id { get; set; }

        public bool Removido { get; set; }
    }
}