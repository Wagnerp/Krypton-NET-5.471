﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
	/// Implement redirected storage for page appearance.
	/// </summary>
    public class PalettePageRedirect : PaletteDoubleRedirect
	{
		#region Identity
		/// <summary>
        /// Initialize a new instance of the PalettePageRedirect class.
		/// </summary>
		/// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PalettePageRedirect(PaletteRedirect redirect,
                                   NeedPaintHandler needPaint)
            : base(redirect, PaletteBackStyle.ControlClient,
                             PaletteBorderStyle.ControlClient, needPaint)
		{
		}
		#endregion

        #region Border
        /// <summary>
        /// Gets access to the border palette details.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override PaletteBorder Border => base.Border;

	    /// <summary>
        /// Gets the border palette.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override IPaletteBorder PaletteBorder => base.PaletteBorder;

	    #endregion
    }
}
