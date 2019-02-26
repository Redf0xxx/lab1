namespace Lab1
{
    partial class ActionsForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.btnCHangePass = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(191, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // btnCHangePass
            // 
            this.btnCHangePass.Location = new System.Drawing.Point(194, 53);
            this.btnCHangePass.Name = "btnCHangePass";
            this.btnCHangePass.Size = new System.Drawing.Size(189, 41);
            this.btnCHangePass.TabIndex = 1;
            this.btnCHangePass.Text = "Change password";
            this.btnCHangePass.UseVisualStyleBackColor = true;
            this.btnCHangePass.Click += new System.EventHandler(this.btnCHangePass_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(194, 101);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(189, 42);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Users list";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(194, 197);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(189, 42);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add user";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 264);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCHangePass);
            this.Controls.Add(this.lbName);
            this.Name = "ActionsForm";
            this.Text = "ActionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCHangePass;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAdd;
    }
}