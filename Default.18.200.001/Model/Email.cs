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
    /// Email
    /// </summary>
    [DataContract]
    public partial class Email : Entity,  IEquatable<Email>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="bcc">bcc.</param>
        /// <param name="body">body.</param>
        /// <param name="cc">cc.</param>
        /// <param name="date">date.</param>
        /// <param name="description">description.</param>
        /// <param name="from">from.</param>
        /// <param name="fromEmailAccountDisplayName">fromEmailAccountDisplayName.</param>
        /// <param name="fromEmailAccountID">fromEmailAccountID.</param>
        /// <param name="incoming">incoming.</param>
        /// <param name="_internal">_internal.</param>
        /// <param name="mailStatus">mailStatus.</param>
        /// <param name="owner">owner.</param>
        /// <param name="parent">parent.</param>
        /// <param name="parentSummary">parentSummary.</param>
        /// <param name="relatedEntityDescription">relatedEntityDescription.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="subject">subject.</param>
        /// <param name="timeActivity">timeActivity.</param>
        /// <param name="to">to.</param>
        /// <param name="workgroup">workgroup.</param>
        public Email(StringValue bcc = default(StringValue), StringValue body = default(StringValue), StringValue cc = default(StringValue), DateTimeValue date = default(DateTimeValue), StringValue description = default(StringValue), StringValue from = default(StringValue), StringValue fromEmailAccountDisplayName = default(StringValue), IntValue fromEmailAccountID = default(IntValue), BooleanValue incoming = default(BooleanValue), BooleanValue _internal = default(BooleanValue), StringValue mailStatus = default(StringValue), StringValue owner = default(StringValue), GuidValue parent = default(GuidValue), StringValue parentSummary = default(StringValue), StringValue relatedEntityDescription = default(StringValue), DateTimeValue startTime = default(DateTimeValue), StringValue subject = default(StringValue), TimeActivity timeActivity = default(TimeActivity), StringValue to = default(StringValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Bcc = bcc;
            this.Body = body;
            this.Cc = cc;
            this.Date = date;
            this.Description = description;
            this.From = from;
            this.FromEmailAccountDisplayName = fromEmailAccountDisplayName;
            this.FromEmailAccountID = fromEmailAccountID;
            this.Incoming = incoming;
            this.Internal = _internal;
            this.MailStatus = mailStatus;
            this.Owner = owner;
            this.Parent = parent;
            this.ParentSummary = parentSummary;
            this.RelatedEntityDescription = relatedEntityDescription;
            this.StartTime = startTime;
            this.Subject = subject;
            this.TimeActivity = timeActivity;
            this.To = to;
            this.Workgroup = workgroup;
        }
        
        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name="Bcc", EmitDefaultValue=false)]
        public StringValue Bcc { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="Body", EmitDefaultValue=false)]
        public StringValue Body { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="Cc", EmitDefaultValue=false)]
        public StringValue Cc { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTimeValue Date { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="From", EmitDefaultValue=false)]
        public StringValue From { get; set; }

        /// <summary>
        /// Gets or Sets FromEmailAccountDisplayName
        /// </summary>
        [DataMember(Name="FromEmailAccountDisplayName", EmitDefaultValue=false)]
        public StringValue FromEmailAccountDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FromEmailAccountID
        /// </summary>
        [DataMember(Name="FromEmailAccountID", EmitDefaultValue=false)]
        public IntValue FromEmailAccountID { get; set; }

        /// <summary>
        /// Gets or Sets Incoming
        /// </summary>
        [DataMember(Name="Incoming", EmitDefaultValue=false)]
        public BooleanValue Incoming { get; set; }

        /// <summary>
        /// Gets or Sets Internal
        /// </summary>
        [DataMember(Name="Internal", EmitDefaultValue=false)]
        public BooleanValue Internal { get; set; }

        /// <summary>
        /// Gets or Sets MailStatus
        /// </summary>
        [DataMember(Name="MailStatus", EmitDefaultValue=false)]
        public StringValue MailStatus { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public GuidValue Parent { get; set; }

        /// <summary>
        /// Gets or Sets ParentSummary
        /// </summary>
        [DataMember(Name="ParentSummary", EmitDefaultValue=false)]
        public StringValue ParentSummary { get; set; }

        /// <summary>
        /// Gets or Sets RelatedEntityDescription
        /// </summary>
        [DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
        public StringValue RelatedEntityDescription { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTimeValue StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public StringValue Subject { get; set; }

        /// <summary>
        /// Gets or Sets TimeActivity
        /// </summary>
        [DataMember(Name="TimeActivity", EmitDefaultValue=false)]
        public TimeActivity TimeActivity { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="To", EmitDefaultValue=false)]
        public StringValue To { get; set; }

        /// <summary>
        /// Gets or Sets Workgroup
        /// </summary>
        [DataMember(Name="Workgroup", EmitDefaultValue=false)]
        public StringValue Workgroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromEmailAccountDisplayName: ").Append(FromEmailAccountDisplayName).Append("\n");
            sb.Append("  FromEmailAccountID: ").Append(FromEmailAccountID).Append("\n");
            sb.Append("  Incoming: ").Append(Incoming).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  MailStatus: ").Append(MailStatus).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  ParentSummary: ").Append(ParentSummary).Append("\n");
            sb.Append("  RelatedEntityDescription: ").Append(RelatedEntityDescription).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TimeActivity: ").Append(TimeActivity).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Workgroup: ").Append(Workgroup).Append("\n");
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
            return this.Equals(input as Email);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="input">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Bcc == input.Bcc ||
                    (this.Bcc != null &&
                    this.Bcc.Equals(input.Bcc))
                ) && base.Equals(input) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && base.Equals(input) && 
                (
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && base.Equals(input) && 
                (
                    this.FromEmailAccountDisplayName == input.FromEmailAccountDisplayName ||
                    (this.FromEmailAccountDisplayName != null &&
                    this.FromEmailAccountDisplayName.Equals(input.FromEmailAccountDisplayName))
                ) && base.Equals(input) && 
                (
                    this.FromEmailAccountID == input.FromEmailAccountID ||
                    (this.FromEmailAccountID != null &&
                    this.FromEmailAccountID.Equals(input.FromEmailAccountID))
                ) && base.Equals(input) && 
                (
                    this.Incoming == input.Incoming ||
                    (this.Incoming != null &&
                    this.Incoming.Equals(input.Incoming))
                ) && base.Equals(input) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && base.Equals(input) && 
                (
                    this.MailStatus == input.MailStatus ||
                    (this.MailStatus != null &&
                    this.MailStatus.Equals(input.MailStatus))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && base.Equals(input) && 
                (
                    this.ParentSummary == input.ParentSummary ||
                    (this.ParentSummary != null &&
                    this.ParentSummary.Equals(input.ParentSummary))
                ) && base.Equals(input) && 
                (
                    this.RelatedEntityDescription == input.RelatedEntityDescription ||
                    (this.RelatedEntityDescription != null &&
                    this.RelatedEntityDescription.Equals(input.RelatedEntityDescription))
                ) && base.Equals(input) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && base.Equals(input) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && base.Equals(input) && 
                (
                    this.TimeActivity == input.TimeActivity ||
                    (this.TimeActivity != null &&
                    this.TimeActivity.Equals(input.TimeActivity))
                ) && base.Equals(input) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && base.Equals(input) && 
                (
                    this.Workgroup == input.Workgroup ||
                    (this.Workgroup != null &&
                    this.Workgroup.Equals(input.Workgroup))
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
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromEmailAccountDisplayName != null)
                    hashCode = hashCode * 59 + this.FromEmailAccountDisplayName.GetHashCode();
                if (this.FromEmailAccountID != null)
                    hashCode = hashCode * 59 + this.FromEmailAccountID.GetHashCode();
                if (this.Incoming != null)
                    hashCode = hashCode * 59 + this.Incoming.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.MailStatus != null)
                    hashCode = hashCode * 59 + this.MailStatus.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.ParentSummary != null)
                    hashCode = hashCode * 59 + this.ParentSummary.GetHashCode();
                if (this.RelatedEntityDescription != null)
                    hashCode = hashCode * 59 + this.RelatedEntityDescription.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.TimeActivity != null)
                    hashCode = hashCode * 59 + this.TimeActivity.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Workgroup != null)
                    hashCode = hashCode * 59 + this.Workgroup.GetHashCode();
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