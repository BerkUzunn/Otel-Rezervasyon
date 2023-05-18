using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Newsletter
    {
        [Key]//ID i birincil anahtar yapmak için

        public int NewsletterID { get; set; }

        public int Mail { get; set; }
    }
}
