using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class IllusionaryBag : TailoredBag
    {
        public string EnchantedClothName { get { return Dreamcloth.EnchantedClothName; } }
        public BitmapImage EnchantedClothImage { get { return ((Dreamcloth)bolt).EnchantedClothImage; } }
        public IllusionaryBag()
        {
            bolt = new Dreamcloth();
            Capacity = 26;
            BoltsRequiredToCraft = 8;
            SkillRequired = 525;
            BagName = "Illusionary Bag";
            BagImage = new BitmapImage(
                new Uri("/Resources/inv_misc_bag_37.jpg", UriKind.RelativeOrAbsolute));
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
