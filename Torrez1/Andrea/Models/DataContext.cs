namespace Andrea.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
{
    public DataContext() : base("DefaultConnection")
    {

    }

    public System.Data.Entity.DbSet<Andrea.Models.Fairy> Fairies { get; set; }
}
}