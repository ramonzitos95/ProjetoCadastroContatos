using ApiContato.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace ApiContato.Injection
{
    public class ServiceCollection
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
    }
}
