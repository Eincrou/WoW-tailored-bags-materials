using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TailoringBagsRawMaterials.View
{
    /// <summary>
    /// Interaction logic for RoyalSatchelUserControl.xaml
    /// </summary>
    public partial class RoyalSatchelUserControl : UserControl
    {
        ViewModel.RoyalSatchelViewModel viewModel;
        public RoyalSatchelUserControl()
        {
            InitializeComponent();

            viewModel = FindResource("viewModel") as ViewModel.RoyalSatchelViewModel;

            satchelBagIcon.Source = viewModel.SatchelBagImage;
            satchelEnchantedClothIcon.Source = viewModel.SatchelEnchantedClothImage;
            satchelBoltIcon.Source = viewModel.SatchelBoltImage;
            satchelClothIcon.Source = viewModel.SatchelClothImage;
        }

        private void satchelAmountInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            int bagsAmount;
            TextBox satchelAmountInput = sender as TextBox;
            if (int.TryParse(satchelAmountInput.Text, out bagsAmount))
            {
                satchelAmountInput.Background = new SolidColorBrush(Colors.White);
                if (viewModel != null)
                    viewModel.SatchelMaterials(bagsAmount);
            }
            else
                satchelAmountInput.Background = new SolidColorBrush(Colors.LightPink);
        }
    }
}
