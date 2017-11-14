﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Custom type converter so that HeaderGroupCollapseTarget values appear as neat text at design time.
    /// </summary>
    internal class HeaderGroupCollapsedTargetConverter : StringLookupConverter
    {
        #region Static Fields
<<<<<<< HEAD

=======
        private Pair[] _pairs = { new Pair(HeaderGroupCollapsedTarget.CollapsedToPrimary,   "Collapse to Primary Header"),
                                             new Pair(HeaderGroupCollapsedTarget.CollapsedToSecondary, "Collapse to Secondary Header"),
                                             new Pair(HeaderGroupCollapsedTarget.CollapsedToBoth,      "Collapse to Both Headers") };
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the HeaderGroupCollapseTargetConverter clas.
        /// </summary>
        public HeaderGroupCollapsedTargetConverter()
            : base(typeof(HeaderGroupCollapsedTarget))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(HeaderGroupCollapsedTarget.CollapsedToPrimary,   "Collapse to Primary Header"),
            new Pair(HeaderGroupCollapsedTarget.CollapsedToSecondary, "Collapse to Secondary Header"),
            new Pair(HeaderGroupCollapsedTarget.CollapsedToBoth,      "Collapse to Both Headers") };

        #endregion
    }
}
