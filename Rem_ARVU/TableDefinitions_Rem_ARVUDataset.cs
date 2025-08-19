// #DA Schema name: Rem_ARVUDataset


namespace Rem_ARVU.Rem_ARVUDataset {
    [RemObjects.DataAbstract.Linq.TableName("Agents")]
    public partial class Agents : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            Agents v____new = new Agents();
            v____new.f____Id = this.f____Id;
            v____new.f____Type = this.f____Type;
            v____new.f____Name = this.f____Name;
            v____new.f____Company = this.f____Company;
            v____new.f____Role = this.f____Role;
            v____new.f____Email = this.f____Email;
            v____new.f____Password = this.f____Password;
            v____new.f____Discount = this.f____Discount;
            v____new.f____Birthdate = this.f____Birthdate;
            v____new.f____Address = this.f____Address;
            v____new.f____PostalCode = this.f____PostalCode;
            v____new.f____Country = this.f____Country;
            v____new.f____Phone = this.f____Phone;
            v____new.f____Photo = this.f____Photo;
            v____new.f____Notes = this.f____Notes;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private Agents m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as Agents);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<Agents>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int64 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.Int64 f____Type;

        [RemObjects.DataAbstract.Linq.FieldName("Type")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Type {
            get {
                return this.f____Type;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Type, value) != 0) {
                    this.OnPropertyChanging("Type");
                    this.f____Type = value;
                    this.OnPropertyChanged("Type");
                }
            }
        }

        private System.String f____Name;

        [RemObjects.DataAbstract.Linq.FieldName("Name")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Name {
            get {
                return this.f____Name;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Name, value) != 0) {
                    this.OnPropertyChanging("Name");
                    this.f____Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private System.String f____Company;

        [RemObjects.DataAbstract.Linq.FieldName("Company")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Company {
            get {
                return this.f____Company;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Company, value) != 0) {
                    this.OnPropertyChanging("Company");
                    this.f____Company = value;
                    this.OnPropertyChanged("Company");
                }
            }
        }

        private System.Int64 f____Role;

        [RemObjects.DataAbstract.Linq.FieldName("Role")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Role {
            get {
                return this.f____Role;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Role, value) != 0) {
                    this.OnPropertyChanging("Role");
                    this.f____Role = value;
                    this.OnPropertyChanged("Role");
                }
            }
        }

        private System.String f____Email;

        [RemObjects.DataAbstract.Linq.FieldName("Email")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Email {
            get {
                return this.f____Email;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Email, value) != 0) {
                    this.OnPropertyChanging("Email");
                    this.f____Email = value;
                    this.OnPropertyChanged("Email");
                }
            }
        }

        private System.String f____Password;

        [RemObjects.DataAbstract.Linq.FieldName("Password")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Password {
            get {
                return this.f____Password;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Password, value) != 0) {
                    this.OnPropertyChanging("Password");
                    this.f____Password = value;
                    this.OnPropertyChanged("Password");
                }
            }
        }

        private System.Double? f____Discount;

        [RemObjects.DataAbstract.Linq.FieldName("Discount")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Float)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Double? Discount {
            get {
                return this.f____Discount;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Double?>.Default.Compare(this.f____Discount, value) != 0) {
                    this.OnPropertyChanging("Discount");
                    this.f____Discount = value;
                    this.OnPropertyChanged("Discount");
                }
            }
        }

        private System.DateTime? f____Birthdate;

        [RemObjects.DataAbstract.Linq.FieldName("Birthdate")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.DateTime? Birthdate {
            get {
                return this.f____Birthdate;
            }
            set {
                if (System.Collections.Generic.Comparer<System.DateTime?>.Default.Compare(this.f____Birthdate, value) != 0) {
                    this.OnPropertyChanging("Birthdate");
                    this.f____Birthdate = value;
                    this.OnPropertyChanged("Birthdate");
                }
            }
        }

        private System.String f____Address;

        [RemObjects.DataAbstract.Linq.FieldName("Address")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Address {
            get {
                return this.f____Address;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Address, value) != 0) {
                    this.OnPropertyChanging("Address");
                    this.f____Address = value;
                    this.OnPropertyChanged("Address");
                }
            }
        }

        private System.String f____PostalCode;

        [RemObjects.DataAbstract.Linq.FieldName("PostalCode")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String PostalCode {
            get {
                return this.f____PostalCode;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____PostalCode, value) != 0) {
                    this.OnPropertyChanging("PostalCode");
                    this.f____PostalCode = value;
                    this.OnPropertyChanged("PostalCode");
                }
            }
        }

        private System.String f____Country;

        [RemObjects.DataAbstract.Linq.FieldName("Country")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Country {
            get {
                return this.f____Country;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Country, value) != 0) {
                    this.OnPropertyChanging("Country");
                    this.f____Country = value;
                    this.OnPropertyChanged("Country");
                }
            }
        }

        private System.String f____Phone;

        [RemObjects.DataAbstract.Linq.FieldName("Phone")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Phone {
            get {
                return this.f____Phone;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Phone, value) != 0) {
                    this.OnPropertyChanging("Phone");
                    this.f____Phone = value;
                    this.OnPropertyChanged("Phone");
                }
            }
        }

        private System.Byte[] f____Photo;

        [RemObjects.DataAbstract.Linq.FieldName("Photo")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Blob)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Byte[] Photo {
            get {
                return this.f____Photo;
            }
            set {
                if (RemObjects.DataAbstract.Linq.LinqDataAdapter.CompareBytes(this.f____Photo, value) != true) {
                    this.OnPropertyChanging("Photo");
                    this.f____Photo = value;
                    this.OnPropertyChanged("Photo");
                }
            }
        }

        private System.String f____Notes;

        [RemObjects.DataAbstract.Linq.FieldName("Notes")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideMemo)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Notes {
            get {
                return this.f____Notes;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Notes, value) != 0) {
                    this.OnPropertyChanging("Notes");
                    this.f____Notes = value;
                    this.OnPropertyChanged("Notes");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("History")]
    public partial class History : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            History v____new = new History();
            v____new.f____Id = this.f____Id;
            v____new.f____OrderId = this.f____OrderId;
            v____new.f____UpdatedBy = this.f____UpdatedBy;
            v____new.f____UpdateDate = this.f____UpdateDate;
            v____new.f____Details = this.f____Details;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private History m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as History);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<History>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int64 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeAutoInc)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.Int64 f____OrderId;

        [RemObjects.DataAbstract.Linq.FieldName("OrderId")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 OrderId {
            get {
                return this.f____OrderId;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____OrderId, value) != 0) {
                    this.OnPropertyChanging("OrderId");
                    this.f____OrderId = value;
                    this.OnPropertyChanged("OrderId");
                }
            }
        }

        private System.Int64 f____UpdatedBy;

        [RemObjects.DataAbstract.Linq.FieldName("UpdatedBy")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 UpdatedBy {
            get {
                return this.f____UpdatedBy;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____UpdatedBy, value) != 0) {
                    this.OnPropertyChanging("UpdatedBy");
                    this.f____UpdatedBy = value;
                    this.OnPropertyChanged("UpdatedBy");
                }
            }
        }

        private System.DateTime f____UpdateDate;

        [RemObjects.DataAbstract.Linq.FieldName("UpdateDate")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.DateTime UpdateDate {
            get {
                return this.f____UpdateDate;
            }
            set {
                if (System.Collections.Generic.Comparer<System.DateTime>.Default.Compare(this.f____UpdateDate, value) != 0) {
                    this.OnPropertyChanging("UpdateDate");
                    this.f____UpdateDate = value;
                    this.OnPropertyChanged("UpdateDate");
                }
            }
        }

        private System.String f____Details;

        [RemObjects.DataAbstract.Linq.FieldName("Details")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideMemo)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Details {
            get {
                return this.f____Details;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Details, value) != 0) {
                    this.OnPropertyChanging("Details");
                    this.f____Details = value;
                    this.OnPropertyChanged("Details");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("OrderDetails")]
    public partial class OrderDetails : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            OrderDetails v____new = new OrderDetails();
            v____new.f____Id = this.f____Id;
            v____new.f____Order = this.f____Order;
            v____new.f____Product = this.f____Product;
            v____new.f____Amount = this.f____Amount;
            v____new.f____Price = this.f____Price;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private OrderDetails m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as OrderDetails);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<OrderDetails>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int64 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeAutoInc)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.Int32 f____Order;

        [RemObjects.DataAbstract.Linq.FieldName("Order")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32 Order {
            get {
                return this.f____Order;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32>.Default.Compare(this.f____Order, value) != 0) {
                    this.OnPropertyChanging("Order");
                    this.f____Order = value;
                    this.OnPropertyChanged("Order");
                }
            }
        }

        private System.Int32 f____Product;

        [RemObjects.DataAbstract.Linq.FieldName("Product")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32 Product {
            get {
                return this.f____Product;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32>.Default.Compare(this.f____Product, value) != 0) {
                    this.OnPropertyChanging("Product");
                    this.f____Product = value;
                    this.OnPropertyChanged("Product");
                }
            }
        }

        private System.Int32 f____Amount;

        [RemObjects.DataAbstract.Linq.FieldName("Amount")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32 Amount {
            get {
                return this.f____Amount;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32>.Default.Compare(this.f____Amount, value) != 0) {
                    this.OnPropertyChanging("Amount");
                    this.f____Amount = value;
                    this.OnPropertyChanged("Amount");
                }
            }
        }

        private System.Double f____Price;

        [RemObjects.DataAbstract.Linq.FieldName("Price")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Float)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Double Price {
            get {
                return this.f____Price;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Double>.Default.Compare(this.f____Price, value) != 0) {
                    this.OnPropertyChanging("Price");
                    this.f____Price = value;
                    this.OnPropertyChanged("Price");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("OrderStatus")]
    public partial class OrderStatus : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            OrderStatus v____new = new OrderStatus();
            v____new.f____Id = this.f____Id;
            v____new.f____Name = this.f____Name;
            v____new.f____Remarks = this.f____Remarks;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private OrderStatus m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as OrderStatus);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<OrderStatus>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int16 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int16 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int16>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.String f____Name;

        [RemObjects.DataAbstract.Linq.FieldName("Name")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Name {
            get {
                return this.f____Name;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Name, value) != 0) {
                    this.OnPropertyChanging("Name");
                    this.f____Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private System.String f____Remarks;

        [RemObjects.DataAbstract.Linq.FieldName("Remarks")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Remarks {
            get {
                return this.f____Remarks;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Remarks, value) != 0) {
                    this.OnPropertyChanging("Remarks");
                    this.f____Remarks = value;
                    this.OnPropertyChanged("Remarks");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("OrderType")]
    public partial class OrderType : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            OrderType v____new = new OrderType();
            v____new.f____Id = this.f____Id;
            v____new.f____Name = this.f____Name;
            v____new.f____Remarks = this.f____Remarks;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private OrderType m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as OrderType);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<OrderType>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int16 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int16 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int16>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.String f____Name;

        [RemObjects.DataAbstract.Linq.FieldName("Name")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Name {
            get {
                return this.f____Name;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Name, value) != 0) {
                    this.OnPropertyChanging("Name");
                    this.f____Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private System.String f____Remarks;

        [RemObjects.DataAbstract.Linq.FieldName("Remarks")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Remarks {
            get {
                return this.f____Remarks;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Remarks, value) != 0) {
                    this.OnPropertyChanging("Remarks");
                    this.f____Remarks = value;
                    this.OnPropertyChanged("Remarks");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("Orders")]
    public partial class Orders : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            Orders v____new = new Orders();
            v____new.f____Id = this.f____Id;
            v____new.f____Date = this.f____Date;
            v____new.f____Status = this.f____Status;
            v____new.f____Type = this.f____Type;
            v____new.f____Contractor = this.f____Contractor;
            v____new.f____Manager = this.f____Manager;
            v____new.f____CreatedBy = this.f____CreatedBy;
            v____new.f____CreateDate = this.f____CreateDate;
            v____new.f____UpdatedBy = this.f____UpdatedBy;
            v____new.f____UpdateDate = this.f____UpdateDate;
            v____new.f____HistoryId = this.f____HistoryId;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private Orders m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as Orders);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<Orders>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int64 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeAutoInc)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.DateTime? f____Date;

        [RemObjects.DataAbstract.Linq.FieldName("Date")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.DateTime? Date {
            get {
                return this.f____Date;
            }
            set {
                if (System.Collections.Generic.Comparer<System.DateTime?>.Default.Compare(this.f____Date, value) != 0) {
                    this.OnPropertyChanging("Date");
                    this.f____Date = value;
                    this.OnPropertyChanged("Date");
                }
            }
        }

        private System.Int16? f____Status;

        [RemObjects.DataAbstract.Linq.FieldName("Status")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int16? Status {
            get {
                return this.f____Status;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int16?>.Default.Compare(this.f____Status, value) != 0) {
                    this.OnPropertyChanging("Status");
                    this.f____Status = value;
                    this.OnPropertyChanged("Status");
                }
            }
        }

        private System.Int16? f____Type;

        [RemObjects.DataAbstract.Linq.FieldName("Type")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int16? Type {
            get {
                return this.f____Type;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int16?>.Default.Compare(this.f____Type, value) != 0) {
                    this.OnPropertyChanging("Type");
                    this.f____Type = value;
                    this.OnPropertyChanged("Type");
                }
            }
        }

        private System.Int32? f____Contractor;

        [RemObjects.DataAbstract.Linq.FieldName("Contractor")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? Contractor {
            get {
                return this.f____Contractor;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____Contractor, value) != 0) {
                    this.OnPropertyChanging("Contractor");
                    this.f____Contractor = value;
                    this.OnPropertyChanged("Contractor");
                }
            }
        }

        private System.Int32? f____Manager;

        [RemObjects.DataAbstract.Linq.FieldName("Manager")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? Manager {
            get {
                return this.f____Manager;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____Manager, value) != 0) {
                    this.OnPropertyChanging("Manager");
                    this.f____Manager = value;
                    this.OnPropertyChanged("Manager");
                }
            }
        }

        private System.Int32? f____CreatedBy;

        [RemObjects.DataAbstract.Linq.FieldName("CreatedBy")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? CreatedBy {
            get {
                return this.f____CreatedBy;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____CreatedBy, value) != 0) {
                    this.OnPropertyChanging("CreatedBy");
                    this.f____CreatedBy = value;
                    this.OnPropertyChanged("CreatedBy");
                }
            }
        }

        private System.DateTime? f____CreateDate;

        [RemObjects.DataAbstract.Linq.FieldName("CreateDate")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.DateTime? CreateDate {
            get {
                return this.f____CreateDate;
            }
            set {
                if (System.Collections.Generic.Comparer<System.DateTime?>.Default.Compare(this.f____CreateDate, value) != 0) {
                    this.OnPropertyChanging("CreateDate");
                    this.f____CreateDate = value;
                    this.OnPropertyChanged("CreateDate");
                }
            }
        }

        private System.Int32? f____UpdatedBy;

        [RemObjects.DataAbstract.Linq.FieldName("UpdatedBy")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? UpdatedBy {
            get {
                return this.f____UpdatedBy;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____UpdatedBy, value) != 0) {
                    this.OnPropertyChanging("UpdatedBy");
                    this.f____UpdatedBy = value;
                    this.OnPropertyChanged("UpdatedBy");
                }
            }
        }

        private System.DateTime? f____UpdateDate;

        [RemObjects.DataAbstract.Linq.FieldName("UpdateDate")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.DateTime? UpdateDate {
            get {
                return this.f____UpdateDate;
            }
            set {
                if (System.Collections.Generic.Comparer<System.DateTime?>.Default.Compare(this.f____UpdateDate, value) != 0) {
                    this.OnPropertyChanging("UpdateDate");
                    this.f____UpdateDate = value;
                    this.OnPropertyChanged("UpdateDate");
                }
            }
        }

        private System.Int64? f____HistoryId;

        [RemObjects.DataAbstract.Linq.FieldName("HistoryId")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64? HistoryId {
            get {
                return this.f____HistoryId;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64?>.Default.Compare(this.f____HistoryId, value) != 0) {
                    this.OnPropertyChanging("HistoryId");
                    this.f____HistoryId = value;
                    this.OnPropertyChanged("HistoryId");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("PriceList")]
    public partial class PriceList : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            PriceList v____new = new PriceList();
            v____new.f____Product = this.f____Product;
            v____new.f____StartDate = this.f____StartDate;
            v____new.f____Price = this.f____Price;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private PriceList m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as PriceList);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<PriceList>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int32 f____Product;

        [RemObjects.DataAbstract.Linq.FieldName("Product")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32 Product {
            get {
                return this.f____Product;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32>.Default.Compare(this.f____Product, value) != 0) {
                    this.OnPropertyChanging("Product");
                    this.f____Product = value;
                    this.OnPropertyChanged("Product");
                }
            }
        }

        private System.DateTime f____StartDate;

        [RemObjects.DataAbstract.Linq.FieldName("StartDate")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.DateTime StartDate {
            get {
                return this.f____StartDate;
            }
            set {
                if (System.Collections.Generic.Comparer<System.DateTime>.Default.Compare(this.f____StartDate, value) != 0) {
                    this.OnPropertyChanging("StartDate");
                    this.f____StartDate = value;
                    this.OnPropertyChanged("StartDate");
                }
            }
        }

        private System.Double f____Price;

        [RemObjects.DataAbstract.Linq.FieldName("Price")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Float)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Double Price {
            get {
                return this.f____Price;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Double>.Default.Compare(this.f____Price, value) != 0) {
                    this.OnPropertyChanging("Price");
                    this.f____Price = value;
                    this.OnPropertyChanged("Price");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("ProductGroups")]
    public partial class ProductGroups : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            ProductGroups v____new = new ProductGroups();
            v____new.f____Id = this.f____Id;
            v____new.f____Parent = this.f____Parent;
            v____new.f____Name = this.f____Name;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private ProductGroups m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as ProductGroups);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<ProductGroups>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int64 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeAutoInc)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.Int32? f____Parent;

        [RemObjects.DataAbstract.Linq.FieldName("Parent")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? Parent {
            get {
                return this.f____Parent;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____Parent, value) != 0) {
                    this.OnPropertyChanging("Parent");
                    this.f____Parent = value;
                    this.OnPropertyChanged("Parent");
                }
            }
        }

        private System.String f____Name;

        [RemObjects.DataAbstract.Linq.FieldName("Name")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Name {
            get {
                return this.f____Name;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Name, value) != 0) {
                    this.OnPropertyChanging("Name");
                    this.f____Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("Products")]
    public partial class Products : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            Products v____new = new Products();
            v____new.f____Id = this.f____Id;
            v____new.f____Code = this.f____Code;
            v____new.f____Name = this.f____Name;
            v____new.f____Details = this.f____Details;
            v____new.f____URL = this.f____URL;
            v____new.f____Warranty = this.f____Warranty;
            v____new.f____Obsolete = this.f____Obsolete;
            v____new.f____Notes = this.f____Notes;
            v____new.f____Vendor = this.f____Vendor;
            v____new.f____Group = this.f____Group;
            v____new.f____MinAmount = this.f____MinAmount;
            v____new.f____MaxAmount = this.f____MaxAmount;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private Products m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as Products);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<Products>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int64 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeAutoInc)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.String f____Code;

        [RemObjects.DataAbstract.Linq.FieldName("Code")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Code {
            get {
                return this.f____Code;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Code, value) != 0) {
                    this.OnPropertyChanging("Code");
                    this.f____Code = value;
                    this.OnPropertyChanged("Code");
                }
            }
        }

        private System.String f____Name;

        [RemObjects.DataAbstract.Linq.FieldName("Name")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Name {
            get {
                return this.f____Name;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Name, value) != 0) {
                    this.OnPropertyChanging("Name");
                    this.f____Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private System.String f____Details;

        [RemObjects.DataAbstract.Linq.FieldName("Details")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Details {
            get {
                return this.f____Details;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Details, value) != 0) {
                    this.OnPropertyChanging("Details");
                    this.f____Details = value;
                    this.OnPropertyChanged("Details");
                }
            }
        }

        private System.String f____URL;

        [RemObjects.DataAbstract.Linq.FieldName("URL")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String URL {
            get {
                return this.f____URL;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____URL, value) != 0) {
                    this.OnPropertyChanging("URL");
                    this.f____URL = value;
                    this.OnPropertyChanged("URL");
                }
            }
        }

        private System.Int16? f____Warranty;

        [RemObjects.DataAbstract.Linq.FieldName("Warranty")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int16? Warranty {
            get {
                return this.f____Warranty;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int16?>.Default.Compare(this.f____Warranty, value) != 0) {
                    this.OnPropertyChanging("Warranty");
                    this.f____Warranty = value;
                    this.OnPropertyChanged("Warranty");
                }
            }
        }

        private System.Boolean f____Obsolete;

        [RemObjects.DataAbstract.Linq.FieldName("Obsolete")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Boolean)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Boolean Obsolete {
            get {
                return this.f____Obsolete;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Boolean>.Default.Compare(this.f____Obsolete, value) != 0) {
                    this.OnPropertyChanging("Obsolete");
                    this.f____Obsolete = value;
                    this.OnPropertyChanged("Obsolete");
                }
            }
        }

        private System.String f____Notes;

        [RemObjects.DataAbstract.Linq.FieldName("Notes")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideMemo)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Notes {
            get {
                return this.f____Notes;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Notes, value) != 0) {
                    this.OnPropertyChanging("Notes");
                    this.f____Notes = value;
                    this.OnPropertyChanged("Notes");
                }
            }
        }

        private System.Int32? f____Vendor;

        [RemObjects.DataAbstract.Linq.FieldName("Vendor")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? Vendor {
            get {
                return this.f____Vendor;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____Vendor, value) != 0) {
                    this.OnPropertyChanging("Vendor");
                    this.f____Vendor = value;
                    this.OnPropertyChanged("Vendor");
                }
            }
        }

        private System.Int32 f____Group;

        [RemObjects.DataAbstract.Linq.FieldName("Group")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32 Group {
            get {
                return this.f____Group;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32>.Default.Compare(this.f____Group, value) != 0) {
                    this.OnPropertyChanging("Group");
                    this.f____Group = value;
                    this.OnPropertyChanged("Group");
                }
            }
        }

        private System.Int32? f____MinAmount;

        [RemObjects.DataAbstract.Linq.FieldName("MinAmount")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? MinAmount {
            get {
                return this.f____MinAmount;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____MinAmount, value) != 0) {
                    this.OnPropertyChanging("MinAmount");
                    this.f____MinAmount = value;
                    this.OnPropertyChanged("MinAmount");
                }
            }
        }

        private System.Int32? f____MaxAmount;

        [RemObjects.DataAbstract.Linq.FieldName("MaxAmount")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? MaxAmount {
            get {
                return this.f____MaxAmount;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____MaxAmount, value) != 0) {
                    this.OnPropertyChanging("MaxAmount");
                    this.f____MaxAmount = value;
                    this.OnPropertyChanged("MaxAmount");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("Roles")]
    public partial class Roles : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            Roles v____new = new Roles();
            v____new.f____Id = this.f____Id;
            v____new.f____Name = this.f____Name;
            v____new.f____CanManageOrderTypes = this.f____CanManageOrderTypes;
            v____new.f____CanManagePrices = this.f____CanManagePrices;
            v____new.f____CanManageClients = this.f____CanManageClients;
            v____new.f____CanManageProviders = this.f____CanManageProviders;
            v____new.f____CanSeeReports = this.f____CanSeeReports;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private Roles m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as Roles);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<Roles>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int32 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.String f____Name;

        [RemObjects.DataAbstract.Linq.FieldName("Name")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Name {
            get {
                return this.f____Name;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Name, value) != 0) {
                    this.OnPropertyChanging("Name");
                    this.f____Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private System.Int32? f____CanManageOrderTypes;

        [RemObjects.DataAbstract.Linq.FieldName("CanManageOrderTypes")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Integer)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int32? CanManageOrderTypes {
            get {
                return this.f____CanManageOrderTypes;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int32?>.Default.Compare(this.f____CanManageOrderTypes, value) != 0) {
                    this.OnPropertyChanging("CanManageOrderTypes");
                    this.f____CanManageOrderTypes = value;
                    this.OnPropertyChanged("CanManageOrderTypes");
                }
            }
        }

        private System.Boolean? f____CanManagePrices;

        [RemObjects.DataAbstract.Linq.FieldName("CanManagePrices")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Boolean)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Boolean? CanManagePrices {
            get {
                return this.f____CanManagePrices;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Boolean?>.Default.Compare(this.f____CanManagePrices, value) != 0) {
                    this.OnPropertyChanging("CanManagePrices");
                    this.f____CanManagePrices = value;
                    this.OnPropertyChanged("CanManagePrices");
                }
            }
        }

        private System.Boolean? f____CanManageClients;

        [RemObjects.DataAbstract.Linq.FieldName("CanManageClients")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Boolean)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Boolean? CanManageClients {
            get {
                return this.f____CanManageClients;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Boolean?>.Default.Compare(this.f____CanManageClients, value) != 0) {
                    this.OnPropertyChanging("CanManageClients");
                    this.f____CanManageClients = value;
                    this.OnPropertyChanged("CanManageClients");
                }
            }
        }

        private System.Boolean? f____CanManageProviders;

        [RemObjects.DataAbstract.Linq.FieldName("CanManageProviders")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Boolean)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Boolean? CanManageProviders {
            get {
                return this.f____CanManageProviders;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Boolean?>.Default.Compare(this.f____CanManageProviders, value) != 0) {
                    this.OnPropertyChanging("CanManageProviders");
                    this.f____CanManageProviders = value;
                    this.OnPropertyChanged("CanManageProviders");
                }
            }
        }

        private System.Boolean? f____CanSeeReports;

        [RemObjects.DataAbstract.Linq.FieldName("CanSeeReports")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.Boolean)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Boolean? CanSeeReports {
            get {
                return this.f____CanSeeReports;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Boolean?>.Default.Compare(this.f____CanSeeReports, value) != 0) {
                    this.OnPropertyChanging("CanSeeReports");
                    this.f____CanSeeReports = value;
                    this.OnPropertyChanged("CanSeeReports");
                }
            }
        }
    }

    [RemObjects.DataAbstract.Linq.TableName("Vendors")]
    public partial class Vendors : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        public object Clone() {
            Vendors v____new = new Vendors();
            v____new.f____Id = this.f____Id;
            v____new.f____Code = this.f____Code;
            v____new.f____Name = this.f____Name;
            v____new.f____VendorSite = this.f____VendorSite;
            return v____new;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string parameterName) {
            if ((this.PropertyChanged != null) && (this.m____OldValues == null))
                this.PropertyChanged.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
        }

        protected void OnPropertyChanging(string parameterName) {
            if (this.PropertyChanging != null)
                this.PropertyChanging.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
        }

        private Vendors m____OldValues;

        public void BeginUpdate() {
            this.m____OldValues = (this.Clone() as Vendors);
        }

        public void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<Vendors>(this.m____OldValues, this);
            this.m____OldValues = null;
        }

        public void CancelUpdate() {
            this.m____OldValues = null;
        }

        private System.Int64 f____Id;

        [RemObjects.DataAbstract.Linq.FieldName("Id")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeAutoInc)]
        [RemObjects.DataAbstract.Linq.PrimaryKey]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.Int64 Id {
            get {
                return this.f____Id;
            }
            set {
                if (System.Collections.Generic.Comparer<System.Int64>.Default.Compare(this.f____Id, value) != 0) {
                    this.OnPropertyChanging("Id");
                    this.f____Id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        private System.String f____Code;

        [RemObjects.DataAbstract.Linq.FieldName("Code")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Code {
            get {
                return this.f____Code;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Code, value) != 0) {
                    this.OnPropertyChanging("Code");
                    this.f____Code = value;
                    this.OnPropertyChanged("Code");
                }
            }
        }

        private System.String f____Name;

        [RemObjects.DataAbstract.Linq.FieldName("Name")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String Name {
            get {
                return this.f____Name;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____Name, value) != 0) {
                    this.OnPropertyChanging("Name");
                    this.f____Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private System.String f____VendorSite;

        [RemObjects.DataAbstract.Linq.FieldName("VendorSite")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges]
        public System.String VendorSite {
            get {
                return this.f____VendorSite;
            }
            set {
                if (System.Collections.Generic.Comparer<System.String>.Default.Compare(this.f____VendorSite, value) != 0) {
                    this.OnPropertyChanging("VendorSite");
                    this.f____VendorSite = value;
                    this.OnPropertyChanged("VendorSite");
                }
            }
        }
    }

    public partial class DataContext {
        public DataContext() {
        }

        private System.Collections.Generic.IEnumerable<Agents> f____Agents;

        public System.Collections.Generic.IEnumerable<Agents> Agents {
            get {
                return this.f____Agents;
            }
            set {
                this.f____Agents = value;
            }
        }

        private System.Collections.Generic.IEnumerable<History> f____History;

        public System.Collections.Generic.IEnumerable<History> History {
            get {
                return this.f____History;
            }
            set {
                this.f____History = value;
            }
        }

        private System.Collections.Generic.IEnumerable<OrderDetails> f____OrderDetails;

        public System.Collections.Generic.IEnumerable<OrderDetails> OrderDetails {
            get {
                return this.f____OrderDetails;
            }
            set {
                this.f____OrderDetails = value;
            }
        }

        private System.Collections.Generic.IEnumerable<OrderStatus> f____OrderStatus;

        public System.Collections.Generic.IEnumerable<OrderStatus> OrderStatus {
            get {
                return this.f____OrderStatus;
            }
            set {
                this.f____OrderStatus = value;
            }
        }

        private System.Collections.Generic.IEnumerable<OrderType> f____OrderType;

        public System.Collections.Generic.IEnumerable<OrderType> OrderType {
            get {
                return this.f____OrderType;
            }
            set {
                this.f____OrderType = value;
            }
        }

        private System.Collections.Generic.IEnumerable<Orders> f____Orders;

        public System.Collections.Generic.IEnumerable<Orders> Orders {
            get {
                return this.f____Orders;
            }
            set {
                this.f____Orders = value;
            }
        }

        private System.Collections.Generic.IEnumerable<PriceList> f____PriceList;

        public System.Collections.Generic.IEnumerable<PriceList> PriceList {
            get {
                return this.f____PriceList;
            }
            set {
                this.f____PriceList = value;
            }
        }

        private System.Collections.Generic.IEnumerable<ProductGroups> f____ProductGroups;

        public System.Collections.Generic.IEnumerable<ProductGroups> ProductGroups {
            get {
                return this.f____ProductGroups;
            }
            set {
                this.f____ProductGroups = value;
            }
        }

        private System.Collections.Generic.IEnumerable<Products> f____Products;

        public System.Collections.Generic.IEnumerable<Products> Products {
            get {
                return this.f____Products;
            }
            set {
                this.f____Products = value;
            }
        }

        private System.Collections.Generic.IEnumerable<Roles> f____Roles;

        public System.Collections.Generic.IEnumerable<Roles> Roles {
            get {
                return this.f____Roles;
            }
            set {
                this.f____Roles = value;
            }
        }

        private System.Collections.Generic.IEnumerable<Vendors> f____Vendors;

        public System.Collections.Generic.IEnumerable<Vendors> Vendors {
            get {
                return this.f____Vendors;
            }
            set {
                this.f____Vendors = value;
            }
        }
    }

}
