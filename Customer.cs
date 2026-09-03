using System;
using System.Collections.Generic;
using System.Text;

namespace C969_Project
{
    internal class Customer
    {
        internal required int CustomerId { get; set; }
        internal required string CustomerName { get; set; }
        internal required int AddressId { get; set; }
        internal bool Active { get; set; }
        internal DateTime CreateDate { get; set; }
        internal string CreatedBy { get; set; }
        internal DateTime LastUpdate { get; set; }
        internal string LastUpdateBy { get; set; }

        internal Customer(int customerId, string customerName, int addressId, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            AddressId = addressId;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
