/* 
 * Default/17.200.001
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
using Acumatica.RESTClient.Model;
using System.ComponentModel.DataAnnotations;


namespace Acumatica.Default_17_200_001.Model
{
    /// <summary>
    /// ContactUserInfo
    /// </summary>
    [DataContract]
    public partial class ContactUserInfo : Entity,  IEquatable<ContactUserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactUserInfo" /> class.
        /// </summary>
        /// <param name="generatePassword">generatePassword.</param>
        /// <param name="login">login.</param>
        /// <param name="password">password.</param>
        /// <param name="roles">roles.</param>
        /// <param name="status">status.</param>
        /// <param name="userType">userType.</param>
        public ContactUserInfo(BooleanValue generatePassword = default(BooleanValue), StringValue login = default(StringValue), StringValue password = default(StringValue), List<ContactRoles> roles = default(List<ContactRoles>), StringValue status = default(StringValue), StringValue userType = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.GeneratePassword = generatePassword;
            this.Login = login;
            this.Password = password;
            this.Roles = roles;
            this.Status = status;
            this.UserType = userType;
        }
        
        /// <summary>
        /// Gets or Sets GeneratePassword
        /// </summary>
        [DataMember(Name="GeneratePassword", EmitDefaultValue=false)]
        public BooleanValue GeneratePassword { get; set; }

        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name="Login", EmitDefaultValue=false)]
        public StringValue Login { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public StringValue Password { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="Roles", EmitDefaultValue=false)]
        public List<ContactRoles> Roles { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name="UserType", EmitDefaultValue=false)]
        public StringValue UserType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactUserInfo {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  GeneratePassword: ").Append(GeneratePassword).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
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
            return this.Equals(input as ContactUserInfo);
        }

        /// <summary>
        /// Returns true if ContactUserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactUserInfo input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.GeneratePassword == input.GeneratePassword ||
                    (this.GeneratePassword != null &&
                    this.GeneratePassword.Equals(input.GeneratePassword))
                ) && base.Equals(input) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && base.Equals(input) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && base.Equals(input) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
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
                if (this.GeneratePassword != null)
                    hashCode = hashCode * 59 + this.GeneratePassword.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserType != null)
                    hashCode = hashCode * 59 + this.UserType.GetHashCode();
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