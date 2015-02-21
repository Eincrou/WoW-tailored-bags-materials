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
    /// Interaction logic for GlacialBagUserControl.xaml
    /// </summary>
    public partial class GlacialBagUserControl : UserControl
    {
        ViewModel.GlacialBagViewModel viewModel;
        public GlacialBagUserControl()
        {
            InitializeComponent();

            viewModel = FindResource("viewModel") as ViewModel.GlacialBagViewModel;

            glacialBagIcon.Source = viewModel.GlacialBagImage;
            glacialEnchantedClothOneIcon.Source = viewModel.GlacialEnchantedClothOneImage;
            glacialEnchantedClothTwoIcon.Source = viewModel.GlacialEnchantedClothTwoImage;
            glacialImbuedIcon.Source = viewModel.GlacialImbuedImage;
            glacialBoltIcon.Source = viewModel.GlacialBoltImage;
            glacialClothIcon.Source = viewModel.GlacialClothImage;
        }
        private void glacialAmountInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            int bagsAmount;
            TextBox satchelAmountInput = sender as TextBox;
            if (int.TryParse(glacialAmountInput.Text, out bagsAmount))
            {
                if (bagsAmount <= 1000)
                {
                    satchelAmountInput.Background = new SolidColorBrush(Colors.White);
                    if (viewModel != null)
                        viewModel.GlacialMaterials(bagsAmount);
                }
                else
                    satchelAmountInput.Background = new SolidColorBrush(Colors.LightYellow);
            }
            else
                satchelAmountInput.Background = new SolidColorBrush(Colors.LightPink);
        }
    }
}
