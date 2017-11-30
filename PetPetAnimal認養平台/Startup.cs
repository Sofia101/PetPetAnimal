using Microsoft.Owin;
using Owin;
using PetPetAnimal認養平台;

[assembly: OwinStartupAttribute(typeof(PetPetAnimal認養平台.Startup))]
namespace PetPetAnimal認養平台
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
