using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ParkingCitationReviews.Logging;


namespace ParkingCitationReviews.Logging
{
    /// <summary>
    /// Log exception to logging solution
    /// </summary>
    public class ExceptionLogger
    {
        #region errorLogging
        /// <summary>
        /// Initializes a new instance of the LogMessage class.
        /// </summary>
        //public ExceptionLogger(
        //    string applicationNameSpace,
        //    string source,
        //    string errorCode,
        //    string errorMessage,
        //    string errorStackTrace,
        //    string className,
        //    string methodName,
        //    string otherData
        //    )

        public ExceptionLogger(Exception ex)
        {

            // log with CORApplicationLogging LogError object

            //LogError log = new LogError(
            //    applicationName,
            //    applicationNameSpace,
            //    errorSource,
            //    className,
            //    methodName,
            //    errorCode,
            //    severity,
            //    errorMessage,
            //    errorStackTrace,
            //    otherData,
            //    createBy,
            //    createDate);

            //bool logged = log.ErrorLogged;
            try
            {


                //return Convert.ToInt32(logged);
                //ErrorLog errorLog = new ErrorLog();
                //errorLog.ApplicationName = applicationName;
                //errorLog.ApplicationNamespace = applicationNameSpace;
                //errorLog.ClassName = className;
                //errorLog.ErrorCode = errorCode;
                //errorLog.ErrorDate = createDate;
                //errorLog.ErrorMessage = errorMessage;
                //errorLog.ErrorUser = createBy;
                //errorLog.HostServer = System.Net.Dns.GetHostName();
                //errorLog.MethodName = methodName;
                //errorLog.OtherData = otherData;
                //errorLog.Severity = severity;
                //errorLog.Source = errorCode;
                //errorLog.Trace = errorStackTrace;
                //LogErrorWithReturnClient logErrorClient = new LogErrorWithReturnClient();
                //logged = logErrorClient.LogError(errorLog);
                //if (logged == false)
                //{
                //    Exception ex = new Exception("ErrorMessage: " + errorMessage + "Trace: " + errorStackTrace);
                //    ex.Source = errorCode;
                //    throw ex;
                //}

                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
            catch (Exception elmahEx)
            {
                throw elmahEx;
            }
        }
        #endregion errorLogging
    }
}
