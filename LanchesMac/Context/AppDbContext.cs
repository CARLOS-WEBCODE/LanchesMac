using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context;

public class AppDbContext : DbContext
{
    //A classe DbContextOptions, define as opções a serem usadas pelo DbContext.
    //e ela vai carregar as informações de configurações necessárias para configurar o DbContext
    //então não vamos precisar definir nada, pois será feito pelo construtor do DbContext
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    //Agora vamos definir as propriedades DbSet, ela vai definir quais classes eu quero mapear para quais tabelas
    //O nome das propriedades de cada DbSet "Categorias" e "Lanches", define o nome da tabela que o EntityFrameworkCore, vai criar
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }
    public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }

}
