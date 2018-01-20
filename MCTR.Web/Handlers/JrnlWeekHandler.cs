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

using System;
using System.Collections.Generic;

using log4net;

using MCTR.DomainEntity;

namespace MCTR.Web.Handlers
{
    ///*********************************************************************
    ///<summary>
    ///JrnlWeekHandler provides a level of abstraction for consuming the REST api.
    ///</summary>
    public class JrnlWeekHandler
    {
         private readonly ILog logger;

        public JrnlWeekHandler()
        {
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : jrnlWeekJrnlWeekOnLoad
        ///</summary>
        ///<param name = "JrnlWeek"></param>
        ///<returns>IEnumerable<JrnlWeek> </returns>

        public IEnumerable<JrnlWeek> jrnlWeekJrnlWeekOnLoad(string bems)
        {
            try
            {
                
                logger.Debug("Executing jrnlWeekJrnlWeekOnLoad rest service handler.");
                string restApiPath = "JrnlWeekService/jrnlWeekJrnlWeekOnLoad";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + bems);
                var response = HandlerUtil<JrnlWeek>.RestgetProcessor(restApiPath, bems);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception e)
            {
                logger.Info("Response received from JrnlWeekRepository.jrnlWeekJrnlWeekOnLoad() : " + e.Message);

                throw;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : jrnlWeekWhenNewFormInstance
        ///</summary>
        ///<param name = "JrnlWeek"></param>
        ///<returns>IEnumerable<JrnlWeek> </returns>

        public IEnumerable<JrnlWeek> jrnlWeekWhenNewFormInstance(JrnlWeek jrnlWeek)
        {
            try
            {

                logger.Debug("Executing jrnlWeekWhenNewFormInstance rest service handler.");
                string restApiPath = "JrnlWeekService/jrnlWeekWhenNewFormInstance";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + jrnlWeek);
                var response = HandlerUtil<JrnlWeek>.RestPostProcessor(restApiPath, jrnlWeek);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception e)
            {
                logger.Info("Response received from JrnlWeekRepository.jrnlWeekJrnlWeekOnLoad() : " + e.Message);

                throw;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : jrnlWeekWhenWindowClosed
        ///</summary>
        ///<param name = "JrnlWeek"></param>
        ///<returns>IEnumerable<JrnlWeek> </returns>

        public IEnumerable<JrnlWeek> jrnlWeekWhenWindowClosed(JrnlWeek jrnlWeek)
        {
            try
            {
                logger.Debug("Executing jrnlWeekWhenWindowClosed rest service handler.");
                string restApiPath = "JrnlWeekService/jrnlWeekWhenWindowClosed";
                logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + jrnlWeek);
                var response = HandlerUtil<JrnlWeek>.RestPostProcessor(restApiPath, jrnlWeek);
                logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
                return response;
            }
            catch (Exception e)
            {
                logger.Info("Response received from JrnlWeekRepository.jrnlWeekJrnlWeekOnLoad() : " + e.Message);

                throw;
            }
        }


    }

}
