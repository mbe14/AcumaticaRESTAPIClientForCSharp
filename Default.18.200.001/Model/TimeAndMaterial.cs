/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Acumatica.RESTClient.Client.OpenAPIDateConverter;

namespace Acumatica.DefaultEndpoint.Model
{
    /// <summary>
    /// TimeAndMaterial
    /// </summary>
    [DataContract]
    public partial class TimeAndMaterial : Entity,  IEquatable<TimeAndMaterial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAndMaterial" /> class.
        /// </summary>
        /// <param name="amountToInvoice">amountToInvoice.</param>
        /// <param name="billedAmount">billedAmount.</param>
        /// <param name="billedQty">billedQty.</param>
        /// <param name="branch">branch.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="date">date.</param>
        /// <param name="deferralCode">deferralCode.</param>
        /// <param name="description">description.</param>
        /// <param name="employeeID">employeeID.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="maxAvailableAmount">maxAvailableAmount.</param>
        /// <param name="maxLimitAmount">maxLimitAmount.</param>
        /// <param name="overLimitAmount">overLimitAmount.</param>
        /// <param name="projectTaskID">projectTaskID.</param>
        /// <param name="qtyToInvoice">qtyToInvoice.</param>
        /// <param name="retainage">retainage.</param>
        /// <param name="retainageAmount">retainageAmount.</param>
        /// <param name="salesAccount">salesAccount.</param>
        /// <param name="salesSubaccount">salesSubaccount.</param>
        /// <param name="status">status.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="vendor">vendor.</param>
        public TimeAndMaterial(DecimalValue amountToInvoice = default(DecimalValue), DecimalValue billedAmount = default(DecimalValue), DecimalValue billedQty = default(DecimalValue), StringValue branch = default(StringValue), StringValue costCode = default(StringValue), DateTimeValue date = default(DateTimeValue), StringValue deferralCode = default(StringValue), StringValue description = default(StringValue), StringValue employeeID = default(StringValue), StringValue inventoryID = default(StringValue), DecimalValue maxAvailableAmount = default(DecimalValue), DecimalValue maxLimitAmount = default(DecimalValue), DecimalValue overLimitAmount = default(DecimalValue), StringValue projectTaskID = default(StringValue), DecimalValue qtyToInvoice = default(DecimalValue), DecimalValue retainage = default(DecimalValue), DecimalValue retainageAmount = default(DecimalValue), StringValue salesAccount = default(StringValue), StringValue salesSubaccount = default(StringValue), StringValue status = default(StringValue), StringValue taxCategory = default(StringValue), DecimalValue unitPrice = default(DecimalValue), StringValue uOM = default(StringValue), StringValue vendor = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AmountToInvoice = amountToInvoice;
            this.BilledAmount = billedAmount;
            this.BilledQty = billedQty;
            this.Branch = branch;
            this.CostCode = costCode;
            this.Date = date;
            this.DeferralCode = deferralCode;
            this.Description = description;
            this.EmployeeID = employeeID;
            this.InventoryID = inventoryID;
            this.MaxAvailableAmount = maxAvailableAmount;
            this.MaxLimitAmount = maxLimitAmount;
            this.OverLimitAmount = overLimitAmount;
            this.ProjectTaskID = projectTaskID;
            this.QtyToInvoice = qtyToInvoice;
            this.Retainage = retainage;
            this.RetainageAmount = retainageAmount;
            this.SalesAccount = salesAccount;
            this.SalesSubaccount = salesSubaccount;
            this.Status = status;
            this.TaxCategory = taxCategory;
            this.UnitPrice = unitPrice;
            this.UOM = uOM;
            this.Vendor = vendor;
        }
        
        /// <summary>
        /// Gets or Sets AmountToInvoice
        /// </summary>
        [DataMember(Name="AmountToInvoice", EmitDefaultValue=false)]
        public DecimalValue AmountToInvoice { get; set; }

        /// <summary>
        /// Gets or Sets BilledAmount
        /// </summary>
        [DataMember(Name="BilledAmount", EmitDefaultValue=false)]
        public DecimalValue BilledAmount { get; set; }

