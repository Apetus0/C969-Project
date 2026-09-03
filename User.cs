using System;
using System.Collections.Generic;
using System.Text;

namespace C969_Project
{
    internal sealed record User
    {
        internal int UserId { get; set; }
        internal string UserName { get; set; } = string.Empty;
        internal string Password { get; set; } = string.Empty;
        internal bool Active { get; set; }
        internal DateTime CreateDate { get; set; }
        internal string CreatedBy { get; set; } = string.Empty;
        internal DateTime LastUpdated { get; set; }
        internal string LastUpdateBy { get; set; }

        internal User(int userId, string userName, string password, bool active, DateTime createDate, string createdBy, DateTime lastUpdated, string lastUpdateBy)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdated = lastUpdated;
            LastUpdateBy = lastUpdateBy;
        }

        internal User(int userId, string userName, string password)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
        }

    }



}
