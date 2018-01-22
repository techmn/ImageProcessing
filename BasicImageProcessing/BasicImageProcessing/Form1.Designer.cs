namespace BasicImageProcessing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tintBtn = new System.Windows.Forms.Button();
            this.blueTintBar = new System.Windows.Forms.TrackBar();
            this.greenTintBar = new System.Windows.Forms.TrackBar();
            this.redTintBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.undoBtn = new System.Windows.Forms.Button();
            this.thresholdBar = new System.Windows.Forms.TrackBar();
            this.thresholdBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edgeBtn = new System.Windows.Forms.Button();
            this.blurBtn = new System.Windows.Forms.Button();
            this.negativeBtn = new System.Windows.Forms.Button();
            this.grayScaleBtn = new System.Windows.Forms.Button();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.sepiaBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTintBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTintBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTintBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sepiaBtn);
            this.groupBox1.Controls.Add(this.tintBtn);
            this.groupBox1.Controls.Add(this.blueTintBar);
            this.groupBox1.Controls.Add(this.greenTintBar);
            this.groupBox1.Controls.Add(this.redTintBar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.undoBtn);
            this.groupBox1.Controls.Add(this.thresholdBar);
            this.groupBox1.Controls.Add(this.thresholdBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edgeBtn);
            this.groupBox1.Controls.Add(this.blurBtn);
            this.groupBox1.Controls.Add(this.negativeBtn);
            this.groupBox1.Controls.Add(this.grayScaleBtn);
            this.groupBox1.Controls.Add(this.browseFileBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // tintBtn
            // 
            this.tintBtn.Location = new System.Drawing.Point(263, 246);
            this.tintBtn.Name = "tintBtn";
            this.tintBtn.Size = new System.Drawing.Size(75, 23);
            this.tintBtn.TabIndex = 16;
            this.tintBtn.Text = "Apply";
            this.tintBtn.UseVisualStyleBackColor = true;
            this.tintBtn.Click += new System.EventHandler(this.tintBtn_Click);
            // 
            // blueTintBar
            // 
            this.blueTintBar.Location = new System.Drawing.Point(182, 246);
            this.blueTintBar.Maximum = 255;
            this.blueTintBar.Name = "blueTintBar";
            this.blueTintBar.Size = new System.Drawing.Size(75, 45);
            this.blueTintBar.TabIndex = 15;
            this.blueTintBar.Value = 128;
            this.blueTintBar.Scroll += new System.EventHandler(this.tintBar_Scroll);
            // 
            // greenTintBar
            // 
            this.greenTintBar.Location = new System.Drawing.Point(101, 246);
            this.greenTintBar.Maximum = 255;
            this.greenTintBar.Name = "greenTintBar";
            this.greenTintBar.Size = new System.Drawing.Size(75, 45);
            this.greenTintBar.TabIndex = 14;
            this.greenTintBar.Value = 128;
            this.greenTintBar.Scroll += new System.EventHandler(this.tintBar_Scroll);
            // 
            // redTintBar
            // 
            this.redTintBar.Location = new System.Drawing.Point(20, 246);
            this.redTintBar.Maximum = 255;
            this.redTintBar.Name = "redTintBar";
            this.redTintBar.Size = new System.Drawing.Size(75, 45);
            this.redTintBar.TabIndex = 13;
            this.redTintBar.Value = 128;
            this.redTintBar.Scroll += new System.EventHandler(this.tintBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tint";
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(263, 19);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(75, 23);
            this.undoBtn.TabIndex = 11;
            this.undoBtn.Text = "Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // thresholdBar
            // 
            this.thresholdBar.Location = new System.Drawing.Point(20, 179);
            this.thresholdBar.Maximum = 255;
            this.thresholdBar.Name = "thresholdBar";
            this.thresholdBar.Size = new System.Drawing.Size(211, 45);
            this.thresholdBar.TabIndex = 10;
            this.thresholdBar.Value = 128;
            this.thresholdBar.Scroll += new System.EventHandler(this.thresholdBar_Scroll);
            // 
            // thresholdBtn
            // 
            this.thresholdBtn.Location = new System.Drawing.Point(263, 179);
            this.thresholdBtn.Name = "thresholdBtn";
            this.thresholdBtn.Size = new System.Drawing.Size(75, 23);
            this.thresholdBtn.TabIndex = 9;
            this.thresholdBtn.Text = "Apply";
            this.thresholdBtn.UseVisualStyleBackColor = true;
            this.thresholdBtn.Click += new System.EventHandler(this.thresholdBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color Conversions";
            // 
            // edgeBtn
            // 
            this.edgeBtn.Location = new System.Drawing.Point(101, 124);
            this.edgeBtn.Name = "edgeBtn";
            this.edgeBtn.Size = new System.Drawing.Size(75, 23);
            this.edgeBtn.TabIndex = 4;
            this.edgeBtn.Text = "Highpass";
            this.edgeBtn.UseVisualStyleBackColor = true;
            this.edgeBtn.Click += new System.EventHandler(this.edgeBtn_Click);
            // 
            // blurBtn
            // 
            this.blurBtn.Location = new System.Drawing.Point(20, 124);
            this.blurBtn.Name = "blurBtn";
            this.blurBtn.Size = new System.Drawing.Size(75, 23);
            this.blurBtn.TabIndex = 3;
            this.blurBtn.Text = "Lowpass";
            this.blurBtn.UseVisualStyleBackColor = true;
            this.blurBtn.Click += new System.EventHandler(this.blurBtn_Click);
            // 
            // negativeBtn
            // 
            this.negativeBtn.Location = new System.Drawing.Point(101, 74);
            this.negativeBtn.Name = "negativeBtn";
            this.negativeBtn.Size = new System.Drawing.Size(75, 23);
            this.negativeBtn.TabIndex = 2;
            this.negativeBtn.Text = "Negative";
            this.negativeBtn.UseVisualStyleBackColor = true;
            this.negativeBtn.Click += new System.EventHandler(this.negativeBtn_Click);
            // 
            // grayScaleBtn
            // 
            this.grayScaleBtn.Location = new System.Drawing.Point(20, 74);
            this.grayScaleBtn.Name = "grayScaleBtn";
            this.grayScaleBtn.Size = new System.Drawing.Size(75, 23);
            this.grayScaleBtn.TabIndex = 1;
            this.grayScaleBtn.Text = "Gray Scale";
            this.grayScaleBtn.UseVisualStyleBackColor = true;
            this.grayScaleBtn.Click += new System.EventHandler(this.grayScaleBtn_Click);
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Location = new System.Drawing.Point(20, 19);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(97, 23);
            this.browseFileBtn.TabIndex = 0;
            this.browseFileBtn.Text = "Browse Image";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            this.browseFileBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgBox);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // imgBox
            // 
            this.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBox.Location = new System.Drawing.Point(40, 33);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(320, 240);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // sepiaBtn
            // 
            this.sepiaBtn.Location = new System.Drawing.Point(182, 74);
            this.sepiaBtn.Name = "sepiaBtn";
            this.sepiaBtn.Size = new System.Drawing.Size(75, 23);
            this.sepiaBtn.TabIndex = 17;
            this.sepiaBtn.Text = "Sepia";
            this.sepiaBtn.UseVisualStyleBackColor = true;
            this.sepiaBtn.Click += new System.EventHandler(this.sepiaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 360);
            this.MinimumSize = new System.Drawing.Size(800, 360);
            this.Name = "Form1";
            this.Text = "Basic Image Processing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTintBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTintBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTintBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.Button grayScaleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edgeBtn;
        private System.Windows.Forms.Button blurBtn;
        private System.Windows.Forms.Button negativeBtn;
        private System.Windows.Forms.Button thresholdBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar thresholdBar;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar redTintBar;
        private System.Windows.Forms.Button tintBtn;
        private System.Windows.Forms.TrackBar blueTintBar;
        private System.Windows.Forms.TrackBar greenTintBar;
        private System.Windows.Forms.Button sepiaBtn;
    }
}

