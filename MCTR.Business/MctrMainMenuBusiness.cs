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
using MCTR.BusinessInterface;
using MCTR.DataAccessInterface;
using MCTR.DataAccess;

namespace MCTR.Business
{

    ///*********************************************************************
    ///<summary>
    ///mctrmainmenu_business is the business logic implementation class which holds all
    ///business logic in it.
    ///</summary>
    public class MctrMainMenuBusiness : BaseBusiness, IMctrMainMenuBusiness
    {
         private readonly ILog logger;
     
        IMctrMainMenuRepository repository = new MctrMainMenuRepository();

        public MctrMainMenuBusiness()
        {
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IEnumerable<MctrMainMenu> buttonPalettebutAdminTblsWhenButtonPressed(IEnumerable<MctrMainMenu> mctrMainMenu)
        {
            try
            {
                logger.Info("Executing MCTR.Business.MctrMainMenuBusiness.buttonPalettebutAdminTblsWhenButtonPressed() with request : " + mctrMainMenu);
                var resultlist = repository.buttonPalettebutAdminTblsWhenButtonPressed(mctrMainMenu);
                logger.Info("Response received from MCTR.Business.MctrMainMenuBusiness.buttonPalettebutAdminTblsWhenButtonPressed() : " + mctrMainMenu);
                return resultlist;
            }
            catch (Exception e)
            {
                logger.Error("Error from MCTR.Business.MctrMainMenuBusiness.buttonPalettebutAdminTblsWhenButtonPressed()" + e.Message);
                throw;
            }
        }

        public IEnumerable<Status> getDescription()
        {
            try
            {
                logger.Info("Executing MCTR.Business.MctrMainMenuBusiness.getDescription()");
                var resultlist = repository.getDescription();
                logger.Info("Response received from MCTR.Business.MctrMainMenuBusiness.getDescription():");
                return resultlist;
            }
            catch (Exception e)
            {
                logger.Error("Error from MCTR.Business.MctrMainMenuBusiness.getDescription()" + e.Message);
                throw;
            }
        }

        public IEnumerable<MctrMainMenu> populateActionTree(IEnumerable<MctrMainMenu> mctrMainMenu)
        {
            try
            {
                logger.Info("Executing MCTR.Business.MctrMainMenuBusiness.populateActionTree() with request : " + mctrMainMenu);
                var resultlist = repository.populateActionTree(mctrMainMenu);
                logger.Info("Response received from MCTR.Business.MctrMainMenuBusiness.populateActionTree() : " + mctrMainMenu);
                return resultlist;
            }
            catch (Exception e)
            {
                logger.Error("Error from MCTR.Business.MctrMainMenuBusiness.populateActionTree()" + e.Message);
                throw;
            }
        }

        public IEnumerable<MctrMainMenu> populateAssignedAtree(IEnumerable<MctrMainMenu> mctrMainMenu)
        {
            try
            {
                logger.Info("Executing MCTR.Business.MctrMainMenuBusiness.populateAssignedAtree() with request : " + mctrMainMenu);
                var resultlist = repository.populateAssignedAtree(mctrMainMenu);
                logger.Info("Response received from MCTR.Business.MctrMainMenuBusiness.populateAssignedAtree() : " + mctrMainMenu);
                return resultlist;
            }
            catch (Exception e)
            {
                logger.Error("Error from MCTR.Business.MctrMainMenuBusiness.populateAssignedAtree()" + e.Message);
                throw;
            }
        }
    }

}