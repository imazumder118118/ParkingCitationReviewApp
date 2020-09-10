// <copyright file="ISecurityTasks.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Business Tier Interface for handling security tasks</summary>

using System;
using System.Collections.Generic;
using System.Text;
using ParkingCitationReviews.EntityObjects;

namespace ParkingCitationReviews.Business.Interfaces
{
    /// <summary>
    /// Business Tier Interface for handling security tasks
    /// </summary>
    public interface ISecurityTasks
    {
        /// <summary>
        /// Retrieves user object for a given platform(e.g.Windows,Unix etc.) based on user ID
        /// </summary>
        /// <param name="platformUserID">platform user ID value</param>
        /// <returns>ApplicationUser oject containing user data</returns>
        ApplicationUser GetApplicationUserByPlatform(string platformUserID);

        /// <summary>
        /// Retrieves string containing user name for a given user ID
        /// </summary>
        /// <param name="userID">user ID value</param>
        /// <returns>string containing user name</returns>
        string GetUserNameByID(int userID);

        /// <summary>
        /// Retrieves all of the security roles for the application
        /// </summary>
        /// <returns>List collection of ApplicationRole objects</returns>
        List<ApplicationRole> GetApplicationRoles();

        /// <summary>
        /// Retrieves an ApplicationRole object based on a specified role name
        /// </summary>
        /// <param name="roleName">Name of the security role</param>
        /// <returns>ApplicationRole oject corresponding to teh specified role name</returns>
        ApplicationRole GetApplicationRoleByName(string roleName);

        /// <summary>
        /// Retrieves a List of ApplicationUser objects corresponding to users in a given role
        /// </summary>
        /// <param name="roleName">role name value</param>
        /// <returns>List of ApplicationUser objects</returns>
        List<ApplicationUser> GetListOfUsersInRole(string roleName);

        /// <summary>
        /// Retrieves the name of a reviewer corresponding to a given reviewer ID
        /// </summary>
        /// <param name="reviewerID">reviewer ID value</param>
        /// <returns>Name of the reviewer as a string</returns>
        string GetReviewerNameByID(string reviewerID);
    }
}
