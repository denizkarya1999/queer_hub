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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace project_freddie_mercury
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class coming_out : Page
    {
        public coming_out()
        {
            this.InitializeComponent();
        }

        private void lgbt_travel_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(safe_travel));
        }

        private void std_prevention_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(std_prevention));
        }

        private void about_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void come_out_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (accepting_radio_button.IsChecked == true)
            {
                var dialog = new MessageDialog("You can try to come out to your family since they are accepting. However make sure you still take precautions, they may change their view ");
                dialog.ShowAsync();
            }

            if (not_accepting_radio_button.IsChecked == true && consent_not_given_radio_button.IsChecked == true && financially_not_radio_button.IsChecked == true && (controversial_radio_button.IsChecked == true || punishable_radio_button.IsChecked == true || lgbt_rights_not_recognized_radio_button.IsChecked == true))
            {
                var dialog = new MessageDialog("You first need to get consent from your family, then you need to get financially independent and lastly you need to leave the place you live in before you come out.");
                dialog.ShowAsync();
            }

            if (not_accepting_radio_button.IsChecked == true && consent_not_given_radio_button.IsChecked == true && financially_not_radio_button.IsChecked == true && (controversial_radio_button.IsChecked == true || punishable_radio_button.IsChecked == true || lgbt_rights_not_recognized_radio_button.IsChecked == true))
            {
                var dialog = new MessageDialog("You first need to get consent from your family, then you need to get financially independent and lastly you need to leave the place you live in before you come out.");
                dialog.ShowAsync();
            }

            if (not_accepting_radio_button.IsChecked == true && consent_given_radio_button.IsChecked == true && financially_dependent_radio_button.IsChecked == true && (controversial_radio_button.IsChecked == true || punishable_radio_button.IsChecked == true || lgbt_rights_not_recognized_radio_button.IsChecked == true))
            {
                var dialog = new MessageDialog("You need to get financially independent and lastly you need to leave the place you live in before you come out.");
                dialog.ShowAsync();
            }

            if (not_accepting_radio_button.IsChecked == true && consent_given_radio_button.IsChecked == true && financially_not_radio_button.IsChecked == true && (controversial_radio_button.IsChecked == true || punishable_radio_button.IsChecked == true || lgbt_rights_not_recognized_radio_button.IsChecked == true))
            {
                var dialog = new MessageDialog("You need to leave the place you live in before you come out.");
                dialog.ShowAsync();
            }

            if (not_accepting_radio_button.IsChecked == true && consent_given_radio_button.IsChecked == true && financially_not_radio_button.IsChecked == true && (full_rights_radio_button.IsChecked == true || only_partnership_recognized_radio_button.IsChecked == true))
            {
                var dialog = new MessageDialog("Just ignore your family, come out right away and live your life.");
                dialog.ShowAsync();
            }

            if (not_accepting_radio_button.IsChecked == true && consent_not_given_radio_button.IsChecked == true && financially_dependent_radio_button.IsChecked == true && (full_rights_radio_button.IsChecked == true || only_partnership_recognized_radio_button.IsChecked == true))
            {
                var dialog = new MessageDialog("Try to get your consent first then get financial independence before you come out.");
                dialog.ShowAsync();
            }

            if (not_accepting_radio_button.IsChecked == true && consent_given_radio_button.IsChecked == true && financially_not_radio_button.IsChecked == true && (full_rights_radio_button.IsChecked == true || only_partnership_recognized_radio_button.IsChecked == true))
            {
                var dialog = new MessageDialog("Get your financial indepedence first then come out.");
                dialog.ShowAsync();
            }
        }

        private void tips_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(safety_tips));
        }
    }
}
