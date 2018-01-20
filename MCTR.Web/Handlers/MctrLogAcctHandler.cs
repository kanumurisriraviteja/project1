///*************************************************************************
/// 
/// BOEING CONFIDENTIAL
/// ___________________
/// 
///  BOEING is a trademark of Boeing Management Company.
///
///  Copyright � 2016 Boeing. All rights reserved.
/// 
/// NOTICE:  All information contained herein is, and remains
/// the property of Boeing and its suppliers, if any.  
/// The intellectual and technical concepts contained
/// herein are proprietary to Boeing and its suppliers and may be 
/// covered by U.S. and Foreign Patents, patents in process, 
/// and are protected by trade secret or copyright law.
/// Dissemination of this information or reproduction of this material
/// is strictly forbidden unless prior written permission is obtained
/// from Boeing. 
///

///************************************************************************
/// Author           : Generated by ATMA �
/// Revision History :  

using log4net;
using MCTR.DomainEntity;
using System;
using System.Collections.Generic;

namespace MCTR.Web.Handlers
{
    ///*********************************************************************
    ///<summary>
    ///MctrLogAcctHandler provides a level of abstraction for consuming the REST api.
    ///</summary>
    public class MctrLogAcctHandler
    {
         private readonly ILog logger;

        public MctrLogAcctHandler()
        {
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : mctrHeaderMctrHeaderOnLoad
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>

        public IEnumerable<MctrLogAcct> mctrHeaderMctrHeaderOnLoad(MctrLogAcct mctrLogAcct)
        {
            try
            {
                logger.Debug("Executing MCTR.Web.Handlers.MctrLogAcctHandler.mctrHeaderMctrHeaderOnLoad with request:");
                string restApiPath = "MctrLogAcctService/mctrHeaderMctrHeaderOnLoad";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + mctrLogAcct);
                var response = HandlerUtil<MctrLogAcct>.RestPostProcessor(restApiPath, mctrLogAcct);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception ex)
            {
                logger.Info("Exception Occured at MCTR.Web.Handlers.MctrLogAcctHandler.mctrHeaderMctrHeaderOnLoad() : " + ex.Message);
                throw;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : validateBems
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>
        public IEnumerable<MctrLogAcct> validateBems(MctrLogAcct mctrLogAcct)
        {
            try
            {
                logger.Debug("Executing MCTR.Web.Handlers.MctrLogAcctHandler.validateBems() with request:");
                string restApiPath = "MctrLogAcctService/validateBems";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + mctrLogAcct);
                var response = HandlerUtil<MctrLogAcct>.RestPostProcessor(restApiPath, mctrLogAcct);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception ex)
            {
                logger.Info("Exception Occured at MCTR.Web.Handlers.MctrLogAcctHandler.validateBems() : " + ex.Message);
                throw;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogMctrLogOnLoad
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>

        public IEnumerable<MctrLogAcct> mctrLogMctrLogOnLoad(MctrLogAcct mctrLogAcct)
        {
            try
            {
                logger.Debug("Executing MCTR.Web.Handlers.MctrLogAcctHandler.mctrLogMctrLogOnLoad rest service handler.");
                string restApiPath = "MctrLogAcctService/mctrLogMctrLogOnLoad";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + mctrLogAcct);
                var response = HandlerUtil<MctrLogAcct>.RestPostProcessor(restApiPath, mctrLogAcct);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception ex)
            {
                logger.Info("Exception Occured at MCTR.Web.Handlers.MctrLogAcctHandler.mctrHeaderMctrHeaderOnLoad() : " + ex.Message);
                throw;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogOnInsert
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>

        public IEnumerable<MctrLogAcct> mctrLogOnInsert(MctrLogAcct mctrLogAcct)
        {
            try
            {
                logger.Debug("Executing MCTR.Web.Handlers.MctrLogAcctHandler.mctrLogOnInsert rest service handler.");
                string restApiPath = "MctrLogAcctService/mctrLogOnInsert";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + mctrLogAcct);
                var response = HandlerUtil<MctrLogAcct>.RestPostProcessor(restApiPath, mctrLogAcct);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception ex)
            {
                logger.Info("Exception Occured at MCTR.Web.Handlers.MctrLogAcctHandler.mctrLogOnInsert() : " + ex.Message);
                throw;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogWhenNewRecordInstance
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>

        public IEnumerable<MctrLogAcct> mctrLogWhenNewRecordInstance(MctrLogAcct mctrLogAcct)
        {
            try
            {
                logger.Debug("Executing MCTR.Web.Handlers.MctrLogAcctHandler.mctrLogWhenNewRecordInstance rest service handler.");
                string restApiPath = "MctrLogAcctService/mctrLogWhenNewRecordInstance";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + mctrLogAcct);
                var response = HandlerUtil<MctrLogAcct>.RestPostProcessor(restApiPath, mctrLogAcct);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception ex)
            {
                logger.Info("Exception Occured at MCTR.Web.Handlers.MctrLogAcctHandler.mctrLogWhenNewRecordInstance() : " + ex.Message);
                throw;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogAcctWhenWindowClosed
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>

        public IEnumerable<MctrLogAcct> mctrLogAcctWhenWindowClosed(MctrLogAcct mctrLogAcct)
        {
            try
            {
                logger.Debug("Executing MCTR.Web.Handlers.MctrLogAcctHandler.mctrLogAcctWhenWindowClosed rest service handler.");
                string restApiPath = "MctrLogAcctService/mctrLogAcctWhenWindowClosed";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + mctrLogAcct);
                var response = HandlerUtil<MctrLogAcct>.RestPostProcessor(restApiPath, mctrLogAcct);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception ex)
            {
                logger.Info("Exception Occured at MCTR.Web.Handlers.MctrLogAcctHandler.mctrLogAcctWhenWindowClosed() : " + ex.Message);
                throw;
            }
        }

    }

}
