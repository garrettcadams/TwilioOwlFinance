﻿using Twilio.OwlFinance.Domain.Model.Data;

namespace Twilio.OwlFinance.Domain.Model.ApiModel
{
    public class CaseExistenceApiModel : ICanHaveError
    {
        public CaseExistenceModel Data { get; set; }
        public string Message { get; set; }
        public bool HasError { get; set; }
        public int StatusCode { get; set; }
    }
}
