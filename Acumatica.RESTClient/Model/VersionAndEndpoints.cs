/* 
 * Some version
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.Auth.Model
{
    /// <summary>
    /// VersionAndEndpoints
    /// </summary>
    [DataContract]
    public partial class VersionAndEndpoints :  IEquatable<VersionAndEndpoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionAndEndpoints" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="endpoints">endpoints.</param>
        public VersionAndEndpoints(Version version = default(Version), List<Endpoint> endpoints = default(List<Endpoint>))
        {
            this.Version = version;
            this.Endpoints = endpoints;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        [DataMember(Name="endpoints", EmitDefaultValue=false)]
        public List<Endpoint> Endpoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionAndEndpoints {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
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
            return this.Equals(input as VersionAndEndpoints);
        }

        /// <summary>
        /// Returns true if VersionAndEndpoints instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionAndEndpoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionAndEndpoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Endpoints == input.Endpoints ||
                    this.Endpoints != null &&
                    this.Endpoints.SequenceEqual(input.Endpoints)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                return hashCode;
            }
        }
    }

}
