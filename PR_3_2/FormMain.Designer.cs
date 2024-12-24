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
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1032, 81);
            panelButtons.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(14, 15);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(102, 50);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
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
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private Panel panelButtons;
        private Button buttonSave;
        private DataGridView dataGridViewAll;
    }
}
