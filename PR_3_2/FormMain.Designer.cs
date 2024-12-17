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
            panelLeft = new Panel();
            panelRightTop = new Panel();
            panelRightBottom = new Panel();
            dataGridViewPartners = new DataGridView();
            dataGridViewProducts = new DataGridView();
            dataGridViewPartnersProducts = new DataGridView();
            panelLeft.SuspendLayout();
            panelRightTop.SuspendLayout();
            panelRightBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(dataGridViewPartners);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 4, 4, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(13, 14, 13, 14);
            panelLeft.Size = new Size(463, 630);
            panelLeft.TabIndex = 0;
            // 
            // panelRightTop
            // 
            panelRightTop.Controls.Add(dataGridViewProducts);
            panelRightTop.Dock = DockStyle.Top;
            panelRightTop.Location = new Point(463, 0);
            panelRightTop.Margin = new Padding(4, 4, 4, 4);
            panelRightTop.Name = "panelRightTop";
            panelRightTop.Padding = new Padding(13, 14, 13, 14);
            panelRightTop.Size = new Size(565, 301);
            panelRightTop.TabIndex = 1;
            // 
            // panelRightBottom
            // 
            panelRightBottom.Controls.Add(dataGridViewPartnersProducts);
            panelRightBottom.Dock = DockStyle.Bottom;
            panelRightBottom.Location = new Point(463, 301);
            panelRightBottom.Margin = new Padding(4, 4, 4, 4);
            panelRightBottom.Name = "panelRightBottom";
            panelRightBottom.Size = new Size(565, 329);
            panelRightBottom.TabIndex = 2;
            // 
            // dataGridViewPartners
            // 
            dataGridViewPartners.BackgroundColor = Color.White;
            dataGridViewPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartners.Location = new Point(12, 12);
            dataGridViewPartners.Name = "dataGridViewPartners";
            dataGridViewPartners.Size = new Size(444, 601);
            dataGridViewPartners.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(7, 12);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(546, 282);
            dataGridViewProducts.TabIndex = 0;
            // 
            // dataGridViewPartnersProducts
            // 
            dataGridViewPartnersProducts.BackgroundColor = Color.White;
            dataGridViewPartnersProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartnersProducts.Location = new Point(7, 7);
            dataGridViewPartnersProducts.Name = "dataGridViewPartnersProducts";
            dataGridViewPartnersProducts.Size = new Size(546, 305);
            dataGridViewPartnersProducts.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1028, 630);
            Controls.Add(panelRightBottom);
            Controls.Add(panelRightTop);
            Controls.Add(panelLeft);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMain";
            Text = "Form1";
            panelLeft.ResumeLayout(false);
            panelRightTop.ResumeLayout(false);
            panelRightBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRightTop;
        private Panel panelRightBottom;
        private DataGridView dataGridViewPartners;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewPartnersProducts;
    }
}
