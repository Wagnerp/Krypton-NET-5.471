﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
    /// <summary>
    /// Custom type converter so that ButtonDisplay values appear as neat text at design time.
    /// </summary>
    public class ButtonDisplayConverter : StringLookupConverter
    {
        #region Static Fields
<<<<<<< HEAD

=======
        private Pair[] _pairs = { new Pair(ButtonDisplay.Hide,           "Hide"),
                                             new Pair(ButtonDisplay.ShowDisabled,   "Show Disabled"),
                                             new Pair(ButtonDisplay.ShowEnabled,    "Show Enabled"),
                                             new Pair(ButtonDisplay.Logic,          "Logic") };
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
        #endregion
                                             
        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonDisplayConverter clas.
        /// </summary>
        public ButtonDisplayConverter()
            : base(typeof(ButtonDisplay))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(ButtonDisplay.Hide,           "Hide"),
            new Pair(ButtonDisplay.ShowDisabled,   "Show Disabled"),
            new Pair(ButtonDisplay.ShowEnabled,    "Show Enabled"),
            new Pair(ButtonDisplay.Logic,          "Logic") };

        #endregion
    }
}
