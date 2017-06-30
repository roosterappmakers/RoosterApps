using System;
using Android;
using Android.App;
using Android.OS;
using Android.Content;
using DotCs.Droid;
using System.Collections.Generic;
using Java.IO;
using System.Linq;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidStore))]
namespace DotCs.Droid
{
	public class AndroidStore : ISaveLocal
	{
		public AndroidStore()
		{

		}

		public List<string> GetAllFiles()
		{
			try
			{

				var path = Application.Context.FilesDir.AbsolutePath;

				string[] files = Application.Context.FileList();

				List<string> filenames = new List<string>();
				foreach (var item in files)
				{
					if (item.Contains("DotCS"))
					{
						filenames.Add(System.IO.Path.GetFileName(item));
					}

					//contents = System.IO.File.ReadAllLines(item);
				}
				return filenames;
			}
			catch (Exception ex)
			{
				return null;
			}

		}

		public string Getcontents(string filename)
		{
			try
			{
				var path = Application.Context.FilesDir.AbsolutePath;
				string filepath = System.IO.Path.Combine(path, filename);
				return string.Join(System.Environment.NewLine, System.IO.File.ReadAllLines(filepath));
			}
			catch (Exception ex)
			{
				return null;
			}
		}

        public void DeleteFile(string filename)
        {
            try
            {
				var path = Application.Context.FilesDir.AbsolutePath;
				string filepath = System.IO.Path.Combine(path, filename);
                System.IO.File.Delete(filepath);

                //return filepath;
            }
            catch(Exception ex)
            {
                
            }
        }

        public string SaveLocal(string FileName, List<string> content)
		{
			try
			{
				var path = Application.Context.FilesDir.AbsolutePath;

				if (!System.IO.Directory.Exists(path))
				{
					System.IO.Directory.CreateDirectory(path);
				}

				string filepath = System.IO.Path.Combine(path, FileName);
				File file = new File(Application.Context.FilesDir, filepath);

				file.Mkdirs();
				//string[] files = Application.Context.FileList();
				//string[] contents = new string[] { };
				//foreach (var item in files)
				//{
				//	contents = System.IO.File.ReadAllLines(item);
				//}
				System.IO.File.WriteAllLines(filepath, content);
				return filepath;

			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
