// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>Represents the correlation filter expression.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class CorrelationFilter :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilter,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterInternal
    {

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        /// <summary>Content type of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>Backing field for <see cref="CorrelationId" /> property.</summary>
        private string _correlationId;

        /// <summary>Identifier of the correlation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string CorrelationId { get => this._correlationId; set => this._correlationId = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        /// <summary>Application specific label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>Backing field for <see cref="MessageId" /> property.</summary>
        private string _messageId;

        /// <summary>Identifier of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string MessageId { get => this._messageId; set => this._messageId = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties _property;

        /// <summary>dictionary object for custom filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.CorrelationFilterProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="ReplyTo" /> property.</summary>
        private string _replyTo;

        /// <summary>Address of the queue to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string ReplyTo { get => this._replyTo; set => this._replyTo = value; }

        /// <summary>Backing field for <see cref="ReplyToSessionId" /> property.</summary>
        private string _replyToSessionId;

        /// <summary>Session identifier to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string ReplyToSessionId { get => this._replyToSessionId; set => this._replyToSessionId = value; }

        /// <summary>Backing field for <see cref="RequiresPreprocessing" /> property.</summary>
        private bool? _requiresPreprocessing;

        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public bool? RequiresPreprocessing { get => this._requiresPreprocessing; set => this._requiresPreprocessing = value; }

        /// <summary>Backing field for <see cref="SessionId" /> property.</summary>
        private string _sessionId;

        /// <summary>Session identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string SessionId { get => this._sessionId; set => this._sessionId = value; }

        /// <summary>Backing field for <see cref="To" /> property.</summary>
        private string _to;

        /// <summary>Address to send to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string To { get => this._to; set => this._to = value; }

        /// <summary>Creates an new <see cref="CorrelationFilter" /> instance.</summary>
        public CorrelationFilter()
        {

        }
    }
    /// Represents the correlation filter expression.
    public partial interface ICorrelationFilter :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>Content type of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Content type of the message.",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        string ContentType { get; set; }
        /// <summary>Identifier of the correlation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the correlation.",
        SerializedName = @"correlationId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationId { get; set; }
        /// <summary>Application specific label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application specific label.",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }
        /// <summary>Identifier of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the message.",
        SerializedName = @"messageId",
        PossibleTypes = new [] { typeof(string) })]
        string MessageId { get; set; }
        /// <summary>dictionary object for custom filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"dictionary object for custom filters",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties Property { get; set; }
        /// <summary>Address of the queue to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address of the queue to reply to.",
        SerializedName = @"replyTo",
        PossibleTypes = new [] { typeof(string) })]
        string ReplyTo { get; set; }
        /// <summary>Session identifier to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Session identifier to reply to.",
        SerializedName = @"replyToSessionId",
        PossibleTypes = new [] { typeof(string) })]
        string ReplyToSessionId { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value that indicates whether the rule action requires preprocessing.",
        SerializedName = @"requiresPreprocessing",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RequiresPreprocessing { get; set; }
        /// <summary>Session identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Session identifier.",
        SerializedName = @"sessionId",
        PossibleTypes = new [] { typeof(string) })]
        string SessionId { get; set; }
        /// <summary>Address to send to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address to send to.",
        SerializedName = @"to",
        PossibleTypes = new [] { typeof(string) })]
        string To { get; set; }

    }
    /// Represents the correlation filter expression.
    internal partial interface ICorrelationFilterInternal

    {
        /// <summary>Content type of the message.</summary>
        string ContentType { get; set; }
        /// <summary>Identifier of the correlation.</summary>
        string CorrelationId { get; set; }
        /// <summary>Application specific label.</summary>
        string Label { get; set; }
        /// <summary>Identifier of the message.</summary>
        string MessageId { get; set; }
        /// <summary>dictionary object for custom filters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties Property { get; set; }
        /// <summary>Address of the queue to reply to.</summary>
        string ReplyTo { get; set; }
        /// <summary>Session identifier to reply to.</summary>
        string ReplyToSessionId { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        bool? RequiresPreprocessing { get; set; }
        /// <summary>Session identifier.</summary>
        string SessionId { get; set; }
        /// <summary>Address to send to.</summary>
        string To { get; set; }

    }
}