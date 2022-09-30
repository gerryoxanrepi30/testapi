using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static WSWMS_TEST.ServiceModels;

namespace WSWMS_TEST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        WMS_TESTDataContext db;
        public List<User> PostDataUser(string userid)
        {
            db = new WMS_TESTDataContext();

            List<User> Users = new List<User>();
            try
            {
                var AllData = db.GetUser(userid);
                
                foreach (var i in AllData)
                {
                    User user = new User();
                    user.userid = i.userid;
                    user.namalengkap = i.namalengkap;
                    user.username = i.username;
                    user.password = i.password;
                    user.status = i.status;
                    Users.Add(user);
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
            
            return Users;
        }
        public string SetDataUser(int userid, string namalengkap, string username, string password, string status)
        {
            db = new WMS_TESTDataContext();
            //List<User> Users = new List<User>();
            try
            {
                db.InsertUser(userid, namalengkap, username, password, status);
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
            return "Data Insert.";
        }
        public string DelDataUser(int userid)
        {
            db = new WMS_TESTDataContext();
            //List<User> Users = new List<User>();
            try
            {
                
                db.DeleteUser(userid);
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
            return "Data Deleted.";
        }

    }
}
