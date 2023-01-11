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
    /// ListRealTimeMetricsResponse
    /// </summary>
    [DataContract(Name = "ListRealTimeMetricsResponse")]
    public partial class ListRealTimeMetricsResponse : IEquatable<ListRealTimeMetricsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRealTimeMetricsResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="totalRowCount">totalRowCount.</param>
        /// <param name="timeframe">timeframe.</param>
        public ListRealTimeMetricsResponse(List<ListMonitoringDimensionsResponseData> data = default(List<ListMonitoringDimensionsResponseData>), long totalRowCount = default(long), List<long> timeframe = default(List<long>))
        {
            this.Data = data;
            this.TotalRowCount = totalRowCount;
            this.Timeframe = timeframe;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<ListMonitoringDimensionsResponseData> Data { get; set; }

        /// <summary>
        /// Gets or Sets TotalRowCount
        /// </summary>
        [DataMember(Name = "total_row_count", EmitDefaultValue = false)]
        public long TotalRowCount { get; set; }

        /// <summary>
        /// Gets or Sets Timeframe
        /// </summary>
        [DataMember(Name = "timeframe", EmitDefaultValue = false)]
        public List<long> Timeframe { get; set; }

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
            sb.Append("class ListRealTimeMetricsResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  TotalRowCount: ").Append(TotalRowCount).Append("\n");
            sb.Append("  Timeframe: ").Append(Timeframe).Append("\n");
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
            return this.Equals(input as ListRealTimeMetricsResponse);
        }

        /// <summary>
        /// Returns true if ListRealTimeMetricsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListRealTimeMetricsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListRealTimeMetricsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.TotalRowCount == input.TotalRowCount ||
                    this.TotalRowCount.Equals(input.TotalRowCount)
                ) && 
                (
                    this.Timeframe == input.Timeframe ||
                    this.Timeframe != null &&
                    input.Timeframe != null &&
                    this.Timeframe.SequenceEqual(input.Timeframe)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalRowCount.GetHashCode();
                if (this.Timeframe != null)
                {
                    hashCode = (hashCode * 59) + this.Timeframe.GetHashCode();
                }
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
            yield break;
        }
    }

}
