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
    ///MctrCompRatesServiceController is a Rest controller implementation  
    ///which acts as a wrapper to the MctrCompRatesBusiness implementation and
    /// provides api path for each methods exposed.
    ///</summary>

    public class MctrCompRatesServiceController : ApiController
    {

         private readonly ILog logger;

        public MctrCompRatesServiceController()
        {
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : mctrcompratesonload
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("mctrcompratesonload")]
        public HttpResponseMessage mctrcompratesonload([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            logger.Info("Executing Rest API : mctrCompRatesMctrCompRatesOnLoad() with request : " + mctrCompRates);
            if (mctrCompRates != null)
            {
                IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                var response = mctrCompRatesBusiness.mctrcompratesonload(mctrCompRates);
                logger.Info("Response received from mctrCompRatesBusiness.mctrCompRatesMctrCompRatesOnLoad() : " + response);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            return null;
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : mctrCompRatescmponCdPostTextItem
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("mctrCompRatescmponCdPostTextItem")]
        public HttpResponseMessage mctrCompRatescmponCdPostTextItem([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            logger.Info("Executing Rest API : mctrCompRatescmponCdPostTextItem() with request : " + mctrCompRates);
            if (mctrCompRates != null)
            {
                IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                var response = mctrCompRatesBusiness.mctrCompRatescmponCdPostTextItem(mctrCompRates);
                logger.Info("Response received from mctrCompRatesBusiness.mctrCompRatescmponCdPostTextItem() : " + response);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            return null;
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : mctrCompRatesrscOutputPostChange
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("mctrCompRatesrscOutputPostChange")]
        public HttpResponseMessage mctrCompRatesrscOutputPostChange([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            logger.Info("Executing Rest API : mctrCompRatesrscOutputPostChange() with request : " + mctrCompRates);
            if (mctrCompRates != null)
            {
                IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                var response = mctrCompRatesBusiness.mctrCompRatesrscOutputPostChange(mctrCompRates);
                logger.Info("Response received from mctrCompRatesBusiness.mctrCompRatesrscOutputPostChange() : " + response);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            return null;
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : mctrCompRatespoolOutputPostChange
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("mctrCompRatespoolOutputPostChange")]
        public HttpResponseMessage mctrCompRatespoolOutputPostChange([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            logger.Info("Executing Rest API : mctrCompRatespoolOutputPostChange() with request : " + mctrCompRates);
            if (mctrCompRates != null)
            {
                IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                var response = mctrCompRatesBusiness.mctrCompRatespoolOutputPostChange(mctrCompRates);
                logger.Info("Response received from mctrCompRatesBusiness.mctrCompRatespoolOutputPostChange() : " + response);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            return null;
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : mctrCompRatescascadeFlgWhenMouseClick
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("mctrCompRatescascadeFlgWhenMouseClick")]
        public HttpResponseMessage mctrCompRatescascadeFlgWhenMouseClick([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : mctrCompRatescascadeFlgWhenMouseClick() with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.mctrCompRatescascadeFlgWhenMouseClick(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.mctrCompRatescascadeFlgWhenMouseClick() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : mctrCompRatesKeyDelrec
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("mctrCompRatesKeyDelrec")]
        public HttpResponseMessage mctrCompRatesKeyDelrec([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : mctrCompRatesKeyDelrec() with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.mctrCompRatesKeyDelrec(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.mctrCompRatesKeyDelrec() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                logger.Error("Error from  Mctr.DataAccess.mctrCompRatesKeyDelrec():" + e.Message);
                throw;
            }
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : selectBlockbutCopyWhenButtonPressed
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("selectBlockbutCopyWhenButtonPressed")]
        public HttpResponseMessage selectBlockbutCopyWhenButtonPressed([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : selectBlockbutCopyWhenButtonPressed() with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.selectBlockbutCopyWhenButtonPressed(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.selectBlockbutCopyWhenButtonPressed() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }



        ///*************************************************************
        ///<summary>
        ///Method Name : getRgRateILOV
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("getrgrateilov")]
        public HttpResponseMessage getrgrateilov([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : getrgrateilov() with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.getrgrateilov(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.getrgrateilov() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : getRgRateCLOV
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("getrgrateclov")]
        public HttpResponseMessage getrgrateclov([FromBody] IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : getRgRateCLOV with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.getrgrateclov(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.getRgRateCLOV : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : mctrCompRatesWhenNewFormInstance
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("mctrCompRatesWhenNewFormInstance")]
        public HttpResponseMessage mctrCompRatesWhenNewFormInstance([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : mctrCompRatesWhenNewFormInstance with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.mctrCompRatesWhenNewFormInstance(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.mctrCompRatesWhenNewFormInstance : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }


        ///*************************************************************
        ///<summary>
        ///Method Name : genericLovCall
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("genericLovCall")]
        public HttpResponseMessage genericLovCall([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : genericLovCall() with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.genericLovCall(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.genericLovCall() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : crtetbl
        ///</summary>
        ///<param name = "MctrCompRates"></param>
        ///<returns>IEnumerable<MctrCompRates> </returns>

        [HttpPost]
        [ActionName("crtetbl")]
        public HttpResponseMessage crtetbl([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                logger.Info("Executing Rest API : crtetbl() with request : " + mctrCompRates);
                if (mctrCompRates != null)
                {
                    IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                    var response = mctrCompRatesBusiness.crtetbl(mctrCompRates);
                    logger.Info("Response received from mctrCompRatesBusiness.crtetbl() : " + response);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        ///*************************************************************
        ///<summary>
        ///Method Name : compositeDelete
        ///</summary>
        ///<param name = "mctrCompRates"></param>
        ///<returns>IEnumerable<mctrCompRates> </returns>
        [HttpPost]
        [ActionName("compositeDelete")]
        public HttpResponseMessage compositeDelete([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                var response = mctrCompRatesBusiness.compositeDelete(mctrCompRates);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        ///*************************************************************
        ///<summary>
        ///Method Name : compositeInsert
        ///</summary>
        ///<param name = "mctrCompRates"></param>
        ///<returns>IEnumerable<mctrCompRates> </returns>

        [HttpPost]
        [ActionName("compositeInsert")]
        public HttpResponseMessage compositeInsert([FromBody]IEnumerable<MctrCompRates> mctrCompRates)
        {
            try
            {
                IMctrCompRatesBusiness mctrCompRatesBusiness = new MctrCompRatesBusiness();
                var response = mctrCompRatesBusiness.compositeInsert(mctrCompRates);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }

}