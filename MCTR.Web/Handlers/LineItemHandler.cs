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
using System.Web;

using System.Threading.Tasks;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

using log4net;

using MCTR.DomainEntity;

namespace MCTR.Web.Handlers
{
///*********************************************************************
///<summary>
///LineItemHandler provides a level of abstraction for consuming the REST api.
///</summary>
  public class LineItemHandler
  {
     private readonly ILog logger;
    
    public LineItemHandler()
    {
      logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
        
     
    ///*************************************************************
    ///<summary>
    ///Method Name : mctrLineItemMctrLineItemOnLoad
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<LineItem> mctrLineItemMctrLineItemOnLoad(LineItem lineItem){

      logger.Debug("Executing mctrLineItemMctrLineItemOnLoad rest service handler.");
      string restApiPath = "LineItemService/mctrLineItemMctrLineItemOnLoad";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + lineItem);
      var response = HandlerUtil<LineItem>.RestPostProcessor(restApiPath, lineItem);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      return response; 
    }
        
    ///*************************************************************
    ///<summary>
    ///Method Name : mctrLineItembutOpenMctrWhenButtonPressed
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<LineItem> mctrLineItembutOpenMctrWhenButtonPressed(LineItem lineItem){

      logger.Debug("Executing mctrLineItembutOpenMctrWhenButtonPressed rest service handler.");
      string restApiPath = "LineItemService/mctrLineItembutOpenMctrWhenButtonPressed";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + lineItem);
      var response = HandlerUtil<LineItem>.RestPostProcessor(restApiPath, lineItem);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      return response; 
    }
        
    ///*************************************************************
    ///<summary>
    ///Method Name : mctrLineItemPostQuery
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<LineItemDomainAdded> mctrLineItemPostQuery(LineItem lineItem){


      logger.Debug("Executing mctrLineItemPostQuery rest service handler.");
      string restApiPath = "LineItemService/mctrLineItemPostQuery";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + lineItem);
      var response = HandlerUtil<LineItem>.RestPostProcessor(restApiPath, lineItem);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      LineItemDomainAdded obj = response.First<LineItem>().LineItemDomainAdded;
      List<LineItemDomainAdded> obj1 = new List<LineItemDomainAdded>();
      obj1.Add(obj);

      return obj1; 
    }
        
    ///*************************************************************
    ///<summary>
    ///Method Name : getRgBems1LOV()
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<MCTREmployeev> getRgBems1LOV(){

      logger.Debug("Executing getRgBems1LOV() rest service handler.");
      string restApiPath = "LineItemService/getRgBems1LOV()";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : ");
      var response = HandlerUtil<MCTREmployeev>.RestGetProcessor(restApiPath);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      return response; 
    }
        
    ///*************************************************************
    ///<summary>
    ///Method Name : getRgBems2LOV()
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<MCTREmployeev> getRgBems2LOV(){

      logger.Debug("Executing getRgBems2LOV() rest service handler.");
      string restApiPath = "LineItemService/getRgBems2LOV()";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : " );
      var response = HandlerUtil<MCTREmployeev>.RestGetProcessor(restApiPath);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      return response; 
    }
        
    ///*************************************************************
    ///<summary>
    ///Method Name : getRgBems3LOV()
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<MCTREmployeev> getRgBems3LOV(){

      logger.Debug("Executing getRgBems3LOV() rest service handler.");
      string restApiPath = "LineItemService/getRgBems3LOV()";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : " );
      var response = HandlerUtil<MCTREmployeev>.RestGetProcessor(restApiPath);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      return response; 
    }
        
    ///*************************************************************
    ///<summary>
    ///Method Name : lineItemOnError
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<LineItem> lineItemOnError(LineItem lineItem){

      logger.Debug("Executing lineItemOnError rest service handler.");
      string restApiPath = "LineItemService/lineItemOnError";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + lineItem);
      var response = HandlerUtil<LineItem>.RestPostProcessor(restApiPath, lineItem);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      return response; 
    }
        
    ///*************************************************************
    ///<summary>
    ///Method Name : lineItemWhenWindowClosed
    ///</summary>
    ///<param name = "LineItem"></param>
    ///<returns>IEnumerable<LineItem> </returns>

    public IEnumerable<LineItem> lineItemWhenWindowClosed(LineItem lineItem){

      logger.Debug("Executing lineItemWhenWindowClosed rest service handler.");
      string restApiPath = "LineItemService/lineItemWhenWindowClosed";
      logger.Info("Invoking Rest API : " + restApiPath + " with Request : " + lineItem);
      var response = HandlerUtil<LineItem>.RestPostProcessor(restApiPath, lineItem);
      logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
      return response; 
    }

        public IEnumerable<LineItem> Get()
        {

            logger.Debug("Executing Get rest service handler.");
            string restApiPath = "LineItemService/Get";
            logger.Info("Invoking Rest API : " + restApiPath);
            var response = HandlerUtil<LineItem>.RestGetProcessor(restApiPath);
            logger.Info("Response received form Rest API : " + restApiPath + " : " + response);
            return response;
        }


    }

}
