using System;
namespace CMS.Models.DataModels
{
    public class GetPnrCodeParamModel
    {
        public Guid OrderId { get; set; }
        public Guid Token { get; set; }
    }
}
