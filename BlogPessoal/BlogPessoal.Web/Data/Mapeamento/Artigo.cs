namespace BlogPessoal.Web.Data.Mapeamento
{
    public class Artigo
    {
        public object Id { get; internal set; }
        public object Titulo { get; internal set; }
        public object Conteudo { get; internal set; }
        public object DataPublicacao { get; internal set; }
        public object CategoriaDeArtigoId { get; internal set; }
        public object AutorId { get; internal set; }
        public object CategoriaDeArtigo { get; internal set; }
        public object Autor { get; internal set; }
        public object Removido { get; internal set; }
    }
}