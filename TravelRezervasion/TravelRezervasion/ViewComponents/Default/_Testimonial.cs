using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelRezervasion.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialMenager testimonialMenager = new TestimonialMenager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialMenager.TGetList();

            return View(values);
        }
    }
}
