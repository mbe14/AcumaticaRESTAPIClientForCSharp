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
    /// ContactNotification
    /// </summary>
    [DataContract]
    public partial class ContactNotification : Entity,  IEquatable<ContactNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactNotification" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="classID">classID.</param>
        /// <param name="description">description.</param>
        /// <param name="format">format.</param>
        /// <param name="mailingID">mailingID.</param>
        /// <param name="module">module.</param>
        /// <param name="notificationID">notificationID.</param>
        /// <param name="report">report.</param>
        /// <param name="source">source.</param>
        public ContactNotification(BooleanValue active = default(BooleanValue), BooleanValue bcc = default(BooleanValue), StringValue classID = default(StringValue), StringValue description = default(StringValue), StringValue format = default(StringValue), StringValue mailingID = default(StringValue), StringValue module = default(StringValue), IntValue notificationID = default(IntValue), StringValue report = default(StringValue), StringValue source = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.Bcc = bcc;
            this.ClassID = classID;
            this.Description = description;
            this.Format = format;
            this.MailingID = mailingID;
            this.Module = module;
            this.NotificationID = notificationID;
            this.Report = report;
            this.Source = source;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name="Bcc", EmitDefaultValue=false)]
        public BooleanValue Bcc { get; set; }

        /// <summary>
        /// Gets or Sets ClassID
        /// </summary>
        [DataMember(Name="ClassID", EmitDefaultValue=false)]
        public StringValue ClassID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="Format", EmitDefaultValue=false)]
        public StringValue Format { get; set; }

        /// <summary>
        /// Gets or Sets MailingID
        /// </summary>
        [DataMember(Name="MailingID", EmitDefaultValue=false)]
        public StringValue MailingID { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="Module", EmitDefaultValue=false)]
        public StringValue Module { get; set; }

        /// <summary>
        /// Gets or Sets NotificationID
        /// </summary>
        [DataMember(Name="NotificationID", EmitDefaultValue=false)]
        public IntValue NotificationID { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name="Report", EmitDefaultValue=false)]
        public StringValue Report { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="Source", EmitDefaultValue=false)]
        public StringValue Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactNotification {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  ClassID: ").Append(ClassID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  MailingID: ").Append(MailingID).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  NotificationID: ").Append(NotificationID).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as ContactNotification);
        }

        /// <summary>
        /// Returns true if ContactNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactNotification input)
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
                    this.Bcc == input.Bcc ||
                    (this.Bcc != null &&
                    this.Bcc.Equals(input.Bcc))
                ) && base.Equals(input) && 
                (
                    this.ClassID == input.ClassID ||
                    (this.ClassID != null &&
                    this.ClassID.Equals(input.ClassID))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && base.Equals(input) && 
                (
                    this.MailingID == input.MailingID ||
                    (this.MailingID != null &&
                    this.MailingID.Equals(input.MailingID))
                ) && base.Equals(input) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && base.Equals(input) && 
                (
                    this.NotificationID == input.NotificationID ||
                    (this.NotificationID != null &&
                    this.NotificationID.Equals(input.NotificationID))
                ) && base.Equals(input) && 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
                ) && base.Equals(input) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.ClassID != null)
                    hashCode = hashCode * 59 + this.ClassID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.MailingID != null)
                    hashCode = hashCode * 59 + this.MailingID.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.NotificationID != null)
                    hashCode = hashCode * 59 + this.NotificationID.GetHashCode();
                if (this.Report != null)
                    hashCode = hashCode * 59 + this.Report.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
