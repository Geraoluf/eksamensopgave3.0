namespace eksamensopgave3._0
{
    partial class Form1
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
            txtmenu = new TextBox();
            txtingrediens1 = new TextBox();
            txtingrediens2 = new TextBox();
            txtingrediens3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtmenu
            // 
            txtmenu.Location = new Point(387, 148);
            txtmenu.Name = "txtmenu";
            txtmenu.Size = new Size(100, 23);
            txtmenu.TabIndex = 0;
            // 
            // txtingrediens1
            // 
            txtingrediens1.Location = new Point(387, 191);
            txtingrediens1.Name = "txtingrediens1";
            txtingrediens1.Size = new Size(100, 23);
            txtingrediens1.TabIndex = 1;
            // 
            // txtingrediens2
            // 
            txtingrediens2.Location = new Point(387, 237);
            txtingrediens2.Name = "txtingrediens2";
            txtingrediens2.Size = new Size(100, 23);
            txtingrediens2.TabIndex = 2;
            // 
            // txtingrediens3
            // 
            txtingrediens3.Location = new Point(387, 284);
            txtingrediens3.Name = "txtingrediens3";
            txtingrediens3.Size = new Size(100, 23);
            txtingrediens3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 150);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 191);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 237);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 292);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtingrediens3);
            Controls.Add(txtingrediens2);
            Controls.Add(txtingrediens1);
            Controls.Add(txtmenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmenu;
        private TextBox txtingrediens1;
        private TextBox txtingrediens2;
        private TextBox txtingrediens3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}