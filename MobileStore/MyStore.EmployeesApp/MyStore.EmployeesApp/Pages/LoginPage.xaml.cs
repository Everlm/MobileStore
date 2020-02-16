using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyStore.Models;
using MyStore.Services;

namespace MyStore.EmployeesApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void SignInButton_Clicked(object sender, EventArgs e)
        {
            var username = UserNameEntry.Text;
            var password = PasswordEntry.Text;

            var employee = await StoreWebApiClient.Instance.Login(username, password);

            if (employee != default(EmployeeDTO))
            {
                App.CurrentEmployee = employee;
                await DisplayAlert("Welcome!", $"Welcome {employee.FullName}", "OK");
                await Navigation.PushAsync(new CustomerListPage());
            }
            else
            {
                await DisplayAlert("Error!", "Wrong credentials!", "OK");
            }
        }
    }
}