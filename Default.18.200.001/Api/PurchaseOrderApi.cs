using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class PurchaseOrderApi : EntityAPI<PurchaseOrder>
    {
        public PurchaseOrderApi() : base()
        {
        }
        public PurchaseOrderApi(Configuration configuration) : base(configuration)
        {
        }
    }
}