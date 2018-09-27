namespace DataFormatter
{
    partial class FormatData
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
            this.txtSource = new System.Windows.Forms.RichTextBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.tvTarget = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(31, 12);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(352, 428);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "";
            // 
            // btnTransform
            // 
            this.btnTransform.BackColor = System.Drawing.Color.Navy;
            this.btnTransform.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransform.ForeColor = System.Drawing.Color.Green;
            this.btnTransform.Location = new System.Drawing.Point(389, 184);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(75, 45);
            this.btnTransform.TabIndex = 1;
            this.btnTransform.Text = ">>>";
            this.btnTransform.UseVisualStyleBackColor = false;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // tvTarget
            // 
            this.tvTarget.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvTarget.Location = new System.Drawing.Point(470, 12);
            this.tvTarget.Name = "tvTarget";
            this.tvTarget.Size = new System.Drawing.Size(343, 428);
            this.tvTarget.TabIndex = 2;
            // 
            // FormatData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(845, 452);
            this.Controls.Add(this.tvTarget);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormatData";
            this.ShowInTaskbar = false;
            this.Text = "FormatData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSource;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.TreeView tvTarget;
    }
}