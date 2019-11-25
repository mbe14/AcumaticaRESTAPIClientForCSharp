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
    /// CreateAccountFromOpportunity
    /// </summary>
    [DataContract]
    public partial class CreateAccountFromOpportunity :  IEquatable<CreateAccountFromOpportunity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountFromOpportunity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAccountFromOpportunity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountFromOpportunity" /> class.
        /// </summary>
        /// <param name="entity">entity (required).</param>
        /// <param name="parameters">parameters (required).</param>
        public CreateAccountFromOpportunity(Opportunity entity = default(Opportunity), ConvertContactToBusinessAccountParameters parameters = default(ConvertContactToBusinessAccountParameters))
        {
            // to ensure "entity" is required (not null)
            if (entity == null)
            {
                throw new InvalidDataException("entity is a required property for CreateAccountFromOpportunity and cannot be null");
            }
            else
            {
                this.Entity = entity;
            }
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new InvalidDataException("parameters is a required property for CreateAccountFromOpportunity and cannot be null");
            }
            else
            {
                this.Parameters = parameters;
            }
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Opportunity Entity { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public ConvertContactToBusinessAccountParameters Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountFromOpportunity {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as CreateAccountFromOpportunity);
        }

        /// <summary>
        /// Returns true if CreateAccountFromOpportunity instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAccountFromOpportunity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccountFromOpportunity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
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
                int hashCode = 41;
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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
            yield break;
        }
    }

}
