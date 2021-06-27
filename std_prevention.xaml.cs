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
    public sealed partial class std_prevention : Page
    {
        List<String> possible_stds = new List<String>();
        public std_prevention()
        {
            this.InitializeComponent();
        }

        private void about_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void calculate_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (anal_sex_radio_button.IsChecked == true || vaginal_sex_radio_button.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("HIV/AIDS");
                possible_stds.Add("Hepatitis B");
                possible_stds.Add("Hepatitis C");
                possible_stds.Add("Syphilis");
                possible_stds.Add("Human Populama Virus (HPV)");
                possible_stds.Add("Herpes Simplex (HSV)");
                possible_stds.Add("Gonorrhea");
                possible_stds.Add("Chlamdyia");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }
            if ((anal_sex_radio_button.IsChecked == true || vaginal_sex_radio_button.IsChecked == true) && (condom.IsChecked == true && prep.IsChecked == true))
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("Human Populama Virus (HPV)");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if ((anal_sex_radio_button.IsChecked == true || vaginal_sex_radio_button.IsChecked == true) && condom.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("Human Populama Virus (HPV)");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if ((anal_sex_radio_button.IsChecked == true || vaginal_sex_radio_button.IsChecked == true) && prep.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("Hepatitis B");
                possible_stds.Add("Hepatitis C");
                possible_stds.Add("Syphilis");
                possible_stds.Add("Human Populama Virus (HPV)");
                possible_stds.Add("Herpes Simplex (HSV)");
                possible_stds.Add("Gonorrhea");
                possible_stds.Add("Chlamdyia");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if ((anal_sex_radio_button.IsChecked == true || vaginal_sex_radio_button.IsChecked == true) && (condom.IsChecked == true && prep.IsChecked == true))
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("Human Populama Virus (HPV)");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if (oral_sex_radio_button.IsChecked == true && (receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true || prep.IsChecked == true))
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("Hepatitis A");
                possible_stds.Add("Syphilis");
                possible_stds.Add("Human Populama Virus (HPV)");
                possible_stds.Add("Herpes Simplex (HSV)");
                possible_stds.Add("Gonorrhea");
                possible_stds.Add("Chlamdyia");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if (oral_sex_radio_button.IsChecked == true && (receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true || prep.IsChecked == true) && condom.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("All Clear!");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if (oral_sex_radio_button.IsChecked == true && insertive_radio_button.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("Human Populama Virus (HPV)");
                possible_stds.Add("Herpes Simplex (HSV)");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if (oral_sex_radio_button.IsChecked == true && insertive_radio_button.IsChecked == true && condom.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("All Clear!");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if (fingering_radio_button.IsChecked == true ||  genital_touching_radio_button.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("All Clear!");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }

            if (deep_kissing_radio_button.IsChecked == true)
            {
                possible_stds_listbox.Items.Clear();
                possible_stds.Add("Herpes Simplex (HSV)");
                possible_stds.Add("Trichomoniasis");
                for (int i = 0; i < possible_stds.Count; i++)
                {
                    possible_stds_listbox.Items.Add(possible_stds.ElementAt(i));
                }
                possible_stds.Clear();
            }
        }

        private void lgbt_travel_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(safe_travel));
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