        /// <summary>
        /// Gets or Sets BilledQty
        /// </summary>
        [DataMember(Name="BilledQty", EmitDefaultValue=false)]
        public DecimalValue BilledQty { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTimeValue Date { get; set; }

        /// <summary>
        /// Gets or Sets DeferralCode
        /// </summary>
        [DataMember(Name="DeferralCode", EmitDefaultValue=false)]
        public StringValue DeferralCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeID
        /// </summary>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public StringValue EmployeeID { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets MaxAvailableAmount
        /// </summary>
        [DataMember(Name="MaxAvailableAmount", EmitDefaultValue=false)]
        public DecimalValue MaxAvailableAmount { get; set; }

        /// <summary>
        /// Gets or Sets MaxLimitAmount
        /// </summary>
        [DataMember(Name="MaxLimitAmount", EmitDefaultValue=false)]
        public DecimalValue MaxLimitAmount { get; set; }

        /// <summary>
        /// Gets or Sets OverLimitAmount
        /// </summary>
        [DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
        public DecimalValue OverLimitAmount { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTaskID
        /// </summary>
        [DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
        public StringValue ProjectTaskID { get; set; }

        /// <summary>
        /// Gets or Sets QtyToInvoice
        /// </summary>
        [DataMember(Name="QtyToInvoice", EmitDefaultValue=false)]
        public DecimalValue QtyToInvoice { get; set; }

        /// <summary>
        /// Gets or Sets Retainage
        /// </summary>
        [DataMember(Name="Retainage", EmitDefaultValue=false)]
        public DecimalValue Retainage { get; set; }

        /// <summary>
        /// Gets or Sets RetainageAmount
        /// </summary>
        [DataMember(Name="RetainageAmount", EmitDefaultValue=false)]
        public DecimalValue RetainageAmount { get; set; }

        /// <summary>
        /// Gets or Sets SalesAccount
        /// </summary>
        [DataMember(Name="SalesAccount", EmitDefaultValue=false)]
        public StringValue SalesAccount { get; set; }

        /// <summary>
        /// Gets or Sets SalesSubaccount
        /// </summary>
        [DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
        public StringValue SalesSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="UnitPrice", EmitDefaultValue=false)]
        public DecimalValue UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="Vendor", EmitDefaultValue=false)]
        public StringValue Vendor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeAndMaterial {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AmountToInvoice: ").Append(AmountToInvoice).Append("\n");
            sb.Append("  BilledAmount: ").Append(BilledAmount).Append("\n");
            sb.Append("  BilledQty: ").Append(BilledQty).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DeferralCode: ").Append(DeferralCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  MaxAvailableAmount: ").Append(MaxAvailableAmount).Append("\n");
            sb.Append("  MaxLimitAmount: ").Append(MaxLimitAmount).Append("\n");
            sb.Append("  OverLimitAmount: ").Append(OverLimitAmount).Append("\n");
            sb.Append("  ProjectTaskID: ").Append(ProjectTaskID).Append("\n");
            sb.Append("  QtyToInvoice: ").Append(QtyToInvoice).Append("\n");
            sb.Append("  Retainage: ").Append(Retainage).Append("\n");
            sb.Append("  RetainageAmount: ").Append(RetainageAmount).Append("\n");
            sb.Append("  SalesAccount: ").Append(SalesAccount).Append("\n");
            sb.Append("  SalesSubaccount: ").Append(SalesSubaccount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimeAndMaterial);
        }

