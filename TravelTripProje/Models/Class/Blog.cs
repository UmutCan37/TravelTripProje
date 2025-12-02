using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Class
{
	public class Blog
	{
        [Key]
        public int ID { get; set; }

        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        public string Acıklama { get; set; }

        public string BlogImage { get; set; }

        public ICollection<Yorum> Yorums { get; set; }

}
}