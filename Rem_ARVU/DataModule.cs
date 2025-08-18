using Rem_ARVU;
using RemObjects.DataAbstract;
using RemObjects.SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Rem_ARVU {
    public partial class DataModule : Component {
        #region Constructors
        public DataModule() {
            this.InitializeComponent();
            this.message.ClientID = Guid.NewGuid();

            this.IsLoggedOn = false;
        }

        public DataModule(IContainer container)
            : this() {
            if (container != null)
                container.Add(this);
        }
        #endregion

        #region Properties

        public Boolean IsLoggedOn { get; protected set; }

        public String UserId { get; protected set; }
        #endregion

        #region DataModule Events
        private void ClientChannel_OnLoginNeeded(object sender, LoginNeededEventArgs e) {
            // Performing login
            if (this.LogOn(Properties.Settings.Default.UserId, Properties.Settings.Default.Password)) {
                e.Retry = true;
                e.LoginSuccessful = true;
                return;
            }
            RequireLogOn();
        }
        #endregion

        #region LogOn/LogOff Handling
        public Boolean LogOn(String userId, String password) {
            if (String.IsNullOrEmpty(userId)) {
                return false;
            }

            var login = new SemicolonSeparatedString();
            login["User ID"] = userId;
            login["Password"] = password;
            var loginString = login.ToString();

            this.IsLoggedOn = (new RemObjects.DataAbstract.Server.BaseLoginService_Proxy(this.message, this.clientChannel, "LoginService")).LoginEx(loginString);

            if (this.IsLoggedOn) {
                this.UserId = userId;
            }

            return this.IsLoggedOn;
        }

        public bool RequireLogOn() {
            String lUserId;
            String lPassword;

            LogOnForm lLoginForm = new LogOnForm();

            if (lLoginForm.ShowDialog() != true) {
                MessageBox.Show("Login cancelled");
                return false;
            }
            lUserId = lLoginForm.UserId;
            lPassword = lLoginForm.GetPassword();

            if (this.LogOn(lUserId, lPassword)) {
                return true;
            } else {
                MessageBox.Show("Login failed");
                return false;
            }
        }

        public void LogOff() {
            if (this.IsLoggedOn) {
                (new RemObjects.DataAbstract.Server.BaseLoginService_Proxy(message, clientChannel, "LoginService")).Logout();
                this.IsLoggedOn = false;
                UserId = null;
                message.ClientID = Guid.Empty;
            }
        }
        #endregion

        #region Data Operations
        public List<T> GetItems<T>() where T : class, new() {
            try {
                return remoteDataAdapter.GetTable<T>().ToList();
            } catch (Exception ex) {
                MessageBox.Show($"Error loading Product Groups: {ex.Message}", "Error");
                return null;
            }
        }

        public void DeleteRow<T>(T row) where T : class, new() {
            try {
                remoteDataAdapter.GetTable<T>().DeleteRow(row);
                remoteDataAdapter.ApplyChanges();
            } catch (Exception ex) {
                MessageBox.Show($"Error deleting from {typeof(T).Name}: {ex.Message}", "Error");
            }
        }

        public void CreateRow<T>(T row) where T : class, new() {
            try {
                remoteDataAdapter.GetTable<T>().InsertRow(row);
                remoteDataAdapter.ApplyChanges();
            } catch (Exception ex) {
                MessageBox.Show($"Error creating in {typeof(T).Name}: {ex.Message}", "Error");
            }
        }

        public void UpdateRow<T>(T row) where T : class, new() {
            try {
                remoteDataAdapter.GetTable<T>().UpdateRow(row);
                remoteDataAdapter.ApplyChanges();
            } catch (Exception ex) {
                MessageBox.Show($"Error updating in {typeof(T).Name}: {ex.Message}", "Error");
            }
        }

        #endregion
    }
}