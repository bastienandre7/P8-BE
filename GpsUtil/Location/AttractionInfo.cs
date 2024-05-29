using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpsUtil.Location
{
    public class AttractionInfo
    {
        public string Name { get; set; }
        public double Distance {  get; set; }
        public Locations Location { get; set; }
        public Locations UserLocation { get; set; }
        public int RewardPoints { get; set; }
    }
}
