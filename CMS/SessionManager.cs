using System.Web;
namespace CMS
{
    public static class SessionManager
    {
        private static T Get<T>(string name)
		{
            if (HttpContext.Current.Session[name] == null)
                return default(T);
            
			return (T)HttpContext.Current.Session[name];
		}

        private static void Set<T>(string name, T value)
        {
            HttpContext.Current.Session[name] = value;
        }


        public static AccountInfo MemberInfo
        {
            get {
                return Get<AccountInfo>("_MemberInfo");
            }

            set{
                Set("_MemberInfo", value);
            }
        }
    }
}
