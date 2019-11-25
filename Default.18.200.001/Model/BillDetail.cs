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
    /// BillDetail
    /// </summary>
    [DataContract]
    public partial class BillDetail : Entity,  IEquatable<BillDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="amount">amount.</param>
        /// <param name="branch">branch.</param>
        /// <param name="calculateDiscountsOnImport">calculateDiscountsOnImport.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="description">description.</param>
        /// <param name="extendedCost">extendedCost.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="nonBillable">nonBillable.</param>
        /// <param name="pOLine">pOLine.</param>
        /// <param name="pOOrderNbr">pOOrderNbr.</param>
        /// <param name="pOOrderType">pOOrderType.</param>
        /// <param name="pOReceiptLine">pOReceiptLine.</param>
        /// <param name="pOReceiptNbr">pOReceiptNbr.</param>
        /// <param name="project">project.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="qty">qty.</param>
        /// <param name="subaccount">subaccount.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="transactionDescription">transactionDescription.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="uOM">uOM.</param>
        public BillDetail(StringValue account = default(StringValue), DecimalValue amount = default(DecimalValue), StringValue branch = default(StringValue), BooleanValue calculateDiscountsOnImport = default(BooleanValue), StringValue costCode = default(StringValue), StringValue description = default(StringValue), DecimalValue extendedCost = default(DecimalValue), StringValue inventoryID = default(StringValue), BooleanValue nonBillable = default(BooleanValue), IntValue pOLine = default(IntValue), StringValue pOOrderNbr = default(StringValue), StringValue pOOrderType = default(StringValue), IntValue pOReceiptLine = default(IntValue), StringValue pOReceiptNbr = default(StringValue), StringValue project = default(StringValue), StringValue projectTask = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue subaccount = default(StringValue), StringValue taxCategory = default(StringValue), StringValue transactionDescription = default(StringValue), DecimalValue unitCost = default(DecimalValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.Amount = amount;
            this.Branch = branch;
            this.CalculateDiscountsOnImport = calculateDiscountsOnImport;
            this.CostCode = costCode;
            this.Description = description;
            this.ExtendedCost = extendedCost;
            this.InventoryID = inventoryID;
            this.NonBillable = nonBillable;
            this.POLine = pOLine;
            this.POOrderNbr = pOOrderNbr;
            this.POOrderType = pOOrderType;
            this.POReceiptLine = pOReceiptLine;
            this.POReceiptNbr = pOReceiptNbr;
            this.Project = project;
            this.ProjectTask = projectTask;
            this.Qty = qty;
            this.Subaccount = subaccount;
            this.TaxCategory = taxCategory;
            this.TransactionDescription = transactionDescription;
            this.UnitCost = unitCost;
            this.UOM = uOM;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets CalculateDiscountsOnImport
        /// </summary>
        [DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
        public BooleanValue CalculateDiscountsOnImport { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedCost
        /// </summary>
        [DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
        public DecimalValue ExtendedCost { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets NonBillable
        /// </summary>
        [DataMember(Name="NonBillable", EmitDefaultValue=false)]
        public BooleanValue NonBillable { get; set; }

        /// <summary>
        /// Gets or Sets POLine
        /// </summary>
        [DataMember(Name="POLine", EmitDefaultValue=false)]
        public IntValue POLine { get; set; }

        /// <summary>
        /// Gets or Sets POOrderNbr
        /// </summary>
        [DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
        public StringValue POOrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets POOrderType
        /// </summary>
        [DataMember(Name="POOrderType", EmitDefaultValue=false)]
        public StringValue POOrderType { get; set; }

        /// <summary>
        /// Gets or Sets POReceiptLine
        /// </summary>
        [DataMember(Name="POReceiptLine", EmitDefaultValue=false)]
        public IntValue POReceiptLine { get; set; }

        /// <summary>
        /// Gets or Sets POReceiptNbr
        /// </summary>
        [DataMember(Name="POReceiptNbr", EmitDefaultValue=false)]
        public StringValue POReceiptNbr { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets Subaccount
        /// </summary>
        [DataMember(Name="Subaccount", EmitDefaultValue=false)]
        public StringValue Subaccount { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDescription
        /// </summary>
        [DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
        public StringValue TransactionDescription { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=false)]
        public DecimalValue UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CalculateDiscountsOnImport: ").Append(CalculateDiscountsOnImport).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  NonBillable: ").Append(NonBillable).Append("\n");
            sb.Append("  POLine: ").Append(POLine).Append("\n");
            sb.Append("  POOrderNbr: ").Append(POOrderNbr).Append("\n");
            sb.Append("  POOrderType: ").Append(POOrderType).Append("\n");
            sb.Append("  POReceiptLine: ").Append(POReceiptLine).Append("\n");
            sb.Append("  POReceiptNbr: ").Append(POReceiptNbr).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as BillDetail);
        }

        /// <summary>
        /// Returns true if BillDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BillDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.CalculateDiscountsOnImport == input.CalculateDiscountsOnImport ||
                    (this.CalculateDiscountsOnImport != null &&
                    this.CalculateDiscountsOnImport.Equals(input.CalculateDiscountsOnImport))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ExtendedCost == input.ExtendedCost ||
                    (this.ExtendedCost != null &&
                    this.ExtendedCost.Equals(input.ExtendedCost))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.NonBillable == input.NonBillable ||
                    (this.NonBillable != null &&
                    this.NonBillable.Equals(input.NonBillable))
                ) && base.Equals(input) && 
                (
                    this.POLine == input.POLine ||
                    (this.POLine != null &&
                    this.POLine.Equals(input.POLine))
                ) && base.Equals(input) && 
                (
                    this.POOrderNbr == input.POOrderNbr ||
                    (this.POOrderNbr != null &&
                    this.POOrderNbr.Equals(input.POOrderNbr))
                ) && base.Equals(input) && 
                (
                    this.POOrderType == input.POOrderType ||
                    (this.POOrderType != null &&
                    this.POOrderType.Equals(input.POOrderType))
                ) && base.Equals(input) && 
                (
                    this.POReceiptLine == input.POReceiptLine ||
                    (this.POReceiptLine != null &&
                    this.POReceiptLine.Equals(input.POReceiptLine))
                ) && base.Equals(input) && 
                (
                    this.POReceiptNbr == input.POReceiptNbr ||
                    (this.POReceiptNbr != null &&
                    this.POReceiptNbr.Equals(input.POReceiptNbr))
                ) && base.Equals(input) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) && 
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && base.Equals(input) && 
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
                ) && base.Equals(input) && 
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CalculateDiscountsOnImport != null)
                    hashCode = hashCode * 59 + this.CalculateDiscountsOnImport.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtendedCost != null)
                    hashCode = hashCode * 59 + this.ExtendedCost.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.NonBillable != null)
                    hashCode = hashCode * 59 + this.NonBillable.GetHashCode();
                if (this.POLine != null)
                    hashCode = hashCode * 59 + this.POLine.GetHashCode();
                if (this.POOrderNbr != null)
                    hashCode = hashCode * 59 + this.POOrderNbr.GetHashCode();
                if (this.POOrderType != null)
                    hashCode = hashCode * 59 + this.POOrderType.GetHashCode();
                if (this.POReceiptLine != null)
                    hashCode = hashCode * 59 + this.POReceiptLine.GetHashCode();
                if (this.POReceiptNbr != null)
                    hashCode = hashCode * 59 + this.POReceiptNbr.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Subaccount != null)
                    hashCode = hashCode * 59 + this.Subaccount.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
