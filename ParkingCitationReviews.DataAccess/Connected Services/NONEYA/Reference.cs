﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkingCitationReviews.DataAccess.NONEYA {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentInfo", Namespace="http://ci.richmond.va.us/services")]
    [System.SerializableAttribute()]
    public partial class DepartmentInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInformation", Namespace="http://ci.richmond.va.us/services")]
    [System.SerializableAttribute()]
    public partial class UserInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BureauIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BureauNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistinguishedNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DivisionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DivisionNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoneyaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuffixField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] WindowsLogonField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BureauId {
            get {
                return this.BureauIdField;
            }
            set {
                if ((this.BureauIdField.Equals(value) != true)) {
                    this.BureauIdField = value;
                    this.RaisePropertyChanged("BureauId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BureauName {
            get {
                return this.BureauNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BureauNameField, value) != true)) {
                    this.BureauNameField = value;
                    this.RaisePropertyChanged("BureauName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DepartmentId {
            get {
                return this.DepartmentIdField;
            }
            set {
                if ((this.DepartmentIdField.Equals(value) != true)) {
                    this.DepartmentIdField = value;
                    this.RaisePropertyChanged("DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DistinguishedName {
            get {
                return this.DistinguishedNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DistinguishedNameField, value) != true)) {
                    this.DistinguishedNameField = value;
                    this.RaisePropertyChanged("DistinguishedName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DivisionId {
            get {
                return this.DivisionIdField;
            }
            set {
                if ((this.DivisionIdField.Equals(value) != true)) {
                    this.DivisionIdField = value;
                    this.RaisePropertyChanged("DivisionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DivisionName {
            get {
                return this.DivisionNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DivisionNameField, value) != true)) {
                    this.DivisionNameField = value;
                    this.RaisePropertyChanged("DivisionName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoneyaId {
            get {
                return this.NoneyaIdField;
            }
            set {
                if ((this.NoneyaIdField.Equals(value) != true)) {
                    this.NoneyaIdField = value;
                    this.RaisePropertyChanged("NoneyaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Suffix {
            get {
                return this.SuffixField;
            }
            set {
                if ((object.ReferenceEquals(this.SuffixField, value) != true)) {
                    this.SuffixField = value;
                    this.RaisePropertyChanged("Suffix");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelephoneNumber {
            get {
                return this.TelephoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneNumberField, value) != true)) {
                    this.TelephoneNumberField = value;
                    this.RaisePropertyChanged("TelephoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] WindowsLogon {
            get {
                return this.WindowsLogonField;
            }
            set {
                if ((object.ReferenceEquals(this.WindowsLogonField, value) != true)) {
                    this.WindowsLogonField = value;
                    this.RaisePropertyChanged("WindowsLogon");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDepartmentName", Namespace="http://ci.richmond.va.us/services")]
    [System.SerializableAttribute()]
    public partial class UserDepartmentName : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ci.richmond.va.us/services", ConfigurationName="NONEYA.INoneyaWebService")]
    public interface INoneyaWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationHostName", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationHostNameRespons" +
            "e")]
        string GetApplicationHostName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationHostName", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationHostNameRespons" +
            "e")]
        System.Threading.Tasks.Task<string> GetApplicationHostNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRole", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRoleRespon" +
            "se")]
        string[] GetRichvaUsersInAppRole(string appId, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRole", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRoleRespon" +
            "se")]
        System.Threading.Tasks.Task<string[]> GetRichvaUsersInAppRoleAsync(string appId, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRoleDepart" +
            "ment", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRoleDepart" +
            "mentResponse")]
        string[] GetRichvaUsersInAppRoleDepartment(string appId, string role, string department);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRoleDepart" +
            "ment", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetRichvaUsersInAppRoleDepart" +
            "mentResponse")]
        System.Threading.Tasks.Task<string[]> GetRichvaUsersInAppRoleDepartmentAsync(string appId, string role, string department);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersInRole", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersInRoleResponse")]
        string[] GetUsersInRole(string appId, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersInRole", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersInRoleResponse")]
        System.Threading.Tasks.Task<string[]> GetUsersInRoleAsync(string appId, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/IsAuthorized", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/IsAuthorizedResponse")]
        bool IsAuthorized(string appId, string userLogonName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/IsAuthorized", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/IsAuthorizedResponse")]
        System.Threading.Tasks.Task<bool> IsAuthorizedAsync(string appId, string userLogonName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/IsInRole", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/IsInRoleResponse")]
        bool IsInRole(string appId, string role, string userLogonName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/IsInRole", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/IsInRoleResponse")]
        System.Threading.Tasks.Task<bool> IsInRoleAsync(string appId, string role, string userLogonName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationRoles", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationRolesResponse")]
        string[] GetApplicationRoles(string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationRoles", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetApplicationRolesResponse")]
        System.Threading.Tasks.Task<string[]> GetApplicationRolesAsync(string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUserRoles", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUserRolesResponse")]
        string[] GetUserRoles(string appId, string userLogonName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUserRoles", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUserRolesResponse")]
        System.Threading.Tasks.Task<string[]> GetUserRolesAsync(string appId, string userLogonName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartments", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartmentsResponse")]
        string[] GetDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartments", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartmentsResponse")]
        System.Threading.Tasks.Task<string[]> GetDepartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartmentsInfo", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartmentsInfoResponse")]
        ParkingCitationReviews.DataAccess.NONEYA.DepartmentInfo[] GetDepartmentsInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartmentsInfo", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetDepartmentsInfoResponse")]
        System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.DepartmentInfo[]> GetDepartmentsInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformation", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformationResponse")]
        ParkingCitationReviews.DataAccess.NONEYA.UserInformation GetUserInformation(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformation", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformationResponse")]
        System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.UserInformation> GetUserInformationAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformationFromId", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformationFromIdRespo" +
            "nse")]
        ParkingCitationReviews.DataAccess.NONEYA.UserInformation GetUserInformationFromId(int noneyaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformationFromId", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUserInformationFromIdRespo" +
            "nse")]
        System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.UserInformation> GetUserInformationFromIdAsync(int noneyaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersDepartmentName", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersDepartmentNameRespons" +
            "e")]
        ParkingCitationReviews.DataAccess.NONEYA.UserDepartmentName GetUsersDepartmentName(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersDepartmentName", ReplyAction="http://ci.richmond.va.us/services/INoneyaWebService/GetUsersDepartmentNameRespons" +
            "e")]
        System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.UserDepartmentName> GetUsersDepartmentNameAsync(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INoneyaWebServiceChannel : ParkingCitationReviews.DataAccess.NONEYA.INoneyaWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NoneyaWebServiceClient : System.ServiceModel.ClientBase<ParkingCitationReviews.DataAccess.NONEYA.INoneyaWebService>, ParkingCitationReviews.DataAccess.NONEYA.INoneyaWebService {
        
        public NoneyaWebServiceClient() {
        }
        
        public NoneyaWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NoneyaWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NoneyaWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NoneyaWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetApplicationHostName() {
            return base.Channel.GetApplicationHostName();
        }
        
        public System.Threading.Tasks.Task<string> GetApplicationHostNameAsync() {
            return base.Channel.GetApplicationHostNameAsync();
        }
        
        public string[] GetRichvaUsersInAppRole(string appId, string role) {
            return base.Channel.GetRichvaUsersInAppRole(appId, role);
        }
        
        public System.Threading.Tasks.Task<string[]> GetRichvaUsersInAppRoleAsync(string appId, string role) {
            return base.Channel.GetRichvaUsersInAppRoleAsync(appId, role);
        }
        
        public string[] GetRichvaUsersInAppRoleDepartment(string appId, string role, string department) {
            return base.Channel.GetRichvaUsersInAppRoleDepartment(appId, role, department);
        }
        
        public System.Threading.Tasks.Task<string[]> GetRichvaUsersInAppRoleDepartmentAsync(string appId, string role, string department) {
            return base.Channel.GetRichvaUsersInAppRoleDepartmentAsync(appId, role, department);
        }
        
        public string[] GetUsersInRole(string appId, string role) {
            return base.Channel.GetUsersInRole(appId, role);
        }
        
        public System.Threading.Tasks.Task<string[]> GetUsersInRoleAsync(string appId, string role) {
            return base.Channel.GetUsersInRoleAsync(appId, role);
        }
        
        public bool IsAuthorized(string appId, string userLogonName) {
            return base.Channel.IsAuthorized(appId, userLogonName);
        }
        
        public System.Threading.Tasks.Task<bool> IsAuthorizedAsync(string appId, string userLogonName) {
            return base.Channel.IsAuthorizedAsync(appId, userLogonName);
        }
        
        public bool IsInRole(string appId, string role, string userLogonName) {
            return base.Channel.IsInRole(appId, role, userLogonName);
        }
        
        public System.Threading.Tasks.Task<bool> IsInRoleAsync(string appId, string role, string userLogonName) {
            return base.Channel.IsInRoleAsync(appId, role, userLogonName);
        }
        
        public string[] GetApplicationRoles(string appId) {
            return base.Channel.GetApplicationRoles(appId);
        }
        
        public System.Threading.Tasks.Task<string[]> GetApplicationRolesAsync(string appId) {
            return base.Channel.GetApplicationRolesAsync(appId);
        }
        
        public string[] GetUserRoles(string appId, string userLogonName) {
            return base.Channel.GetUserRoles(appId, userLogonName);
        }
        
        public System.Threading.Tasks.Task<string[]> GetUserRolesAsync(string appId, string userLogonName) {
            return base.Channel.GetUserRolesAsync(appId, userLogonName);
        }
        
        public string[] GetDepartments() {
            return base.Channel.GetDepartments();
        }
        
        public System.Threading.Tasks.Task<string[]> GetDepartmentsAsync() {
            return base.Channel.GetDepartmentsAsync();
        }
        
        public ParkingCitationReviews.DataAccess.NONEYA.DepartmentInfo[] GetDepartmentsInfo() {
            return base.Channel.GetDepartmentsInfo();
        }
        
        public System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.DepartmentInfo[]> GetDepartmentsInfoAsync() {
            return base.Channel.GetDepartmentsInfoAsync();
        }
        
        public ParkingCitationReviews.DataAccess.NONEYA.UserInformation GetUserInformation(string userName) {
            return base.Channel.GetUserInformation(userName);
        }
        
        public System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.UserInformation> GetUserInformationAsync(string userName) {
            return base.Channel.GetUserInformationAsync(userName);
        }
        
        public ParkingCitationReviews.DataAccess.NONEYA.UserInformation GetUserInformationFromId(int noneyaId) {
            return base.Channel.GetUserInformationFromId(noneyaId);
        }
        
        public System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.UserInformation> GetUserInformationFromIdAsync(int noneyaId) {
            return base.Channel.GetUserInformationFromIdAsync(noneyaId);
        }
        
        public ParkingCitationReviews.DataAccess.NONEYA.UserDepartmentName GetUsersDepartmentName(string userName) {
            return base.Channel.GetUsersDepartmentName(userName);
        }
        
        public System.Threading.Tasks.Task<ParkingCitationReviews.DataAccess.NONEYA.UserDepartmentName> GetUsersDepartmentNameAsync(string userName) {
            return base.Channel.GetUsersDepartmentNameAsync(userName);
        }
    }
}
