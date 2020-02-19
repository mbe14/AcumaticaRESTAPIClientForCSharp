/* 
 * DeviceHub/19.200.001
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace Acumatica.DeviceHub_19_200_001.Model
{
    /// <summary>
    /// Scanner
    /// </summary>
    [DataContract]
    public partial class Scanner : Entity,  IEquatable<Scanner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scanner" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="fileTypeComboValues">fileTypeComboValues.</param>
        /// <param name="fileTypeDefValue">fileTypeDefValue.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="paperSourceComboValues">paperSourceComboValues.</param>
        /// <param name="paperSourceDefValue">paperSourceDefValue.</param>
        /// <param name="pixelTypeComboValues">pixelTypeComboValues.</param>
        /// <param name="pixelTypeDefValue">pixelTypeDefValue.</param>
        /// <param name="resolutionComboValues">resolutionComboValues.</param>
        /// <param name="resolutionDefValue">resolutionDefValue.</param>
        /// <param name="deviceHub">deviceHub.</param>
        /// <param name="scannerName">scannerName.</param>
        public Scanner(StringValue description = default(StringValue), StringValue fileTypeComboValues = default(StringValue), StringValue fileTypeDefValue = default(StringValue), BooleanValue isActive = default(BooleanValue), StringValue paperSourceComboValues = default(StringValue), StringValue paperSourceDefValue = default(StringValue), StringValue pixelTypeComboValues = default(StringValue), StringValue pixelTypeDefValue = default(StringValue), StringValue resolutionComboValues = default(StringValue), StringValue resolutionDefValue = default(StringValue), StringValue deviceHub = default(StringValue), StringValue scannerName = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Description = description;
            this.FileTypeComboValues = fileTypeComboValues;
            this.FileTypeDefValue = fileTypeDefValue;
            this.IsActive = isActive;
            this.PaperSourceComboValues = paperSourceComboValues;
            this.PaperSourceDefValue = paperSourceDefValue;
            this.PixelTypeComboValues = pixelTypeComboValues;
            this.PixelTypeDefValue = pixelTypeDefValue;
            this.ResolutionComboValues = resolutionComboValues;
            this.ResolutionDefValue = resolutionDefValue;
            this.DeviceHub = deviceHub;
            this.ScannerName = scannerName;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets FileTypeComboValues
        /// </summary>
        [DataMember(Name="FileTypeComboValues", EmitDefaultValue=false)]
        public StringValue FileTypeComboValues { get; set; }

        /// <summary>
        /// Gets or Sets FileTypeDefValue
        /// </summary>
        [DataMember(Name="FileTypeDefValue", EmitDefaultValue=false)]
        public StringValue FileTypeDefValue { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=false)]
        public BooleanValue IsActive { get; set; }

        /// <summary>
        /// Gets or Sets PaperSourceComboValues
        /// </summary>
        [DataMember(Name="PaperSourceComboValues", EmitDefaultValue=false)]
        public StringValue PaperSourceComboValues { get; set; }

        /// <summary>
        /// Gets or Sets PaperSourceDefValue
        /// </summary>
        [DataMember(Name="PaperSourceDefValue", EmitDefaultValue=false)]
        public StringValue PaperSourceDefValue { get; set; }

        /// <summary>
        /// Gets or Sets PixelTypeComboValues
        /// </summary>
        [DataMember(Name="PixelTypeComboValues", EmitDefaultValue=false)]
        public StringValue PixelTypeComboValues { get; set; }

        /// <summary>
        /// Gets or Sets PixelTypeDefValue
        /// </summary>
        [DataMember(Name="PixelTypeDefValue", EmitDefaultValue=false)]
        public StringValue PixelTypeDefValue { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionComboValues
        /// </summary>
        [DataMember(Name="ResolutionComboValues", EmitDefaultValue=false)]
        public StringValue ResolutionComboValues { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionDefValue
        /// </summary>
        [DataMember(Name="ResolutionDefValue", EmitDefaultValue=false)]
        public StringValue ResolutionDefValue { get; set; }

        /// <summary>
        /// Gets or Sets DeviceHub
        /// </summary>
        [DataMember(Name="DeviceHub", EmitDefaultValue=false)]
        public StringValue DeviceHub { get; set; }

        /// <summary>
        /// Gets or Sets ScannerName
        /// </summary>
        [DataMember(Name="ScannerName", EmitDefaultValue=false)]
        public StringValue ScannerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scanner {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FileTypeComboValues: ").Append(FileTypeComboValues).Append("\n");
            sb.Append("  FileTypeDefValue: ").Append(FileTypeDefValue).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  PaperSourceComboValues: ").Append(PaperSourceComboValues).Append("\n");
            sb.Append("  PaperSourceDefValue: ").Append(PaperSourceDefValue).Append("\n");
            sb.Append("  PixelTypeComboValues: ").Append(PixelTypeComboValues).Append("\n");
            sb.Append("  PixelTypeDefValue: ").Append(PixelTypeDefValue).Append("\n");
            sb.Append("  ResolutionComboValues: ").Append(ResolutionComboValues).Append("\n");
            sb.Append("  ResolutionDefValue: ").Append(ResolutionDefValue).Append("\n");
            sb.Append("  DeviceHub: ").Append(DeviceHub).Append("\n");
            sb.Append("  ScannerName: ").Append(ScannerName).Append("\n");
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
            return this.Equals(input as Scanner);
        }

        /// <summary>
        /// Returns true if Scanner instances are equal
        /// </summary>
        /// <param name="input">Instance of Scanner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scanner input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.FileTypeComboValues == input.FileTypeComboValues ||
                    (this.FileTypeComboValues != null &&
                    this.FileTypeComboValues.Equals(input.FileTypeComboValues))
                ) && base.Equals(input) && 
                (
                    this.FileTypeDefValue == input.FileTypeDefValue ||
                    (this.FileTypeDefValue != null &&
                    this.FileTypeDefValue.Equals(input.FileTypeDefValue))
                ) && base.Equals(input) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && base.Equals(input) && 
                (
                    this.PaperSourceComboValues == input.PaperSourceComboValues ||
                    (this.PaperSourceComboValues != null &&
                    this.PaperSourceComboValues.Equals(input.PaperSourceComboValues))
                ) && base.Equals(input) && 
                (
                    this.PaperSourceDefValue == input.PaperSourceDefValue ||
                    (this.PaperSourceDefValue != null &&
                    this.PaperSourceDefValue.Equals(input.PaperSourceDefValue))
                ) && base.Equals(input) && 
                (
                    this.PixelTypeComboValues == input.PixelTypeComboValues ||
                    (this.PixelTypeComboValues != null &&
                    this.PixelTypeComboValues.Equals(input.PixelTypeComboValues))
                ) && base.Equals(input) && 
                (
                    this.PixelTypeDefValue == input.PixelTypeDefValue ||
                    (this.PixelTypeDefValue != null &&
                    this.PixelTypeDefValue.Equals(input.PixelTypeDefValue))
                ) && base.Equals(input) && 
                (
                    this.ResolutionComboValues == input.ResolutionComboValues ||
                    (this.ResolutionComboValues != null &&
                    this.ResolutionComboValues.Equals(input.ResolutionComboValues))
                ) && base.Equals(input) && 
                (
                    this.ResolutionDefValue == input.ResolutionDefValue ||
                    (this.ResolutionDefValue != null &&
                    this.ResolutionDefValue.Equals(input.ResolutionDefValue))
                ) && base.Equals(input) && 
                (
                    this.DeviceHub == input.DeviceHub ||
                    (this.DeviceHub != null &&
                    this.DeviceHub.Equals(input.DeviceHub))
                ) && base.Equals(input) && 
                (
                    this.ScannerName == input.ScannerName ||
                    (this.ScannerName != null &&
                    this.ScannerName.Equals(input.ScannerName))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FileTypeComboValues != null)
                    hashCode = hashCode * 59 + this.FileTypeComboValues.GetHashCode();
                if (this.FileTypeDefValue != null)
                    hashCode = hashCode * 59 + this.FileTypeDefValue.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.PaperSourceComboValues != null)
                    hashCode = hashCode * 59 + this.PaperSourceComboValues.GetHashCode();
                if (this.PaperSourceDefValue != null)
                    hashCode = hashCode * 59 + this.PaperSourceDefValue.GetHashCode();
                if (this.PixelTypeComboValues != null)
                    hashCode = hashCode * 59 + this.PixelTypeComboValues.GetHashCode();
                if (this.PixelTypeDefValue != null)
                    hashCode = hashCode * 59 + this.PixelTypeDefValue.GetHashCode();
                if (this.ResolutionComboValues != null)
                    hashCode = hashCode * 59 + this.ResolutionComboValues.GetHashCode();
                if (this.ResolutionDefValue != null)
                    hashCode = hashCode * 59 + this.ResolutionDefValue.GetHashCode();
                if (this.DeviceHub != null)
                    hashCode = hashCode * 59 + this.DeviceHub.GetHashCode();
                if (this.ScannerName != null)
                    hashCode = hashCode * 59 + this.ScannerName.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}