
namespace MiniProject
{
    partial class main
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
            this.add = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(51, 35);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 33);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(51, 74);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(105, 33);
            this.view.TabIndex = 1;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(51, 113);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(105, 33);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(51, 152);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(105, 33);
            this.find.TabIndex = 3;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.view);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

