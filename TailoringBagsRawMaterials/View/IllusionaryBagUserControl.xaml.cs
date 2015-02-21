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
    /// Interaction logic for IllusionaryBagViewModel.xaml
    /// </summary>
    public partial class IllusionaryBagUserControl : UserControl
    {
        ViewModel.IllusionaryBagViewModel viewModel;
        public IllusionaryBagUserControl()
        {
            InitializeComponent();

            viewModel = FindResource("viewModel") as ViewModel.IllusionaryBagViewModel;

            illusionaryBagIcon.Source = viewModel.IllusionaryBagImage;
            illusionaryEnchantedClothIcon.Source = viewModel.IllusionaryEnchantedClothImage;
            illusionaryBoltIcon.Source = viewModel.IllusionaryBoltImage;
            illusionaryClothIcon.Source = viewModel.IllusionaryClothImage;
        }

        private void illusionaryAmountInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            int bagsAmount;
            TextBox satchelAmountInput = sender as TextBox;
            if (int.TryParse(illusionaryAmountInput.Text, out bagsAmount))
            {
                if (bagsAmount <= 1000)
                {
                    satchelAmountInput.Background = new SolidColorBrush(Colors.White);
                    if (viewModel != null)
                        viewModel.IllusionaryMaterials(bagsAmount);
                }
                else
                    satchelAmountInput.Background = new SolidColorBrush(Colors.LightYellow);
            }
            else
                satchelAmountInput.Background = new SolidColorBrush(Colors.LightPink);
        }
    }
}
