using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class RoyalSatchel : TailoredBag
    {
        public string EnchantedClothName { get { return ImperialSilk.EnchantedClothName; } }
        public BitmapImage EnchantedClothImage { get { return ((ImperialSilk)bolt).EnchantedClothImage; } }
        public RoyalSatchel()
        {
            bolt = new ImperialSilk();
            Capacity = 28;
            BoltsRequiredToCraft = 12;
            SkillRequired = 600;
            BagName = "Royal Satchel";
            BagImage = new BitmapImage(
                new Uri("/Resources/inv_misc_bag_31.jpg", 
                    UriKind.RelativeOrAbsolute));
        }
        public int GetNumEnchantedCloth(int numBags)
        {
            return BoltsRequiredToCraft * numBags;
        }
        public override int GetNumBolts(int numBags)
        {
            return BoltsRequiredToCraft * ImperialSilk.NumBoltsForEnchanted * numBags;
        }
        public override int GetNumBasicCloth(int numBags)
        {
            return BoltsRequiredToCraft * ImperialSilk.NumBoltsForEnchanted * bolt.NumClothForBolt * numBags;
        }
    }
}
