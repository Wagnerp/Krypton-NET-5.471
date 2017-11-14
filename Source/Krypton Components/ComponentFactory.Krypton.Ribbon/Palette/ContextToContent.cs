﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    internal class ContextToContent : RibbonToContent
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextToContent class.
        /// </summary>
        /// <param name="ribbonGeneral">Source for general ribbon settings.</param>
        public ContextToContent(PaletteRibbonGeneral ribbonGeneral)
            : base(ribbonGeneral)
        {
            OverrideTextColor = Color.Empty;
            OverrideTextHint = PaletteTextHint.Inherit;
        }
        #endregion

        #region OverrideTextColor
        /// <summary>
        /// Gets and sets the text color override.
        /// </summary>
        public Color OverrideTextColor { get; set; }

        #endregion

        #region OverrideTextHint
        /// <summary>
        /// Gets and sets the text hint.
        /// </summary>
        public PaletteTextHint OverrideTextHint { get; set; }

        #endregion

        #region IPaletteContent
        /// <summary>
        /// Gets the text trimming to use for short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextTrim value.</returns>
        public override PaletteTextTrim GetContentShortTextTrim(PaletteState state)
        {
            return PaletteTextTrim.Character;
        }

        /// <summary>
        /// Gets the horizontal relative alignment of the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>RelativeAlignment value.</returns>
        public override PaletteRelativeAlign GetContentShortTextH(PaletteState state)
        {
            return RibbonGeneral.GetRibbonContextTextAlign(state);
        }

        /// <summary>
        /// Gets the font for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Font value.</returns>
        public override Font GetContentShortTextFont(PaletteState state)
        {
            return RibbonGeneral.GetRibbonContextTextFont(state);
        }

        /// <summary>
        /// Gets the rendering hint for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextHint value.</returns>
        public override PaletteTextHint GetContentShortTextHint(PaletteState state)
        {
<<<<<<< HEAD
            if (OverrideTextHint != PaletteTextHint.Inherit)
            {
                return OverrideTextHint;
=======
            if (_overrideTextHint != PaletteTextHint.Inherit)
            {
                return _overrideTextHint;
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
            else
            {
                return RibbonGeneral.GetRibbonTextHint(state);
            }
        }

        /// <summary>
        /// Gets the first back color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentShortTextColor1(PaletteState state)
        {
<<<<<<< HEAD
            if (OverrideTextColor != Color.Empty)
            {
                return OverrideTextColor;
=======
            if (_overrideTextColor != Color.Empty)
            {
                return _overrideTextColor;
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
            else
            {
                return RibbonGeneral.GetRibbonContextTextColor(state);
            }
        }

        /// <summary>
        /// Gets the second back color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentShortTextColor2(PaletteState state)
        {
<<<<<<< HEAD
            if (OverrideTextColor != Color.Empty)
            {
                return OverrideTextColor;
=======
            if (_overrideTextColor != Color.Empty)
            {
                return _overrideTextColor;
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
            else
            {
                return RibbonGeneral.GetRibbonContextTextColor(state);
            }
        }

        /// <summary>
        /// Gets the text trimming to use for long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextTrim value.</returns>
        public override PaletteTextTrim GetContentLongTextTrim(PaletteState state)
        {
            return PaletteTextTrim.Character;
        }

        /// <summary>
        /// Gets the font for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Font value.</returns>
        public override Font GetContentLongTextFont(PaletteState state)
        {
            return RibbonGeneral.GetRibbonContextTextFont(state);
        }

        /// <summary>
        /// Gets the rendering hint for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextHint value.</returns>
        public override PaletteTextHint GetContentLongTextHint(PaletteState state)
        {
<<<<<<< HEAD
            if (OverrideTextHint != PaletteTextHint.Inherit)
            {
                return OverrideTextHint;
=======
            if (_overrideTextHint != PaletteTextHint.Inherit)
            {
                return _overrideTextHint;
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
            else
            {
                return RibbonGeneral.GetRibbonTextHint(state);
            }
        }

        /// <summary>
        /// Gets the first back color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentLongTextColor1(PaletteState state)
        {
<<<<<<< HEAD
            if (OverrideTextColor != Color.Empty)
            {
                return OverrideTextColor;
=======
            if (_overrideTextColor != Color.Empty)
            {
                return _overrideTextColor;
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
            else
            {
                return RibbonGeneral.GetRibbonContextTextColor(state);
            }
        }

        /// <summary>
        /// Gets the second back color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentLongTextColor2(PaletteState state)
        {
<<<<<<< HEAD
            if (OverrideTextColor != Color.Empty)
            {
                return OverrideTextColor;
=======
            if (_overrideTextColor != Color.Empty)
            {
                return _overrideTextColor;
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
            else
            {
                return RibbonGeneral.GetRibbonContextTextColor(state);
            }
        }
        #endregion
    }
}
