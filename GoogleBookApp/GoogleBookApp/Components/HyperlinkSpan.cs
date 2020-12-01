using Xamarin.Essentials;
using Xamarin.Forms;

namespace GoogleBookApp.Components
{
    public class HyperlinkSpan : Span
    {
        public static readonly BindableProperty UrlProperty = BindableProperty.Create(
            propertyName: nameof(Url),
            returnType: typeof(string),
            declaringType: typeof(HyperlinkSpan),
            defaultValue: null,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: HandleUrlChanged);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        protected static void HandleUrlChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var span = (HyperlinkSpan)bindable;
            var url = (string)newValue;
            if (!string.IsNullOrEmpty(url))
            {
                span.TextDecorations = TextDecorations.Underline;
                span.TextColor = Color.Blue;
                span.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(async () => await Browser.OpenAsync(url))
                });
            }
        }
    }
}
