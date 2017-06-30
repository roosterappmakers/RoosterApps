using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DotCs
{
    public class ResultViewModel:BaseViewModel
	{
        public ICommand DeleteCommand { get; set; }

        private static ResultViewModel _instance;
        public static ResultViewModel instance
        {
            get{
                if (_instance == null)
                    _instance = new ResultViewModel();
                return _instance;
            }
        }
		public ResultViewModel()
		{
            _instance = this;
            LoadList();

		}

        internal void LoadList()
        {
            try
            {
                showitemlist.Clear();
				List<string> listoffiles = DependencyService.Get<ISaveLocal>().GetAllFiles();

				foreach (var item in listoffiles)
				{
					showitemlist.Add(new ShowItem1()
					{
						thetext = item,
					});
				}
            }
            catch( Exception ex)
            {}

        }

        //private void FileDeleteOperation(object obj)
        //{
        //    try
        //    {
        //        ShowItem si = obj as ShowItem;

        //    }
        //    catch( Exception ex)
        //    {

        //    }

        //}

        private ObservableCollection<ShowItem1> _showitemlist = new ObservableCollection<ShowItem1>();
        public ObservableCollection<ShowItem1> showitemlist
        {
            get{
                return _showitemlist;
            }
            set{
                _showitemlist = value;
                RaisePropertyChanged("showitemlist");
            }
        }

	}


	public class ShowItem1
	{
		public string thetext { get; set; }

	}
}
