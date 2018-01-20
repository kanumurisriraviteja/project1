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
using MCTR.BusinessInterface;
using MCTR.Business;
using MCTR.DomainEntities;
using MCTR.DomainEntity;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MCTR.RESTService.Controllers
{
    public class MctrLogServiceController : ApiController
    {

         private readonly ILog logger;
        public MctrLogServiceController()
        {
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogOnInsert
        ///</summary>
        ///<param name = "mctrLogOrig"></param>
        ///<returns>IEnumerable<mctrLogOrig> </returns>

        [HttpPost]
        [ActionName("mctrLogOnInsert")]
        public HttpResponseMessage mctrLogOnInsert([FromBody]IEnumerable<MctrLog> mctrLogOrig)
        {
            try
            {
                
                if (mctrLogOrig != null)
                {
                    logger.Info("Executing Rest API : mctrLogOnInsert() with request : " + mctrLogOrig);
                    IMctrLogBusiness mctrLogOrigBusiness = new MctrlogorigBusiness();
                    var response = mctrLogOrigBusiness.mctrLogOnInsert(mctrLogOrig);
                    logger.Info("Response received from mctrLogOrigBusiness.mctrLogOnInsert() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch (Exception e)
            {

                logger.Error("Error from MCTR.RESTService: " + e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogWhenNewRecordInstance
        ///</summary>
        ///<param name = "mctrLogOrig"></param>
        ///<returns>IEnumerable<mctrLogOrig> </returns>
        [HttpPost]
        [ActionName("mctrLogWhenNewRecordInstance")]
        public HttpResponseMessage mctrLogWhenNewRecordInstance([FromBody]IEnumerable<MctrLog> mctrLogOrig)
        {
            try
            {
                logger.Info("Executing Rest API : mctrLogWhenNewRecordInstance() with request : " + mctrLogOrig);
                if (mctrLogOrig != null)
                {
                    IMctrLogBusiness mctrLogOrigBusiness = new MctrlogorigBusiness();
                    var response = mctrLogOrigBusiness.mctrLogWhenNewRecordInstance(mctrLogOrig);
                    logger.Info("Response received from mctrLogOrigBusiness.mctrLogWhenNewRecordInstance() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch (Exception e)
            {

                logger.Error("Error from MCTR.RESTService: " + e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogOrigWhenWindowClosed
        ///</summary>
        ///<param name = "mctrLogOrig"></param>
        ///<returns>IEnumerable<mctrLogOrig> </returns>
        [HttpPost]
        [ActionName("mctrLogOrigWhenWindowClosed")]
        public HttpResponseMessage mctrLogOrigWhenWindowClosed([FromBody]IEnumerable<MctrLog> mctrLogOrig)
        {
            try
            {
                logger.Info("Executing Rest API : mctrLogOrigWhenWindowClosed() with request : " + mctrLogOrig);
                if (mctrLogOrig != null)
                {
                    logger.Info("Response received from mctrLogOrigBusiness.mctrLogOrigWhenWindowClosed() : ");
                    return null;
                }
                return null;
            }
            catch (Exception e)
            {

                logger.Error("Error from MCTR.RESTService: " + e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        ///*************************************************************
        ///<summary>
        ///Method Name : get
        ///</summary>
       
        [HttpGet]
        [ActionName("Get")]
        public HttpResponseMessage Get()
        {
            try
            {
                IMctrLogBusiness mctrLogOrigBusiness = new MctrlogorigBusiness();
                var response= mctrLogOrigBusiness.Get();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {

                logger.Error("Error from MCTR.RESTService: " + e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        ///*************************************************************
        ///<summary>
        ///Method Name : validateBemsJson
        ///</summary>
        ///<param name = "mctrLog"></param>
        ///<returns>IEnumerable<mctrLog> </returns>
        [HttpPost]
        [ActionName("validateBemsJson")]
        public HttpResponseMessage validateBemsJson([FromBody]IEnumerable<MctrLog> mctrLog)
        {
            try
            {
                IMctrLogBusiness mctrLogOrigBusiness = new MctrlogorigBusiness();
                var response = mctrLogOrigBusiness.validateBemsJson(mctrLog);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {

                logger.Error("Error from MCTR.RESTService: " + e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }

}
