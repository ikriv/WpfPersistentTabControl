// Created by Eugene Sadovoi
// Downloaded from http://www.codeproject.com/Articles/362940/Persist-the-Visual-Tree-when-switching-tabs-in-the
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Reflection;
using System.Collections.ObjectModel;

namespace PersistentTabControl
{
    public class ColorsRepository : Collection<ColorInfo>, IColorsRepository
    {
        public ColorsRepository()
        {
            foreach (PropertyInfo property in typeof(Colors).GetProperties())
                Add(new ColorInfo() { Key = property.Name, Value = (Color)property.GetValue(null, null) });
        }
    }

    public interface IColorsRepository { }
}
