using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wave
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailTrans : ContentPage
    {
        public string operation;
        public int montant;
        
        public string date;
        public DetailTrans(string operation, int montant, string date)
        {
            this.operation = operation;
            this.montant = montant;
            this.date = date;
            InitializeComponent();
            oprationtxt.Text = operation;
            montanttxt.Text = montant.ToString();
            datetxt.Text = date;
        }
    }
}