// <copyright file="ApplicationRole.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Definition of ApplicationRole Class</summary>

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace ParkingCitationReviews.EntityObjects
{
    /// <summary>
    /// Custom class representing an application role
    /// </summary>
    [Serializable]
    public class ApplicationRole : IComparable
    {

        
        /// <summary>
        ///  Private member field containing role name value
        /// </summary>
        private string roleName = string.Empty;

        /// <summary>
        ///  Private member field containing role ID value
        /// </summary>
        private string roleID = string.Empty;

        /// <summary>
        /// Private member field containing role description value
        /// </summary>
        private string roleDescription = string.Empty;

        /// <summary>
        /// Private member field containing application name value
        /// </summary>
        private string applicationName = string.Empty;

        /// <summary>
        /// Private member field containing application ID value
        /// </summary>
        private string applicationID = string.Empty;

        /// <summary>
        /// Private member field containing boolean value for whether or not the role is active
        /// </summary>
        private bool isActive = false;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ApplicationRole class with no input parameters
        /// </summary>
        public ApplicationRole()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationRole class with input parameter for role name
        /// </summary>
        /// <param name="roleName">String value of role name</param>
        public ApplicationRole(string roleName)
        {
            this.roleName = roleName;
        }
        #endregion

        /// <summary>
        /// Gets or sets the value for role name
        /// </summary>
        public string RoleName
        {
            get
            {
                return this.roleName;
            }

            set
            {
                this.roleName = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for role ID
        /// </summary>
        public string RoleID
        {
            get
            {
                return this.roleID;
            }

            set
            {
                this.roleID = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for role description
        /// </summary>
        public string RoleDescription
        {
            get
            {
                return this.roleDescription;
            }

            set
            {
                this.roleDescription = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for application name
        /// </summary>
        public string ApplicationName
        {
            get
            {
                return this.applicationName;
            }

            set
            {
                this.applicationName = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for application ID
        /// </summary>
        public string ApplicationID
        {
            get
            {
                return this.applicationID;
            }

            set
            {
                this.applicationID = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the role is active
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this.isActive;
            }

            set
            {
                this.isActive = value;
            }
        }

        #region IComparable Members

        /// <summary>
        /// Compares this instance with a specified object
        /// </summary>
        /// <param name="obj">object to compare this object to</param>
        /// <returns>Integer indicating the result of performing the CompareTo method on RoleName of the passed in object with the RoleName of this object as a parameter</returns>
        public int CompareTo(object obj)
        {
            ApplicationRole r = (ApplicationRole)obj;
            return r.RoleName.CompareTo(this.RoleName);
        }
        #endregion

        #region Override Equals

        /// <summary>
        /// Overrides the Equals method for ApplicationRole
        /// </summary>
        /// <param name="obj">object to test equality against</param>
        /// <returns>Boolean indicating whether the two object equal one another</returns>
        public override bool Equals(object obj)
        {
            // Check for null & type match
            if (obj == null || this.GetType() != obj.GetType() || this.roleName == string.Empty)
            {
                return false;
            }

            ApplicationRole r = (ApplicationRole)obj;
            if (this.roleName.Trim().ToLower() == r.RoleName.Trim().ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
