using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class Dreamcloth : ClothBolt
    {
        public const string EnchantedClothName = "Dreamcloth";
        public const int NumBoltsForEnchanted = 8;
        public BitmapImage EnchantedClothImage = new BitmapImage(
            new Uri("/Resources/inv_chest_cloth_57.jpg", UriKind.RelativeOrAbsolute));
        public Dreamcloth()
        {
            this.BoltName = "Bolt of Embersilk Cloth";
            this.ClothName = "Embersilk Cloth";
            this.NumClothForBolt = 5;
            this.Expansion = "Cataclysm";
            this.BoltImage = new BitmapImage(
                new Uri("/Resources/inv_misc_emberweavecloth_01.jpg", UriKind.RelativeOrAbsolute));
            this.ClothImage = new BitmapImage(
                new Uri("/Resources/inv_misc_emberweaveclothbolt_01.jpg", UriKind.RelativeOrAbsolute));
        }
    }
}
