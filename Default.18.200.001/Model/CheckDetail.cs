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
    /// CheckDetail
    /// </summary>
    [DataContract]
    public partial class CheckDetail : Entity,  IEquatable<CheckDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckDetail" /> class.
        /// </summary>
        /// <param name="amountPaid">amountPaid.</param>
        /// <param name="balance">balance.</param>
        /// <param name="cashDiscountBalance">cashDiscountBalance.</param>
        /// <param name="docType">docType.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        public CheckDetail(DecimalValue amountPaid = default(DecimalValue), DecimalValue balance = default(DecimalValue), DecimalValue cashDiscountBalance = default(DecimalValue), StringValue docType = default(StringValue), StringValue referenceNbr = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AmountPaid = amountPaid;
            this.Balance = balance;
            this.CashDiscountBalance = cashDiscountBalance;
            this.DocType = docType;
            this.ReferenceNbr = referenceNbr;
        }
        
        /// <summary>
        /// Gets or Sets AmountPaid
        /// </summary>
        [DataMember(Name="AmountPaid", EmitDefaultValue=false)]
        public DecimalValue AmountPaid { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public DecimalValue Balance { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountBalance
        /// </summary>
        [DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
        public DecimalValue CashDiscountBalance { get; set; }

        /// <summary>
        /// Gets or Sets DocType
        /// </summary>
        [DataMember(Name="DocType", EmitDefaultValue=false)]
        public StringValue DocType { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CashDiscountBalance: ").Append(CashDiscountBalance).Append("\n");
            sb.Append("  DocType: ").Append(DocType).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
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
            return this.Equals(input as CheckDetail);
        }

        /// <summary>
        /// Returns true if CheckDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AmountPaid == input.AmountPaid ||
                    (this.AmountPaid != null &&
                    this.AmountPaid.Equals(input.AmountPaid))
                ) && base.Equals(input) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && base.Equals(input) && 
                (
                    this.CashDiscountBalance == input.CashDiscountBalance ||
                    (this.CashDiscountBalance != null &&
                    this.CashDiscountBalance.Equals(input.CashDiscountBalance))
                ) && base.Equals(input) && 
                (
                    this.DocType == input.DocType ||
                    (this.DocType != null &&
                    this.DocType.Equals(input.DocType))
                ) && base.Equals(input) && 
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
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
                if (this.AmountPaid != null)
                    hashCode = hashCode * 59 + this.AmountPaid.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.CashDiscountBalance != null)
                    hashCode = hashCode * 59 + this.CashDiscountBalance.GetHashCode();
                if (this.DocType != null)
                    hashCode = hashCode * 59 + this.DocType.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
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
