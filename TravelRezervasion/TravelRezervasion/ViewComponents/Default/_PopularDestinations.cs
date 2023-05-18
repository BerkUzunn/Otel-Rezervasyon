using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Concrete;

namespace TravelRezervasion.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();

            return View(values);
        }
    }
}
