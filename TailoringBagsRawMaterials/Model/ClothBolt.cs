using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    abstract class ClothBolt
    {
        public string BoltName { get; protected set; }
        public string ClothName { get; protected set; }
        public int NumClothForBolt { get; protected set; }
        public string Expansion { get; protected set; }
        public BitmapImage BoltImage { get; protected set; }
        public BitmapImage ClothImage { get; protected set; }

        public override string ToString()
        {
            return BoltName;
        }
    }
}
