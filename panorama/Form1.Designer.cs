namespace panorama
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
            image1_btn = new Button();
            image2_btn = new Button();
            image3_btn = new Button();
            stitcher_btn = new Button();
            image1_pb = new PictureBox();
            image2_pb = new PictureBox();
            image3_pb = new PictureBox();
            res_pb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)image1_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image2_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image3_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)res_pb).BeginInit();
            SuspendLayout();
            // 
            // image1_btn
            // 
            image1_btn.Location = new Point(60, 32);
            image1_btn.Name = "image1_btn";
            image1_btn.Size = new Size(153, 42);
            image1_btn.TabIndex = 0;
            image1_btn.Text = "load image 1";
            image1_btn.UseVisualStyleBackColor = true;
            image1_btn.Click += image1_btn_Click;
            // 
            // image2_btn
            // 
            image2_btn.Location = new Point(350, 32);
            image2_btn.Name = "image2_btn";
            image2_btn.Size = new Size(153, 42);
            image2_btn.TabIndex = 1;
            image2_btn.Text = "load image 2";
            image2_btn.UseVisualStyleBackColor = true;
            image2_btn.Click += image2_btn_Click;
            // 
            // image3_btn
            // 
            image3_btn.Location = new Point(640, 32);
            image3_btn.Name = "image3_btn";
            image3_btn.Size = new Size(153, 42);
            image3_btn.TabIndex = 2;
            image3_btn.Text = "load image 3";
            image3_btn.UseVisualStyleBackColor = true;
            image3_btn.Click += image3_btn_Click;
            // 
            // stitcher_btn
            // 
            stitcher_btn.Location = new Point(364, 272);
            stitcher_btn.Name = "stitcher_btn";
            stitcher_btn.Size = new Size(131, 42);
            stitcher_btn.TabIndex = 3;
            stitcher_btn.Text = "connect";
            stitcher_btn.UseVisualStyleBackColor = true;
            stitcher_btn.Click += stitcher_btn_Click;
            // 
            // image1_pb
            // 
            image1_pb.Location = new Point(7, 80);
            image1_pb.Name = "image1_pb";
            image1_pb.Size = new Size(275, 183);
            image1_pb.TabIndex = 4;
            image1_pb.TabStop = false;
            image1_pb.Visible = false;
            // 
            // image2_pb
            // 
            image2_pb.Location = new Point(288, 80);
            image2_pb.Name = "image2_pb";
            image2_pb.Size = new Size(275, 183);
            image2_pb.TabIndex = 5;
            image2_pb.TabStop = false;
            image2_pb.Visible = false;
            // 
            // image3_pb
            // 
            image3_pb.Location = new Point(569, 80);
            image3_pb.Name = "image3_pb";
            image3_pb.Size = new Size(275, 183);
            image3_pb.TabIndex = 6;
            image3_pb.TabStop = false;
            image3_pb.Visible = false;
            // 
            // res_pb
            // 
            res_pb.Location = new Point(192, 320);
            res_pb.Name = "res_pb";
            res_pb.Size = new Size(479, 313);
            res_pb.TabIndex = 7;
            res_pb.TabStop = false;
            res_pb.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 640);
            Controls.Add(res_pb);
            Controls.Add(image3_pb);
            Controls.Add(image2_pb);
            Controls.Add(image1_pb);
            Controls.Add(stitcher_btn);
            Controls.Add(image3_btn);
            Controls.Add(image2_btn);
            Controls.Add(image1_btn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)image1_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)image2_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)image3_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)res_pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button image1_btn;
        private Button image2_btn;
        private Button image3_btn;
        private Button stitcher_btn;
        private PictureBox image1_pb;
        private PictureBox image2_pb;
        private PictureBox image3_pb;
        private PictureBox res_pb;
    }
}
