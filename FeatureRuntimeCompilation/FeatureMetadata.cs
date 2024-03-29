﻿namespace FeatureRuntimeCompilation
{
    internal class FeatureMetadata
    {
        public FeatureMetadata(string featureName, string controllerTypeName, string featurePath)
        {
            Name = featureName;
            ControllerTypeName = controllerTypeName;
            FeaturePath = featurePath;
        }

        public string Name { get; }
        public string ControllerTypeName { get; }
        public string FeaturePath { get; }
    }
}