﻿namespace Hello_Word
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
            btnClickThis = new Button();
            lblHelloWorld = new Label();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(333, 205);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(94, 29);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click this";
            btnClickThis.UseVisualStyleBackColor = true;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(338, 259);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(89, 20);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "Hello Word!";
            lblHelloWorld.Click += lblHelloWorld_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickThis);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label lblHelloWorld;
    }
}