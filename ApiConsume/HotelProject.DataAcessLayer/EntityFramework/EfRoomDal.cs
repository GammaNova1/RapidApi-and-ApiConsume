using HotelProject.DataAcessLayer.Abstract;
using HotelProject.DataAcessLayer.Concrete;
using HotelProject.DataAcessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAcessLayer.EntityFramework
{
	public class EfRoomDal:GenericRepository<Room>, IRoomDal
	{
		public EfRoomDal(Context context) : base(context)
		{
		
		}
	}
}
