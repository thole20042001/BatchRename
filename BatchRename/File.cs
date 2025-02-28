﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchRename
{
    public class File : INotifyPropertyChanged
    {
        private string _filename;
        private string _newfilename;
        private string _path;
        private string _status;

        public string Filename
        {
            get => _filename; set
            {
                _filename = value;
                NotifyChanged("Filename");
            }
        }

        public string Newfilename
        {
            get => _newfilename;
            set
            {
                _newfilename = value;
                NotifyChanged("Newfilename");
            }
        }

        public string Path
        {
            get => _path;
            set
            {
                _path = value;
                NotifyChanged("Path");
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                NotifyChanged("Status");
            }
        }

        private void NotifyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(v));
            }
        }

        public File Clone()
        {
            return new File()
            {
                Filename = this._filename,
                Newfilename = this._newfilename,
                Path = this._path,
                Status = this._status
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
