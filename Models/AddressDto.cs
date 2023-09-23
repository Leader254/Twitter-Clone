using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.Models
{
    public class AddressDto
    {
        public string street { get; set; } // street address
        public string suite { get; set; } // suite address
        public string city { get; set; } // city address
        public string zipcode { get; set; } // zipcode address
        public GeoDto? geo { get; set; } // geo location  
    }
}