using System;
using System.Collections.Generic;

namespace DotCs.Model
{
    public class InterfaceFileGenerator
    {
		private string _classname;
		private string[] _properties= new string[] { };
		private string[] _methods= new string[] { };
		private string[] _events= new string[] { };

		public InterfaceFileGenerator(string classname, string[] properties, string[] methods,
									   string[] events)
		{
			_classname = classname;
			_properties = properties;
			_methods = methods;
			_events = events;
		}
		public string GenerateClass()
		{
			try
			{

				if (_classname == null)
					_classname = "Root";
				List<string> fullclass = new List<string>();

				fullclass.Add("using System;");
				fullclass.Add("using System.Collections.Generic;\n");

				
				fullclass.Add("public Interface I" + _classname + "\n{\n");
				if (_properties.Length > 0 && _properties != null)
				{
					foreach (var item in _properties)
					{
						fullclass.Add("string " + item + "{ get; set; }\n");
					}
				}
				if (_events.Length > 0 && _events != null)
				{
					foreach (var item in _events)
					{
						fullclass.Add("event eventhandler " + item + ";\n");
					}
				}
				if (_methods.Length > 0 && _methods != null)
				{
					foreach (var item in _methods)
					{
                        fullclass.Add("void " + item + "();");
					}
				}

				fullclass.Add("}\n");
				return string.Join(System.Environment.NewLine, fullclass);
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
