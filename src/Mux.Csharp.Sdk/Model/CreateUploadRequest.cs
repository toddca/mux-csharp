/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Mux.Csharp.Sdk.Client.OpenAPIDateConverter;

namespace Mux.Csharp.Sdk.Model
{
    /// <summary>
    /// CreateUploadRequest
    /// </summary>
    [DataContract(Name = "CreateUploadRequest")]
    public partial class CreateUploadRequest : IEquatable<CreateUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadRequest" /> class.
        /// </summary>
        /// <param name="timeout">Max time in seconds for the signed upload URL to be valid. If a successful upload has not occurred before the timeout limit, the direct upload is marked &#x60;timed_out&#x60; (default to 3600).</param>
        /// <param name="corsOrigin">If the upload URL will be used in a browser, you must specify the origin in order for the signed URL to have the correct CORS headers..</param>
        /// <param name="newAssetSettings">newAssetSettings.</param>
        /// <param name="test">test.</param>
        public CreateUploadRequest(int timeout = 3600, string corsOrigin = default(string), CreateAssetRequest newAssetSettings = default(CreateAssetRequest), bool test = default(bool))
        {
            this.Timeout = timeout;
            this.CorsOrigin = corsOrigin;
            this.NewAssetSettings = newAssetSettings;
            this.Test = test;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Max time in seconds for the signed upload URL to be valid. If a successful upload has not occurred before the timeout limit, the direct upload is marked &#x60;timed_out&#x60;
        /// </summary>
        /// <value>Max time in seconds for the signed upload URL to be valid. If a successful upload has not occurred before the timeout limit, the direct upload is marked &#x60;timed_out&#x60;</value>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public int Timeout { get; set; }

        /// <summary>
        /// If the upload URL will be used in a browser, you must specify the origin in order for the signed URL to have the correct CORS headers.
        /// </summary>
        /// <value>If the upload URL will be used in a browser, you must specify the origin in order for the signed URL to have the correct CORS headers.</value>
        [DataMember(Name = "cors_origin", EmitDefaultValue = false)]
        public string CorsOrigin { get; set; }

        /// <summary>
        /// Gets or Sets NewAssetSettings
        /// </summary>
        [DataMember(Name = "new_asset_settings", EmitDefaultValue = false)]
        public CreateAssetRequest NewAssetSettings { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name = "test", EmitDefaultValue = true)]
        public bool Test { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUploadRequest {\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  CorsOrigin: ").Append(CorsOrigin).Append("\n");
            sb.Append("  NewAssetSettings: ").Append(NewAssetSettings).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUploadRequest);
        }

        /// <summary>
        /// Returns true if CreateUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUploadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
                ) && 
                (
                    this.CorsOrigin == input.CorsOrigin ||
                    (this.CorsOrigin != null &&
                    this.CorsOrigin.Equals(input.CorsOrigin))
                ) && 
                (
                    this.NewAssetSettings == input.NewAssetSettings ||
                    (this.NewAssetSettings != null &&
                    this.NewAssetSettings.Equals(input.NewAssetSettings))
                ) && 
                (
                    this.Test == input.Test ||
                    this.Test.Equals(input.Test)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                if (this.CorsOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.CorsOrigin.GetHashCode();
                }
                if (this.NewAssetSettings != null)
                {
                    hashCode = (hashCode * 59) + this.NewAssetSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Test.GetHashCode();
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Timeout (int) maximum
            if (this.Timeout > (int)604800)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value less than or equal to 604800.", new [] { "Timeout" });
            }

            // Timeout (int) minimum
            if (this.Timeout < (int)60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value greater than or equal to 60.", new [] { "Timeout" });
            }

            yield break;
        }
    }

}
