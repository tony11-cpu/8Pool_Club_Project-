namespace MyPoolClubProject
{
    partial class Form1
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
            this.ctrlPoolStation4 = new MyPoolClubProject.ctrlPoolStation();
            this.ctrlPoolStation3 = new MyPoolClubProject.ctrlPoolStation();
            this.ctrlPoolStation2 = new MyPoolClubProject.ctrlPoolStation();
            this.ctrlPoolStation1 = new MyPoolClubProject.ctrlPoolStation();
            this.SuspendLayout();
            // 
            // ctrlPoolStation4
            // 
            this.ctrlPoolStation4.AutoSize = true;
            this.ctrlPoolStation4.HourlyRate = 10D;
            this.ctrlPoolStation4.Location = new System.Drawing.Point(1330, 1);
            this.ctrlPoolStation4.Name = "ctrlPoolStation4";
            this.ctrlPoolStation4.PlayerName = "Player 1";
            this.ctrlPoolStation4.Size = new System.Drawing.Size(659, 545);
            this.ctrlPoolStation4.TabIndex = 3;
            this.ctrlPoolStation4.TableName = "Table 1";
            // 
            // ctrlPoolStation3
            // 
            this.ctrlPoolStation3.AutoSize = true;
            this.ctrlPoolStation3.HourlyRate = 10D;
            this.ctrlPoolStation3.Location = new System.Drawing.Point(665, 7);
            this.ctrlPoolStation3.Name = "ctrlPoolStation3";
            this.ctrlPoolStation3.PlayerName = "Player 1";
            this.ctrlPoolStation3.Size = new System.Drawing.Size(659, 545);
            this.ctrlPoolStation3.TabIndex = 2;
            this.ctrlPoolStation3.TableName = "Table 1";
            // 
            // ctrlPoolStation2
            // 
            this.ctrlPoolStation2.AutoSize = true;
            this.ctrlPoolStation2.HourlyRate = 10D;
            this.ctrlPoolStation2.Location = new System.Drawing.Point(665, 0);
            this.ctrlPoolStation2.Name = "ctrlPoolStation2";
            this.ctrlPoolStation2.PlayerName = "Player 1";
            this.ctrlPoolStation2.Size = new System.Drawing.Size(659, 545);
            this.ctrlPoolStation2.TabIndex = 1;
            this.ctrlPoolStation2.TableName = "Table 1";
            // 
            // ctrlPoolStation1
            // 
            this.ctrlPoolStation1.AutoSize = true;
            this.ctrlPoolStation1.HourlyRate = 12D;
            this.ctrlPoolStation1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPoolStation1.Name = "ctrlPoolStation1";
            this.ctrlPoolStation1.PlayerName = "Tony Masoud";
            this.ctrlPoolStation1.Size = new System.Drawing.Size(659, 545);
            this.ctrlPoolStation1.TabIndex = 0;
            this.ctrlPoolStation1.TableName = "Table Pool";
            this.ctrlPoolStation1.OnGameFinish += new System.EventHandler<MyPoolClubProject.clsUtils.cls8PoolEventArgs>(this.ctrlPoolStation1_OnGameFinish_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1989, 558);
            this.Controls.Add(this.ctrlPoolStation4);
            this.Controls.Add(this.ctrlPoolStation3);
            this.Controls.Add(this.ctrlPoolStation2);
            this.Controls.Add(this.ctrlPoolStation1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPoolStation ctrlPoolStation1;
        private ctrlPoolStation ctrlPoolStation2;
        private ctrlPoolStation ctrlPoolStation3;
        private ctrlPoolStation ctrlPoolStation4;
    }
}

