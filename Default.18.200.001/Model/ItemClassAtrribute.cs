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
    /// ItemClassAtrribute
    /// </summary>
    [DataContract]
    public partial class ItemClassAtrribute : Entity,  IEquatable<ItemClassAtrribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemClassAtrribute" /> class.
        /// </summary>
        /// <param name="attributeID">attributeID.</param>
        /// <param name="required">required.</param>
        /// <param name="sortOrder">sortOrder.</param>
        public ItemClassAtrribute(StringValue attributeID = default(StringValue), BooleanValue required = default(BooleanValue), ShortValue sortOrder = default(ShortValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AttributeID = attributeID;
            this.Required = required;
            this.SortOrder = sortOrder;
        }
        
        /// <summary>
        /// Gets or Sets AttributeID
        /// </summary>
        [DataMember(Name="AttributeID", EmitDefaultValue=false)]
        public StringValue AttributeID { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="Required", EmitDefaultValue=false)]
        public BooleanValue Required { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="SortOrder", EmitDefaultValue=false)]
        public ShortValue SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemClassAtrribute {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AttributeID: ").Append(AttributeID).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as ItemClassAtrribute);
        }

        /// <summary>
        /// Returns true if ItemClassAtrribute instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemClassAtrribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemClassAtrribute input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AttributeID == input.AttributeID ||
                    (this.AttributeID != null &&
                    this.AttributeID.Equals(input.AttributeID))
                ) && base.Equals(input) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && base.Equals(input) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
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
                if (this.AttributeID != null)
                    hashCode = hashCode * 59 + this.AttributeID.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
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
