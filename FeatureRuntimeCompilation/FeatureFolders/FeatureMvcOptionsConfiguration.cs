﻿using ASPNETCoreRuntimeCompilation.FeatureRuntimeCompilation.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ASPNETCoreRuntimeCompilation.FeatureFolders
{
    public class FeatureMvcOptionsConfiguration : IConfigureOptions<MvcOptions>
    {
        private readonly FeatureRuntimeCompilationOptions _options;
        private readonly ILogger<FeatureControllerModelConvention> _logger;

        public FeatureMvcOptionsConfiguration(FeatureRuntimeCompilationOptions options, ILogger<FeatureControllerModelConvention> logger)
        {
            _options = options;
            _logger = logger;
        }

        public void Configure(MvcOptions options)
        {
            options.Conventions.Add(new FeatureControllerModelConvention(_options, _logger));
        }
    }
}