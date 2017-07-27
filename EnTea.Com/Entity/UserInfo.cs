using System;

namespace EnTea.Com.Entity
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
