// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownConfigurationGroupValuePropertiesFormat : IUtf8JsonSerializable, IJsonModel<ConfigurationGroupValuePropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationGroupValuePropertiesFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfigurationGroupValuePropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ConfigurationGroupValuePropertiesFormat IJsonModel<ConfigurationGroupValuePropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
        }

        internal static UnknownConfigurationGroupValuePropertiesFormat DeserializeUnknownConfigurationGroupValuePropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            string publisherName = default;
            PublisherScope? publisherScope = default;
            string configurationGroupSchemaName = default;
            string configurationGroupSchemaOfferingLocation = default;
            DeploymentResourceIdReference configurationGroupSchemaResourceReference = default;
            ConfigurationGroupValueConfigurationType configurationType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaName"u8))
                {
                    configurationGroupSchemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaOfferingLocation"u8))
                {
                    configurationGroupSchemaOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationGroupSchemaResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationGroupValueConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownConfigurationGroupValuePropertiesFormat(
                provisioningState,
                publisherName,
                publisherScope,
                configurationGroupSchemaName,
                configurationGroupSchemaOfferingLocation,
                configurationGroupSchemaResourceReference,
                configurationType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigurationGroupValuePropertiesFormat IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationGroupValuePropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
