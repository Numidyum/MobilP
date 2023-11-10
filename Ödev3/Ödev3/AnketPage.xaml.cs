using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Ödev3
{
    public partial class AnketPage : ContentPage
    {
        public AnketPage()
        {
            InitializeComponent();
        }

        void OnItalicCheckBoxChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                yazilabel.FontAttributes |= FontAttributes.Italic;
            }
            else
            {
                yazilabel.FontAttributes &= ~FontAttributes.Italic;
            }
        }

        void OnBoldCheckBoxChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                yazilabel.FontAttributes |= FontAttributes.Bold;
            }
            else
            {
                yazilabel.FontAttributes &= ~FontAttributes.Bold;
            }
        }

        void OnUnderlineCheckBoxChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                yazilabel.TextDecorations |= TextDecorations.Underline;
            }
            else
            {
                yazilabel.TextDecorations &= ~TextDecorations.Underline;
            }
        }

        void OnStrikethroughCheckBoxChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                yazilabel.TextDecorations |= TextDecorations.Strikethrough;
            }
            else
            {
                yazilabel.TextDecorations &= ~TextDecorations.Strikethrough;
            }
        }

        void TextChanged(object sender, TextChangedEventArgs e)
        {
            yazilabel.Text = yazigir.Text;
        }

        void CheckedCinsiyetChanged(object sender, TextChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            cinsiyet.Text = $"Seçimin: {button.Value}";
        }

    }
}