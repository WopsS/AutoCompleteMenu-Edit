namespace Tester
{
    partial class AdvancedSample
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSample));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new ScintillaNET.Scintilla();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ScintillaNET";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "This example shows how to create custom autocomplete menu with keywords, snippets" +
    ", method suggestions, text correctors etc.";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "script_16x16.png");
            this.imageList1.Images.SetKeyName(1, "app_16x16.png");
            this.imageList1.Images.SetKeyName(2, "1302166543_virtualbox.png");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 149);
            this.richTextBox1.Styles.BraceBad.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.BraceLight.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.CallTip.FontName = "Segoe \0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.ControlChar.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.Default.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.IndentGuide.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.LastPredefined.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.LineNumber.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.Styles.Max.FontName = "Verdan\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Try to type \"in\"\nTry to type \"class\"\nTry to type \"obj.\"\nTry to type \"set{}abc\"\nTr" +
    "y to type \"123and567\"";
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AllowsTabKey = true;
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = this.imageList1;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.SearchPattern = "[\\w\\.:=!<>]";
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // AdvancedSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AdvancedSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedSample";
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla richTextBox1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
    }
}