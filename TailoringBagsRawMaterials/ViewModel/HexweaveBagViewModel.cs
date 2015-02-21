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
    class HexweaveBagViewModel : INotifyPropertyChanged
    {
        private HexweaveBag _hexweaveBag = new HexweaveBag();
        //public int NumberOfBags;
        public string HexBagName { get { return _hexweaveBag.BagName + "s :"; } }
        public string HexBagDescription { get { return _hexweaveBag.Description; } }
        public string HexBoltName { get { return _hexweaveBag.BoltName; } }
        public string HexClothName { get { return _hexweaveBag.ClothName; } }
        public BitmapImage HexBoltImage { get { return _hexweaveBag.BoltImage; } }
        public BitmapImage HexClothImage { get { return _hexweaveBag.ClothImage; } }
        public BitmapImage HexBagImage { get { return _hexweaveBag.BagImage; } }

        private int _hexBoltCount;
        public int HexBoltCount { get { return _hexBoltCount; } }
        private int _hexClothCount;
        public int HexClothCount { get { return _hexClothCount; } }
        public HexweaveBagViewModel()
        {
            _hexBoltCount = _hexweaveBag.GetNumBolts(1);
            _hexClothCount = _hexweaveBag.GetNumBasicCloth(1);
        }

        public void HexweaveMaterials(int numBags)
        {
            _hexBoltCount = _hexweaveBag.GetNumBolts(numBags);
            _hexClothCount = _hexweaveBag.GetNumBasicCloth(numBags);
            OnPropertyChanged("HexBoltCount");
            OnPropertyChanged("HexClothCount");
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
