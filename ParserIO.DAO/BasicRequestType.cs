﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParserIO.DAO
{
    public class BasicRequestType
    {
        private  string _userId = string.Empty;
        private string _pinCode = string.Empty;

        [XmlIgnore()]
        public string _ApplicationAutoriseeSeparator = "#!$";

        public string UserId
        {
            get
            {
                return _userId;
            }

            set
            {
                _userId = value;
            }
        }
        public string PinCode
        {
            get
            {
                return _pinCode;
            }

            set
            {
                _pinCode = value;
            }
        }

        [XmlIgnore()]
        public string Caller { get; set; }

        [XmlIgnore()]
        public string Function { get; set; }

        public BasicRequestType()
        {
        }

        public BasicRequestType(string userId, string pinCode)
        {
            UserId = userId;
            PinCode = pinCode;
        }

        //public string GetPassword()
        //{
        //    string result = null;
        //    string[] stringSeparators = new string[] { _ApplicationAutoriseeSeparator };
        //    var splitResult = PinCode.Split(stringSeparators, StringSplitOptions.None);
        //    if (splitResult.Length > 0)
        //    {
        //        result = splitResult[0];
        //    }

        //    return result;
        //}

        //public string GetLicence()
        //{
        //    string result = "PARSER_IO-5e048966-92ed-4c65-aae1-ee744bb12bd0";
            
        //    string[] stringSeparators = new string[] { _ApplicationAutoriseeSeparator };
        //    var splitResult = PinCode.Split(stringSeparators, StringSplitOptions.None);
        //    if (splitResult.Length == 2)
        //    {
        //        result = splitResult[1];
        //    }

        //    return result;
        //}

        public virtual bool Validate()
        {
            if (string.IsNullOrEmpty(UserId))
            {
                throw new ArgumentNullException("UserId");
            }

            if (string.IsNullOrEmpty(PinCode))
            {
                throw new ArgumentNullException("PinCode");
            }

            return true;
        }
    }
}
