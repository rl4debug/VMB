using System;
namespace CMS.Models.DataModels
{
    public class MemberInfo
    {
        public string Username { get; set; }
        public int Type { get; set; }
        public string FullName { get; set; }
        public int Status { get; set; }
        public double Balance { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
