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
using Acumatica.RESTClient.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
    /// <summary>
    /// Payments
    /// </summary>
    [DataContract]
    public partial class Payments : Entity,  IEquatable<Payments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payments" /> class.
        /// </summary>
        /// <param name="appliedToOrder">appliedToOrder.</param>
        /// <param name="balance">balance.</param>
        /// <param name="cashAccount">cashAccount.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="docType">docType.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="paymentAmount">paymentAmount.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="paymentRef">paymentRef.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="status">status.</param>
        /// <param name="transferredtoInvoice">transferredtoInvoice.</param>
        public Payments(DecimalValue appliedToOrder = default(DecimalValue), DecimalValue balance = default(DecimalValue), StringValue cashAccount = default(StringValue), StringValue currencyID = default(StringValue), StringValue docType = default(StringValue), StringValue orderNbr = default(StringValue), StringValue orderType = default(StringValue), DecimalValue paymentAmount = default(DecimalValue), StringValue paymentMethod = default(StringValue), StringValue paymentRef = default(StringValue), StringValue referenceNbr = default(StringValue), StringValue status = default(StringValue), DecimalValue transferredtoInvoice = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AppliedToOrder = appliedToOrder;
            this.Balance = balance;
            this.CashAccount = cashAccount;
            this.CurrencyID = currencyID;
            this.DocType = docType;
            this.OrderNbr = orderNbr;
            this.OrderType = orderType;
            this.PaymentAmount = paymentAmount;
            this.PaymentMethod = paymentMethod;
            this.PaymentRef = paymentRef;
            this.ReferenceNbr = referenceNbr;
            this.Status = status;
            this.TransferredtoInvoice = transferredtoInvoice;
        }
        
        /// <summary>
        /// Gets or Sets AppliedToOrder
        /// </summary>
        [DataMember(Name="AppliedToOrder", EmitDefaultValue=false)]
        public DecimalValue AppliedToOrder { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public DecimalValue Balance { get; set; }

        /// <summary>
        /// Gets or Sets CashAccount
        /// </summary>
        [DataMember(Name="CashAccount", EmitDefaultValue=false)]
        public StringValue CashAccount { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets DocType
        /// </summary>
        [DataMember(Name="DocType", EmitDefaultValue=false)]
        public StringValue DocType { get; set; }

        /// <summary>
        /// Gets or Sets OrderNbr
        /// </summary>
        [DataMember(Name="OrderNbr", EmitDefaultValue=false)]
        public StringValue OrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="OrderType", EmitDefaultValue=false)]
        public StringValue OrderType { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAmount
        /// </summary>
        [DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
        public DecimalValue PaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public StringValue PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets PaymentRef
        /// </summary>
        [DataMember(Name="PaymentRef", EmitDefaultValue=false)]
        public StringValue PaymentRef { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TransferredtoInvoice
        /// </summary>
        [DataMember(Name="TransferredtoInvoice", EmitDefaultValue=false)]
        public DecimalValue TransferredtoInvoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payments {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AppliedToOrder: ").Append(AppliedToOrder).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CashAccount: ").Append(CashAccount).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  DocType: ").Append(DocType).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  PaymentAmount: ").Append(PaymentAmount).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentRef: ").Append(PaymentRef).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransferredtoInvoice: ").Append(TransferredtoInvoice).Append("\n");
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
            return this.Equals(input as Payments);
        }

        /// <summary>
        /// Returns true if Payments instances are equal
        /// </summary>
        /// <param name="input">Instance of Payments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payments input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AppliedToOrder == input.AppliedToOrder ||
                    (this.AppliedToOrder != null &&
                    this.AppliedToOrder.Equals(input.AppliedToOrder))
                ) && base.Equals(input) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && base.Equals(input) && 
                (
                    this.CashAccount == input.CashAccount ||
                    (this.CashAccount != null &&
                    this.CashAccount.Equals(input.CashAccount))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) && 
                (
                    this.DocType == input.DocType ||
                    (this.DocType != null &&
                    this.DocType.Equals(input.DocType))
                ) && base.Equals(input) && 
                (
                    this.OrderNbr == input.OrderNbr ||
                    (this.OrderNbr != null &&
                    this.OrderNbr.Equals(input.OrderNbr))
                ) && base.Equals(input) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && base.Equals(input) && 
                (
                    this.PaymentAmount == input.PaymentAmount ||
                    (this.PaymentAmount != null &&
                    this.PaymentAmount.Equals(input.PaymentAmount))
                ) && base.Equals(input) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && base.Equals(input) && 
                (
                    this.PaymentRef == input.PaymentRef ||
                    (this.PaymentRef != null &&
                    this.PaymentRef.Equals(input.PaymentRef))
                ) && base.Equals(input) && 
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TransferredtoInvoice == input.TransferredtoInvoice ||
                    (this.TransferredtoInvoice != null &&
                    this.TransferredtoInvoice.Equals(input.TransferredtoInvoice))
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
                if (this.AppliedToOrder != null)
                    hashCode = hashCode * 59 + this.AppliedToOrder.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.CashAccount != null)
                    hashCode = hashCode * 59 + this.CashAccount.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.DocType != null)
                    hashCode = hashCode * 59 + this.DocType.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.PaymentAmount != null)
                    hashCode = hashCode * 59 + this.PaymentAmount.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentRef != null)
                    hashCode = hashCode * 59 + this.PaymentRef.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TransferredtoInvoice != null)
                    hashCode = hashCode * 59 + this.TransferredtoInvoice.GetHashCode();
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