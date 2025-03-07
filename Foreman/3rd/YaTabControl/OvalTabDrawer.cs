using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GrayIris.Utilities.UI.Controls
{
	/// <summary>
	/// The <see cref="OvalTabDrawer"/> draws ovals for tabs.
	/// </summary>
	public class OvalTabDrawer : YaTabDrawerBase
	{
		/// <summary>
		/// Creates an instance of the <see cref="OvalTabDrawer"/> class.
		/// </summary>
		public OvalTabDrawer() {}

		#region YaTabDrawer Members

		/// <summary>
		/// Inherited from <see cref="YaTabDrawerBase"/>.
		/// </summary>
		/// <param name="foreColor">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		/// <param name="backColor">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		/// <param name="highlightColor">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		/// <param name="shadowColor">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
        /// <param name="borderColor">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
        /// <param name="hoverColor">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		/// <param name="active">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
        /// <param name="mouseOver">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		/// <param name="dock">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		/// <param name="graphics">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		/// <param name="tabSize">See <see cref="YaTabDrawerBase.DrawTab(Color,Color,Color,Color,Color,bool,DockStyle,Graphics,SizeF)"/>.</param>
		public override void DrawTab( Color foreColor, Color backColor, Color highlightColor, Color shadowColor, Color borderColor, Color hoverColor, bool active, bool mouseOver, DockStyle dock, Graphics graphics, SizeF tabSize, bool isNewTab )
		{
			if( active )
			{
				Brush b = null;
				b = new SolidBrush( foreColor );
				graphics.FillEllipse( b, 0, 0, tabSize.Width, tabSize.Height );
				b.Dispose();
				Pen p = new Pen( borderColor );
				graphics.DrawEllipse( p, 0, 0, tabSize.Width, tabSize.Height );
				p.Dispose();
			}
		}

		/// <summary>
		/// Inherited from <see cref="YaTabDrawerBase"/>.
		/// </summary>
		/// <returns>
		/// The <see cref="XlTabDrawer"/> uses highlights. Hence, this
		/// method always returns <b>true</b>.
		/// </returns>
		public override bool UsesHighlghts
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		/// Inherited from <see cref="YaTabDrawerBase"/>.
		/// </summary>
		/// <returns>
		/// The <see cref="VsTabDrawer"/> supports all directional
		/// <see cref="DockStyle"/>s.
		/// </returns>
		public override DockStyle[] SupportedTabDockStyles
		{
			get
			{
				return new DockStyle[] { DockStyle.Bottom, DockStyle.Top, DockStyle.Left, DockStyle.Right };
			}
		}

		/// <summary>
		/// Returns the <see cref="DockStyle"/>s 
		/// </summary>
		public override bool SupportsTabDockStyle(DockStyle dock)
		{
			return ( dock != DockStyle.Fill && dock != DockStyle.None );
		}

        ///// <summary>
        ///// Draws the new tab button.
        ///// </summary>
        //public override void DrawNewTabButton(Graphics graphics, RectangleF tabPagesRectangle)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Returns the width of the new tab button.
        ///// </summary>
        //public override float NewTabButtonWidth
        //{
        //    get { return 0.0f; }
        //}

		#endregion
	}
}
