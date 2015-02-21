using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.ViewModel
{
    using Model;
    using System.ComponentModel;
    using System.Windows.Media.Imaging;
    class IllusionaryBagViewModel : INotifyPropertyChanged
    {
        private IllusionaryBag _illusionaryBag = new IllusionaryBag();
        //public int NumberOfBags;
        public string IllusionaryBagName { get { return _illusionaryBag.BagName + "s :"; } }
        public string IllusionaryBagDescription { get { return _illusionaryBag.Description; } }
        public string IllusionaryEnchantedName { get { return _illusionaryBag.EnchantedClothName; } }
        public string IllusionaryBoltName { get { return _illusionaryBag.BoltName; } }
        public string IllusionaryClothName { get { return _illusionaryBag.ClothName; } }
        public BitmapImage IllusionaryEnchantedClothImage { get { return _illusionaryBag.EnchantedClothImage; } }
        public BitmapImage IllusionaryBoltImage { get { return _illusionaryBag.BoltImage; } }
        public BitmapImage IllusionaryClothImage { get { return _illusionaryBag.ClothImage; } }
        public BitmapImage IllusionaryBagImage { get { return _illusionaryBag.BagImage; } }

        private int _illusionaryEnchantedClothCount;
        public int IllusionaryEnchantedClothCount { get { return _illusionaryEnchantedClothCount; } }
        private int _illusionaryBoltCount;
        public int IllusionaryBoltCount { get { return _illusionaryBoltCount; } }
        private int _illusionaryClothCount;
        public int IllusionaryClothCount { get { return _illusionaryClothCount; } }

        public IllusionaryBagViewModel()
        {
            _illusionaryEnchantedClothCount = _illusionaryBag.GetNumEnchantedCloth(1);
            _illusionaryBoltCount = _illusionaryBag.GetNumBolts(1);
            _illusionaryClothCount = _illusionaryBag.GetNumBasicCloth(1);
        }

        public void IllusionaryMaterials(int numBags)
        {
            _illusionaryEnchantedClothCount = _illusionaryBag.GetNumEnchantedCloth(numBags);
            _illusionaryBoltCount = _illusionaryBag.GetNumBolts(numBags);
            _illusionaryClothCount = _illusionaryBag.GetNumBasicCloth(numBags);
            OnPropertyChanged("IllusionaryEnchantedClothCount");
            OnPropertyChanged("IllusionaryBoltCount");
            OnPropertyChanged("IllusionaryClothCount");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
