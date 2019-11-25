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
    /// TransferOrderDetailAllocation
    /// </summary>
    [DataContract]
    public partial class TransferOrderDetailAllocation : Entity,  IEquatable<TransferOrderDetailAllocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOrderDetailAllocation" /> class.
        /// </summary>
        /// <param name="locationID">locationID.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="qty">qty.</param>
        /// <param name="splitLineNumber">splitLineNumber.</param>
        /// <param name="subitem">subitem.</param>
        public TransferOrderDetailAllocation(StringValue locationID = default(StringValue), StringValue lotSerialNbr = default(StringValue), DecimalValue qty = default(DecimalValue), IntValue splitLineNumber = default(IntValue), StringValue subitem = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.LocationID = locationID;
            this.LotSerialNbr = lotSerialNbr;
            this.Qty = qty;
            this.SplitLineNumber = splitLineNumber;
            this.Subitem = subitem;
        }
        
        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets LotSerialNbr
        /// </summary>
        [DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
        public StringValue LotSerialNbr { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets SplitLineNumber
        /// </summary>
        [DataMember(Name="SplitLineNumber", EmitDefaultValue=false)]
        public IntValue SplitLineNumber { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferOrderDetailAllocation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  SplitLineNumber: ").Append(SplitLineNumber).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
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
            return this.Equals(input as TransferOrderDetailAllocation);
        }

        /// <summary>
        /// Returns true if TransferOrderDetailAllocation instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferOrderDetailAllocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferOrderDetailAllocation input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) && 
                (
                    this.LotSerialNbr == input.LotSerialNbr ||
                    (this.LotSerialNbr != null &&
                    this.LotSerialNbr.Equals(input.LotSerialNbr))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.SplitLineNumber == input.SplitLineNumber ||
                    (this.SplitLineNumber != null &&
                    this.SplitLineNumber.Equals(input.SplitLineNumber))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
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
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.SplitLineNumber != null)
                    hashCode = hashCode * 59 + this.SplitLineNumber.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
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
