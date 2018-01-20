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
using System.Data;
using log4net;
using Oracle.ManagedDataAccess.Client;
using MCTR.DomainEntity;
using MCTR.DataAccessInterface;

namespace MCTR.DataAccess
{
    ///*********************************************************************
    ///<summary>
    ///MctrOpenReportsBlRepository is a data access implementation which holds all 
    ///the data access logic in it.
    ///</summary>
    public class MctrOpenReportsBlRepository : BaseRepository, IMctrOpenReportsBlRepository 
    {

        private readonly ILog logger;

        public MctrOpenReportsBlRepository()
        {
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : selectionoriginatorWhenButtonPressed
        ///</summary>
        ///<param name = "MctrOpenReportsBl"></param>
        ///<returns>IEnumerable<MctrOpenReportsBl> </returns>

        public IEnumerable<MctrOpenReportsBl> selectionoriginatorWhenButtonPressed(IEnumerable<MctrOpenReportsBl> mctrOpenReportsBl)
        {
            OracleParameter[] parameters = new OracleParameter[1];
            logger.Debug("Executing selectionoriginatorWhenButtonPressed with input : " + mctrOpenReportsBl);
            string name = findReportServer("mctr");
            if (name == "server_not_found")
            {

                //set_application_property(cursor_style, 'default');

                throw new Exception("the mctr report server is not on-line. please contact your mctr coordinator.");
            }
            return null;
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : selectionstatusWhenButtonPressed
        ///</summary>
        ///<param name = "MctrOpenReportsBl"></param>
        ///<returns>IEnumerable<MctrOpenReportsBl> </returns>

        public IEnumerable<MctrOpenReportsBl> selectionstatusWhenButtonPressed(IEnumerable<MctrOpenReportsBl> mctrOpenReportsBl)
        {
            
            OracleParameter[] parameters = new OracleParameter[1];
            logger.Debug("Executing selectionstatusWhenButtonPressed with input : " + mctrOpenReportsBl);

            string name =  findReportServer("mctr");
            if(name == "server_not_found")
            {

                //set_application_property(cursor_style, 'default');

              throw new Exception("the mctr report server is not on-line. please contact your mctr coordinator.");
            }

            return null;
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : selectionfinancialControlWhenButtonPressed
        ///</summary>
        ///<param name = "MctrOpenReportsBl"></param>
        ///<returns>IEnumerable<MctrOpenReportsBl> </returns>

        public IEnumerable<MctrOpenReportsBl> selectionfinancialControlWhenButtonPressed(IEnumerable<MctrOpenReportsBl> mctrOpenReportsBl)
        {
            
            OracleParameter[] parameters = new OracleParameter[1];
            logger.Debug("Executing selectionfinancialControlWhenButtonPressed with input : " + mctrOpenReportsBl);
            string name = findReportServer("mctr");
            if (name == "server_not_found")
            {

                //set_application_property(cursor_style, 'default');

                throw new Exception("the mctr report server is not on-line. please contact your mctr coordinator.");
            }
            return null;
        }

        ///*************************************************************
        ///<summary>
        ///Method Name : selectionbutExcelWhenButtonPressed
        ///</summary>
        ///<param name = "MctrOpenReportsBl"></param>
        ///<returns>IEnumerable<MctrOpenReportsBl> </returns>

        public IEnumerable<MctrOpenReportsBl> selectionbutExcelWhenButtonPressed(IEnumerable<MctrOpenReportsBl> mctrOpenReportsBl)
        {
            OracleParameter[] parameters = new OracleParameter[1];
            logger.Debug("Executing selectionbutExcelWhenButtonPressed with input : " + mctrOpenReportsBl);

            var retrived = mctrOpenReportsBl.First<MctrOpenReportsBl>();

            StringBuilder query = new StringBuilder("select tbl . mctr_no , tbl . title , tbl . bems_fin_ctl , decode ( rtrim ( tbl . fin_ctl_full_name ) , ',' , null , tbl . fin_ctl_full_name ) as fin_ctl , tbl . fin_ctl_phone , tbl . bems_orig , tbl . full_name , tbl . work_phone , tbl . orig_date , tbl . status_id , tbl . status_descr , tbl . status_date , decode ( rtrim ( tbl . intray_full_name ) , ',' , ' ' , tbl . intray_full_name ) as intray_name , tbl . intray_phone , tbl . days , decode ( l . proj_trans_type_from , null , '???' , l . proj_trans_type_from ) as ptt , decode ( count ( distinct l . line_no ) , null , 0 , count ( distinct l . line_no ) ) as lines , decode ( abs ( sum ( l . amount_from + l . adjustment_from ) ) , null , 0 , abs ( sum ( l . amount_from + l . adjustment_from ) ) ) as amount from ( select h . mctr_no , h . bems_orig , h . bems_fin_ctl , trunc ( h . date_enter ) as orig_date , h . status_id , s . status_descr , h . title , ( o . last_name || ', ' || o . first_name ) as full_name , o . work_phone , ( fa . last_name || ', ' || fa . first_name ) as fin_ctl_full_name , fa . work_phone as fin_ctl_phone , decode ( h . status_id , 'SA' , ( sa . last_name || ', ' || sa . first_name ) , 'FA' , ( fa . last_name || ', ' || fa . first_name ) , 'AA' , ( aa . last_name || ', ' || aa . first_name ) , 'LB' , ( lb . last_name || ', ' || lb . first_name ) , 'LM' , ( lb . last_name || ', ' || lb . first_name ) , 'MA' , ( ma . last_name || ', ' || ma . first_name ) , 'CA' , ( ca . last_name || ', ' || ca . first_name ) , 'JA' , ( aa . last_name || ', ' || aa . first_name ) , 'SR' , ( sr . last_name || ', ' || sr . first_name ) , ' ' ) as intray_full_name , decode ( h . status_id , 'SA' , sa . work_phone , 'FA' , fa . work_phone , 'AA' , aa . work_phone , 'LB' , lb . work_phone , 'LM' , lb . work_phone , 'MA' , ma . work_phone , 'CA' , ca . work_phone , 'JA' , aa . work_phone , 'SR' , sr . work_phone , ' ' ) as intray_phone , max ( trunc ( sh . date_time_entered ) ) as status_date , min ( trunc ( sysdate ) - trunc ( sh . date_time_entered ) ) as days from mctr_header h , mctr_employee_v o , mctr_employee_v sa , mctr_employee_v fa , mctr_employee_v aa , mctr_employee_v lb , mctr_employee_v ma , mctr_employee_v ca , mctr_employee_v sr , mctr_status s , mctr_status_hist sh where h . orig_bu = :0 and h . status_id in ( 'OA' , 'OR' , 'SA' , 'LA' , 'FA' , 'AA' , 'LB' , 'LM' , 'MA' , 'CA' , 'SR' , 'JA' , 'IP' ) and h . bems_orig = o . bems_id ( + ) and h . bems_super = sa . bems_id ( + ) and h . bems_fin_ctl = fa . bems_id ( + ) and h . bems_acct = aa . bems_id ( + ) and h . bems_lbr_acct = lb . bems_id ( + ) and h . bems_matl_acct = ma . bems_id ( + ) and h . bems_cost_acct = ca . bems_id ( + ) and h . bems_sr_acct = sr . bems_id ( + ) and h . status_id = s . status_id ( + ) and h . mctr_no = sh . mctr_no ( + ) group by h . mctr_no , h . bems_orig , h . bems_fin_ctl , trunc ( h . date_enter ) , h . status_id , s . status_descr , h . title , o . last_name , o . first_name , o . work_phone , fa . last_name , fa . first_name , fa . work_phone , decode ( h . status_id , 'SA' , ( sa . last_name || ', ' || sa . first_name ) , 'FA' , ( fa . last_name || ', ' || fa . first_name ) , 'AA' , ( aa . last_name || ', ' || aa . first_name ) , 'LB' , ( lb . last_name || ', ' || lb . first_name ) , 'LM' , ( lb . last_name || ', ' || lb . first_name ) , 'MA' , ( ma . last_name || ', ' || ma . first_name ) , 'CA' , ( ca . last_name || ', ' || ca . first_name ) , 'JA' , ( aa . last_name || ', ' || aa . first_name ) , 'SR' , ( sr . last_name || ', ' || sr . first_name ) , ' ' ) , decode ( h . status_id , 'SA' , sa . work_phone , 'FA' , fa . work_phone , 'AA' , aa . work_phone , 'LB' , lb . work_phone , 'LM' , lb . work_phone , 'MA' , ma . work_phone , 'CA' , ca . work_phone , 'JA' , aa . work_phone , 'SR' , sr . work_phone , ' ' ) ) tbl , mctr_line_item l where tbl . mctr_no = l . mctr_no ( + ) group by tbl . mctr_no , tbl . title , tbl . bems_orig , tbl . bems_fin_ctl , decode ( rtrim ( tbl . fin_ctl_full_name ) , ',' , null , tbl . fin_ctl_full_name ) , tbl . fin_ctl_phone , tbl . full_name , tbl . work_phone , tbl . orig_date , tbl . status_id , tbl . status_descr , tbl . status_date , decode ( rtrim ( tbl . intray_full_name ) , ',' , ' ' , tbl . intray_full_name ) , tbl . intray_phone , tbl . days , decode ( l . proj_trans_type_from , null , '???' , l . proj_trans_type_from ) order by tbl . mctr_no desc , decode ( l . proj_trans_type_from , null , '???' , l . proj_trans_type_from ) asc");

            parameters[0] = new OracleParameter(":f_bu", OracleDbType.Varchar2, retrived.f_bu, ParameterDirection.Input);
            var result = entities.Database.SqlQuery<MctrOpenReportsBl>(query.ToString(), parameters).ToList<MctrOpenReportsBl>();
            return result;
        }

        public IEnumerable<MctrBusUnit> getRgBuLOV(IEnumerable<MctrBusUnit> mctrOpenReportsBl)
        {
            OracleParameter[] parameter = new OracleParameter[1];

            var retrived = mctrOpenReportsBl.First<MctrBusUnit>();

            StringBuilder query = new StringBuilder("select b . business_unit , b . group_cd7 , b . descr , b . effdt , b . eff_status from mctr_bus_unit_v b where exists ( select rb . business_unit from mctr_role_bu rb where rb . bems = :session_bems and ( rb . business_unit = b . business_unit or ( rb . group_cd7 = b . group_cd7 and rb . business_unit = '**' ) ) ) and exists ( select h . orig_bu from mctr_header h where h . orig_bu = b . business_unit and h . status_id = '99' and h . date_journal is not null ) order by b . business_unit");

            parameter[0] = new OracleParameter(":session_bems", OracleDbType.Varchar2, retrived.session_bems, ParameterDirection.Input);

            var result = entities.Database.SqlQuery<MctrBusUnit>(query.ToString(), parameter).ToList<MctrBusUnit>();

            return result;
        }

        public string findReportServer(string appName)
        {

            try
            {

                // this function returns the oracle reports server name, or if the name is not found, or an error occurs, returns &quot; server_not_found & quot;.
                OracleParameter[] parmeter = new OracleParameter[1];
                StringBuilder query = new StringBuilder("select reportserver_name  from  reportserver_destination where upper ( application ) = :0");
                parmeter[0] = new OracleParameter(":application", OracleDbType.Varchar2, appName, ParameterDirection.Input);

                string result = entities.Database.SqlQuery<MctrOpenReportsBl>(query.ToString(), parmeter).ToString();

                return result;
            }
            catch (Exception e)
            {
                logger.Error("Error from MCTR.DataAccess.LineItemRepository.mctrLineItemPostQuery" + e.Message);

                return "server_not_found";

            }
        }
    }

}
