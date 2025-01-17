/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// HttpError
    /// </summary>
    [DataContract]
    public partial class HttpError : Dictionary<String, Object>,  IEquatable<HttpError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpError" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="messageDetail">messageDetail.</param>
        /// <param name="exceptionMessage">exceptionMessage.</param>
        /// <param name="exceptionType">exceptionType.</param>
        /// <param name="stackTrace">stackTrace.</param>
        /// <param name="modelState">modelState.</param>
        public HttpError(string message = default(string), string messageDetail = default(string), string exceptionMessage = default(string), string exceptionType = default(string), string stackTrace = default(string), Dictionary<string, List<string>> modelState = default(Dictionary<string, List<string>>)) : base()
        {
            this.Message = message;
            this.MessageDetail = messageDetail;
            this.ExceptionMessage = exceptionMessage;
            this.ExceptionType = exceptionType;
            this.StackTrace = stackTrace;
            this.ModelState = modelState;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MessageDetail
        /// </summary>
        [DataMember(Name="messageDetail", EmitDefaultValue=false)]
        public string MessageDetail { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionMessage
        /// </summary>
        [DataMember(Name="exceptionMessage", EmitDefaultValue=false)]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionType
        /// </summary>
        [DataMember(Name="exceptionType", EmitDefaultValue=false)]
        public string ExceptionType { get; set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name="stackTrace", EmitDefaultValue=false)]
        public string StackTrace { get; set; }

        /// <summary>
        /// Gets or Sets ModelState
        /// </summary>
        [DataMember(Name="modelState", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> ModelState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpError {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageDetail: ").Append(MessageDetail).Append("\n");
            sb.Append("  ExceptionMessage: ").Append(ExceptionMessage).Append("\n");
            sb.Append("  ExceptionType: ").Append(ExceptionType).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  ModelState: ").Append(ModelState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as HttpError);
        }

        /// <summary>
        /// Returns true if HttpError instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpError input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && base.Equals(input) && 
                (
                    this.MessageDetail == input.MessageDetail ||
                    (this.MessageDetail != null &&
                    this.MessageDetail.Equals(input.MessageDetail))
                ) && base.Equals(input) && 
                (
                    this.ExceptionMessage == input.ExceptionMessage ||
                    (this.ExceptionMessage != null &&
                    this.ExceptionMessage.Equals(input.ExceptionMessage))
                ) && base.Equals(input) && 
                (
                    this.ExceptionType == input.ExceptionType ||
                    (this.ExceptionType != null &&
                    this.ExceptionType.Equals(input.ExceptionType))
                ) && base.Equals(input) && 
                (
                    this.StackTrace == input.StackTrace ||
                    (this.StackTrace != null &&
                    this.StackTrace.Equals(input.StackTrace))
                ) && base.Equals(input) && 
                (
                    this.ModelState == input.ModelState ||
                    this.ModelState != null &&
                    this.ModelState.SequenceEqual(input.ModelState)
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageDetail != null)
                    hashCode = hashCode * 59 + this.MessageDetail.GetHashCode();
                if (this.ExceptionMessage != null)
                    hashCode = hashCode * 59 + this.ExceptionMessage.GetHashCode();
                if (this.ExceptionType != null)
                    hashCode = hashCode * 59 + this.ExceptionType.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
                if (this.ModelState != null)
                    hashCode = hashCode * 59 + this.ModelState.GetHashCode();
                return hashCode;
            }
        }
    }

}
