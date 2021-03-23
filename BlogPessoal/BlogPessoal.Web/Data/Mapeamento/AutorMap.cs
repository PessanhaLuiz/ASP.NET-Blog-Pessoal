using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("autor", "dbo");

            HasKey(t => t.Id);

            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("Nome");
            Property(x => x.Email).IsRequired().HasMaxLength(150).HasColumnName("Email");
            Property(x => x.Senha).IsRequired().HasMaxLength(50).HasColumnName("Senha");
            
        }

    }
}