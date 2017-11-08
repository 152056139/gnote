namespace Gnote.Dialog
{
    partial class NewNotebook
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
            this.textBoxNotebook = new System.Windows.Forms.TextBox();
            this.LabelNotebookName = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNotebook
            // 
            this.textBoxNotebook.Location = new System.Drawing.Point(101, 33);
            this.textBoxNotebook.Name = "textBoxNotebook";
            this.textBoxNotebook.Size = new System.Drawing.Size(229, 21);
            this.textBoxNotebook.TabIndex = 0;
            // 
            // LabelNotebookName
            // 
            this.LabelNotebookName.AutoSize = true;
            this.LabelNotebookName.Location = new System.Drawing.Point(42, 36);
            this.LabelNotebookName.Name = "LabelNotebookName";
            this.LabelNotebookName.Size = new System.Drawing.Size(41, 12);
            this.LabelNotebookName.TabIndex = 1;
            this.LabelNotebookName.Text = "笔记本";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(72, 82);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(228, 82);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 133);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.LabelNotebookName);
            this.Controls.Add(this.textBoxNotebook);
            this.MaximumSize = new System.Drawing.Size(380, 171);
            this.MinimumSize = new System.Drawing.Size(380, 171);
            this.Name = "NewNotebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建笔记本";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNotebook;
        private System.Windows.Forms.Label LabelNotebookName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button Cancel;
    }
}