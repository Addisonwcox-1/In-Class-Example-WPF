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

namespace In_Class_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name, address;
            int zip;

            name = txtName.Text;
            address = txtAddress.Text;
            zip = Convert.ToInt32(txtZip.Text);

            bool isFormValid = true;
            if (name==" " || name==string.Empty)
            {
                MessageBox.Show("Please input your name");
                txtName.Focus();
                isFormValid = false;          //instead of return;
            }

           if (address ==" " || address==string.Empty)
            {
                MessageBox.Show("Please input address");
                txtAddress.Focus();
                isFormValid = false;
            }

           if (isFormValid==false)
            {
                return;
            }

            EntryForm ef = new EntryForm();
            ef.Name = name;
            ef.Address = address;
            ef.Zip = zip;

             //Another way to do it
            //EntryForm ef2 = new EntryForm(txtName.Text, txtAddress.Text, Convert.ToInt32(txtZip.Text));

            //if found help online, then reference with a link :www._____.com
            
            
            lstApplications.Items.Add(ef);
        }
    }
}
