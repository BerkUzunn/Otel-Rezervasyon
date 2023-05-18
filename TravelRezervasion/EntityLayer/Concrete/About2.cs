using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About2
    {
        [Key]//ID i birincil anahtar yapmak için

        public int AboutID2 { get; set; }

        public string Title1 { get; set; }

        public string Title2 { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }



    }
}
