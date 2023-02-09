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
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
        }

        private void BtnSigh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbPass.Password == "0000")
                {
                    MessageBox.Show("Информация корректна. Вход в режим Администратора активен.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    FrameActionNavigate.frameNavigate.Navigate(new PageDefaultAdmin());
                }
                else{ 
                    MessageBox.Show("Информация НЕ корректна. Вход в режим Администратора не выполним!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
