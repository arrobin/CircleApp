namespace CircleApp2
{
    partial class CircleUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.rediustTextBox = new System.Windows.Forms.TextBox();
            this.diameterButton = new System.Windows.Forms.Button();
            this.resultLebel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.areaButton = new System.Windows.Forms.Button();
            this.perimeterButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius";
            // 
            // rediustTextBox
            // 
            this.rediustTextBox.Location = new System.Drawing.Point(102, 34);
            this.rediustTextBox.Name = "rediustTextBox";
            this.rediustTextBox.Size = new System.Drawing.Size(247, 20);
            this.rediustTextBox.TabIndex = 0;
            // 
            // diameterButton
            // 
            this.diameterButton.Location = new System.Drawing.Point(33, 110);
            this.diameterButton.Name = "diameterButton";
            this.diameterButton.Size = new System.Drawing.Size(75, 23);
            this.diameterButton.TabIndex = 2;
            this.diameterButton.Text = "Diameter";
            this.diameterButton.UseVisualStyleBackColor = true;
            this.diameterButton.Click += new System.EventHandler(this.diameterButton_Click);
            // 
            // resultLebel
            // 
            this.resultLebel.AutoSize = true;
            this.resultLebel.Location = new System.Drawing.Point(30, 71);
            this.resultLebel.Name = "resultLebel";
            this.resultLebel.Size = new System.Drawing.Size(37, 13);
            this.resultLebel.TabIndex = 0;
            this.resultLebel.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(102, 71);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(247, 20);
            this.resultTextBox.TabIndex = 1;
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(193, 110);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 23);
            this.areaButton.TabIndex = 4;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // perimeterButton
            // 
            this.perimeterButton.Location = new System.Drawing.Point(114, 110);
            this.perimeterButton.Name = "perimeterButton";
            this.perimeterButton.Size = new System.Drawing.Size(75, 23);
            this.perimeterButton.TabIndex = 3;
            this.perimeterButton.Text = "Parimeter";
            this.perimeterButton.UseVisualStyleBackColor = true;
            this.perimeterButton.Click += new System.EventHandler(this.perimeterButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(274, 110);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CircleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 161);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.perimeterButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.diameterButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.rediustTextBox);
            this.Controls.Add(this.resultLebel);
            this.Controls.Add(this.label1);
            this.Name = "CircleUI";
            this.Text = "CircleUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rediustTextBox;
        private System.Windows.Forms.Button diameterButton;
        private System.Windows.Forms.Label resultLebel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button perimeterButton;
        private System.Windows.Forms.Button clearButton;
    }
}

