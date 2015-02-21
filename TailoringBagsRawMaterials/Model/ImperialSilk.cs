using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class ImperialSilk : ClothBolt
    {
        public const string EnchantedClothName = "Imperial Silk";
        public const int NumBoltsForEnchanted = 8;
        public BitmapImage EnchantedClothImage = new BitmapImage(new Uri("/Resources/inv_fabric_imperialsilk.jpg", UriKind.RelativeOrAbsolute));
        public ImperialSilk()
        {
            this.BoltName = "Bolt of Windwool Cloth";
            this.ClothName = "Windwool Cloth";
            this.NumClothForBolt = 5;
            this.Expansion = "Mists of Pandaria";
            this.BoltImage = new BitmapImage(new Uri("/Resources/inv_fabric_windwool_bolt.jpg", UriKind.RelativeOrAbsolute));
            this.ClothImage = new BitmapImage(new Uri("/Resources/inv_fabric_windwool.jpg", UriKind.RelativeOrAbsolute));
        }
    }
}
