// <copyright file="SecurityTasks.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Business Tier Class for handling security tasks</summary>

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
using ParkingCitationReviews.Business.Interfaces;
using ParkingCitationReviews.EntityObjects;
using ParkingCitationReviews.DataAccess;


namespace ParkingCitationReviews.Business
{
    /// <summary>
    /// Business Tier Class for handling security tasks
    /// </summary>
    public class SecurityTasks : ISecurityTasks
    {
        /// <summary>
        /// Private member field for interfacing with SecurityData class in the data access tier 
        /// </summary>
        private readonly ISecurityData securityData;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the SecurityTasks class with an input parameter for SecurityData
        /// </summary>
        /// <param name="securityData">SecurityData object passed</param>
        public SecurityTasks(ISecurityData securityData)
        {
            this.securityData = securityData;
        }

        /// <summary>
        /// Initializes a new instance of the SecurityTasks class with no input parameters
        /// </summary>
        public SecurityTasks() : this(new SecurityData())
        {
        }
        #endregion

        /// <summary>
        /// Retrieves user object for a given platform(e.g.Windows,Unix etc.) based on user ID
        /// </summary>
        /// <param name="platformUserID">platform user ID value</param>
        /// <returns>ApplicationUser oject containing user data</returns>
        #region GetApplicationUser By Platform
        public ApplicationUser GetApplicationUserByPlatform(string platformUserID)
        {
            try
            {
                return this.securityData.GetApplicationUserByPlatform(platformUserID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// Retrieves string containing user name for a given user ID
        /// </summary>
        /// <param name="userID">user ID value</param>
        /// <returns>string containing user name</returns>
        public string GetUserNameByID(int userID)
        {
            try
            {
                return this.securityData.GetUserNameByID(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves all of the security roles for the application
        /// </summary>
        /// <returns>List collection of ApplicationRole objects</returns>
        public List<ApplicationRole> GetApplicationRoles()
        {
            try
            {
                return this.securityData.GetApplicationRoles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves an ApplicationRole object based on a specified role name
        /// </summary>
        /// <param name="roleName">Name of the security role</param>
        /// <returns>ApplicationRole oject corresponding to teh specified role name</returns>
        public ApplicationRole GetApplicationRoleByName(string roleName)
        {
            try
            {
                return this.securityData.GetApplicationRoleByName(roleName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a List of ApplicationUser objects corresponding to users in a given role
        /// </summary>
        /// <param name="roleName">role name value</param>
        /// <returns>List of ApplicationUser objects</returns>
        public List<ApplicationUser> GetListOfUsersInRole(string roleName)
        {
            try
            {
                return this.securityData.GetListOfUsersInRole(roleName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves the name of a reviewer corresponding to a given reviewer ID
        /// </summary>
        /// <param name="reviewerID">reviewer ID value</param>
        /// <returns>Name of the reviewer as a string</returns>
        public string GetReviewerNameByID(string reviewerID)
        {
            try
            {
                return this.securityData.GetReviewerNameByID(reviewerID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
