using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Class
{
	public class Yorum
	{
		public int ID { get; set; }

		public string KullaniciAdi { get; set; }

		public string Mail { get; set; }

		public string Yorumlar { get; set; }

		public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }

    }
}