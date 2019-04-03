using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetDependencyDemo.Models
{
    public class RepositoryHandlerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register<UserData>(z => new UserData()).AsSelf();
            builder.Register<Membership>(x => new Membership(x.Resolve<UserData>())).As<IMembership>();
        }
    }
}
