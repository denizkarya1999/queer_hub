using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace project_freddie_mercury
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class safe_travel : Page
    {
        public safe_travel()
        {
            this.InitializeComponent();
        }

        private void about_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }

        private void std_prevention_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(std_prevention));
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }


        private void show_country_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (usa_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_in_the_United_States"));
            if (canada_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_Canada"));
            if (eu_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_the_European_Union"));
            if (australia_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_Australia#:~:text=Australia%20legalised%20same%2Dsex%20marriage,2009%20as%20de%20facto%20relationships."));
            if (new_zealand_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_New_Zealand"));
            if (israel_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_Israel"));
            if (taiwan_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_Taiwan#:~:text=Both%20male%20and%20female%20same,child%2C%20they%20may%20adopt%20stepchildren."));
            if (brazil_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_Brazil"));
            if (russia_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_Russia"));
            if (turkey_radio_button.IsChecked == true)
                main_webview.Navigate(new Uri("https://en.wikipedia.org/wiki/LGBT_rights_in_Turkey"));
        }

        private void coming_out_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(coming_out));
        }

        private void tips_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(safety_tips));
        }
    }
}
