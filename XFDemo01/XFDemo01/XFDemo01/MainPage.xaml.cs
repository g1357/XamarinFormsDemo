using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFDemo01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if ( ! String.IsNullOrWhiteSpace(eName.Text))
                Label1.Text = "Hello, " + eName.Text;
            else
                Label1.Text = "Hello, Grigory!";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to Xamarin.Forms!";
        }
    }
}
