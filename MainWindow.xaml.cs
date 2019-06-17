/* Ethan Shipston
 * ICS4U
 * June 17 2019
 * Finds the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */
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

namespace _184988SumSquareDifference
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double[] nums = new double[100];
            double[] nums2 = new double[100];

            for (int i = 0; i < 100; i++)
            {
                nums[i] = Math.Pow(i + 1, 2);
                nums2[i] = i + 1;
            }

            double total = nums.Sum();
            double sqrTotal = Math.Pow(nums2.Sum(), 2);

            double dif = sqrTotal - total;

            MessageBox.Show("Sum: " + total.ToString() +
                "\nSquare: " + sqrTotal.ToString() +
                "\nDifference: " + dif.ToString());
        }
    }
}
