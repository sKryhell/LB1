using Microsoft.EntityFrameworkCore;

namespace LB1
{
    //Контекст преднозначен для подключения к базе данных 
    internal class ApplicationContext: DbContext    
    {
        //Свойство Users позволяет контексту работать с таблицей Users
        public DbSet<User> Users { get; set; } = null; 

        public ApplicationContext()
        {
            // Создает базу данных и таблицы в ней 
            Database.EnsureCreated();
        }

        // OnConfiguring этот метод содержит настройки для подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=1111");
        }
    }
}
