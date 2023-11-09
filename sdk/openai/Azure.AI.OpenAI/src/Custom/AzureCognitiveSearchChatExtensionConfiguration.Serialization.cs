// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AzureCognitiveSearchChatExtensionConfiguration : IUtf8JsonSerializable
    {
        // CUSTOM CODE NOTE: This hides the AzureChatExtensionConfiguration.ToRequestContent method
        //                      with the "override" keyword.

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
