﻿using System;
using System.Windows.Forms;

namespace WinTlx.Controls
{
	class SelectablePictureBox : PictureBox
	{
		public delegate void EnterEventHandler();
		public event EnterEventHandler EnterEvt;

		public delegate void LeaveEventHandler();
		public event LeaveEventHandler LeaveEvt;


		public SelectablePictureBox()
		{
			this.SetStyle(ControlStyles.Selectable, true);
			this.TabStop = true;
		}
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.Focus();
			base.OnMouseDown(e);
		}
		protected override void OnEnter(EventArgs e)
		{
			this.Invalidate();
			EnterEvt?.Invoke();
			base.OnEnter(e);
		}
		protected override void OnLeave(EventArgs e)
		{
			this.Invalidate();
			LeaveEvt?.Invoke();
			base.OnLeave(e);
		}
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			if (this.Focused)
			{
				var rc = this.ClientRectangle;
				rc.Inflate(-2, -2);
				ControlPaint.DrawFocusRectangle(pe.Graphics, rc);
			}
		}
	}
}
