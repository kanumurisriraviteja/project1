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
using System.Text;
using System.Threading.Tasks;

using MCTR.DomainEntity;

namespace MCTR.DataAccessInterface
{
///*********************************************************************
///<summary>
///IMctrLogAcctRepository is an data access interface for the MctrLogAcctRepository   
///which facilitates the dependency injection.
///</summary>
  public interface IMctrLogAcctRepository  
    { 
     

    ///*************************************************************
    ///<summary>
    ///Method Name : mctrHeaderMctrHeaderOnLoad
    ///</summary>
    ///<param name = "MctrLogAcct"></param>
    ///<returns>IEnumerable<MctrLogAcct> </returns>
    IEnumerable<MctrLogAcct> mctrHeaderMctrHeaderOnLoad(IEnumerable<MctrLogAcct> mctrLogAcct);
        ///*************************************************************
        ///<summary>
        ///Method Name : validateBems
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>
        IEnumerable<MctrLogAcct> validateBems(IEnumerable<MctrLogAcct> mctrLogAcct);


        ///*************************************************************
        ///<summary>
        ///Method Name : mctrLogMctrLogOnLoad
        ///</summary>
        ///<param name = "MctrLogAcct"></param>
        ///<returns>IEnumerable<MctrLogAcct> </returns>
        IEnumerable<MctrLogAcct> mctrLogMctrLogOnLoad();
       

    ///*************************************************************
    ///<summary>
    ///Method Name : mctrLogOnInsert
    ///</summary>
    ///<param name = "MctrLogAcct"></param>
    ///<returns>IEnumerable<MctrLogAcct> </returns>
    IEnumerable<MctrLogAcct> mctrLogOnInsert(IEnumerable<MctrLogAcct> mctrLogAcct);
       

    ///*************************************************************
    ///<summary>
    ///Method Name : mctrLogWhenNewRecordInstance
    ///</summary>
    ///<param name = "MctrLogAcct"></param>
    ///<returns>IEnumerable<MctrLogAcct> </returns>
    IEnumerable<MctrLogAcct> mctrLogWhenNewRecordInstance(IEnumerable<MctrLogAcct> mctrLogAcct);
       

    ///*************************************************************
    ///<summary>
    ///Method Name : mctrLogAcctWhenWindowClosed
    ///</summary>
    ///<param name = "MctrLogAcct"></param>
    ///<returns>IEnumerable<MctrLogAcct> </returns>
    IEnumerable<MctrLogAcct> mctrLogAcctWhenWindowClosed(IEnumerable<MctrLogAcct> mctrLogAcct);
       
    
  }

}
