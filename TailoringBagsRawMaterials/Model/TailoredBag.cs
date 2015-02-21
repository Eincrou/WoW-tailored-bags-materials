using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    abstract class TailoredBag
    {
        protected ClothBolt bolt;
        public string BagName { get; protected set; }
        public string BoltName { get { return bolt.BoltName; } }
        public string ClothName { get { return bolt.ClothName; } }
        public int BoltsRequiredToCraft { get; protected set; }

        public int Capacity { get; protected set; }
        public string Description { get { return Capacity + "-slot bag (" + Expansion + ")"; } }
        public int SkillRequired { get; protected set; }
        public string Expansion { get { return bolt.Expansion; } }

        public BitmapImage BoltImage { get { return bolt.BoltImage; } }
        public BitmapImage ClothImage { get { return bolt.ClothImage; } }
        public BitmapImage BagImage { get; protected set; }

        public virtual int GetNumBolts(int numBags)
        {
            return numBags * BoltsRequiredToCraft;
        }
        public virtual int GetNumBasicCloth(int numBags)
        {
            return numBags * BoltsRequiredToCraft * bolt.NumClothForBolt;
        }
        public TailoredBag() { }
        public override string ToString()
        {
            return BagName;
        }
    }
}
