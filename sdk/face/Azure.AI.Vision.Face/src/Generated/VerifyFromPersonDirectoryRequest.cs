// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The VerifyFromPersonDirectoryRequest. </summary>
    internal partial class VerifyFromPersonDirectoryRequest
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VerifyFromPersonDirectoryRequest"/>. </summary>
        /// <param name="faceId"> The faceId of the face, come from "Detect". </param>
        /// <param name="personId"> Specify a certain person in PersonDirectory Person. </param>
        public VerifyFromPersonDirectoryRequest(Guid faceId, Guid personId)
        {
            FaceId = faceId;
            PersonId = personId;
        }

        /// <summary> Initializes a new instance of <see cref="VerifyFromPersonDirectoryRequest"/>. </summary>
        /// <param name="faceId"> The faceId of the face, come from "Detect". </param>
        /// <param name="personId"> Specify a certain person in PersonDirectory Person. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VerifyFromPersonDirectoryRequest(Guid faceId, Guid personId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FaceId = faceId;
            PersonId = personId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VerifyFromPersonDirectoryRequest"/> for deserialization. </summary>
        internal VerifyFromPersonDirectoryRequest()
        {
        }

        /// <summary> The faceId of the face, come from "Detect". </summary>
        public Guid FaceId { get; }
        /// <summary> Specify a certain person in PersonDirectory Person. </summary>
        public Guid PersonId { get; }
    }
}
