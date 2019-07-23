namespace e3PluginDemo.Controls
{
    partial class UserControlExample
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetBomPartList = new System.Windows.Forms.Button();
            this.btnSetSheetTextsColorAsRed = new System.Windows.Forms.Button();
            this.btnHighlightSegments = new System.Windows.Forms.Button();
            this.btnSetProjectTextsColorAsPurple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetBomPartList
            // 
            this.btnGetBomPartList.Location = new System.Drawing.Point(4, 4);
            this.btnGetBomPartList.Name = "btnGetBomPartList";
            this.btnGetBomPartList.Size = new System.Drawing.Size(200, 24);
            this.btnGetBomPartList.TabIndex = 0;
            this.btnGetBomPartList.Text = "Get BOM part list";
            this.btnGetBomPartList.UseVisualStyleBackColor = true;
            this.btnGetBomPartList.Click += new System.EventHandler(this.BtnGetBomPartList_Click);
            // 
            // btnSetSheetTextsColorAsRed
            // 
            this.btnSetSheetTextsColorAsRed.Location = new System.Drawing.Point(4, 30);
            this.btnSetSheetTextsColorAsRed.Name = "btnSetSheetTextsColorAsRed";
            this.btnSetSheetTextsColorAsRed.Size = new System.Drawing.Size(200, 24);
            this.btnSetSheetTextsColorAsRed.TabIndex = 1;
            this.btnSetSheetTextsColorAsRed.Text = "Set Sheet Texts Color as Red";
            this.btnSetSheetTextsColorAsRed.UseVisualStyleBackColor = true;
            this.btnSetSheetTextsColorAsRed.Click += new System.EventHandler(this.BtnSetSheetTextsColorAsRed_Click);
            // 
            // btnHighlightSegments
            // 
            this.btnHighlightSegments.Location = new System.Drawing.Point(4, 82);
            this.btnHighlightSegments.Name = "btnHighlightSegments";
            this.btnHighlightSegments.Size = new System.Drawing.Size(200, 24);
            this.btnHighlightSegments.TabIndex = 3;
            this.btnHighlightSegments.Text = "Highlight Segments";
            this.btnHighlightSegments.UseVisualStyleBackColor = true;
            this.btnHighlightSegments.Click += new System.EventHandler(this.BtnHighlightSegments_Click);
            // 
            // btnSetProjectTextsColorAsPurple
            // 
            this.btnSetProjectTextsColorAsPurple.Location = new System.Drawing.Point(4, 56);
            this.btnSetProjectTextsColorAsPurple.Name = "btnSetProjectTextsColorAsPurple";
            this.btnSetProjectTextsColorAsPurple.Size = new System.Drawing.Size(200, 24);
            this.btnSetProjectTextsColorAsPurple.TabIndex = 2;
            this.btnSetProjectTextsColorAsPurple.Text = "Set Project Texts Color as Purple";
            this.btnSetProjectTextsColorAsPurple.UseVisualStyleBackColor = true;
            this.btnSetProjectTextsColorAsPurple.Click += new System.EventHandler(this.BtnSetProjectTextsColorAsPurple_Click);
            // 
            // UserControlExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSetProjectTextsColorAsPurple);
            this.Controls.Add(this.btnHighlightSegments);
            this.Controls.Add(this.btnSetSheetTextsColorAsRed);
            this.Controls.Add(this.btnGetBomPartList);
            this.Name = "UserControlExample";
            this.Size = new System.Drawing.Size(208, 111);
            this.Tag = "c07b1e1a-cebd-41c5-af22-72db0697838d";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetBomPartList;
        private System.Windows.Forms.Button btnSetSheetTextsColorAsRed;
        private System.Windows.Forms.Button btnHighlightSegments;
        private System.Windows.Forms.Button btnSetProjectTextsColorAsPurple;
    }
}
