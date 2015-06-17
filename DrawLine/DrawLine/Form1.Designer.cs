namespace DrawLine
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
            this.lenghttextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthtextBox = new System.Windows.Forms.TextBox();
            this.rectanglebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lenghttextbox
            // 
            this.lenghttextbox.Location = new System.Drawing.Point(58, 26);
            this.lenghttextbox.Name = "lenghttextbox";
            this.lenghttextbox.Size = new System.Drawing.Size(100, 22);
            this.lenghttextbox.TabIndex = 1;
            this.lenghttextbox.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "長：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "寬：";
            // 
            // widthtextBox
            // 
            this.widthtextBox.Location = new System.Drawing.Point(208, 27);
            this.widthtextBox.Name = "widthtextBox";
            this.widthtextBox.Size = new System.Drawing.Size(100, 22);
            this.widthtextBox.TabIndex = 4;
            this.widthtextBox.Text = "200";
            // 
            // rectanglebutton
            // 
            this.rectanglebutton.Location = new System.Drawing.Point(328, 27);
            this.rectanglebutton.Name = "rectanglebutton";
            this.rectanglebutton.Size = new System.Drawing.Size(121, 23);
            this.rectanglebutton.TabIndex = 5;
            this.rectanglebutton.Text = "畫矩形囉！！！";
            this.rectanglebutton.UseVisualStyleBackColor = true;
            this.rectanglebutton.Click += new System.EventHandler(this.rectanglebutton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 399);
            this.Controls.Add(this.rectanglebutton);
            this.Controls.Add(this.widthtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lenghttextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lenghttextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthtextBox;
        private System.Windows.Forms.Button rectanglebutton;

    }
}

