using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PinchScrollViewTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        void PinchGestureRecognizer_PinchUpdated(System.Object sender, Xamarin.Forms.PinchGestureUpdatedEventArgs e)
        {
            string status = e.Status.ToString();

            if (e.Status == GestureStatus.Running)
            {
                status += " - Scale is " + e.Scale.ToString();
            }

            (BindingContext as MainViewModel).PinchStatus = status;
        }
    }
}
