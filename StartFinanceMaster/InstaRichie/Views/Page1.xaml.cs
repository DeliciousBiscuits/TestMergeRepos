using SQLite.Net;
using StartFinance.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StartFinance.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {

        SQLiteConnection conn; // adding an SQLite connection
        int selectedID, mobile;
        string firstName, lastName, gender, emailAdd, dOB;
        string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "Findata.sqlite");

        public Page1()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            /// Initializing a database
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            Results();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Results();
        }

        // Results 
        public void Results()
        {
            // Creating table
            conn.CreateTable<PersonalInfo>();

            /// Refresh Data
            var query = conn.Table<PersonalInfo>();
            PersonalInfoListView.ItemsSource = query.ToList();
        }

        // Add Personal Info
        private async void AddInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // change if statements!! another way to code it 
                if (FirstNameText.Text.ToString() == "")
                {
                    MessageDialog dialog = new MessageDialog("No Account Name entered", "Oops..!");
                    await dialog.ShowAsync();
                }

                else
                {
                    conn.Insert(new PersonalInfo()
                    {
                        FirstName = FirstNameText.Text,
                        LastName = LastNameText.Text,
                        DOB = DOBText.Date.ToString("MM-dd-yyyy"),
                        Gender = GenderText.SelectedItem.ToString(),
                        EmailAddress = EmailText.Text,
                        MobilePhone = Convert.ToInt32(MobileText.Text)
                    });
                    Results();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageDialog dialog = new MessageDialog("You forgot to enter the Value or entered an invalid data", "Oops..!");
                    await dialog.ShowAsync();
                }
                else if (ex is SQLiteException)
                {
                    MessageDialog dialog = new MessageDialog("A similar name already exists, Try a different name", "Oops..!");
                    await dialog.ShowAsync();
                }
            }
        }

        //Edit the Personal Information
        private async void EditInfo_Click(object sender, RoutedEventArgs e)
        {

            var person = PersonalInfoListView.SelectedItem as PersonalInfo;
            try
            {
                firstName = FirstNameText.Text;
                lastName = LastNameText.Text;
                gender = GenderText.SelectedItem.ToString();
                emailAdd = EmailText.Text;
                mobile = Convert.ToInt32(MobileText.Text);
                dOB = DOBText.Date.ToString("MM-dd-yyyy");
                //change AppBarButtons
                addButton.IsEnabled = false;
                deleteButton.IsEnabled = false;
                editButton.IsEnabled = false;
                resetButton.IsEnabled = false;
                saveButton.IsEnabled = true;
                cancelButton.IsEnabled = true;
                addButton.Visibility = Visibility.Collapsed;
                resetButton.Visibility = Visibility.Collapsed;
                deleteButton.Visibility = Visibility.Collapsed;
                editButton.Visibility = Visibility.Collapsed;
                saveButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;

                if (selectedID == null)
                {
                    MessageDialog dialog = new MessageDialog("No selected the Item", "Oops..!");
                    await dialog.ShowAsync();
                }
                else
                {

                    conn.CreateTable<PersonalInfo>();
                    var query1 = conn.Table<PersonalInfo>();
                    var query3 = conn.Query<PersonalInfo>("UPDATE PersonalInfo SET FirstName ='" + firstName + "' , LastName ='" + lastName + "' , DOB ='" + dOB + "' , Gender ='" + gender + "' , EmailAddress ='" + emailAdd + "' , MobilePhone ='" + mobile + "' WHERE ID = '" + selectedID + "'");
                    PersonalInfoListView.ItemsSource = query1.ToList();
                    MessageDialog updated = new MessageDialog("Personal Information updated succesfully!");
                    await updated.ShowAsync();
                    Results();
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageDialog dialog2 = new MessageDialog("Invalid Data Entered. Please Try Again!", "Oops..!");
                    await dialog2.ShowAsync();
                }
            }



        }



        private async void SaveInfo_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        // Deleting personal Info 
        private async void DeleteInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string AccSelection = ((PersonalInfo)PersonalInfoListView.SelectedItem).FirstName;
                if (AccSelection == "")
                {
                    MessageDialog dialog = new MessageDialog("Not selected the Item", "Oops..!");
                    await dialog.ShowAsync();
                }
                else
                {
                    conn.CreateTable<PersonalInfo>();
                    var query1 = conn.Table<PersonalInfo>();
                    var query3 = conn.Query<PersonalInfo>("DELETE FROM PersonalInfo WHERE FirstName ='" + AccSelection + "'");
                    PersonalInfoListView.ItemsSource = query1.ToList();
                }
            }
            catch (NullReferenceException)
            {
                MessageDialog dialog = new MessageDialog("Not selected the Item", "Oops..!");
                await dialog.ShowAsync();
            }
        }

        // Selecting the ListBox Item 
        private void PersonalInfoListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var person = PersonalInfoListView.SelectedItem as PersonalInfo;
            if (person != null)
            {
                //Frame.Navigate(typeof(Views.PersonalInfoPage), person.ID);
                selectedID = person.ID;
                var query = conn.Table<PersonalInfo>();

                firstName = person.FirstName;
                lastName = person.LastName;
                gender = person.Gender;
                emailAdd = person.EmailAddress;
                dOB = person.DOB;
                mobile = person.MobilePhone;
                FirstNameText.Text = firstName;
                LastNameText.Text = lastName;

                DOBText.SelectedDate = DateTime.ParseExact(dOB, @"MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                GenderText.SelectedItem = gender;
                EmailText.Text = emailAdd;
                MobileText.Text = mobile.ToString();


            }
            // Reset selected index to -1 (no selection)
            PersonalInfoListView.SelectedIndex = -1;
        }

        // Resets everything to default 
        private void ClearFields()
        {
            FirstNameText.Text = string.Empty;
            LastNameText.Text = string.Empty;
            DOBText.SelectedDate = null;
            GenderText.Text = string.Empty;
            EmailText.Text = string.Empty;
            MobileText.Text = string.Empty;


        }
        private void CancelInfo_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
            addButton.IsEnabled = true;
            saveButton.IsEnabled = false;
            deleteButton.IsEnabled = true;
            editButton.IsEnabled = true;
            addButton.Visibility = Visibility.Visible;
            saveButton.Visibility = Visibility.Collapsed;
            cancelButton.Visibility = Visibility.Collapsed;
            deleteButton.Visibility = Visibility.Visible;
            editButton.Visibility = Visibility.Visible;
            Results();

        }

        // Resets everything to default 
        private async void Reset_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
            var query1 = conn.Table<PersonalInfo>();
            var query3 = conn.DeleteAll<PersonalInfo>();
            MessageDialog ClearDialog = new MessageDialog("Cleared", "information");
            await ClearDialog.ShowAsync();
            Results();
        }

    }
}