        /// <summary>
        /// Returns true if TimeAndMaterial instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeAndMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeAndMaterial input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AmountToInvoice == input.AmountToInvoice ||
                    (this.AmountToInvoice != null &&
                    this.AmountToInvoice.Equals(input.AmountToInvoice))
                ) && base.Equals(input) && 
                (
                    this.BilledAmount == input.BilledAmount ||
                    (this.BilledAmount != null &&
                    this.BilledAmount.Equals(input.BilledAmount))
                ) && base.Equals(input) && 
                (
                    this.BilledQty == input.BilledQty ||
                    (this.BilledQty != null &&
                    this.BilledQty.Equals(input.BilledQty))
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) && 
                (
                    this.DeferralCode == input.DeferralCode ||
                    (this.DeferralCode != null &&
                    this.DeferralCode.Equals(input.DeferralCode))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.MaxAvailableAmount == input.MaxAvailableAmount ||
                    (this.MaxAvailableAmount != null &&
                    this.MaxAvailableAmount.Equals(input.MaxAvailableAmount))
                ) && base.Equals(input) && 
                (
                    this.MaxLimitAmount == input.MaxLimitAmount ||
                    (this.MaxLimitAmount != null &&
                    this.MaxLimitAmount.Equals(input.MaxLimitAmount))
                ) && base.Equals(input) && 
                (
                    this.OverLimitAmount == input.OverLimitAmount ||
                    (this.OverLimitAmount != null &&
                    this.OverLimitAmount.Equals(input.OverLimitAmount))
                ) && base.Equals(input) && 
                (
                    this.ProjectTaskID == input.ProjectTaskID ||
                    (this.ProjectTaskID != null &&
                    this.ProjectTaskID.Equals(input.ProjectTaskID))
                ) && base.Equals(input) && 
                (
                    this.QtyToInvoice == input.QtyToInvoice ||
                    (this.QtyToInvoice != null &&
                    this.QtyToInvoice.Equals(input.QtyToInvoice))
                ) && base.Equals(input) && 
                (
                    this.Retainage == input.Retainage ||
                    (this.Retainage != null &&
                    this.Retainage.Equals(input.Retainage))
                ) && base.Equals(input) && 
                (
                    this.RetainageAmount == input.RetainageAmount ||
                    (this.RetainageAmount != null &&
                    this.RetainageAmount.Equals(input.RetainageAmount))
                ) && base.Equals(input) && 
                (
                    this.SalesAccount == input.SalesAccount ||
                    (this.SalesAccount != null &&
                    this.SalesAccount.Equals(input.SalesAccount))
                ) && base.Equals(input) && 
                (
                    this.SalesSubaccount == input.SalesSubaccount ||
                    (this.SalesSubaccount != null &&
                    this.SalesSubaccount.Equals(input.SalesSubaccount))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && base.Equals(input) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
                ) && base.Equals(input) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.AmountToInvoice != null)
                    hashCode = hashCode * 59 + this.AmountToInvoice.GetHashCode();
                if (this.BilledAmount != null)
                    hashCode = hashCode * 59 + this.BilledAmount.GetHashCode();
                if (this.BilledQty != null)
                    hashCode = hashCode * 59 + this.BilledQty.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DeferralCode != null)
                    hashCode = hashCode * 59 + this.DeferralCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.MaxAvailableAmount != null)
                    hashCode = hashCode * 59 + this.MaxAvailableAmount.GetHashCode();
                if (this.MaxLimitAmount != null)
                    hashCode = hashCode * 59 + this.MaxLimitAmount.GetHashCode();
                if (this.OverLimitAmount != null)
                    hashCode = hashCode * 59 + this.OverLimitAmount.GetHashCode();
                if (this.ProjectTaskID != null)
                    hashCode = hashCode * 59 + this.ProjectTaskID.GetHashCode();
                if (this.QtyToInvoice != null)
                    hashCode = hashCode * 59 + this.QtyToInvoice.GetHashCode();
                if (this.Retainage != null)
                    hashCode = hashCode * 59 + this.Retainage.GetHashCode();
                if (this.RetainageAmount != null)
                    hashCode = hashCode * 59 + this.RetainageAmount.GetHashCode();
                if (this.SalesAccount != null)
                    hashCode = hashCode * 59 + this.SalesAccount.GetHashCode();
                if (this.SalesSubaccount != null)
                    hashCode = hashCode * 59 + this.SalesSubaccount.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.Vendor != null)
                    hashCode = hashCode * 59 + this.Vendor.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
