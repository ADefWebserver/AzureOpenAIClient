﻿// Copyright (c) 2022 Jason Shave. All rights reserved.
// Licensed under the MIT License.

namespace AzureOpenAIClient.Http
{
    public class OpenAIClientConfiguration
    {
        public string BaseUri { get; set; }
        public string ApiKey { get; set; }
        public string DeploymentName { get; set; }
        public string ApiVersion { get; set; } = "2022-12-01";
    }
}