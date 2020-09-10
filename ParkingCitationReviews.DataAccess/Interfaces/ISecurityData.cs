using System;
using System.Collections.Generic;
using System.Text;
using ParkingCitationReviews.EntityObjects;
//using CORSecurity = RichmondCityVirginia.CORInternalSecurity;


namespace ParkingCitationReviews.DataAccess
{
    public interface ISecurityData
    {
        ApplicationUser GetApplicationUserByPlatform(string platformUserID);
        ApplicationUser GetApplicationUserByID(string userID);
        //ApplicationUser GetUser(CORSecurity.Model.IUser user);
        List<ApplicationUser> GetListOfUsersInRole(string roleName);
        List<ApplicationUser> GetListOfUsersInApp();
        List<ApplicationRole> GetApplicationRoles();
        ApplicationRole GetApplicationRoleByName(string roleName);
        List<ApplicationRole> GetUserRoles(string userID);
        string GetReviewerNameByID(string reviewerID);
        string GetUserNameByID(int userID);
    }
}
