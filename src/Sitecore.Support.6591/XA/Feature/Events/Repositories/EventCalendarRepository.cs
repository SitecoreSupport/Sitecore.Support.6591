using Sitecore.Support.XA.Feature.Events.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;

namespace Sitecore.Support.XA.Feature.Events.Repositories
{
    public class EventCalendarRepository : Sitecore.XA.Feature.Events.Repositories.EventCalendarRepository
    {
        public override IRenderingModelBase GetModel()
        {
            EventCalendarRenderingModel renderingModel = new EventCalendarRenderingModel();
            this.FillBaseProperties(renderingModel);
            renderingModel.JsonDataProperties = this.GetJsonDataProperties();
            renderingModel.Id = Guid.NewGuid().ToString();
            return renderingModel;
        }
    }
}