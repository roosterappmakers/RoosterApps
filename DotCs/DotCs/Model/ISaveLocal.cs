using System;
using System.Collections.Generic;

namespace DotCs
{
	public interface ISaveLocal
	{
		string SaveLocal(string FileName, List<string> Content);
		List<string> GetAllFiles();
		string Getcontents(string filename);
        void DeleteFile(string filename);
	}
}
