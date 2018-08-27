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

namespace Questionnaire
{
    /// <summary>
    /// Interaction logic for FinancialGoal.xaml
    /// </summary>
    public partial class FinancialGoal : Page
    {
        public FinancialGoal()
        {
            InitializeComponent();
            InitiateGoalsAndAssets();
        }
        private void InitiateGoalsAndAssets()
        {
            stackAssetDetails.Children.Add(new AssetDetails());
            stackGoals.Children.Add(new Goals());
        }
        private void btnAddAsset_Click(object sender, RoutedEventArgs e)
        {
            stackAssetDetails.Children.Add(new AssetDetails());
        }

        private void btnAddGoals_Click(object sender, RoutedEventArgs e)
        {
            stackGoals.Children.Add(new Goals());
        }
    }
}
