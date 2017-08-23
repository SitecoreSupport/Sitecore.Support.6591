using Microsoft.Extensions.DependencyInjection;
using Sitecore.XA.Feature.Events.Repositories;
using Sitecore.XA.Foundation.IOC.Pipelines.IOC;

namespace Sitecore.Support.XA.Feature.Events.Pipelines.IoC
{
    public class RegisterEventsServices : IocProcessor
    {
        public override void Process(IocArgs args)
        {
            args.ServiceCollection.AddTransient<IEventCalendarRepository, Sitecore.Support.XA.Feature.Events.Repositories.EventCalendarRepository>();
            args.ServiceCollection.AddTransient<IEventListRepository, EventListRepository>();
        }
    }
}