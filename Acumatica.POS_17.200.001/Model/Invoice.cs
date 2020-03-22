using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class Invoice : Entity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="ApplicationsCreditMemo", EmitDefaultValue=false)]
		public List<InvoiceApplicationsCreditMemo> ApplicationsCreditMemo { get; set; }

		[DataMember(Name="ApplicationsDefault", EmitDefaultValue=false)]
		public List<InvoiceApplicationsDefault> ApplicationsDefault { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue Balance { get; set; }

		[DataMember(Name="BillingPrinted", EmitDefaultValue=false)]
		public BooleanValue BillingPrinted { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue CustomerOrder { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<InvoiceDetail> Details { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue DueDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LinkARAccount", EmitDefaultValue=false)]
		public StringValue LinkARAccount { get; set; }

		[DataMember(Name="LinkBranch", EmitDefaultValue=false)]
		public StringValue LinkBranch { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<InvoiceTaxDetail> TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue Terms { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}