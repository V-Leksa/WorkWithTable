namespace WorkWithTable
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
            DGV = new DataGridView();
            OpenBT = new Button();
            SaveBT = new Button();
            AddBT = new Button();
            DeleteBT = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(0, 0);
            DGV.Name = "DGV";
            DGV.RowTemplate.Height = 25;
            DGV.Size = new Size(779, 449);
            DGV.TabIndex = 0;
            // 
            // OpenBT
            // 
            OpenBT.BackColor = Color.LightGreen;
            OpenBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OpenBT.ForeColor = Color.Black;
            OpenBT.Location = new Point(785, 12);
            OpenBT.Name = "OpenBT";
            OpenBT.Size = new Size(184, 72);
            OpenBT.TabIndex = 1;
            OpenBT.Text = "Открыть";
            OpenBT.UseVisualStyleBackColor = false;
            OpenBT.Click += OpenBT_Click;
            // 
            // SaveBT
            // 
            SaveBT.BackColor = Color.FromArgb(192, 255, 255);
            SaveBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBT.Location = new Point(785, 90);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(184, 72);
            SaveBT.TabIndex = 2;
            SaveBT.Text = "Сохранить";
            SaveBT.UseVisualStyleBackColor = false;
            SaveBT.Click += SaveBT_Click;
            // 
            // AddBT
            // 
            AddBT.BackColor = SystemColors.GradientActiveCaption;
            AddBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBT.Location = new Point(785, 168);
            AddBT.Name = "AddBT";
            AddBT.Size = new Size(184, 72);
            AddBT.TabIndex = 3;
            AddBT.Text = "Добавить";
            AddBT.UseVisualStyleBackColor = false;
            AddBT.Click += AddBT_Click;
            // 
            // DeleteBT
            // 
            DeleteBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBT.Location = new Point(785, 246);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(184, 72);
            DeleteBT.TabIndex = 4;
            DeleteBT.Text = "Удалить";
            DeleteBT.UseVisualStyleBackColor = true;
            DeleteBT.Click += DeleteBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 450);
            Controls.Add(DeleteBT);
            Controls.Add(AddBT);
            Controls.Add(SaveBT);
            Controls.Add(OpenBT);
            Controls.Add(DGV);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Открыть";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV;
        private Button OpenBT;
        private Button SaveBT;
        private Button AddBT;
        private Button DeleteBT;
    }
}