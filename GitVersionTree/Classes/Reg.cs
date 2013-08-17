using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GitVersionTree
{
	public static class Reg
	{
        private static string ProductKey = @"HKEY_CURRENT_USER\SOFTWARE\" + Application.ProductName;

        public static string Read(string Name, string Section = "")
		{
            if (!String.IsNullOrEmpty(Section) &&
                !Section.StartsWith(@"\"))
            {
                Section = @"\" + Section;
            }
            return (string)Registry.GetValue(ProductKey + Section, Name, null);
		}	

        public static void Write(string Name, string Value, string Section = "")
		{
            if (!String.IsNullOrEmpty(Section) &&
                !Section.StartsWith(@"\"))
            {
                Section = @"\" + Section;
            }
            Registry.SetValue(ProductKey + Section, Name, Value);
        }

	}
}
