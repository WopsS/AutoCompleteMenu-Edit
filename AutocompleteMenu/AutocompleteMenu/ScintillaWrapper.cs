using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ScintillaNET;

namespace AutocompleteMenuNS
{
    public class ScintillaWrapper : ITextBoxWrapper
    {
        private Scintilla target;

        private ScintillaWrapper(Scintilla targetControl)
        {
            this.target = targetControl;
        }

        public static ScintillaWrapper Create(Scintilla targetControl)
        {
            var result = new ScintillaWrapper(targetControl);
            return result;
        }

        public virtual string Text
        {
            get { return target.Text; }
            set { target.Text = value; }
        }

        public virtual string SelectedText
        {
            get { return (string)target.Selection.Text; }
            set { target.Selection.Text = value; }
        }

        public virtual int SelectionLength
        {
            get { return (int)target.Selection.Length; }
            set { target.Selection.Length = value; }
        }

        public virtual int SelectionStart
        {
            get { return (int)target.Selection.Start; }
            set { target.Selection.Start = value; }
        }

        public virtual Point GetPositionFromCharIndex(int pos)
        {
            Point test;
            test = new Point();
            test.X = target.PointXFromPosition(pos);
            return test;
        }


        public virtual Form FindForm()
        {
            return target.FindForm();
        }

        public virtual event EventHandler LostFocus
        {
            add { target.LostFocus += value; }
            remove { target.LostFocus -= value; } 
        }

        public virtual event KeyEventHandler KeyDown
        {
            add { target.KeyDown += value; }
            remove { target.KeyDown -= value; }
        }

        public virtual event ScrollEventHandler Scroll
        {
            add { }
            remove { }
        }

        public virtual event MouseEventHandler MouseDown 
        {
            add { target.MouseDown += value; }
            remove { target.MouseDown -= value; } 
        }

        public virtual Control TargetControl
        {
            get { return target; }
        }


        public bool Readonly
        {
            get { return target.IsReadOnly;  }
        }
    }
}
