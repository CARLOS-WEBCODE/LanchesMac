namespace LanchesMac.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string CategoriaNome { get; set; }
    public string Descricao { get; set; }

    //Definir o relacionamento de 1 para muitos
    //Uma categoria possui muitos lanches
    public List<Lanche> Lanches { get; set; }
}
