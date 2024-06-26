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
    /// AssetStaticRenditionsFiles
    /// </summary>
    [DataContract(Name = "Asset_static_renditions_files")]
    public partial class AssetStaticRenditionsFiles : IEquatable<AssetStaticRenditionsFiles>, IValidatableObject
    {
        /// <summary>
        /// Defines Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum LowMp4 for value: low.mp4
            /// </summary>
            [EnumMember(Value = "low.mp4")]
            LowMp4 = 1,

            /// <summary>
            /// Enum MediumMp4 for value: medium.mp4
            /// </summary>
            [EnumMember(Value = "medium.mp4")]
            MediumMp4 = 2,

            /// <summary>
            /// Enum HighMp4 for value: high.mp4
            /// </summary>
            [EnumMember(Value = "high.mp4")]
            HighMp4 = 3,

            /// <summary>
            /// Enum AudioM4a for value: audio.m4a
            /// </summary>
            [EnumMember(Value = "audio.m4a")]
            AudioM4a = 4,

            /// <summary>
            /// Enum Capped1080pMp4 for value: capped-1080p.mp4
            /// </summary>
            [EnumMember(Value = "capped-1080p.mp4")]
            Capped1080pMp4 = 5

        }


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Extension of the static rendition file
        /// </summary>
        /// <value>Extension of the static rendition file</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExtEnum
        {
            /// <summary>
            /// Enum Mp4 for value: mp4
            /// </summary>
            [EnumMember(Value = "mp4")]
            Mp4 = 1,

            /// <summary>
            /// Enum M4a for value: m4a
            /// </summary>
            [EnumMember(Value = "m4a")]
            M4a = 2

        }


        /// <summary>
        /// Extension of the static rendition file
        /// </summary>
        /// <value>Extension of the static rendition file</value>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public ExtEnum? Ext { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetStaticRenditionsFiles" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="ext">Extension of the static rendition file.</param>
        /// <param name="height">The height of the static rendition&#39;s file in pixels.</param>
        /// <param name="width">The width of the static rendition&#39;s file in pixels.</param>
        /// <param name="bitrate">The bitrate in bits per second.</param>
        /// <param name="filesize">The file size in bytes.</param>
        public AssetStaticRenditionsFiles(NameEnum? name = default(NameEnum?), ExtEnum? ext = default(ExtEnum?), int height = default(int), int width = default(int), long bitrate = default(long), string filesize = default(string))
        {
            this.Name = name;
            this.Ext = ext;
            this.Height = height;
            this.Width = width;
            this.Bitrate = bitrate;
            this.Filesize = filesize;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The height of the static rendition&#39;s file in pixels
        /// </summary>
        /// <value>The height of the static rendition&#39;s file in pixels</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// The width of the static rendition&#39;s file in pixels
        /// </summary>
        /// <value>The width of the static rendition&#39;s file in pixels</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The bitrate in bits per second
        /// </summary>
        /// <value>The bitrate in bits per second</value>
        [DataMember(Name = "bitrate", EmitDefaultValue = false)]
        public long Bitrate { get; set; }

        /// <summary>
        /// The file size in bytes
        /// </summary>
        /// <value>The file size in bytes</value>
        [DataMember(Name = "filesize", EmitDefaultValue = false)]
        public string Filesize { get; set; }

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
            sb.Append("class AssetStaticRenditionsFiles {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  Filesize: ").Append(Filesize).Append("\n");
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
            return this.Equals(input as AssetStaticRenditionsFiles);
        }

        /// <summary>
        /// Returns true if AssetStaticRenditionsFiles instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetStaticRenditionsFiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetStaticRenditionsFiles input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.Ext == input.Ext ||
                    this.Ext.Equals(input.Ext)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Bitrate == input.Bitrate ||
                    this.Bitrate.Equals(input.Bitrate)
                ) && 
                (
                    this.Filesize == input.Filesize ||
                    (this.Filesize != null &&
                    this.Filesize.Equals(input.Filesize))
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
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                hashCode = (hashCode * 59) + this.Ext.GetHashCode();
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.Bitrate.GetHashCode();
                if (this.Filesize != null)
                {
                    hashCode = (hashCode * 59) + this.Filesize.GetHashCode();
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
