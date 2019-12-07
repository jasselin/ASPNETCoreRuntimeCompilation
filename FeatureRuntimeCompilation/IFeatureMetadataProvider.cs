﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace ASPNETCoreRuntimeCompilation.FeatureRuntimeCompilation
{
    public interface IFeatureMetadataProvider
    {
        FeatureMetadata GetMetadataFor(RouteValueDictionary routeValues);
        FeatureMetadata GetMetadataFor(string featurePath);
    }
}