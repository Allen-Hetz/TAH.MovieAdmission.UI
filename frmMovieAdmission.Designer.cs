namespace TAH.MovieAdmission.UI
{
    partial class frmMovieAdmission
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAge = new TextBox();
            chkParent = new CheckBox();
            chkTicket = new CheckBox();
            chkBanned = new CheckBox();
            btnCheck = new Button();
            lblResult = new Label();
            lblMain = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(103, 72);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Customer Age:";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F);
            txtAge.Location = new Point(48, 96);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(223, 29);
            txtAge.TabIndex = 2;
            // 
            // chkParent
            // 
            chkParent.AutoSize = true;
            chkParent.Font = new Font("Segoe UI", 12F);
            chkParent.Location = new Point(48, 144);
            chkParent.Name = "chkParent";
            chkParent.Size = new Size(191, 25);
            chkParent.TabIndex = 3;
            chkParent.Text = "Parent is with customer";
            chkParent.UseVisualStyleBackColor = true;
            // 
            // chkTicket
            // 
            chkTicket.AutoSize = true;
            chkTicket.Font = new Font("Segoe UI", 12F);
            chkTicket.Location = new Point(48, 183);
            chkTicket.Name = "chkTicket";
            chkTicket.Size = new Size(178, 25);
            chkTicket.TabIndex = 4;
            chkTicket.Text = "Customer has a ticket";
            chkTicket.UseVisualStyleBackColor = true;
            // 
            // chkBanned
            // 
            chkBanned.AutoSize = true;
            chkBanned.Font = new Font("Segoe UI", 12F);
            chkBanned.Location = new Point(48, 222);
            chkBanned.Name = "chkBanned";
            chkBanned.Size = new Size(168, 25);
            chkBanned.TabIndex = 5;
            chkBanned.Text = "Customer is banned";
            chkBanned.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(48, 268);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(223, 42);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check Admission";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(48, 338);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(223, 46);
            lblResult.TabIndex = 7;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(8, 24);
            lblMain.Name = "lblMain";
            lblMain.RightToLeft = RightToLeft.Yes;
            lblMain.Size = new Size(305, 32);
            lblMain.TabIndex = 8;
            lblMain.Text = "Movie Theater Admission";
            // 
            // frmMovieAdmission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 412);
            Controls.Add(lblMain);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(chkBanned);
            Controls.Add(chkTicket);
            Controls.Add(chkParent);
            Controls.Add(txtAge);
            Controls.Add(label1);
            Name = "frmMovieAdmission";
            Text = "Movie Theater Admission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtAge;
        private CheckBox chkParent;
        private CheckBox chkTicket;
        private CheckBox chkBanned;
        private Button btnCheck;
        private Label lblResult;
        private Label lblMain;
    }
}
