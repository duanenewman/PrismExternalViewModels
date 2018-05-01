using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace ExternalViewsTest
{
    public static class ViewModelLocator
    {
        public static Type ViewTypeToViewModelTypeResolver(Type viewType)
        {
            var rootViewModelNamespace = "ExternalViewsTest.ViewModels";
            var viewName = viewType.FullName;
            viewName = viewName.Substring(viewName.LastIndexOf('.') + 1);
            var suffix = viewName.EndsWith("View") ? "Model" : "ViewModel";
            var viewModelName = $"{rootViewModelNamespace}.{viewName}{suffix}";

            var assembly = typeof(ViewModelLocator).GetTypeInfo().Assembly;
            var type = assembly.GetType(viewModelName);

            return type;
        }
    }
}
