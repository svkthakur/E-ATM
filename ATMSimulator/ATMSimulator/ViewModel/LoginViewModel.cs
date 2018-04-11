using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        private string _groupBoxName = "Login";
        private string _loginButtonText = "Login";
        private string _newCardButtonText = "New Card?";
        private string _firstCardNumberText , _secondCardNumberText , _thirdCardNumberText , _fourthCardNumberText;

        public string GroupBoxName
        {
            get { return _groupBoxName; }
            set { _groupBoxName = value; }
        }

        public string LoginButtonText
        {
            get { return _loginButtonText; }
            set { _loginButtonText = value; }
        }

        public string NewCardButtonText
        {
            get { return _newCardButtonText; }
            set { _newCardButtonText = value; }
        }

        public string FirstCardNumberText
        {
            get { return _firstCardNumberText; }
            set
            {
                _firstCardNumberText = value;
                OnPropertyChanged("FirstCardNumber");
            }
        }

        public string SecondCardNumberText
        {
            get { return _secondCardNumberText; }
            set
            {
                _secondCardNumberText = value;
                OnPropertyChanged("SecondCardNumberText");
            }
        }

        public string ThirdCardNumberText
        {
            get { return _thirdCardNumberText; }
            set
            {
                _thirdCardNumberText = value;
                OnPropertyChanged("SecondCardNumberText");
            }
        }

        public string FourthCardNumberText
        {
            get { return _fourthCardNumberText; }
            set
            {
                _fourthCardNumberText = value;
                OnPropertyChanged("SecondCardNumberText");
            }
        }

        public DelegateCommand LoginCommand { get; private set; }
        public DelegateCommand NewCardCommand { get; private set; }

        public LoginViewModel()
        {
            //LoginButton = new DelegateCommand();
        }

    }
}
