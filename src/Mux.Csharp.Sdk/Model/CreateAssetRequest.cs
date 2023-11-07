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
    /// CreateAssetRequest
    /// </summary>
    [DataContract(Name = "CreateAssetRequest")]
    public partial class CreateAssetRequest : IEquatable<CreateAssetRequest>, IValidatableObject
    {
        /// <summary>
        /// Specify what level (if any) of support for mp4 playback. In most cases you should use our default HLS-based streaming playback ({playback_id}.m3u8) which can automatically adjust to viewers&#39; connection speeds, but an mp4 can be useful for some legacy devices or downloading for offline playback. See the [Download your videos guide](/guides/video/download-your-videos) for more information.
        /// </summary>
        /// <value>Specify what level (if any) of support for mp4 playback. In most cases you should use our default HLS-based streaming playback ({playback_id}.m3u8) which can automatically adjust to viewers&#39; connection speeds, but an mp4 can be useful for some legacy devices or downloading for offline playback. See the [Download your videos guide](/guides/video/download-your-videos) for more information.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Mp4SupportEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2

        }


        /// <summary>
        /// Specify what level (if any) of support for mp4 playback. In most cases you should use our default HLS-based streaming playback ({playback_id}.m3u8) which can automatically adjust to viewers&#39; connection speeds, but an mp4 can be useful for some legacy devices or downloading for offline playback. See the [Download your videos guide](/guides/video/download-your-videos) for more information.
        /// </summary>
        /// <value>Specify what level (if any) of support for mp4 playback. In most cases you should use our default HLS-based streaming playback ({playback_id}.m3u8) which can automatically adjust to viewers&#39; connection speeds, but an mp4 can be useful for some legacy devices or downloading for offline playback. See the [Download your videos guide](/guides/video/download-your-videos) for more information.</value>
        [DataMember(Name = "mp4_support", EmitDefaultValue = false)]
        public Mp4SupportEnum? Mp4Support { get; set; }
        /// <summary>
        /// Specify what level (if any) of support for master access. Master access can be enabled temporarily for your asset to be downloaded. See the [Download your videos guide](/guides/video/download-your-videos) for more information.
        /// </summary>
        /// <value>Specify what level (if any) of support for master access. Master access can be enabled temporarily for your asset to be downloaded. See the [Download your videos guide](/guides/video/download-your-videos) for more information.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MasterAccessEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Temporary for value: temporary
            /// </summary>
            [EnumMember(Value = "temporary")]
            Temporary = 2

        }


        /// <summary>
        /// Specify what level (if any) of support for master access. Master access can be enabled temporarily for your asset to be downloaded. See the [Download your videos guide](/guides/video/download-your-videos) for more information.
        /// </summary>
        /// <value>Specify what level (if any) of support for master access. Master access can be enabled temporarily for your asset to be downloaded. See the [Download your videos guide](/guides/video/download-your-videos) for more information.</value>
        [DataMember(Name = "master_access", EmitDefaultValue = false)]
        public MasterAccessEnum? MasterAccess { get; set; }
        /// <summary>
        /// Max resolution tier can be used to control the maximum &#x60;resolution_tier&#x60; your asset is encoded, stored, and streamed at. If not set, this defaults to &#x60;1080p&#x60;.
        /// </summary>
        /// <value>Max resolution tier can be used to control the maximum &#x60;resolution_tier&#x60; your asset is encoded, stored, and streamed at. If not set, this defaults to &#x60;1080p&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MaxResolutionTierEnum
        {
            /// <summary>
            /// Enum _1080p for value: 1080p
            /// </summary>
            [EnumMember(Value = "1080p")]
            _1080p = 1,

            /// <summary>
            /// Enum _1440p for value: 1440p
            /// </summary>
            [EnumMember(Value = "1440p")]
            _1440p = 2,

            /// <summary>
            /// Enum _2160p for value: 2160p
            /// </summary>
            [EnumMember(Value = "2160p")]
            _2160p = 3

        }


        /// <summary>
        /// Max resolution tier can be used to control the maximum &#x60;resolution_tier&#x60; your asset is encoded, stored, and streamed at. If not set, this defaults to &#x60;1080p&#x60;.
        /// </summary>
        /// <value>Max resolution tier can be used to control the maximum &#x60;resolution_tier&#x60; your asset is encoded, stored, and streamed at. If not set, this defaults to &#x60;1080p&#x60;.</value>
        [DataMember(Name = "max_resolution_tier", EmitDefaultValue = false)]
        public MaxResolutionTierEnum? MaxResolutionTier { get; set; }
        /// <summary>
        /// The encoding tier informs the cost, quality, and available platform features for the asset. By default the &#x60;smart&#x60; encoding tier is used. [See the guide for more details.](https://docs.mux.com/guides/video/use-encoding-tiers)
        /// </summary>
        /// <value>The encoding tier informs the cost, quality, and available platform features for the asset. By default the &#x60;smart&#x60; encoding tier is used. [See the guide for more details.](https://docs.mux.com/guides/video/use-encoding-tiers)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncodingTierEnum
        {
            /// <summary>
            /// Enum Smart for value: smart
            /// </summary>
            [EnumMember(Value = "smart")]
            Smart = 1,

            /// <summary>
            /// Enum Baseline for value: baseline
            /// </summary>
            [EnumMember(Value = "baseline")]
            Baseline = 2

        }


        /// <summary>
        /// The encoding tier informs the cost, quality, and available platform features for the asset. By default the &#x60;smart&#x60; encoding tier is used. [See the guide for more details.](https://docs.mux.com/guides/video/use-encoding-tiers)
        /// </summary>
        /// <value>The encoding tier informs the cost, quality, and available platform features for the asset. By default the &#x60;smart&#x60; encoding tier is used. [See the guide for more details.](https://docs.mux.com/guides/video/use-encoding-tiers)</value>
        [DataMember(Name = "encoding_tier", EmitDefaultValue = false)]
        public EncodingTierEnum? EncodingTier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        /// <param name="input">An array of objects that each describe an input file to be used to create the asset. As a shortcut, input can also be a string URL for a file when only one input file is used. See &#x60;input[].url&#x60; for requirements..</param>
        /// <param name="playbackPolicy">An array of playback policy names that you want applied to this asset and available through &#x60;playback_ids&#x60;. Options include: &#x60;\&quot;public\&quot;&#x60; (anyone with the playback URL can stream the asset). And &#x60;\&quot;signed\&quot;&#x60; (an additional access token is required to play the asset). If no playback_policy is set, the asset will have no playback IDs and will therefore not be playable. For simplicity, a single string name can be used in place of the array in the case of only one playback policy..</param>
        /// <param name="perTitleEncode">perTitleEncode.</param>
        /// <param name="passthrough">Arbitrary user-supplied metadata that will be included in the asset details and related webhooks. Can be used to store your own ID for a video along with the asset. **Max: 255 characters**..</param>
        /// <param name="mp4Support">Specify what level (if any) of support for mp4 playback. In most cases you should use our default HLS-based streaming playback ({playback_id}.m3u8) which can automatically adjust to viewers&#39; connection speeds, but an mp4 can be useful for some legacy devices or downloading for offline playback. See the [Download your videos guide](/guides/video/download-your-videos) for more information..</param>
        /// <param name="normalizeAudio">Normalize the audio track loudness level. This parameter is only applicable to on-demand (not live) assets. (default to false).</param>
        /// <param name="masterAccess">Specify what level (if any) of support for master access. Master access can be enabled temporarily for your asset to be downloaded. See the [Download your videos guide](/guides/video/download-your-videos) for more information..</param>
        /// <param name="test">Marks the asset as a test asset when the value is set to true. A Test asset can help evaluate the Mux Video APIs without incurring any cost. There is no limit on number of test assets created. Test asset are watermarked with the Mux logo, limited to 10 seconds, deleted after 24 hrs..</param>
        /// <param name="maxResolutionTier">Max resolution tier can be used to control the maximum &#x60;resolution_tier&#x60; your asset is encoded, stored, and streamed at. If not set, this defaults to &#x60;1080p&#x60;..</param>
        /// <param name="encodingTier">The encoding tier informs the cost, quality, and available platform features for the asset. By default the &#x60;smart&#x60; encoding tier is used. [See the guide for more details.](https://docs.mux.com/guides/video/use-encoding-tiers).</param>
        public CreateAssetRequest(List<InputSettings> input = default(List<InputSettings>), List<PlaybackPolicy> playbackPolicy = default(List<PlaybackPolicy>), bool perTitleEncode = default(bool), string passthrough = default(string), Mp4SupportEnum? mp4Support = default(Mp4SupportEnum?), bool normalizeAudio = false, MasterAccessEnum? masterAccess = default(MasterAccessEnum?), bool test = default(bool), MaxResolutionTierEnum? maxResolutionTier = default(MaxResolutionTierEnum?), EncodingTierEnum? encodingTier = default(EncodingTierEnum?))
        {
            this.Input = input;
            this.PlaybackPolicy = playbackPolicy;
            this.PerTitleEncode = perTitleEncode;
            this.Passthrough = passthrough;
            this.Mp4Support = mp4Support;
            this.NormalizeAudio = normalizeAudio;
            this.MasterAccess = masterAccess;
            this.Test = test;
            this.MaxResolutionTier = maxResolutionTier;
            this.EncodingTier = encodingTier;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// An array of objects that each describe an input file to be used to create the asset. As a shortcut, input can also be a string URL for a file when only one input file is used. See &#x60;input[].url&#x60; for requirements.
        /// </summary>
        /// <value>An array of objects that each describe an input file to be used to create the asset. As a shortcut, input can also be a string URL for a file when only one input file is used. See &#x60;input[].url&#x60; for requirements.</value>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public List<InputSettings> Input { get; set; }

        /// <summary>
        /// An array of playback policy names that you want applied to this asset and available through &#x60;playback_ids&#x60;. Options include: &#x60;\&quot;public\&quot;&#x60; (anyone with the playback URL can stream the asset). And &#x60;\&quot;signed\&quot;&#x60; (an additional access token is required to play the asset). If no playback_policy is set, the asset will have no playback IDs and will therefore not be playable. For simplicity, a single string name can be used in place of the array in the case of only one playback policy.
        /// </summary>
        /// <value>An array of playback policy names that you want applied to this asset and available through &#x60;playback_ids&#x60;. Options include: &#x60;\&quot;public\&quot;&#x60; (anyone with the playback URL can stream the asset). And &#x60;\&quot;signed\&quot;&#x60; (an additional access token is required to play the asset). If no playback_policy is set, the asset will have no playback IDs and will therefore not be playable. For simplicity, a single string name can be used in place of the array in the case of only one playback policy.</value>
        [DataMember(Name = "playback_policy", EmitDefaultValue = false)]
        public List<PlaybackPolicy> PlaybackPolicy { get; set; }

        /// <summary>
        /// Gets or Sets PerTitleEncode
        /// </summary>
        [DataMember(Name = "per_title_encode", EmitDefaultValue = true)]
        [Obsolete]
        public bool PerTitleEncode { get; set; }

        /// <summary>
        /// Arbitrary user-supplied metadata that will be included in the asset details and related webhooks. Can be used to store your own ID for a video along with the asset. **Max: 255 characters**.
        /// </summary>
        /// <value>Arbitrary user-supplied metadata that will be included in the asset details and related webhooks. Can be used to store your own ID for a video along with the asset. **Max: 255 characters**.</value>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

        /// <summary>
        /// Normalize the audio track loudness level. This parameter is only applicable to on-demand (not live) assets.
        /// </summary>
        /// <value>Normalize the audio track loudness level. This parameter is only applicable to on-demand (not live) assets.</value>
        [DataMember(Name = "normalize_audio", EmitDefaultValue = true)]
        public bool NormalizeAudio { get; set; }

        /// <summary>
        /// Marks the asset as a test asset when the value is set to true. A Test asset can help evaluate the Mux Video APIs without incurring any cost. There is no limit on number of test assets created. Test asset are watermarked with the Mux logo, limited to 10 seconds, deleted after 24 hrs.
        /// </summary>
        /// <value>Marks the asset as a test asset when the value is set to true. A Test asset can help evaluate the Mux Video APIs without incurring any cost. There is no limit on number of test assets created. Test asset are watermarked with the Mux logo, limited to 10 seconds, deleted after 24 hrs.</value>
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
            sb.Append("class CreateAssetRequest {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  PlaybackPolicy: ").Append(PlaybackPolicy).Append("\n");
            sb.Append("  PerTitleEncode: ").Append(PerTitleEncode).Append("\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  Mp4Support: ").Append(Mp4Support).Append("\n");
            sb.Append("  NormalizeAudio: ").Append(NormalizeAudio).Append("\n");
            sb.Append("  MasterAccess: ").Append(MasterAccess).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  MaxResolutionTier: ").Append(MaxResolutionTier).Append("\n");
            sb.Append("  EncodingTier: ").Append(EncodingTier).Append("\n");
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
            return this.Equals(input as CreateAssetRequest);
        }

        /// <summary>
        /// Returns true if CreateAssetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAssetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAssetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Input == input.Input ||
                    this.Input != null &&
                    input.Input != null &&
                    this.Input.SequenceEqual(input.Input)
                ) && 
                (
                    this.PlaybackPolicy == input.PlaybackPolicy ||
                    this.PlaybackPolicy != null &&
                    input.PlaybackPolicy != null &&
                    this.PlaybackPolicy.SequenceEqual(input.PlaybackPolicy)
                ) && 
                (
                    this.PerTitleEncode == input.PerTitleEncode ||
                    this.PerTitleEncode.Equals(input.PerTitleEncode)
                ) && 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
                ) && 
                (
                    this.Mp4Support == input.Mp4Support ||
                    this.Mp4Support.Equals(input.Mp4Support)
                ) && 
                (
                    this.NormalizeAudio == input.NormalizeAudio ||
                    this.NormalizeAudio.Equals(input.NormalizeAudio)
                ) && 
                (
                    this.MasterAccess == input.MasterAccess ||
                    this.MasterAccess.Equals(input.MasterAccess)
                ) && 
                (
                    this.Test == input.Test ||
                    this.Test.Equals(input.Test)
                ) && 
                (
                    this.MaxResolutionTier == input.MaxResolutionTier ||
                    this.MaxResolutionTier.Equals(input.MaxResolutionTier)
                ) && 
                (
                    this.EncodingTier == input.EncodingTier ||
                    this.EncodingTier.Equals(input.EncodingTier)
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
                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
                }
                if (this.PlaybackPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PlaybackPolicy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PerTitleEncode.GetHashCode();
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Mp4Support.GetHashCode();
                hashCode = (hashCode * 59) + this.NormalizeAudio.GetHashCode();
                hashCode = (hashCode * 59) + this.MasterAccess.GetHashCode();
                hashCode = (hashCode * 59) + this.Test.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxResolutionTier.GetHashCode();
                hashCode = (hashCode * 59) + this.EncodingTier.GetHashCode();
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
