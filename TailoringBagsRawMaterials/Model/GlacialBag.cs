using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class GlacialBag : TailoredBag
    {
        private Ebonweave _boltTwo = new Ebonweave();
        public string EnchantedClothOneName { get { return Moonshroud.EnchantedClothName; } }
        public BitmapImage EnchantedClothOneImage { get { return ((Moonshroud)bolt).EnchantedClothImage; } }
        public string EnchantedClothOneMaterialOneName { get { return Moonshroud.EnchantedMaterialOneName; } }
        public BitmapImage EnchantedClothOneMaterialOneImage { get { return ((Moonshroud)bolt).EnchantedMaterialOneImage; } }

        public string EnchantedClothTwoName { get { return Ebonweave.EnchantedClothName; } }
        public BitmapImage EnchantedClothTwoImage { get { return _boltTwo.EnchantedClothImage; } }
        public string EnchantedClothTwoMaterialOneName { get { return Ebonweave.EnchantedMaterialOneName; } }
        public BitmapImage EnchantedClothTwoMaterialOneImage { get { return _boltTwo.EnchantedMaterialOneImage; } }

        public string ImbuedClothName { get { return Ebonweave.ImbuedClothName; } }
        public BitmapImage ImbuedClothImage { get { return _boltTwo.ImbuedClothImage; } }

        public GlacialBag()
        {
            bolt = new Moonshroud();
            Capacity = 22;
            BoltsRequiredToCraft = 4;
            SkillRequired = 525;
            BagName = "Glacial Bag";
            BagImage = new BitmapImage(new Uri("/Resources/Inv_misc_bag_enchantedrunecloth.png", UriKind.RelativeOrAbsolute));
        }

        public int GetNumEnchantedCloth(int numBags)
        {
            return BoltsRequiredToCraft * numBags;
        }
        public int GetNumImbuedCloth(int numBags)
        {
            return Moonshroud.NumImbuedForEnchanted * GetNumEnchantedCloth(numBags) * 2;
        }
        public override int GetNumBolts(int numBags)
        {
            return Moonshroud.NumBoltsForImbued * GetNumImbuedCloth(numBags);
        }
        public override int GetNumBasicCloth(int numBags)
        {
            return bolt.NumClothForBolt * GetNumBolts(numBags);
        }
    }
}
