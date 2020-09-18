using System;
using System.Collections.Generic;

namespace PartyInvites.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string NameAscii { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lon { get; set; }
        public int CountryId { get; set; }
    }
}
