namespace CodeReviewProgram
{
    partial class MainForm
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
            this.LoginInfo = new System.Windows.Forms.Label();
            this.btnCodeInsert = new System.Windows.Forms.Button();
            this.btnCodeUpdate = new System.Windows.Forms.Button();
            this.btnCodeDelee = new System.Windows.Forms.Button();
            this.versionViewControl1 = new CodeReviewProgram.Controls.VersionViewControl();
            this.commentViewControl1 = new CodeReviewProgram.Controls.CommentViewControl();
            this.categoryViewControl1 = new CodeReviewProgram.Controls.CategoryViewControl();
            this.SuspendLayout();
            // 
            // LoginInfo
            // 
            this.LoginInfo.Location = new System.Drawing.Point(12, 7);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(183, 50);
            this.LoginInfo.TabIndex = 1;
            this.LoginInfo.Text = "text1";
            this.LoginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCodeInsert
            // 
            this.btnCodeInsert.Location = new System.Drawing.Point(735, 21);
            this.btnCodeInsert.Name = "btnCodeInsert";
            this.btnCodeInsert.Size = new System.Drawing.Size(58, 50);
            this.btnCodeInsert.TabIndex = 5;
            this.btnCodeInsert.Text = "삽입";
            this.btnCodeInsert.UseVisualStyleBackColor = true;
            // 
            // btnCodeUpdate
            // 
            this.btnCodeUpdate.Location = new System.Drawing.Point(799, 21);
            this.btnCodeUpdate.Name = "btnCodeUpdate";
            this.btnCodeUpdate.Size = new System.Drawing.Size(58, 50);
            this.btnCodeUpdate.TabIndex = 6;
            this.btnCodeUpdate.Text = "수정";
            this.btnCodeUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCodeDelee
            // 
            this.btnCodeDelee.Location = new System.Drawing.Point(863, 21);
            this.btnCodeDelee.Name = "btnCodeDelee";
            this.btnCodeDelee.Size = new System.Drawing.Size(58, 50);
            this.btnCodeDelee.TabIndex = 7;
            this.btnCodeDelee.Text = "삭제";
            this.btnCodeDelee.UseVisualStyleBackColor = true;
            // 
            // versionViewControl1
            // 
            this.versionViewControl1.Location = new System.Drawing.Point(201, 12);
            this.versionViewControl1.Name = "versionViewControl1";
            this.versionViewControl1.Size = new System.Drawing.Size(725, 404);
            this.versionViewControl1.TabIndex = 4;
            // 
            // commentViewControl1
            // 
            this.commentViewControl1.ForeColor = System.Drawing.Color.Chocolate;
            this.commentViewControl1.Location = new System.Drawing.Point(201, 422);
            this.commentViewControl1.Name = "commentViewControl1";
            this.commentViewControl1.Size = new System.Drawing.Size(725, 130);
            this.commentViewControl1.TabIndex = 3;
            // 
            // categoryViewControl1
            // 
            this.categoryViewControl1.Location = new System.Drawing.Point(12, 60);
            this.categoryViewControl1.Name = "categoryViewControl1";
            this.categoryViewControl1.Size = new System.Drawing.Size(183, 492);
            this.categoryViewControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(938, 564);
            this.Controls.Add(this.btnCodeDelee);
            this.Controls.Add(this.btnCodeUpdate);
            this.Controls.Add(this.btnCodeInsert);
            this.Controls.Add(this.versionViewControl1);
            this.Controls.Add(this.commentViewControl1);
            this.Controls.Add(this.LoginInfo);
            this.Controls.Add(this.categoryViewControl1);
            this.Name = "MainForm";
            this.Text = "삭제";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CategoryViewControl categoryViewControl1;
        private System.Windows.Forms.Label LoginInfo;
        private Controls.CommentViewControl commentViewControl1;
        private Controls.VersionViewControl versionViewControl1;
        private System.Windows.Forms.Button btnCodeInsert;
        private System.Windows.Forms.Button btnCodeUpdate;
        private System.Windows.Forms.Button btnCodeDelee;
    }
}