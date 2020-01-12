using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class StatementCycleApi : EntityAPI<StatementCycle>
    {
        public StatementCycleApi() : base()
        {
        }
        public StatementCycleApi(Configuration configuration) : base(configuration)
        {
        }
    }
}