﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Header
    {

        private string _classification;
        private string _date;
        private string _id;

        public Header(string classification, string date, string id)
        {
            _classification = classification;
            _date = date;
            _id = id;
        }
    }
}
