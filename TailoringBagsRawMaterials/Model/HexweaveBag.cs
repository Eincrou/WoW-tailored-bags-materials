using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class HexweaveBag : TailoredBag
    {
        public HexweaveBag()
        {
            bolt = new HexweaveBolt();
            Capacity = 30;
            BoltsRequiredToCraft = 100;
            SkillRequired = 1;
            BagName = "Hexweave Bag";
            BagImage = new BitmapImage(new Uri("/Resources/inv_tailoring_hexweavebag.jpg", UriKind.RelativeOrAbsolute));
        }
    }
}
