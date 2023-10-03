﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.PaymentsMicroservice.Contracts.Requests
{
    public class CreateProudctRequestContract
    {
        public long OrderId { get; set; }
        public string Name { get; set; }
        public decimal TotalAmount { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
