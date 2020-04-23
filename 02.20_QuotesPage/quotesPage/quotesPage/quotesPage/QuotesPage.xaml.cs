using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace quotesPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        int quoteCount = 0;
        string[] quotes = { "Life is about making an impact, not making an income.", 
                            "Whatever the mind of man can conceive and believe, it can achieve.", 
                            "Strive not to be success, but rather to be of value.",
                            "Two roads diverged in a wood, and I took the one less traveled by, And that has made all the difference.",
                            "You can't blame gravity for falling in love." };

        public QuotesPage()
        {
            InitializeComponent();
            quoteLabel.Text = quotes[quoteCount];
        }

        public int updateQuoteCount(int count)
        {
            int totalQuotes = quotes.Length - 1;

            if (count == totalQuotes)
            {
                count = 0;
                return count;
            }
            else
            {
                count++;
                return count;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            quoteCount = updateQuoteCount(quoteCount);
            quoteLabel.Text = quotes[quoteCount];
        }
    }
}