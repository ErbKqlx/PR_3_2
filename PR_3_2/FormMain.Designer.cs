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
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
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
            flowLayoutPanelButtons.Controls.Add(buttonAdd);
            flowLayoutPanelButtons.Controls.Add(buttonUpdate);
            flowLayoutPanelButtons.Controls.Add(buttonDelete);
            flowLayoutPanelButtons.Dock = DockStyle.Top;
            flowLayoutPanelButtons.Location = new Point(0, 0);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(10);
            flowLayoutPanelButtons.Size = new Size(1261, 86);
            flowLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Location = new Point(13, 13);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(162, 42);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.White;
            buttonUpdate.Location = new Point(181, 13);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(162, 42);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Location = new Point(349, 13);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(162, 42);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
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
            Text = "Партнеры";
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
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}
