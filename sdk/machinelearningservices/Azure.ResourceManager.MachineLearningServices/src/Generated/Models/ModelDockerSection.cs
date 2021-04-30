// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The ModelDockerSection. </summary>
    public partial class ModelDockerSection
    {
        /// <summary> Initializes a new instance of ModelDockerSection. </summary>
        public ModelDockerSection()
        {
        }

        /// <summary> Base image used for Docker-based runs. Mutually exclusive with BaseDockerfile. </summary>
        public string BaseImage { get; set; }
        /// <summary> Base Dockerfile used for Docker-based runs. Mutually exclusive with BaseImage. </summary>
        public string BaseDockerfile { get; set; }
        /// <summary> Image registry that contains the base image. </summary>
        public ModelDockerSectionBaseImageRegistry BaseImageRegistry { get; set; }
    }
}
