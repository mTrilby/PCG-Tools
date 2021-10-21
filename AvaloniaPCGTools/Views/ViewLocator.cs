using Avalonia.Controls;
using Avalonia.Controls.Templates;
using PCGTools_Avalonia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGTools_Avalonia.Views
{
    internal class ViewLocator : IDataTemplate
    {
        public IControl Build(object param)
        {
            if (param == null) return new TextBlock { Text = "Object not found." };

            var name = param.GetType().FullName?.Split(".").Last() + "Control";
            if (string.IsNullOrEmpty(name)) return new TextBlock { Text = "Object type not found." };
            
            var type = Type.GetType("PCGTools_Avalonia.Views." + name);
            if (type != null) return Activator.CreateInstance(type) as Control ?? new TextBlock { Text = name + " could not be created." };

            return new TextBlock { Text = name + " not found." };
        }

        public bool Match(object data) => data is PcgBaseViewModel;
    }
}
