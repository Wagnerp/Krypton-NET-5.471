﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2018. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.1.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Storage for the primary header of the header group control.
	/// </summary>
	public class HeaderGroupValuesPrimary : HeaderValuesBase
	{
		#region Static Fields
        private const string _defaultHeading = "Heading";
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the HeaderGroupValuesPrimary class.
		/// </summary>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public HeaderGroupValuesPrimary(NeedPaintHandler needPaint)
            : base(needPaint)
		{
		}
		#endregion

		#region Default Values
		/// <summary>
		/// Gets the default heading value.
		/// </summary>
		/// <returns>String reference.</returns>
		protected override string GetHeadingDefault()
		{
			return _defaultHeading;
		}

		/// <summary>
		/// Gets the default description value.
		/// </summary>
		/// <returns>String reference.</returns>
		protected override string GetDescriptionDefault()
		{
			return string.Empty;
		}
		#endregion

        #region Heading
        /// <summary>
        /// Gets and sets the header text.
        /// </summary>
        [DefaultValue("Heading")]
        public override string Heading
        {
            get => base.Heading;
            set => base.Heading = value;
        }    
        #endregion
	}
}
