﻿namespace Kanjimusou
{
    partial class learn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(learn));
            this.picture = new System.Windows.Forms.PictureBox();
            this.sound = new System.Windows.Forms.Button();
            this.close_it = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.exercise = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.paraphrase = new System.Windows.Forms.Label();
            this.more = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(300, 300);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // sound
            // 
            this.sound.Location = new System.Drawing.Point(318, 27);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(49, 23);
            this.sound.TabIndex = 1;
            this.sound.Text = "s";
            this.sound.UseVisualStyleBackColor = true;
            // 
            // close_it
            // 
            this.close_it.BackColor = System.Drawing.Color.Transparent;
            this.close_it.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_it.BackgroundImage")));
            this.close_it.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_it.Location = new System.Drawing.Point(339, -2);
            this.close_it.Name = "close_it";
            this.close_it.Size = new System.Drawing.Size(28, 23);
            this.close_it.TabIndex = 2;
            this.close_it.UseVisualStyleBackColor = false;
            this.close_it.Click += new System.EventHandler(this.close_it_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(318, 105);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(49, 21);
            this.write.TabIndex = 3;
            this.write.Text = "w";
            this.write.UseVisualStyleBackColor = true;
            // 
            // exercise
            // 
            this.exercise.Location = new System.Drawing.Point(319, 194);
            this.exercise.Name = "exercise";
            this.exercise.Size = new System.Drawing.Size(48, 22);
            this.exercise.TabIndex = 4;
            this.exercise.Text = "e";
            this.exercise.UseVisualStyleBackColor = true;
            this.exercise.Click += new System.EventHandler(this.exercise_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(319, 291);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(48, 21);
            this.next.TabIndex = 5;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            // 
            // paraphrase
            // 
            this.paraphrase.AutoSize = true;
            this.paraphrase.Location = new System.Drawing.Point(10, 333);
            this.paraphrase.Name = "paraphrase";
            this.paraphrase.Size = new System.Drawing.Size(65, 12);
            this.paraphrase.TabIndex = 6;
            this.paraphrase.Text = "paraphrase";
            // 
            // more
            // 
            this.more.AutoSize = true;
            this.more.Location = new System.Drawing.Point(255, 414);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(101, 12);
            this.more.TabIndex = 7;
            this.more.TabStop = true;
            this.more.Text = "more information";
            // 
            // learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 435);
            this.Controls.Add(this.more);
            this.Controls.Add(this.paraphrase);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exercise);
            this.Controls.Add(this.write);
            this.Controls.Add(this.close_it);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "learn";
            this.Opacity = 0.85D;
            this.Text = "learn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.learn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Button close_it;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button exercise;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label paraphrase;
        private System.Windows.Forms.LinkLabel more;
    }
}