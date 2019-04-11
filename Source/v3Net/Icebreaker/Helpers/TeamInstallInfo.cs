﻿//----------------------------------------------------------------------------------------------
// <copyright file="TeamInstallInfo.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------------------------

namespace Icebreaker.Helpers
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents information about a team to which the Icebreaker app was installed
    /// </summary>
    public class TeamInstallInfo : Document
    {
        /// <summary>
        /// Gets or sets the team id
        /// </summary>
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the tenant id
        /// </summary>
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the service URL
        /// </summary>
        [JsonProperty("serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Team - Id = {this.TeamId}, TenantId = {this.TenantId}, ServiceUrl = {this.ServiceUrl}";
        }
    }
}