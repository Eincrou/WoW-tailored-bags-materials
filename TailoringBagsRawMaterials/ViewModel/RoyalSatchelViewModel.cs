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
    class RoyalSatchelViewModel : INotifyPropertyChanged
    {
        private RoyalSatchel _royalSatchel = new RoyalSatchel();
        //public int NumberOfBags;
        public string SatchelBagName { get { return _royalSatchel.BagName + "s :"; } }
        public string SatchelBagDescription { get { return _royalSatchel.Description; } }
        public string SatchelEnchantedName { get { return _royalSatchel.EnchantedClothName; } }
        public string SatchelBoltName { get { return _royalSatchel.BoltName; } }
        public string SatchelClothName { get { return _royalSatchel.ClothName; } }
        public BitmapImage SatchelEnchantedClothImage { get { return _royalSatchel.EnchantedClothImage; } }
        public BitmapImage SatchelBoltImage { get { return _royalSatchel.BoltImage; } }
        public BitmapImage SatchelClothImage { get { return _royalSatchel.ClothImage; } }
        public BitmapImage SatchelBagImage { get { return _royalSatchel.BagImage; } }

        private int _satchelEnchantedClothCount;
        public int SatchelEnchantedClothCount { get { return _satchelEnchantedClothCount; } }
        private int _satchelBoltCount;
        public int SatchelBoltCount { get { return _satchelBoltCount; } }
        private int _satchelClothCount;
        public int SatchelClothCount { get { return _satchelClothCount; } }
        
        public RoyalSatchelViewModel()
        {
            _satchelEnchantedClothCount = _royalSatchel.GetNumEnchantedCloth(1);
            _satchelBoltCount = _royalSatchel.GetNumBolts(1);
            _satchelClothCount = _royalSatchel.GetNumBasicCloth(1);
        }

        public void SatchelMaterials(int numBags)
        {
            _satchelEnchantedClothCount = _royalSatchel.GetNumEnchantedCloth(numBags);
            _satchelBoltCount = _royalSatchel.GetNumBolts(numBags);
            _satchelClothCount = _royalSatchel.GetNumBasicCloth(numBags);
            OnPropertyChanged("SatchelEnchantedClothCount");
            OnPropertyChanged("SatchelBoltCount");
            OnPropertyChanged("SatchelClothCount");
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
