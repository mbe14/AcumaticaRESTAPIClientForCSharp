using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EstimateOperationOutsideProcess : Entity_v4
	{

		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue DropShippedtoVendor { get; set; }

		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue OutsideProcess { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue VendorLocation { get; set; }

	}
}