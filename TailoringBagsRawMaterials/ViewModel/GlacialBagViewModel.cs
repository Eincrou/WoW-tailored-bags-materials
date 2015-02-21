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
    class GlacialBagViewModel : INotifyPropertyChanged
    {
        private GlacialBag _glacialBag = new GlacialBag();
        //public int NumberOfBags;
        public string GlacialBagName { get { return _glacialBag.BagName + "s :"; } }
        public string GlacialBagDescription { get { return _glacialBag.Description; } }

        public string GlacialEnchantedClothOneName { get { return _glacialBag.EnchantedClothOneName; } }
        public string GlacialEnchantedOneMaterialName { get { return _glacialBag.EnchantedClothOneMaterialOneName; } }
        public string GlacialEnchantedClothTwoName { get { return _glacialBag.EnchantedClothTwoName; } }
        public string GlacialEnchantedTwoMaterialName { get { return _glacialBag.EnchantedClothTwoMaterialOneName; } }
        public string GlacialImbuedName { get { return _glacialBag.ImbuedClothName; } }
        public string GlacialBoltName { get { return _glacialBag.BoltName; } }
        public string GlacialClothName { get { return _glacialBag.ClothName; } }

        public BitmapImage GlacialEnchantedClothOneImage { get { return _glacialBag.EnchantedClothOneImage; } }
        public BitmapImage GlacialEnchantedClothOneMaterialOneImage { get { return _glacialBag.EnchantedClothOneMaterialOneImage; } }
        public BitmapImage GlacialEnchantedClothTwoMaterialOneImage { get { return _glacialBag.EnchantedClothTwoMaterialOneImage; } }
        public BitmapImage GlacialEnchantedClothTwoImage { get { return _glacialBag.EnchantedClothTwoImage; } }
        public BitmapImage GlacialImbuedImage { get { return _glacialBag.ImbuedClothImage; } }
        public BitmapImage GlacialBoltImage { get { return _glacialBag.BoltImage; } }
        public BitmapImage GlacialClothImage { get { return _glacialBag.ClothImage; } }
        public BitmapImage GlacialBagImage { get { return _glacialBag.BagImage; } }

        private int _glacialEnchantedClothOneCount;
        public int GlacialEnchantedClothOneCount { get { return _glacialEnchantedClothOneCount; } }
        private int _glacialEnchantedClothTwoCount;
        public int GlacialEnchantedClothTwoCount { get { return _glacialEnchantedClothTwoCount; } }
        private int _glacialImbuedCount;
        public int GlacialImbuedCount { get { return _glacialImbuedCount; } }
        private int _glacialBoltCount;
        public int GlacialBoltCount { get { return _glacialBoltCount; } }
        private int _glacialClothCount;
        public int GlacialClothCount { get { return _glacialClothCount; } }

        public GlacialBagViewModel()
        {
            _glacialEnchantedClothOneCount = _glacialBag.GetNumEnchantedCloth(1);
            _glacialEnchantedClothTwoCount = _glacialBag.GetNumEnchantedCloth(1);
            _glacialImbuedCount = _glacialBag.GetNumImbuedCloth(1);
            _glacialBoltCount = _glacialBag.GetNumBolts(1);
            _glacialClothCount = _glacialBag.GetNumBasicCloth(1);
        }

        public void GlacialMaterials(int numBags)
        {
            _glacialEnchantedClothOneCount = _glacialBag.GetNumEnchantedCloth(numBags);
            _glacialEnchantedClothTwoCount = _glacialBag.GetNumEnchantedCloth(numBags);
            _glacialImbuedCount = _glacialBag.GetNumImbuedCloth(numBags);
            _glacialBoltCount = _glacialBag.GetNumBolts(numBags);
            _glacialClothCount = _glacialBag.GetNumBasicCloth(numBags);
            OnPropertyChanged("GlacialEnchantedClothOneCount");
            OnPropertyChanged("GlacialEnchantedClothTwoCount");
            OnPropertyChanged("GlacialImbuedCount");
            OnPropertyChanged("GlacialBoltCount");
            OnPropertyChanged("GlacialClothCount");
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
