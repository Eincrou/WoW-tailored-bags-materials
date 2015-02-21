using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class Moonshroud : ClothBolt
    {
        public const string EnchantedClothName = "Moonshroud";
        public const string EnchantedMaterialOneName = "Eternal Life";
        public const int NumImbuedForEnchanted = 1;
        public const int NumEnchantedMaterialOne = 2;

        public const string ImbuedClothName = "Bolt of Imbued Frostweave";
        public const int NumBoltsForImbued = 2;
        public const string ImbuedMaterialOneName = "Infinite Dust";
        public const int NumImbuedMaterialOne = 2;        
        
        public BitmapImage EnchantedClothImage = new BitmapImage(
            new Uri("/Resources/Inv_fabric_moonshroud.png", 
                UriKind.RelativeOrAbsolute));
        public BitmapImage ImbuedClothImage = new BitmapImage(
            new Uri("/Resources/Inv_fabric_frostweave_imbuedbolt.png",
                UriKind.RelativeOrAbsolute));
        public BitmapImage EnchantedMaterialOneImage = new BitmapImage(
                    new Uri("/Resources/Inv_elemental_eternal_life.png",
                        UriKind.RelativeOrAbsolute));
        public BitmapImage ImbuedMaterialOne = new BitmapImage(
            new Uri("/Resources/Inv_misc_dust_infinite.png",
                UriKind.RelativeOrAbsolute));
        public Moonshroud()
        {
            this.BoltName = "Bolt of Frostweave";
            this.ClothName = "Frostweave Cloth";
            this.NumClothForBolt = 5;
            this.Expansion = "Wrath of the Lich King";
            this.BoltImage = new BitmapImage(
                new Uri("/Resources/Inv_fabric_frostweave_bolt.png", 
                    UriKind.RelativeOrAbsolute));
            this.ClothImage = new BitmapImage(
                new Uri("/Resources/Inv_fabric_soulcloth.png", 
                    UriKind.RelativeOrAbsolute));
        }
    }
}
