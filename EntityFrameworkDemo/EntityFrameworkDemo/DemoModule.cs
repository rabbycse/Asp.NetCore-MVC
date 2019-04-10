using Autofac;
using Autofac.Core;

namespace EntityFrameworkDemo
{
    internal class DemoModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<DemoContext>();
        }
    }
}