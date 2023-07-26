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
    public partial class WavePage : ContentPage
    {
        List<Transaction> transactions;
        public WavePage()
        {
            InitializeComponent();
            transactions = new List<Transaction>();

            NavigationPage.SetHasBackButton(this, false);
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            liste.ItemsSource = transactions;
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
            transactions.Add(new Transaction { operation = "Modou Khoulé", montant = 20000, date = "1996" });
        }

        private void liste_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Transaction tr = ((ListView)sender).SelectedItem as Transaction;
            Navigation.PushAsync(new DetailTrans(tr.operation,tr.montant,tr.date));
        }
    }

    public class Transaction
    {
        public string operation { get; set; }
        public int montant { get; set; }
         public string date { get; set; }
    }
}