using Microsoft.Practices.Prism.Mvvm;

namespace ViewModelLocatorDemo.Views
{
    public class MainDemoViewModel : BindableBase
    {
        string _message = "Hello World";
        public string Message
        {
            get { return _message; }
            set { SetProperty<string>(ref _message, value); }
        }
    }
}
