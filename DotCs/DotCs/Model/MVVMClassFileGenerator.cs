using System;
using System.Collections.Generic;

namespace DotCs.Model
{
    public class MVVMClassFileGenerator
    {
        private string _classname;
        private string[] _properties = new string[]{};
        private string[] _methods= new string[] { };
        private string[] _events= new string[] { };

        public MVVMClassFileGenerator(string classname, string[] properties, string[] methods,
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
                fullclass.Add("using System.Collections.Generic;");
                fullclass.Add("using System.Linq;\n");

                fullclass.Add("namespace " + _classname + "\n{\n");
                fullclass.Add("public class " + _classname + ":BaseViewModel\n{\n");

                fullclass.Add("public " + _classname + "()\n{\n}\n");

                if (_properties.Length > 0 && _properties != null)
                {
                    foreach (var item in _properties)
                    {
                        fullclass.Add("private string _" + item + ";\n" +
                                      "public string " + item + "{ get\n{\n return" + "_" + item +
                                      ";\n}\n" +
                                      " set\n{\n" + "_" + item + "= value;\n" +
                                      "RaisePropertyChanged(" + (char)34 + item + (char)34 + ");\n}\n");
                    }
                }
                if (_events.Length > 0 && _events != null)
                {
                    foreach (var item in _events)
                    {
                        fullclass.Add("public event eventhandler " + item + "= delegate{};\n");
                    }
                }
                if (_methods.Length > 0 && _methods != null)
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
