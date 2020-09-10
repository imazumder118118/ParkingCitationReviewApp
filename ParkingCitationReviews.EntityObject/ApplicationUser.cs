// <copyright file="ApplicationUser.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Definition of ApplicationUser Class</summary>

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace ParkingCitationReviews.EntityObjects
{
    /// <summary>
    /// Custom class representing an application role
    /// </summary>
    [Serializable]
    public class ApplicationUser : IComparable
    {
        #region Private Members
        /// <summary>
        ///  Private member field containing user name value
        /// </summary>
        private string name = string.Empty;

        /// <summary>
        ///  Private member field containing user ID value
        /// </summary>
        private string userID = string.Empty;

        /// <summary>
        ///  Private member field containing user first name value
        /// </summary>
        private string fName = string.Empty;

        /// <summary>
        ///  Private member field containing user last name value
        /// </summary>
        private string lName = string.Empty;

        /// <summary>
        ///  Private member field containing user email address value
        /// </summary>
        private string eMail = string.Empty;

        /// <summary>
        ///  Private member field containing user phone number value
        /// </summary>
        private string phone = string.Empty;

        /// <summary>
        ///  Private member field containing user department ID value
        /// </summary>
        private string departmentID = string.Empty;

        /// <summary>
        ///  Private member field containing List collection of user's application roles
        /// </summary>
        private List<ApplicationRole> roles = new List<ApplicationRole>();
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the value for user name
        /// </summary>
        public string UserName
        {
            get
            {
                return this.fName + " " + this.lName;
            }
        }

        /// <summary>
        /// Gets the value for user name as displayed in a list control
        /// </summary>
        public string ListName
        {
            get
            {
                return this.lName + ", " + this.fName;
            }
        }

        /// <summary>
        /// Gets or sets the value for user name as displayed in the log
        /// </summary>
        public string LOGName
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for user ID
        /// </summary>
        public string UserID
        {
            get
            {
                return this.userID;
            }

            set
            {
                this.userID = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for user first name
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.fName;
            }

            set
            {
                this.fName = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for user last name
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lName;
            }

            set
            {
                this.lName = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for user phone number
        /// </summary>
        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                this.phone = value;
            }
        }

        /// <summary>
        /// Gets or sets the List of ApplicationRole objects corresponding to the user's security roles
        /// </summary>
        public List<ApplicationRole> Roles
        {
            get
            {
                return this.roles;
            }

            set
            {
                this.roles = value;
            }
        }
        #endregion

        #region IComparable Members

        /// <summary>
        /// Compares this instance with a specified object
        /// </summary>
        /// <param name="obj">object to compare this object to</param>
        /// <returns>Integer indicating the result of performing the CompareTo method on ListName of the passed in object with the ListName of this object as a parameter</returns>
        public int CompareTo(object obj)
        {
            ApplicationUser comp = (ApplicationUser)obj;
            return this.ListName.CompareTo(comp.ListName);
        }
        #endregion

        #region Override Equals

        /// <summary>
        /// Overrides the Equals method for ApplicationUser
        /// </summary>
        /// <param name="obj">object to test equality against</param>
        /// <returns>Boolean indicating whether the two object equal one another</returns>
        public override bool Equals(object obj)
        {
            // Check for null & type match
            if (obj == null || this.GetType() != obj.GetType() || this.ListName == string.Empty)
            {
                return false;
            }

            ApplicationUser u = (ApplicationUser)obj;
            return this.ListName.Trim().ToLower() == u.ListName.Trim().ToLower();
        }
        #endregion
    }
}
