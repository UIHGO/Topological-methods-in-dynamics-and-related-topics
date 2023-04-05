namespace VovaStroitKust
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeMap = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.meshSizeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IterationsCountText = new System.Windows.Forms.TextBox();
            this.startGrowing = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.commandText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeMap
            // 
            this.treeMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeMap.BackColor = System.Drawing.SystemColors.MenuText;
            this.treeMap.Cursor = System.Windows.Forms.Cursors.No;
            this.treeMap.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeMap.ForeColor = System.Drawing.Color.Yellow;
            this.treeMap.Location = new System.Drawing.Point(12, 12);
            this.treeMap.Name = "treeMap";
            this.treeMap.Size = new System.Drawing.Size(845, 648);
            this.treeMap.TabIndex = 0;
            this.treeMap.Text = "";
            this.treeMap.TextChanged += new System.EventHandler(this.treeMap_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(700, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Initialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // meshSizeText
            // 
            this.meshSizeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.meshSizeText.Location = new System.Drawing.Point(67, 666);
            this.meshSizeText.Name = "meshSizeText";
            this.meshSizeText.Size = new System.Drawing.Size(100, 20);
            this.meshSizeText.TabIndex = 2;
            this.meshSizeText.TextChanged += new System.EventHandler(this.meshSizeText_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MeshSize";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IterationsCount";
            // 
            // IterationsCountText
            // 
            this.IterationsCountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IterationsCountText.Location = new System.Drawing.Point(255, 666);
            this.IterationsCountText.Name = "IterationsCountText";
            this.IterationsCountText.Size = new System.Drawing.Size(100, 20);
            this.IterationsCountText.TabIndex = 4;
            this.IterationsCountText.TextChanged += new System.EventHandler(this.IterationsCountText_TextChanged);
            // 
            // startGrowing
            // 
            this.startGrowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startGrowing.Location = new System.Drawing.Point(781, 666);
            this.startGrowing.Name = "startGrowing";
            this.startGrowing.Size = new System.Drawing.Size(75, 23);
            this.startGrowing.TabIndex = 6;
            this.startGrowing.Text = "StartGrowing";
            this.startGrowing.UseVisualStyleBackColor = true;
            this.startGrowing.Click += new System.EventHandler(this.startGrowing_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Command";
            // 
            // commandText
            // 
            this.commandText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.commandText.Location = new System.Drawing.Point(423, 666);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(100, 20);
            this.commandText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 669);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 698);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.startGrowing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IterationsCountText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meshSizeText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox treeMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox meshSizeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IterationsCountText;
        private System.Windows.Forms.Button startGrowing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.Label label4;
    }
}

