namespace Frogger
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            txtVie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNiveau = new TextBox();
            btnCommencer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.route;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 642);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtVie
            // 
            txtVie.Enabled = false;
            txtVie.Font = new Font("Segoe UI", 30F);
            txtVie.Location = new Point(104, 697);
            txtVie.Name = "txtVie";
            txtVie.ReadOnly = true;
            txtVie.Size = new Size(100, 61);
            txtVie.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(-1, 700);
            label1.Name = "label1";
            label1.Size = new Size(99, 54);
            label1.TabIndex = 2;
            label1.Text = "Vie :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(727, 704);
            label2.Name = "label2";
            label2.Size = new Size(166, 54);
            label2.TabIndex = 4;
            label2.Text = "Niveau :";
            // 
            // txtNiveau
            // 
            txtNiveau.Enabled = false;
            txtNiveau.Font = new Font("Segoe UI", 30F);
            txtNiveau.Location = new Point(899, 697);
            txtNiveau.Name = "txtNiveau";
            txtNiveau.ReadOnly = true;
            txtNiveau.Size = new Size(100, 61);
            txtNiveau.TabIndex = 3;
            // 
            // btnCommencer
            // 
            btnCommencer.Font = new Font("Segoe UI", 30F);
            btnCommencer.Location = new Point(210, 697);
            btnCommencer.Name = "btnCommencer";
            btnCommencer.Size = new Size(511, 61);
            btnCommencer.TabIndex = 5;
            btnCommencer.Text = "Commencer";
            btnCommencer.UseVisualStyleBackColor = true;
            btnCommencer.Click += btnCommencer_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 761);
            Controls.Add(btnCommencer);
            Controls.Add(label2);
            Controls.Add(txtNiveau);
            Controls.Add(label1);
            Controls.Add(txtVie);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Frogger";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtVie;
        private Label label1;
        private Label label2;
        private TextBox txtNiveau;
        private Button btnCommencer;
        private System.Windows.Forms.Timer timer1;
    }
}
