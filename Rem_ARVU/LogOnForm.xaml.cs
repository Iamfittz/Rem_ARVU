using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Rem_ARVU
{
    public partial class LogOnForm : Window, INotifyPropertyChanged
    {
        #region Constructor
        public LogOnForm()
        {
            this.InitializeComponent();

            this.UserId = Properties.Settings.Default.UserId;
            this.SetPassword(Properties.Settings.Default.Password);

            this.DoStorePassword = Properties.Settings.Default.StorePassword;
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        protected void TriggerPropertyChanged(String propertyName)
        {
            if  (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        
        #region Properties
        private String fUserId;
        public String UserId
        {
            get
            {
                return this.fUserId;
            }
            set
            {
                this.fUserId = value;
                this.TriggerPropertyChanged("UserId");
            }
        }

        private Boolean fDoStorePassword;
        public Boolean DoStorePassword
        {
            get
            {
                return (this.fDoStorePassword);
            }
            set
            {
                this.fDoStorePassword = value;
                this.TriggerPropertyChanged("DoStorePassword");
            }
        }
        #endregion

        #region Password access
        public String GetPassword()
        {
            return this.PasswordTextBox.Password;
        }

        public void SetPassword(String value)
        {
            this.PasswordTextBox.Password = value;
        }
        #endregion
        
        #region Commands
        public static ICommand AcceptCredentials = new RoutedUICommand("Accept Credentials", "AcceptCredentials", typeof(LogOnForm));

        private void AcceptCredentials_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.Handled = true;

            e.CanExecute = !String.IsNullOrEmpty(this.UserId);
        }

        private void AcceptCredentials_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Properties.Settings.Default.UserId = this.UserId;
            Properties.Settings.Default.Password = this.DoStorePassword ? this.GetPassword() : String.Empty;
            Properties.Settings.Default.StorePassword = this.DoStorePassword;
            Properties.Settings.Default.Save();

            this.DialogResult = true;
        }
        #endregion
    }
}
