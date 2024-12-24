namespace PR_3_2
{
    partial class FormMain
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
            panelMain = new Panel();
            dataGridViewAll = new DataGridView();
            panelButtons = new Panel();
            button2 = new Button();
            button1 = new Button();
            buttonSave = new Button();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dataGridViewAll);
            panelMain.Dock = DockStyle.Bottom;
            panelMain.Location = new Point(0, 87);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(10);
            panelMain.Size = new Size(1032, 518);
            panelMain.TabIndex = 3;
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.BackgroundColor = Color.White;
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Dock = DockStyle.Fill;
            dataGridViewAll.Location = new Point(10, 10);
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.Size = new Size(1012, 498);
            dataGridViewAll.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1032, 81);
            panelButtons.TabIndex = 4;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.White;
            button2.Location = new Point(122, 15);
            button2.Name = "button2";
            button2.Size = new Size(127, 50);
            button2.TabIndex = 2;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.Location = new Point(255, 15);
            button1.Name = "button1";
            button1.Size = new Size(102, 50);
            button1.TabIndex = 1;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.BackColor = Color.White;
            buttonSave.Location = new Point(14, 15);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(102, 50);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 605);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Form1";
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private Panel panelButtons;
        private Button buttonSave;
        private DataGridView dataGridViewAll;
        private Button button2;
        private Button button1;
    }
}
