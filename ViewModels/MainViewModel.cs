using Prism.Mvvm;

namespace SteppPlanChecker.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _title = "Stepp ESAPIX Starter Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainViewModel()
        {

        }
    }
}
