using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MRPDetailInquiryResult : Entity_v4
	{

		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue ParentInventoryID { get; set; }

		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue ParentSubitem { get; set; }

		[DataMember(Name="ProductInventoryID", EmitDefaultValue=false)]
		public StringValue ProductInventoryID { get; set; }

		[DataMember(Name="ProductSubitem", EmitDefaultValue=false)]
		public StringValue ProductSubitem { get; set; }

		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue PromiseDate { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue QtyOnHand { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue RecordID { get; set; }

		[DataMember(Name="ReferenceType", EmitDefaultValue=false)]
		public StringValue ReferenceType { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue RelatedDocument { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}