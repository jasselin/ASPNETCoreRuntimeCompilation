﻿using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Linq;

namespace ASPNETCoreRuntimeCompilation.FeatureFolders
{
    public class FeatureControllerModelConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            SetControllerProperties(controller);
            SetControllerRoute(controller);
        }
        
        private void SetControllerProperties(ControllerModel controller)
        {
            var controllerType = controller.ControllerType;
            var featureNamespace = string.Concat(controllerType.Assembly.GetName().Name, ".Features.");

            // Not a feature controller
            if (!controllerType.FullName.StartsWith(featureNamespace))
                return;

            // Gets the controller properies from the feature class name
            // ASPNETCoreRuntimeCompilation.Features.Level1.Level2.FeatureA => { level1 = "Level1", level2 = "Level2" }
            var tokens = controllerType.FullName.Substring(featureNamespace.Length).Split('.');
            for (var i = 0; i < tokens.Length - 1; i++)
                controller.Properties.Add($"level{tokens.Length - i - 1}", tokens[i]);
        }

        private void SetControllerRoute(ControllerModel controller)
        {
            // Sets the controller route using a convention via RouteAttribute
            // ASPNETCoreRuntimeCompilation.Features.Level2.Level1.FeatureA => Route("Level2/Level1/FeatureA/{action=Index}")
            foreach (var selector in controller.Selectors.Where(x => x.AttributeRouteModel == null))
            {
                var controllerPath = string.Join('/', controller.Properties.Values);
                var attrRouteModel = new AttributeRouteModel
                {
                    Template = string.Concat(controllerPath, "/{action=Index}")
                };
                selector.AttributeRouteModel = attrRouteModel;
            }
        }
    }
}