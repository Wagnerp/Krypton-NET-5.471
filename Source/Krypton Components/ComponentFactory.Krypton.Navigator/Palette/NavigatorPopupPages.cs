﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
	/// Storage for popup page related properties.
	/// </summary>
    public class NavigatorPopupPages : Storage
    {
        #region Static Fields

        private const int DEFAULT_BORDER = 3;
        private const int DEFAULT_GAP = 3;
        private const PopupPageElement DEFAULT_ELEMENT = PopupPageElement.Item;
        private const PopupPagePosition DEFAULT_POSITION = PopupPagePosition.ModeAppropriate;

        #endregion

        #region Instance Fields
        private KryptonNavigator _navigator;

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorPopupPage class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorPopupPages(KryptonNavigator navigator,
                                  NeedPaintHandler needPaint)
		{
            Debug.Assert(navigator != null);
            Debug.Assert(needPaint != null);
            
            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
<<<<<<< HEAD
            AllowPopupPages = PopupPageAllow.OnlyOutlookMiniMode;
            Gap = DEFAULT_GAP;
            Border = DEFAULT_GAP;
            Element = DEFAULT_ELEMENT;
            Position = DEFAULT_POSITION;
=======
            _allowPopupPages = PopupPageAllow.OnlyOutlookMiniMode;
            _gap = DEFAULT_GAP;
            _border = DEFAULT_GAP;
            _element = DEFAULT_ELEMENT;
            _position = DEFAULT_POSITION;
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
        }
		#endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
<<<<<<< HEAD
        public override bool IsDefault => ((AllowPopupPages == PopupPageAllow.OnlyOutlookMiniMode) &&
                                           (Border == DEFAULT_BORDER) &&
                                           (Element == DEFAULT_ELEMENT) &&
                                           (Gap == DEFAULT_GAP) &&
                                           (Position == DEFAULT_POSITION));

=======
        public override bool IsDefault
        {
            get
            {
                return ((AllowPopupPages == PopupPageAllow.OnlyOutlookMiniMode) &&
                        (Border == DEFAULT_BORDER) &&
                        (Element == DEFAULT_ELEMENT) &&
                        (Gap == DEFAULT_GAP) &&
                        (Position == DEFAULT_POSITION));
            }
        }
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
        #endregion

        #region AllowPopupPages
        /// <summary>
        /// Gets and sets if popup pages are displayed.
        /// </summary>
        [Category("Visuals")]
        [Description("Determines if popup pages are displayed.")]
        [DefaultValue(typeof(PopupPageAllow), "Only Outlook Mini Mode")]
        public PopupPageAllow AllowPopupPages { get; set; }

        #endregion

        #region Border
        /// <summary>
        /// Gets and sets the border pixel width around the popup page.
        /// </summary>
        [Category("Visuals")]
        [Description("Pixel border width around the popup page.")]
        [DefaultValue(3)]
        public int Border { get; set; }

        #endregion

        #region Element
        /// <summary>
        /// Gets and sets the relative element to use when calculating size and position of the popup page.
        /// </summary>
        [Category("Visuals")]
        [Description("The relative element to use when calculating size and position of the popup page.")]
        [DefaultValue(typeof(PopupPageElement), "Item")]
        public PopupPageElement Element { get; set; }

        #endregion

        #region Gap
        /// <summary>
        /// Gets and sets the pixel gap between the source element and the popup page.
        /// </summary>
        [Category("Visuals")]
        [Description("Pixel gap between the source element and the popup page.")]
        [DefaultValue(3)]
        public int Gap { get; set; }

        #endregion

        #region Position
        /// <summary>
        /// Gets and sets how to calculate the size and position of the popup page relative to element.
        /// </summary>
        [Category("Visuals")]
        [Description("How to calculate the size and position of the popup page.")]
        [DefaultValue(typeof(PopupPagePosition), "ModeAppropriate")]
        public PopupPagePosition Position { get; set; }

        #endregion
    }
}
