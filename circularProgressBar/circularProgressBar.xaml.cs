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

namespace circularProgressBar
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class progressbar : UserControl
    {

        public progressbar()
        {
            InitializeComponent();
        }
        public void setprogress(int i)
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                progress.EndAngle = (Convert.ToDouble(i) / 100) * 360;
                pgPerentage.Content = i.ToString() + "%";
            }));
        }
    }
}
