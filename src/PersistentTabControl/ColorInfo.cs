// Created by Eugene Sadovoi
// Downloaded from http://www.codeproject.com/Articles/362940/Persist-the-Visual-Tree-when-switching-tabs-in-the
using System.Windows.Media;

namespace PersistentTabControl
{
    public class ColorInfo
    {
        #region Properties

        public string Key { get; set; }
        public Color Value { get; set; }

        #endregion

        #region Methosd

        public override string ToString()
        {
            return Key;
        }

        #endregion
    }
}
