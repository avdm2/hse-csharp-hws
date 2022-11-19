using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Message_service
{
    /// <summary>
    /// �������� ����� ���������.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// ����� �����.
        /// </summary>
        /// <param name="args">��������� �������.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// �������� ������� ���� "IHostBuilder", ������������� ��� ��������� "TestServer".
        /// </summary>
        /// <param name="args">���������.</param>
        /// <returns>������ ���� "IHostBuilder, ������������ ��� ����������� �������������� � ����������."</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
