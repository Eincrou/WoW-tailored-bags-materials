using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringBagsRawMaterials.Model
{
    using System.Windows.Media.Imaging;
    class HexweaveBolt : ClothBolt
    {        
        public HexweaveBolt()
        {
            this.BoltName = "Hexweave Cloth";
            this.ClothName = "Sumptuous Fur";
            this.NumClothForBolt = 2;
            this.Expansion = "Warlords of Draenor";
            this.BoltImage = new BitmapImage(new Uri("/Resources/inv_tailoring_hexweavethread.jpg", UriKind.RelativeOrAbsolute));
            this.ClothImage = new BitmapImage(new Uri("/Resources/inv_misc_nativebeastfur.jpg", UriKind.RelativeOrAbsolute));      
           // this.ClothImage = "pack://application:,,,/Resources/inv_misc_nativebeastfur.jpg";                
        }
    }
}
