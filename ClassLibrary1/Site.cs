using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1
{
   public class Site
    {

        [Key]
        public int SiteID { get; set; }
      

        public string SiteName { get; set; }
    }
}
