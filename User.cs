using System;
using System.Collections.Generic;
using System.Text;

namespace C969_Project
{
    internal sealed record User
    {
        internal required int Id { get; set; }
        internal required string UserName { get; set; } = string.Empty;
        internal required string Password { get; set; } = string.Empty;
        internal bool Active { get; set; }
        internal DateTime CreateDate { get; set; }
        internal string CreatedBy { get; set; } = string.Empty;
        internal DateTime LastUpdated { get; set; }
        internal string LastUpdateBy { get; set; }

        internal User(int id, string userName, string password, bool active, DateTime createDate, string createdBy, DateTime lastUpdated, string lastUpdateBy)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdated = lastUpdated;
            LastUpdateBy = lastUpdateBy;
        }

    }



}
