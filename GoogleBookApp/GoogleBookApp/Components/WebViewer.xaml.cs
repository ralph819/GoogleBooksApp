using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoogleBookApp.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewer : ContentPage
    {
        public WebViewer(string title, string url)
        {
            InitializeComponent();
            Title = title;
            WebView.Source = url;
        }
    }
}