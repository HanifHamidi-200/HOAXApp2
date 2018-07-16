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

namespace MarsTraining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> _index = new List<int> { 1, 2, 3, 4 };

        private void fReset()
        {
            for (int i = 1; i <= 4; i++)
            {
                _index[i - 1] = i;
            }
        }
        private void fRandom()
        {
            Random rnd1 = new Random();
            for (int i = 1; i <= 4; i++)
            {
                _index[i - 1] = rnd1.Next(1, 5);
            }
        }

        private void fDialog(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    fSub1 _dlg1 = new fSub1();
                    _dlg1.ShowDialog();
                    break;
                case 2:
                    fSub2 _dlg2 = new fSub2();
                    _dlg2.ShowDialog();
                    break;
                case 3:
                    fSub3 _dlg3 = new fSub3();
                    _dlg3.ShowDialog();
                    break;
                default:
                    fSub4 _dlg4 = new fSub4();
                    _dlg4.ShowDialog();
                    break;
            }

        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pic1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fDialog(_index[0]);
        }

        private void pic2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fDialog(_index[1]);
        }

        private void pic3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fDialog(_index[2]);
        }

        private void pic4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fDialog(_index[3]);
        }

        private void btnReset_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fReset();
        }

        private void btnRandom_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fRandom();
        }
    }
}
