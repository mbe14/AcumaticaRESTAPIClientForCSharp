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
    /// ProjectEquipment
    /// </summary>
    [DataContract]
    public partial class ProjectEquipment : Entity,  IEquatable<ProjectEquipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectEquipment" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="description">description.</param>
        /// <param name="equipmentID">equipmentID.</param>
        /// <param name="runRate">runRate.</param>
        /// <param name="runRateItem">runRateItem.</param>
        /// <param name="setupRate">setupRate.</param>
        /// <param name="setupRateItem">setupRateItem.</param>
        /// <param name="suspendRate">suspendRate.</param>
        /// <param name="suspendRateItem">suspendRateItem.</param>
        public ProjectEquipment(BooleanValue active = default(BooleanValue), StringValue description = default(StringValue), StringValue equipmentID = default(StringValue), DecimalValue runRate = default(DecimalValue), StringValue runRateItem = default(StringValue), DecimalValue setupRate = default(DecimalValue), StringValue setupRateItem = default(StringValue), DecimalValue suspendRate = default(DecimalValue), StringValue suspendRateItem = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.Description = description;
            this.EquipmentID = equipmentID;
            this.RunRate = runRate;
            this.RunRateItem = runRateItem;
            this.SetupRate = setupRate;
            this.SetupRateItem = setupRateItem;
            this.SuspendRate = suspendRate;
            this.SuspendRateItem = suspendRateItem;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets EquipmentID
        /// </summary>
        [DataMember(Name="EquipmentID", EmitDefaultValue=false)]
        public StringValue EquipmentID { get; set; }

        /// <summary>
        /// Gets or Sets RunRate
        /// </summary>
        [DataMember(Name="RunRate", EmitDefaultValue=false)]
        public DecimalValue RunRate { get; set; }

        /// <summary>
        /// Gets or Sets RunRateItem
        /// </summary>
        [DataMember(Name="RunRateItem", EmitDefaultValue=false)]
        public StringValue RunRateItem { get; set; }

        /// <summary>
        /// Gets or Sets SetupRate
        /// </summary>
        [DataMember(Name="SetupRate", EmitDefaultValue=false)]
        public DecimalValue SetupRate { get; set; }

        /// <summary>
        /// Gets or Sets SetupRateItem
        /// </summary>
        [DataMember(Name="SetupRateItem", EmitDefaultValue=false)]
        public StringValue SetupRateItem { get; set; }

        /// <summary>
        /// Gets or Sets SuspendRate
        /// </summary>
        [DataMember(Name="SuspendRate", EmitDefaultValue=false)]
        public DecimalValue SuspendRate { get; set; }

        /// <summary>
        /// Gets or Sets SuspendRateItem
        /// </summary>
        [DataMember(Name="SuspendRateItem", EmitDefaultValue=false)]
        public StringValue SuspendRateItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectEquipment {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EquipmentID: ").Append(EquipmentID).Append("\n");
            sb.Append("  RunRate: ").Append(RunRate).Append("\n");
            sb.Append("  RunRateItem: ").Append(RunRateItem).Append("\n");
            sb.Append("  SetupRate: ").Append(SetupRate).Append("\n");
            sb.Append("  SetupRateItem: ").Append(SetupRateItem).Append("\n");
            sb.Append("  SuspendRate: ").Append(SuspendRate).Append("\n");
            sb.Append("  SuspendRateItem: ").Append(SuspendRateItem).Append("\n");
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
            return this.Equals(input as ProjectEquipment);
        }

        /// <summary>
        /// Returns true if ProjectEquipment instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectEquipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectEquipment input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.EquipmentID == input.EquipmentID ||
                    (this.EquipmentID != null &&
                    this.EquipmentID.Equals(input.EquipmentID))
                ) && base.Equals(input) && 
                (
                    this.RunRate == input.RunRate ||
                    (this.RunRate != null &&
                    this.RunRate.Equals(input.RunRate))
                ) && base.Equals(input) && 
                (
                    this.RunRateItem == input.RunRateItem ||
                    (this.RunRateItem != null &&
                    this.RunRateItem.Equals(input.RunRateItem))
                ) && base.Equals(input) && 
                (
                    this.SetupRate == input.SetupRate ||
                    (this.SetupRate != null &&
                    this.SetupRate.Equals(input.SetupRate))
                ) && base.Equals(input) && 
                (
                    this.SetupRateItem == input.SetupRateItem ||
                    (this.SetupRateItem != null &&
                    this.SetupRateItem.Equals(input.SetupRateItem))
                ) && base.Equals(input) && 
                (
                    this.SuspendRate == input.SuspendRate ||
                    (this.SuspendRate != null &&
                    this.SuspendRate.Equals(input.SuspendRate))
                ) && base.Equals(input) && 
                (
                    this.SuspendRateItem == input.SuspendRateItem ||
                    (this.SuspendRateItem != null &&
                    this.SuspendRateItem.Equals(input.SuspendRateItem))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EquipmentID != null)
                    hashCode = hashCode * 59 + this.EquipmentID.GetHashCode();
                if (this.RunRate != null)
                    hashCode = hashCode * 59 + this.RunRate.GetHashCode();
                if (this.RunRateItem != null)
                    hashCode = hashCode * 59 + this.RunRateItem.GetHashCode();
                if (this.SetupRate != null)
                    hashCode = hashCode * 59 + this.SetupRate.GetHashCode();
                if (this.SetupRateItem != null)
                    hashCode = hashCode * 59 + this.SetupRateItem.GetHashCode();
                if (this.SuspendRate != null)
                    hashCode = hashCode * 59 + this.SuspendRate.GetHashCode();
                if (this.SuspendRateItem != null)
                    hashCode = hashCode * 59 + this.SuspendRateItem.GetHashCode();
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
