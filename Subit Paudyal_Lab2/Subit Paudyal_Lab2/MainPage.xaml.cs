using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Subit_Paudyal_Lab2 //Assignment 2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void convertClick(object sender, RoutedEventArgs e)
        {
            try
            {       //when "convert to Celsius" radio button is selected/checked.
                if ((bool)convertToCel.IsChecked)
                {
                    convertCel();
                }   //only if "convert to Fahrenheit" radio button is selected/checked.
                    // if appropriate radio box is not selected for a conversion, error message is displayed.
                else if ((bool)convertToFah.IsChecked)
                {
                    convertFah();
                }
            }
            catch (Exception caught)
            { 
                result.Text = caught.Message;
            }
        }
        private void convertCel()
        {
           //assigning fah as the value that user types on the "tempFah" textBox in the interface.
            double Fah = double.Parse(tempFah.Text);
            double outcome = 0;
            // using math. round(2) so that we get answer in 2 decimal value.
            outcome = Math.Round((Fah - 32) * (5.0D/9.0D), 2);
            result.Text = outcome.ToString();
            //result.text is here so that the outcome from the conversion is displayed on the result field.
        }
        private void convertFah()
        {
            //assigning Cel as the value that user types on the "tempCel" textBox in the interface.
            double Cel = double.Parse(tempCel.Text);
            double outcome = 0;
            // using math. round(2) so that we get answer in 2 decimal value.
            outcome = Math.Round((Cel * 1.8 +32), 2);
            result.Text = outcome.ToString();
            //result.text is here so that the outcome from the conversion is displayed on the result field.
        }
    }
}
