using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
    public class ModernPanel : Panel
    {
        private int _shadowSize = 3;
        private int _cornerRadius = 10;
        private Color _shadowColor = Color.FromArgb(40, 0, 0, 0);

        public ModernPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.White;
            Padding = new Padding(_shadowSize, _shadowSize, _shadowSize, _shadowSize);
        }

        public int ShadowSize
        {
            get => _shadowSize;
            set { _shadowSize = value; Padding = new Padding(value); Invalidate(); }
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        public Color ShadowColor
        {
            get => _shadowColor;
            set { _shadowColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw shadow
            using (GraphicsPath shadowPath = RoundedRectangle(ClientRectangle, _cornerRadius))
            {
                using (PathGradientBrush shadowBrush = new PathGradientBrush(shadowPath))
                {
                    shadowBrush.CenterColor = _shadowColor;
                    shadowBrush.SurroundColors = new Color[] { Color.Transparent };
                    shadowBrush.WrapMode = WrapMode.Clamp;
                    g.FillPath(shadowBrush, shadowPath);
                }
            }

            // Draw panel background
            Rectangle innerRect = new Rectangle(
                _shadowSize,
                _shadowSize,
                Width - _shadowSize * 2,
                Height - _shadowSize * 2);

            using (GraphicsPath path = RoundedRectangle(innerRect, _cornerRadius))
            {
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillPath(brush, path);
                }
            }

            base.OnPaint(e);
        }

        private GraphicsPath RoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
