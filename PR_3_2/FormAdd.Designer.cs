namespace PR_3_2
{
    partial class FormAdd
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
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonDelete = new Button();
            buttonSave = new Button();
            panelFill = new Panel();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(buttonDelete);
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(0, 413);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(456, 76);
            flowLayoutPanelBottom.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Location = new Point(286, 13);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(147, 40);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.Location = new Point(133, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(147, 40);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(456, 413);
            panelFill.TabIndex = 1;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(456, 489);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormAdd";
            Text = "Добавление записи";
            flowLayoutPanelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button buttonDelete;
        private Button buttonSave;
        private Panel panelFill;
    }
}