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
    /// Interaction logic for BagUserControl.xaml
    /// </summary>
    public partial class HexweaveBagUserControl : UserControl
    {
        ViewModel.HexweaveBagViewModel viewModel;
        public HexweaveBagUserControl()
        {
            InitializeComponent();

            viewModel = FindResource("viewModel") as ViewModel.HexweaveBagViewModel;

        //    hexweaveBagIcon.Source = viewModel.HexBagImage;
         //   hexweaveBoltIcon.Source = viewModel.HexBoltImage;
        //    hexweaveClothIcon.Source = viewModel.HexClothImage;
        }

        private void hexweaveAmountInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            int bagsAmount;
            TextBox hexweaveAmountInput = sender as TextBox;
            if (int.TryParse(hexweaveAmountInput.Text, out bagsAmount))
            {
                if (bagsAmount <= 1000)
                {
                    hexweaveAmountInput.Background = new SolidColorBrush(Colors.White);
                    if (viewModel != null)
                        viewModel.HexweaveMaterials(bagsAmount);
                }
                else
                    hexweaveAmountInput.Background = new SolidColorBrush(Colors.LightYellow);
            }
            else
                hexweaveAmountInput.Background = new SolidColorBrush(Colors.LightPink);
        }
    }
}
