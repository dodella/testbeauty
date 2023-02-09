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
using User6BeautyApp.Actions.ProgrammApp;

namespace User6BeautyApp.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageDefaultAdmin.xaml
    /// </summary>
    public partial class PageDefaultAdmin : Page
    {
        public PageDefaultAdmin()
        {
            InitializeComponent();

            GridServices.ItemsSource = ConnectionData.ConnectPoint.Service.ToList();
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteService_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
