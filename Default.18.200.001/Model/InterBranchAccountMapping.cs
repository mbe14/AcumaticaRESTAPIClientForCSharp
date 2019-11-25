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
    /// InterBranchAccountMapping
    /// </summary>
    [DataContract]
    public partial class InterBranchAccountMapping : Entity,  IEquatable<InterBranchAccountMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterBranchAccountMapping" /> class.
        /// </summary>
        /// <param name="originatingBranch">originatingBranch.</param>
        /// <param name="postingLedger">postingLedger.</param>
        /// <param name="transactionsInDestinationBranch">transactionsInDestinationBranch.</param>
        /// <param name="transactionsInSourceBranch">transactionsInSourceBranch.</param>
        public InterBranchAccountMapping(StringValue originatingBranch = default(StringValue), StringValue postingLedger = default(StringValue), List<InterBranchAccountMappingTransactionInDestinationBranchDetail> transactionsInDestinationBranch = default(List<InterBranchAccountMappingTransactionInDestinationBranchDetail>), List<InterBranchAccountMappingTransactionInSourceBranchDetail> transactionsInSourceBranch = default(List<InterBranchAccountMappingTransactionInSourceBranchDetail>), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.OriginatingBranch = originatingBranch;
            this.PostingLedger = postingLedger;
            this.TransactionsInDestinationBranch = transactionsInDestinationBranch;
            this.TransactionsInSourceBranch = transactionsInSourceBranch;
        }
        
        /// <summary>
        /// Gets or Sets OriginatingBranch
        /// </summary>
        [DataMember(Name="OriginatingBranch", EmitDefaultValue=false)]
        public StringValue OriginatingBranch { get; set; }

        /// <summary>
        /// Gets or Sets PostingLedger
        /// </summary>
        [DataMember(Name="PostingLedger", EmitDefaultValue=false)]
        public StringValue PostingLedger { get; set; }

        /// <summary>
        /// Gets or Sets TransactionsInDestinationBranch
        /// </summary>
        [DataMember(Name="TransactionsInDestinationBranch", EmitDefaultValue=false)]
        public List<InterBranchAccountMappingTransactionInDestinationBranchDetail> TransactionsInDestinationBranch { get; set; }

        /// <summary>
        /// Gets or Sets TransactionsInSourceBranch
        /// </summary>
        [DataMember(Name="TransactionsInSourceBranch", EmitDefaultValue=false)]
        public List<InterBranchAccountMappingTransactionInSourceBranchDetail> TransactionsInSourceBranch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterBranchAccountMapping {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  OriginatingBranch: ").Append(OriginatingBranch).Append("\n");
            sb.Append("  PostingLedger: ").Append(PostingLedger).Append("\n");
            sb.Append("  TransactionsInDestinationBranch: ").Append(TransactionsInDestinationBranch).Append("\n");
            sb.Append("  TransactionsInSourceBranch: ").Append(TransactionsInSourceBranch).Append("\n");
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
            return this.Equals(input as InterBranchAccountMapping);
        }

        /// <summary>
        /// Returns true if InterBranchAccountMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of InterBranchAccountMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterBranchAccountMapping input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.OriginatingBranch == input.OriginatingBranch ||
                    (this.OriginatingBranch != null &&
                    this.OriginatingBranch.Equals(input.OriginatingBranch))
                ) && base.Equals(input) && 
                (
                    this.PostingLedger == input.PostingLedger ||
                    (this.PostingLedger != null &&
                    this.PostingLedger.Equals(input.PostingLedger))
                ) && base.Equals(input) && 
                (
                    this.TransactionsInDestinationBranch == input.TransactionsInDestinationBranch ||
                    this.TransactionsInDestinationBranch != null &&
                    this.TransactionsInDestinationBranch.SequenceEqual(input.TransactionsInDestinationBranch)
                ) && base.Equals(input) && 
                (
                    this.TransactionsInSourceBranch == input.TransactionsInSourceBranch ||
                    this.TransactionsInSourceBranch != null &&
                    this.TransactionsInSourceBranch.SequenceEqual(input.TransactionsInSourceBranch)
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
                if (this.OriginatingBranch != null)
                    hashCode = hashCode * 59 + this.OriginatingBranch.GetHashCode();
                if (this.PostingLedger != null)
                    hashCode = hashCode * 59 + this.PostingLedger.GetHashCode();
                if (this.TransactionsInDestinationBranch != null)
                    hashCode = hashCode * 59 + this.TransactionsInDestinationBranch.GetHashCode();
                if (this.TransactionsInSourceBranch != null)
                    hashCode = hashCode * 59 + this.TransactionsInSourceBranch.GetHashCode();
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
