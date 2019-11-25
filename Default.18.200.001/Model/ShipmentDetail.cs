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
    /// ShipmentDetail
    /// </summary>
    [DataContract]
    public partial class ShipmentDetail : Entity,  IEquatable<ShipmentDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDetail" /> class.
        /// </summary>
        /// <param name="allocations">allocations.</param>
        /// <param name="description">description.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="freeItem">freeItem.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="openQty">openQty.</param>
        /// <param name="orderedQty">orderedQty.</param>
        /// <param name="orderLineNbr">orderLineNbr.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="originalQty">originalQty.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="shippedQty">shippedQty.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public ShipmentDetail(List<ShipmentDetailAllocation> allocations = default(List<ShipmentDetailAllocation>), StringValue description = default(StringValue), DateTimeValue expirationDate = default(DateTimeValue), BooleanValue freeItem = default(BooleanValue), StringValue inventoryID = default(StringValue), IntValue lineNbr = default(IntValue), StringValue locationID = default(StringValue), StringValue lotSerialNbr = default(StringValue), DecimalValue openQty = default(DecimalValue), DecimalValue orderedQty = default(DecimalValue), IntValue orderLineNbr = default(IntValue), StringValue orderNbr = default(StringValue), StringValue orderType = default(StringValue), DecimalValue originalQty = default(DecimalValue), StringValue reasonCode = default(StringValue), DecimalValue shippedQty = default(DecimalValue), StringValue subitem = default(StringValue), StringValue uOM = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Allocations = allocations;
            this.Description = description;
            this.ExpirationDate = expirationDate;
            this.FreeItem = freeItem;
            this.InventoryID = inventoryID;
            this.LineNbr = lineNbr;
            this.LocationID = locationID;
            this.LotSerialNbr = lotSerialNbr;
            this.OpenQty = openQty;
            this.OrderedQty = orderedQty;
            this.OrderLineNbr = orderLineNbr;
            this.OrderNbr = orderNbr;
            this.OrderType = orderType;
            this.OriginalQty = originalQty;
            this.ReasonCode = reasonCode;
            this.ShippedQty = shippedQty;
            this.Subitem = subitem;
            this.UOM = uOM;
            this.WarehouseID = warehouseID;
        }
        
        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<ShipmentDetailAllocation> Allocations { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets FreeItem
        /// </summary>
        [DataMember(Name="FreeItem", EmitDefaultValue=false)]
        public BooleanValue FreeItem { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

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
        /// Gets or Sets OpenQty
        /// </summary>
        [DataMember(Name="OpenQty", EmitDefaultValue=false)]
        public DecimalValue OpenQty { get; set; }

        /// <summary>
        /// Gets or Sets OrderedQty
        /// </summary>
        [DataMember(Name="OrderedQty", EmitDefaultValue=false)]
        public DecimalValue OrderedQty { get; set; }

        /// <summary>
        /// Gets or Sets OrderLineNbr
        /// </summary>
        [DataMember(Name="OrderLineNbr", EmitDefaultValue=false)]
        public IntValue OrderLineNbr { get; set; }

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
        /// Gets or Sets OriginalQty
        /// </summary>
        [DataMember(Name="OriginalQty", EmitDefaultValue=false)]
        public DecimalValue OriginalQty { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
        public StringValue ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets ShippedQty
        /// </summary>
        [DataMember(Name="ShippedQty", EmitDefaultValue=false)]
        public DecimalValue ShippedQty { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

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
            sb.Append("class ShipmentDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  FreeItem: ").Append(FreeItem).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  OpenQty: ").Append(OpenQty).Append("\n");
            sb.Append("  OrderedQty: ").Append(OrderedQty).Append("\n");
            sb.Append("  OrderLineNbr: ").Append(OrderLineNbr).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  OriginalQty: ").Append(OriginalQty).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  ShippedQty: ").Append(ShippedQty).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as ShipmentDetail);
        }

        /// <summary>
        /// Returns true if ShipmentDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) && 
                (
                    this.FreeItem == input.FreeItem ||
                    (this.FreeItem != null &&
                    this.FreeItem.Equals(input.FreeItem))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
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
                    this.OpenQty == input.OpenQty ||
                    (this.OpenQty != null &&
                    this.OpenQty.Equals(input.OpenQty))
                ) && base.Equals(input) && 
                (
                    this.OrderedQty == input.OrderedQty ||
                    (this.OrderedQty != null &&
                    this.OrderedQty.Equals(input.OrderedQty))
                ) && base.Equals(input) && 
                (
                    this.OrderLineNbr == input.OrderLineNbr ||
                    (this.OrderLineNbr != null &&
                    this.OrderLineNbr.Equals(input.OrderLineNbr))
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
                    this.OriginalQty == input.OriginalQty ||
                    (this.OriginalQty != null &&
                    this.OriginalQty.Equals(input.OriginalQty))
                ) && base.Equals(input) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && base.Equals(input) && 
                (
                    this.ShippedQty == input.ShippedQty ||
                    (this.ShippedQty != null &&
                    this.ShippedQty.Equals(input.ShippedQty))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.FreeItem != null)
                    hashCode = hashCode * 59 + this.FreeItem.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.OpenQty != null)
                    hashCode = hashCode * 59 + this.OpenQty.GetHashCode();
                if (this.OrderedQty != null)
                    hashCode = hashCode * 59 + this.OrderedQty.GetHashCode();
                if (this.OrderLineNbr != null)
                    hashCode = hashCode * 59 + this.OrderLineNbr.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.OriginalQty != null)
                    hashCode = hashCode * 59 + this.OriginalQty.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.ShippedQty != null)
                    hashCode = hashCode * 59 + this.ShippedQty.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
