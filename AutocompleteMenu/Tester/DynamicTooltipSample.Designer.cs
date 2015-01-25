namespace Tester
{
    partial class DynamicTooltipSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicTooltipSample));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new ScintillaNET.Scintilla();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RichTextBox";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "This example shows how to dynamically create tooltip for items.\r\nStart to type \"a" +
                "bc\" into textbox. Click on the item of AutocompleteMenu.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(421, 180);
            this.richTextBox1.Styles.BraceBad.FontName = "Verdan";
            this.richTextBox1.Styles.BraceLight.FontName = "Verdan";
            this.richTextBox1.Styles.CallTip.FontName = "Segoe ";
            this.richTextBox1.Styles.ControlChar.FontName = "Verdan";
            this.richTextBox1.Styles.Default.FontName = "Verdan";
            this.richTextBox1.Styles.IndentGuide.FontName = "Verdan";
            this.richTextBox1.Styles.LastPredefined.FontName = "Verdan";
            this.richTextBox1.Styles.LineNumber.FontName = "Verdan";
            this.richTextBox1.Styles.Max.FontName = "Verdan";
            this.richTextBox1.TabIndex = 0;
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "abc",
        "abcd",
        "abcde",
        "abcdef"};
            this.autocompleteMenu1.LeftPadding = 0;
            this.autocompleteMenu1.TargetControlWrapper = null;
            this.autocompleteMenu1.Hovered += new System.EventHandler<AutocompleteMenuNS.HoveredEventArgs>(this.autocompleteMenu1_Hovered);
            // 
            // DynamicTooltipSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DynamicTooltipSample";
            this.Text = "Dynamic tooltip sample";
            this.Load += new System.EventHandler(this.DynamicTooltipSample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla richTextBox1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}