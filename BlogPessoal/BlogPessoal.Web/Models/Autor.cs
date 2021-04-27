using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "O e-mail informado é inválido")]

        public string Email  { get; set; }
        [DataType(DataType.Password)]

        public string  Senha { get; set; }

        public bool Administrador { get; set; }
        [Display(Name = "Data de Cadastro")]

        public DateTime DataDeCadastro { get; set; }

        public virtual ICollection<Artigo> Artigos { get; set; }

    }
}