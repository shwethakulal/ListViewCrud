using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListViewCrud
{
	public partial class App : Application
	{
        static ListViewDatabase database;
        public App ()
		{
			InitializeComponent();

			MainPage = new ListViewCrud.MainPage();
		}

        public static ListViewDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ListViewDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("ListSQLite.db3"));
                }
                return database;
            }
        }
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
