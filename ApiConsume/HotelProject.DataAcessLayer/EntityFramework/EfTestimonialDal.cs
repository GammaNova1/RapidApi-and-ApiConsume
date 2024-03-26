using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAcessLayer.Abstract;
using HotelProject.DataAcessLayer.Concrete;
using HotelProject.DataAcessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
namespace HotelProject.DataAcessLayer.EntityFramework
{
	public class EfTestimonialDal:GenericRepository<Testimonial>, ITestimonialDal
	{
        public EfTestimonialDal(Context context) : base(context)
        {
            
        }
    }
}
