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
            panel1 = new Panel();
            dataGridViewAll = new DataGridView();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(flowLayoutPanelButtons);
            panelMain.Dock = DockStyle.Bottom;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1261, 610);
            panelMain.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewAll);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 524);
            panel1.TabIndex = 1;
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAll.BackgroundColor = Color.White;
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Dock = DockStyle.Fill;
            dataGridViewAll.Location = new Point(0, 0);
            dataGridViewAll.MultiSelect = false;
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.ReadOnly = true;
            dataGridViewAll.Size = new Size(1261, 524);
            dataGridViewAll.TabIndex = 0;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(button1);
            flowLayoutPanelButtons.Controls.Add(button2);
            flowLayoutPanelButtons.Controls.Add(button3);
            flowLayoutPanelButtons.Dock = DockStyle.Top;
            flowLayoutPanelButtons.Location = new Point(0, 0);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(10);
            flowLayoutPanelButtons.Size = new Size(1261, 86);
            flowLayoutPanelButtons.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Size = new Size(162, 42);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(181, 13);
            button2.Name = "button2";
            button2.Size = new Size(162, 42);
            button2.TabIndex = 1;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(349, 13);
            button3.Name = "button3";
            button3.Size = new Size(162, 42);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1261, 610);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Form1";
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private DataGridView dataGridViewAll;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
