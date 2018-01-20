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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;

using MCTR.DomainEntity;
using MCTR.BusinessInterface;
using MCTR.Business;

namespace MCTR.RESTService.Controllers
{
    ///*********************************************************************
    ///<summary>
    ///MctrOffsetFormBlServiceController is a Rest controller implementation  
    ///which acts as a wrapper to the MctrOffsetFormBlBusiness implementation and
    ///provides api path for each methods exposed.
    ///</summary>

    public class MctrOffsetFormBlServiceController : ApiController
    {

         private readonly ILog logger;

        public MctrOffsetFormBlServiceController()
        {
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : mctrOffsetMctrOffsetOnLoad
        ///</summary>
        ///<param name = "MctrOffsetFormBl"></param>
        ///<returns>IEnumerable<MctrOffsetFormBl> </returns>

        [HttpPost]
        [ActionName("mctrOffsetMctrOffsetOnLoad")]
        public HttpResponseMessage mctrOffsetMctrOffsetOnLoad([FromBody]IEnumerable<MctrOffsetFormBl> mctrOffsetFormBl)
        {
            try
            {
                logger.Info("Executing Rest API : mctrOffsetMctrOffsetOnLoad() with request : " + mctrOffsetFormBl);

                IMctrOffsetFormBlBusiness mctrOffsetFormBlBusiness = new MctrOffsetFormBlBusiness();
                var response = mctrOffsetFormBlBusiness.mctrOffsetMctrOffsetOnLoad(mctrOffsetFormBl);
                logger.Info("Response received from mctrOffsetFormBlBusiness.mctrOffsetMctrOffsetOnLoad() : " + response);
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
        ///Method Name : mctrOffsetFormBlWhenNewFormInstance
        ///</summary>
        ///<param name = "MctrOffsetFormBl"></param>
        ///<returns>IEnumerable<MctrOffsetFormBl> </returns>

        [HttpPost]
        [ActionName("mctrOffsetFormBlWhenNewFormInstance")]
        public HttpResponseMessage mctrOffsetFormBlWhenNewFormInstance([FromBody]IEnumerable<MctrOffsetFormBl> mctrOffsetFormBl)
        {
            try
            {
                logger.Info("Executing Rest API : mctrOffsetFormBlWhenNewFormInstance() with request : " + mctrOffsetFormBl);
                if (mctrOffsetFormBl != null)
                {
                    IMctrOffsetFormBlBusiness mctrOffsetFormBlBusiness = new MctrOffsetFormBlBusiness();
                    var response = mctrOffsetFormBlBusiness.mctrOffsetFormBlWhenNewFormInstance(mctrOffsetFormBl);
                    logger.Info("Response received from mctrOffsetFormBlBusiness.mctrOffsetFormBlWhenNewFormInstance() : " + response);
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
        ///Method Name : mctrOffsetFormBlWhenWindowClosed
        ///</summary>
        ///<param name = "MctrOffsetFormBl"></param>
        ///<returns>IEnumerable<MctrOffsetFormBl> </returns>

        [HttpPost]
        [ActionName("mctrOffsetFormBlWhenWindowClosed")]
        public HttpResponseMessage mctrOffsetFormBlWhenWindowClosed([FromBody]IEnumerable<MctrOffsetFormBl> mctrOffsetFormBl)
        {
            try
            {


                logger.Info("Executing Rest API : mctrOffsetFormBlWhenWindowClosed() with request : " + mctrOffsetFormBl);
                if (mctrOffsetFormBl != null)
                {
                    IMctrOffsetFormBlBusiness mctrOffsetFormBlBusiness = new MctrOffsetFormBlBusiness();
                    var response = mctrOffsetFormBlBusiness.mctrOffsetFormBlWhenWindowClosed(mctrOffsetFormBl);
                    logger.Info("Response received from mctrOffsetFormBlBusiness.mctrOffsetFormBlWhenWindowClosed() : " + response);
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


    }

}
