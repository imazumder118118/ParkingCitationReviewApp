// <copyright file="SecurityData.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Class for handling data access related to security tasks</summary>

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
using ParkingCitationReviews.EntityObjects;
//using ParkingCitationReviews.Logging;

namespace ParkingCitationReviews.DataAccess
{
    /// <summary>
    /// Class for handling data access related to security tasks
    /// </summary>
    public class SecurityData : ISecurityData
    {
        #region Constructor

        /// <summary>
        /// Private member field for interfacing with a CORInternalSecurity UserTask object 
        /// </summary>
        //private CORSecurity.Task.IUserTask userTask;

        /// <summary>
        /// Private member field for interfacing with a CORInternalSecurity RoleTask object  
        /// </summary>
        //private CORSecurity.Task.IRoleTask roleTask;
        NONEYA.NoneyaWebServiceClient noneya;


        /// <summary>
        /// Initializes a new instance of the SecurityData class
        /// </summary>
        public SecurityData()
        {
            try
            {
                //this.userTask = new CORSecurity.Task.UserTask();
                //this.roleTask = new CORSecurity.Task.RoleTask();

                noneya = new NONEYA.NoneyaWebServiceClient();

            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);

                // throw up to next tier
                throw;
            }
        }
        #endregion

        /// <summary>
        /// Returns an ApplicationUser object based on a given CORInternalSecurity user object
        /// </summary>
        /// <param name="user">CORInternalSecurity user object</param>
        /// <returns>ApplicationUser object</returns>
        //public ApplicationUser GetUser(CORSecurity.Model.IUser user)
        public ApplicationUser MapUser(NONEYA.UserInformation user)
        {
            ApplicationUser aUser = new ApplicationUser();
            try
            {
                if (user != null)
                {
                    //----[[ set user info ]]----//
                    aUser.FirstName = user.FirstName;
                    aUser.LastName = user.LastName;
                    aUser.UserID = user.NoneyaId.ToString();
                    aUser.Phone = user.TelephoneNumber;



                    aUser.Roles = this.GetUserRoles(user.NoneyaId.ToString());

                }

                return aUser;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger
                  //  (ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns an ApplicationRole object based on a given CORInternalSecurity role object
        /// </summary>
        /// <param name="role">CORInternalSecurity role object</param>
        /// <returns>ApplicationRole object</returns>
        //public ApplicationRole GetRole(CORSecurity.Model.IRole role)
        public ApplicationRole MapRole(string role)
        {
            ApplicationRole aRole = new ApplicationRole();
            try
            {
                if (role != null)
                {
                    //----[[ set role info ]]----//
                    aRole.RoleName = role;
                }

                return aRole;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns string containing user name for a given user ID
        /// </summary>
        /// <param name="userID">user ID value</param>
        /// <returns>string containing user name</returns>
        public string GetUserNameByID(int userID)
        {
            //CORSecurity.Model.IUser appUser = null;
            try
            {

                NONEYA.UserInformation appUser = new NONEYA.UserInformation();
                appUser = noneya.GetUserInformationFromId(userID);
                return appUser.LastName + ", " + appUser.FirstName;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns an ApplicationUser object based on a given user ID
        /// </summary>
        /// <param name="userID">user ID value</param>
        /// <returns>ApplicationUser object</returns>
        public ApplicationUser GetApplicationUserByID(string userID)
        {
            //CORSecurity.Model.IUser appUser = null;
            try
            {
                //appUser = this.userTask.GetUser(userID);
                //return this.GetUser(appUser);


                Int32 uID = Convert.ToInt32(userID);
                NONEYA.UserInformation noneyaUser = new NONEYA.UserInformation();
                noneyaUser = noneya.GetUserInformationFromId(uID);
                return this.MapUser(noneyaUser);


            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns an ApplicationUser object for a given platform(e.g.Windows,Unix etc.) based on user ID
        /// </summary>
        /// <param name="platformUserID">user ID value</param>
        /// <returns>ApplicationUser object</returns>
        public ApplicationUser GetApplicationUserByPlatform(string platformUserID)
        {
            //----[[ Instantiate user object ]]----//
            //CORSecurity.Model.IUser appUser = null;
            NONEYA.UserInformation noneyaUser = null;
            try
            {

                //appUser = this.userTask.GetUser(platformUserID, CORSecurity.Model.PlatformTypeEnum.WINDOWSNT);
                //return this.GetUser(appUser);
                noneyaUser = noneya.GetUserInformation(platformUserID);
                return MapUser(noneyaUser);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns a List of ApplicationUser objects corresponding to users in a given role 
        /// </summary>
        /// <param name="roleName">role name value</param>
        /// <returns>List of ApplicationUser objects</returns>
        /// 



        public List<ApplicationUser> GetListOfUsersInRole(string roleName)
        {
            List<ApplicationUser> roleUsers = new List<ApplicationUser>();
            List<NONEYA.UserInformation> noneyaUsers = new List<NONEYA.UserInformation>();
            foreach (string user in noneya.GetUsersInRole(ConfigurationManager.AppSettings["ApplicationSecurityName"].ToString(), roleName))
            {
                noneyaUsers.Add(noneya.GetUserInformation(user));
            }

            for (int i = 0; i < noneyaUsers.Count; i++)
            {
               // check that the user is active and there are no duplicates in the list
                if (i > 0 && noneyaUsers[i].NoneyaId == noneyaUsers[i - 1].NoneyaId || noneyaUsers[i].NoneyaId == 0)
                {
                    continue;
                }
                else
                {
                    ApplicationUser au = MapUser(noneyaUsers[i]);
                    roleUsers.Add(au);
                }
            }
            //foreach (CORSecurity.Model.IUser u in this.userTask.GetUsersInRole(roleName))
            //foreach (NONEYA.UserInformation u in noneyaUsers.)
            //{
            //    // I have to check whether the user is active. The GetUsersInRole method does not check for this
            //    if (u.NoneyaId != 0)
            //    {


            //        //ApplicationUser au = this.GetUser(u);
            //        ApplicationUser au = MapUser(u);
            //        roleUsers.Add(au);
            //    }
            //}

            roleUsers.Sort();
            return roleUsers;
        }


        /// <summary>
        /// Returns a List of ApplicationUser objects for all the users with access to this application
        /// </summary>
        /// <returns>List of ApplicationUser objects</returns>
        public List<ApplicationUser> GetListOfUsersInApp()
        {
            try
            {
                List<ApplicationUser> users = new List<ApplicationUser>();
                string[] noneyaAppRoles = noneya.GetApplicationRoles(ConfigurationManager.AppSettings["ApplicationSecurityName"].ToString());
                List<NONEYA.UserInformation> AppUsers = new List<NONEYA.UserInformation>();
                foreach (string role in noneyaAppRoles)
                {
                    foreach (string username in noneya.GetUsersInRole(ConfigurationManager.AppSettings["ApplicationSecurityName"].ToString(), role))
                    {
                        AppUsers.Add(noneya.GetUserInformation(username));
                    }

                }
                foreach (NONEYA.UserInformation user in AppUsers)
                {
                    users.Add(this.MapUser(user));
                }

                users.Sort();
                return users;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns a List of ApplicationRole objects for all the security roles in this application
        /// </summary>
        /// <returns>List of ApplicationRole objects</returns>
        public List<ApplicationRole> GetApplicationRoles()
        {
            try
            {

                List<string> noneyaRoles = new List<string>(noneya.GetApplicationRoles(ConfigurationManager.AppSettings["ApplicationSecurityName"].ToString()));
                return MapRoles(noneyaRoles);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns an ApplicationRole object based on a given role name
        /// </summary>
        /// <param name="roleName">role name value</param>
        /// <returns>ApplicationRole object</returns>
        public ApplicationRole GetApplicationRoleByName(string roleName)
        {
            //----[[ Instantiate role object ]]----//
            //CORSecurity.Model.IRole appRole = null;
            string noneyaRole = null;
            string[] appRoles;
            try
            {
                appRoles = noneya.GetApplicationRoles(ConfigurationManager.AppSettings["ApplicationSecurityName"].ToString());

                foreach (string role in appRoles)
                {
                    if (role.Equals(roleName)) noneyaRole = role;
                }

                return MapRole(noneyaRole);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns a List of ApplicationRole objects corresponding to all the roles for a given user ID
        /// </summary>
        /// <param name="userID">user ID value</param>
        /// <returns>List of ApplicationRole objects</returns>
        public List<ApplicationRole> GetUserRoles(string userID)
        {
            try
            {
                List<ApplicationRole> roles = new List<ApplicationRole>();
                Int32 uID = Convert.ToInt32(userID);
                // I have to get a CORInternalSecurity User object first to check whether the user is active. The GetUserRoles method does not check for this.
                //CORSecurity.Model.IUser iSecUser = this.userTask.GetUser(userID);
                NONEYA.UserInformation noneyaUser = noneya.GetUserInformationFromId(uID);
                //if (iSecUser.IsActive)
                if (noneyaUser.NoneyaId != 0)
                {
                    List<string> noneyaRoles = new List<string>(noneya.GetUserRoles(ConfigurationManager.AppSettings["ApplicationSecurityName"].ToString(), noneyaUser.WindowsLogon[0].ToString()));//this.GetUserNameByID(uID)));


                    roles = MapRoles(noneyaRoles);
                }

                return roles;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns a List of ApplicationRole objects corresponding to all the roles for a given CORInternalSecurity User object
        /// </summary>
        /// <param name="userID">CORInternalSecurity User object</param>
        /// <returns>List of ApplicationRole objects</returns>
        //public List<ApplicationRole> GetUserRoles(CORSecurity.Model.IUser user)
        public List<ApplicationRole> MapUserRoles(NONEYA.UserInformation user)
        {
            try
            {
                List<ApplicationRole> roles = new List<ApplicationRole>();

                // I have to check whether the user is active. The GetUserRoles method does not check for this.
                if (user.NoneyaId != 0)
                {
                    List<string> noneyaRoles = new List<string>(noneya.GetUserRoles(ConfigurationManager.AppSettings["ApplicationSecurityName"].ToString(), this.GetUserNameByID(user.NoneyaId)));
                    roles = MapRoles(noneyaRoles);

                }

                return roles;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Returns the name of a reviewer corresponding to a given reviewer ID
        /// </summary>
        /// <param name="reviewerID">reviewer ID value</param>
        /// <returns>Name of the reviewer as a string</returns>
        public string GetReviewerNameByID(string reviewerID)
        {
            try
            {
                string reviewerName = "";

                if (reviewerID == "-1")
                {
                    reviewerName = "Parking Contractor";
                }
                else if ((reviewerID == "") || (reviewerID == "0"))
                {
                    reviewerName = "";
                }
                else
                {
                    ApplicationUser noteByUser = this.GetApplicationUserByID(reviewerID);
                    reviewerName = noteByUser.UserName;
                }

                return reviewerName;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Returns a List of ApplicationRole objects based on a given List of CORInternalSecurity Role objects 
        /// </summary>
        /// <param name="roles">List of CORInternalSecurity Role objects</param>
        /// <returns>List of ApplicationRole objects</returns>
        //private List<ApplicationRole> MapISecRolesToApplicationRoles(List<CORSecurity.Model.IRole> roles)
        private List<ApplicationRole> MapRoles(List<string> roles)
        {
            try
            {
                List<ApplicationRole> appRoles = new List<ApplicationRole>();
                if (roles.Count > 0)
                {
                    //foreach (CORSecurity.Model.IRole r in roles)
                    foreach (string r in roles)
                    {
                        ApplicationRole role = new ApplicationRole();
                        role.RoleName = r;
                        appRoles.Add(role);

                    }
                }

                return appRoles;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                //ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }
    }
}
