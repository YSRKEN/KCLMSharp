using KCLMSharp.ViewModel;
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

namespace KCLMSharp.View
{
    /// <summary>
    /// KammusuListPage.xaml の相互作用ロジック
    /// </summary>
    public partial class KammusuListPage : Page
    {
        public KammusuListPage()
        {
            InitializeComponent();
        }
		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			var bindData = DataContext as MainViewModel;
			if (bindData != null)
				NavigationService.Navigate(new Uri(bindData.ModeUri[bindData.ModeIndex], UriKind.Relative));
		}
	}
}
