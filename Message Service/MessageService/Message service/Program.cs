using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Message_service
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        /// <param name="args">Параметры запуска.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Создание объекта типа "IHostBuilder", используемого для настройки "TestServer".
        /// </summary>
        /// <param name="args">Аргументы.</param>
        /// <returns>Объект типа "IHostBuilder, используемый для дальнейшего взаимодействия с программой."</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
