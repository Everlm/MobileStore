﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyStore.Models;

namespace MyStore.EmployeesApp
{
	public partial class App : Application
	{
		public static EmployeeDTO CurrentEmployee;

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Pages.LoginPage());
		}
	}
}