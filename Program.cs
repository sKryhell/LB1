namespace LB1
{
    internal static class Program
    {
        
        [STAThread]
        // ћетод с которого начинаетс€ выполнение програмы 
        static void Main()
        {
            //обращаемс€ к ApplicationContext чтобы создать базу данных и таблици в ней 
            using (ApplicationContext db = new ApplicationContext())
            {
                // —оздаем и инициализируем обьекты user1, user2
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                //«аносим в данные в таблицу 
                db.Users.AddRange(user1, user2);
                //—охранение базы данных
                db.SaveChanges();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}