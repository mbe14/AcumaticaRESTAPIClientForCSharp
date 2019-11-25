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
    /// SalesInvoiceSalesPersonDetail
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceSalesPersonDetail : Entity,  IEquatable<SalesInvoiceSalesPersonDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceSalesPersonDetail" /> class.
        /// </summary>
        /// <param name="commissionableAmount">commissionableAmount.</param>
        /// <param name="commissionAmount">commissionAmount.</param>
        /// <param name="commissionPercent">commissionPercent.</param>
        /// <param name="salespersonID">salespersonID.</param>
        public SalesInvoiceSalesPersonDetail(DecimalValue commissionableAmount = default(DecimalValue), DecimalValue commissionAmount = default(DecimalValue), DecimalValue commissionPercent = default(DecimalValue), StringValue salespersonID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CommissionableAmount = commissionableAmount;
            this.CommissionAmount = commissionAmount;
            this.CommissionPercent = commissionPercent;
            this.SalespersonID = salespersonID;
        }
        
        /// <summary>
        /// Gets or Sets CommissionableAmount
        /// </summary>
        [DataMember(Name="CommissionableAmount", EmitDefaultValue=false)]
        public DecimalValue CommissionableAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommissionAmount
        /// </summary>
        [DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
        public DecimalValue CommissionAmount { get; set; }

        /// <summary>
        /// Gets or Sets CommissionPercent
        /// </summary>
        [DataMember(Name="CommissionPercent", EmitDefaultValue=false)]
        public DecimalValue CommissionPercent { get; set; }

        /// <summary>
        /// Gets or Sets SalespersonID
        /// </summary>
        [DataMember(Name="SalespersonID", EmitDefaultValue=false)]
        public StringValue SalespersonID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesInvoiceSalesPersonDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CommissionableAmount: ").Append(CommissionableAmount).Append("\n");
            sb.Append("  CommissionAmount: ").Append(CommissionAmount).Append("\n");
            sb.Append("  CommissionPercent: ").Append(CommissionPercent).Append("\n");
            sb.Append("  SalespersonID: ").Append(SalespersonID).Append("\n");
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
            return this.Equals(input as SalesInvoiceSalesPersonDetail);
        }

        /// <summary>
        /// Returns true if SalesInvoiceSalesPersonDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesInvoiceSalesPersonDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceSalesPersonDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CommissionableAmount == input.CommissionableAmount ||
                    (this.CommissionableAmount != null &&
                    this.CommissionableAmount.Equals(input.CommissionableAmount))
                ) && base.Equals(input) && 
                (
                    this.CommissionAmount == input.CommissionAmount ||
                    (this.CommissionAmount != null &&
                    this.CommissionAmount.Equals(input.CommissionAmount))
                ) && base.Equals(input) && 
                (
                    this.CommissionPercent == input.CommissionPercent ||
                    (this.CommissionPercent != null &&
                    this.CommissionPercent.Equals(input.CommissionPercent))
                ) && base.Equals(input) && 
                (
                    this.SalespersonID == input.SalespersonID ||
                    (this.SalespersonID != null &&
                    this.SalespersonID.Equals(input.SalespersonID))
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
                if (this.CommissionableAmount != null)
                    hashCode = hashCode * 59 + this.CommissionableAmount.GetHashCode();
                if (this.CommissionAmount != null)
                    hashCode = hashCode * 59 + this.CommissionAmount.GetHashCode();
                if (this.CommissionPercent != null)
                    hashCode = hashCode * 59 + this.CommissionPercent.GetHashCode();
                if (this.SalespersonID != null)
                    hashCode = hashCode * 59 + this.SalespersonID.GetHashCode();
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
