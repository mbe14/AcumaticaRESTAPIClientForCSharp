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
    /// InventorySummaryInquiry
    /// </summary>
    [DataContract]
    public partial class InventorySummaryInquiry : Entity,  IEquatable<InventorySummaryInquiry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySummaryInquiry" /> class.
        /// </summary>
        /// <param name="expandByLotSerialNbr">expandByLotSerialNbr.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="results">results.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public InventorySummaryInquiry(BooleanValue expandByLotSerialNbr = default(BooleanValue), StringValue inventoryID = default(StringValue), StringValue locationID = default(StringValue), List<InventorySummaryRow> results = default(List<InventorySummaryRow>), StringValue subitem = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ExpandByLotSerialNbr = expandByLotSerialNbr;
            this.InventoryID = inventoryID;
            this.LocationID = locationID;
            this.Results = results;
            this.Subitem = subitem;
            this.WarehouseID = warehouseID;
        }
        
        /// <summary>
        /// Gets or Sets ExpandByLotSerialNbr
        /// </summary>
        [DataMember(Name="ExpandByLotSerialNbr", EmitDefaultValue=false)]
        public BooleanValue ExpandByLotSerialNbr { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="Results", EmitDefaultValue=false)]
        public List<InventorySummaryRow> Results { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public StringValue WarehouseID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventorySummaryInquiry {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ExpandByLotSerialNbr: ").Append(ExpandByLotSerialNbr).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
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
            return this.Equals(input as InventorySummaryInquiry);
        }

        /// <summary>
        /// Returns true if InventorySummaryInquiry instances are equal
        /// </summary>
        /// <param name="input">Instance of InventorySummaryInquiry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventorySummaryInquiry input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ExpandByLotSerialNbr == input.ExpandByLotSerialNbr ||
                    (this.ExpandByLotSerialNbr != null &&
                    this.ExpandByLotSerialNbr.Equals(input.ExpandByLotSerialNbr))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
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
                if (this.ExpandByLotSerialNbr != null)
                    hashCode = hashCode * 59 + this.ExpandByLotSerialNbr.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
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
