﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Text;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Workspace
{
    /// <summary>
    /// Handle a star number which consists of a number with optional asterisk at the end.
    /// </summary>
    public class StarNumber
    {
        #region Internal Fields
        private string _value;

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the StarNumber class.
        /// </summary>
        public StarNumber()
        {
            _value = "*";
            UsingStar = true;
            FixedSize = 0;
            StarSize = 1;
        }

        /// <summary>
        /// Initialize a new instance of the StarNumber class.
        /// </summary>
        /// <param name="value">Initial value to process.</param>
        public StarNumber(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets a string representing the value of the instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the star notation and breaks it apart.
        /// </summary>
        public string Value
        {
            get => _value;

            set
            {
                // Validate the incoming value
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot be assigned a null value.");
                }

                // If it ends with an asterisk...
                if (value.EndsWith("*"))
                {
                    // If there is only an asterisk in the string
                    if (value.Length == 1)
                    {
                        StarSize = 1;
                    }
                    else
                    {
                        // The star number can have decimal places
                        StarSize = double.Parse(value.Substring(0, value.Length - 1));
                    }

                    UsingStar = true;
                }
                else
                {
                    // No asterisk, so it should be just be an integer number
                    FixedSize = int.Parse(value);
                    UsingStar = false;
                }

                _value = value;
            }
        }

        /// <summary>
        /// Gets a value indicating if stars are being specified.
        /// </summary>
        public bool UsingStar { get; private set; }

        /// <summary>
        /// Gets the fixed size value.
        /// </summary>
        public int FixedSize { get; private set; }

        /// <summary>
        /// Gets the star size value.
        /// </summary>
        public double StarSize { get; private set; }

        #endregion

        #region Internal
        internal string PersistString
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(UsingStar ? "T," : "F,");
                builder.Append(FixedSize.ToString() + ",");
                builder.Append(CommonHelper.DoubleToString(StarSize));
                return builder.ToString();
            }

            set
            {
                string[] parts = value.Split(',');
                UsingStar = (parts[0] == "T");
                FixedSize = int.Parse(parts[1]);
                StarSize = CommonHelper.StringToDouble(parts[2]);
            }
        }
        #endregion
    }
}
