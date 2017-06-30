using System;
using System.Collections.Generic;
using System.IO;
using Xamasoft.JsonClassGenerator;

namespace DotCs.Model
{
    
    public interface ICreator
    {
        string SimpleClassCreator(string classname, string[] MethodNames, string[] PropertiesNames, string[] EventNames);
        string AbstractClassCreator(string classname, string[] MethodNames, string[] PropertiesNames, string[] EventNames);
        string InterfaceClassCreator(string classname, string[] MethodNames, string[] PropertiesNames, string[] EventNames);
        string MVVMClassCreator(string classname, string[] MethodNames, string[] PropertiesNames, string[] EventNames);
        string JsonClassCreator(string Response);
    }



    public class DesignPatternClasses : ICreator
    {
        public DesignPatternClasses()
        {
        }

        public string AbstractClassCreator(string classname, string[] MethodNames, string[] PropertiesNames, string[] EventNames)
        {
			try
			{

				if (classname == null)
					classname = "Root";
				List<string> fullclass = new List<string>();

				fullclass.Add("using System;");
				fullclass.Add("using System.Collections.Generic;\n");


				fullclass.Add("public abstract class " + classname + "\n{\n");
				if (PropertiesNames.Length > 0 && PropertiesNames != null)
				{
					foreach (var item in PropertiesNames)
					{
						fullclass.Add("public abstract string " + item + "{ get; set; }\n");
					}
				}
				if (EventNames.Length > 0 && EventNames != null)
				{
					foreach (var item in EventNames)
					{
						fullclass.Add("public abstract event eventhandler " + item + ";\n");
					}
				}
				if (MethodNames.Length > 0 && MethodNames != null)
				{
					foreach (var item in MethodNames)
					{
						fullclass.Add("public abstract void " + item + "();");
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

        public string InterfaceClassCreator(string classname, string[] MethodNames, 
                                            string[] PropertiesNames, string[] EventNames)
        {
			try
			{

				if (classname == null)
					classname = "Root";
				List<string> fullclass = new List<string>();

				fullclass.Add("using System;");
				fullclass.Add("using System.Collections.Generic;\n");


				fullclass.Add("public Interface I" + classname + "\n{\n");
				if (PropertiesNames.Length > 0 && PropertiesNames != null)
				{
					foreach (var item in PropertiesNames)
					{
						fullclass.Add("string " + item + "{ get; set; }\n");
					}
				}
				if (EventNames.Length > 0 && EventNames != null)
				{
					foreach (var item in EventNames)
					{
						fullclass.Add("event eventhandler " + item + ";\n");
					}
				}
				if (MethodNames.Length > 0 && MethodNames != null)
				{
					foreach (var item in MethodNames)
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

        public string JsonClassCreator(string Response)
        {
			string result = null;
			var gen = new JsonClassGenerator();
            gen.Example = Response;
			gen.InternalVisibility = false;

			gen.CodeWriter = null;
			gen.ExplicitDeserialization = false;
			gen.Namespace = "DotCs";
			gen.NoHelperClass = false;
			gen.SecondaryNamespace = null;
			gen.TargetFolder = null;
			gen.UseProperties = true;
			gen.MainClass = "DotCs";
			gen.UsePascalCase = true;
			gen.UseNestedClasses = false;
			gen.ApplyObfuscationAttributes = false;
			gen.SingleFile = true;
			gen.ExamplesInDocumentation = false;


            try
            {
                if (gen != null)
                {
                    using (var sw = new StringWriter())
                    {
                        gen.OutputStream = sw;
                        gen.GenerateClasses();
                        sw.Flush();
                        result = sw.ToString();
                    }
                }
                return result;
            }
            catch (Exception ex)
            { return null; }
        }

        public string MVVMClassCreator(string classname, string[] MethodNames, string[] PropertiesNames, string[] EventNames)
        {
			try
            {
				if (classname == null)
					classname = "Root";
				List<string> fullclass = new List<string>();

				fullclass.Add("using System;");
				fullclass.Add("using System.Collections.Generic;");
				fullclass.Add("using System.Linq;\n");

				fullclass.Add("namespace " + classname + "\n{\n");
				fullclass.Add("public class " + classname + ":BaseViewModel\n{\n");

				fullclass.Add("public " + classname + "()\n{\n}\n");

				if (PropertiesNames.Length > 0 && PropertiesNames != null)
				{
					foreach (var item in PropertiesNames)
					{
						fullclass.Add("private string _" + item + ";\n" +
									  "public string " + item + "{ get\n{\n return" + "_" + item +
									  ";\n}\n" +
									  " set\n{\n" + "_" + item + "= value;\n" +
									  "RaisePropertyChanged(" + (char)34 + item + (char)34 + ");\n}\n");
					}
				}
				if (EventNames.Length > 0 && EventNames != null)
				{
					foreach (var item in EventNames)
					{
						fullclass.Add("public event eventhandler " + item + "= delegate{};\n");
					}
				}
				if (MethodNames.Length > 0 && MethodNames != null)
				{
					foreach (var item in MethodNames)
					{
						fullclass.Add("public void " + item + "()\n{\n" + "\ttry\n\t\t{\n\t\t}\n\tcatch (Exception ex)\n\t\t{\n\t\t}\n}\n");
					}
				}

				fullclass.Add("}\n}\n");
				return string.Join(System.Environment.NewLine, fullclass);
			}
			catch (Exception ex)
			{
				return null;
			}
        }

        public string SimpleClassCreator(string _classname, string[] _methods, string[] _properties, string[] _events)
        {
			try
            {
				if (_classname == null)
					_classname = "Root";
				List<string> fullclass = new List<string>();

				fullclass.Add("using System;");
				fullclass.Add("using System.Collections.Generic;");
				fullclass.Add("using System.Linq;\n");

				fullclass.Add("namespace " + _classname + "\n{\n");
				fullclass.Add("public class " + _classname + "\n{\n");

				fullclass.Add("public " + _classname + "()\n{\n}\n");

				if (_properties.Length > 0 && _properties != null)
				{
					foreach (var item in _properties)
					{
						fullclass.Add("public string " + item + "{ get; set; }\n");
					}
				}
				if (_events != null && _events.Length > 0)
				{
					foreach (var item in _events)
					{
						fullclass.Add("public event eventhandler " + item + "= delegate{};\n");
					}
				}
				if (_methods != null && _methods.Length > 0)
				{
					foreach (var item in _methods)
					{
						fullclass.Add("public void " + item + "()\n{\n" + "\ttry\n\t\t{\n\t\t}\n\tcatch (Exception ex)\n\t\t{\n\t\t}\n}\n");
					}
				}

				fullclass.Add("}\n}\n");
				return string.Join(System.Environment.NewLine, fullclass);
			}
			catch (Exception ex)
			{
				return null;
			}
        }
    }
}
