// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The description of an X509 CA Certificate. </summary>
    public partial class DeviceProvisioningServicesCertificateProperties
    {
        /// <summary> Initializes a new instance of DeviceProvisioningServicesCertificateProperties. </summary>
        public DeviceProvisioningServicesCertificateProperties()
        {
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesCertificateProperties. </summary>
        /// <param name="subject"> The certificate's subject name. </param>
        /// <param name="expireOn"> The certificate's expiration date and time. </param>
        /// <param name="thumbprint"> The certificate's thumbprint. </param>
        /// <param name="isVerified"> Determines whether certificate has been verified. </param>
        /// <param name="certificate"> base-64 representation of X509 certificate .cer file or just .pem file content. </param>
        /// <param name="createdOn"> The certificate's creation date and time. </param>
        /// <param name="updatedOn"> The certificate's last update date and time. </param>
        internal DeviceProvisioningServicesCertificateProperties(string subject, DateTimeOffset? expireOn, BinaryData thumbprint, bool? isVerified, BinaryData certificate, DateTimeOffset? createdOn, DateTimeOffset? updatedOn)
        {
            Subject = subject;
            ExpireOn = expireOn;
            Thumbprint = thumbprint;
            IsVerified = isVerified;
            Certificate = certificate;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
        }

        /// <summary> The certificate's subject name. </summary>
        public string Subject { get; }
        /// <summary> The certificate's expiration date and time. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary>
        /// The certificate's thumbprint.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Thumbprint { get; }
        /// <summary> Determines whether certificate has been verified. </summary>
        public bool? IsVerified { get; set; }
        /// <summary>
        /// base-64 representation of X509 certificate .cer file or just .pem file content.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Certificate { get; set; }
        /// <summary> The certificate's creation date and time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The certificate's last update date and time. </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}
