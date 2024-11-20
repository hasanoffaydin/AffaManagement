using AffaManagement.Entity;
using Microsoft.EntityFrameworkCore;


namespace AffaManagement.DataBase
{
    internal class DbHelper : DbContext
    {
        string connectionString = "Data Source=HASANOV\\SQLEXPRESS;Initial Catalog=Affa;Integrated Security=True;TrustServerCertificate=True;";


        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ResultGame> ResultGames { get; set; }
        public DbSet<Game> Games { get; set; }
        //public DbSet<TurnirCedveli> TurnirCedvelis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString); 
        }
    }
}
