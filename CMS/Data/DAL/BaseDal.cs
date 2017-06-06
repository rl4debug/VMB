using System;
using System.Configuration;
namespace CMS.Data.DAL
{
    public class BaseDal
    {
        public string ConnectionString { 
            get {
                return ConfigurationManager.ConnectionStrings["VMBConnection"].ConnectionString;
            }
        }
    }
}
