using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public class ToggleSwitch : UserControl
    {
        //private bool isChecked = false;
        //private int knobPosition;
        //private int targetPosition;
        //private System.Windows.Forms.Timer animationTimer;

        //public event EventHandler CheckedChanged;

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public bool Checked
        //{
        //    get => isChecked;
        //    set
        //    {
        //        isChecked = value;
        //        targetPosition = isChecked ? this.Width - this.Height + 4 : 4;
        //        animationTimer.Start();
        //        CheckedChanged?.Invoke(this, EventArgs.Empty);
        //        Invalidate();
        //    }
        //}

        //public ToggleSwitch()
        //{
        //    this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        //    this.Size = new Size(70, 35);
        //    this.BackColor = Color.Transparent;

        //    knobPosition = 4;
        //    targetPosition = 4;

        //    animationTimer = new System.Windows.Forms.Timer();
        //    animationTimer.Interval = 10;
        //    animationTimer.Tick += AnimationTimer_Tick;

        //    this.Click += ToggleSwitch_Click;
        //}

        //private void ToggleSwitch_Click(object sender, EventArgs e)
        //{
        //    Checked = !Checked;
        //}

        //private void AnimationTimer_Tick(object sender, EventArgs e)
        //{
        //    if (Math.Abs(knobPosition - targetPosition) > 1)
        //    {
        //        knobPosition += (targetPosition - knobPosition) > 0 ? 4 : -4;
        //        Invalidate();
        //    }
        //    else
        //    {
        //        knobPosition = targetPosition;
        //        animationTimer.Stop();
        //        Invalidate();
        //    }
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        //    Color bgColor = isChecked ? Color.FromArgb(45, 55, 72) : Color.FromArgb(203, 213, 225);
        //    using (Brush bgBrush = new SolidBrush(bgColor))
        //    {
        //        e.Graphics.FillPath(bgBrush, GetRoundedRectangle(this.ClientRectangle, this.Height));
        //    }

        //    int knobSize = this.Height - 8;
        //    Color knobColor = Color.White;
        //    using (Brush knobBrush = new SolidBrush(knobColor))
        //    {
        //        e.Graphics.FillEllipse(knobBrush, knobPosition, 4, knobSize, knobSize);
        //    }
        //}

        //private void InitializeComponent()
        //{
        //    SuspendLayout();
        //    // 
        //    // ToggleSwitch
        //    // 
        //    Name = "ToggleSwitch";
        //    Size = new Size(150, 60);
        //    ResumeLayout(false);

        //}

        //private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    int d = radius;
        //    path.AddArc(rect.X, rect.Y, d, d, 90, 180);
        //    path.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 180);
        //    path.CloseFigure();
        //    return path;
        //}
    }

}
