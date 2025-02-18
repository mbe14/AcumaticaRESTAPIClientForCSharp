using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CapableToPromise : Entity_v4
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CapableToPromiseDetail> Details { get; set; }

		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue ProcessAction { get; set; }

		[DataMember(Name="RegularProductionOrderType", EmitDefaultValue=false)]
		public StringValue RegularProductionOrderType { get; set; }

		[DataMember(Name="SONbr", EmitDefaultValue=false)]
		public StringValue SONbr { get; set; }

		[DataMember(Name="SOType", EmitDefaultValue=false)]
		public StringValue SOType { get; set; }

	}
}