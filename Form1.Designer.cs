namespace ScatterGraph
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
            components = new System.ComponentModel.Container();
            pnlGraph = new Panel();
            btnReloadData = new Button();
            btnAddPlot = new Button();
            groupBox1 = new GroupBox();
            btnRemovePlot = new Button();
            numHoursSelected = new NumericUpDown();
            numAgeSelected = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btnIncreaseSize = new Button();
            btnDecreaseSize = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            pnlGraph.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHoursSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAgeSelected).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGraph
            // 
            pnlGraph.BackColor = SystemColors.ScrollBar;
            pnlGraph.Controls.Add(btnReloadData);
            pnlGraph.Location = new Point(258, 80);
            pnlGraph.Name = "pnlGraph";
            pnlGraph.Size = new Size(910, 610);
            pnlGraph.TabIndex = 0;
            // 
            // btnReloadData
            // 
            btnReloadData.BackColor = SystemColors.Control;
            btnReloadData.BackgroundImageLayout = ImageLayout.Center;
            btnReloadData.FlatAppearance.BorderColor = Color.White;
            btnReloadData.FlatAppearance.BorderSize = 0;
            btnReloadData.Location = new Point(816, 45);
            btnReloadData.Name = "btnReloadData";
            btnReloadData.Size = new Size(50, 50);
            btnReloadData.TabIndex = 0;
            btnReloadData.UseVisualStyleBackColor = false;
            btnReloadData.Click += btnReloadData_Click;
            // 
            // btnAddPlot
            // 
            btnAddPlot.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPlot.ForeColor = SystemColors.ControlDarkDark;
            btnAddPlot.Location = new Point(58, 217);
            btnAddPlot.Name = "btnAddPlot";
            btnAddPlot.Size = new Size(88, 38);
            btnAddPlot.TabIndex = 1;
            btnAddPlot.Text = "Add";
            btnAddPlot.UseVisualStyleBackColor = true;
            btnAddPlot.Click += btnCustomPlot;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSlateGray;
            groupBox1.Controls.Add(btnRemovePlot);
            groupBox1.Controls.Add(numHoursSelected);
            groupBox1.Controls.Add(numAgeSelected);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddPlot);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(25, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 321);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Custom plot";
            // 
            // btnRemovePlot
            // 
            btnRemovePlot.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemovePlot.ForeColor = SystemColors.ControlDarkDark;
            btnRemovePlot.Location = new Point(58, 261);
            btnRemovePlot.Name = "btnRemovePlot";
            btnRemovePlot.Size = new Size(88, 38);
            btnRemovePlot.TabIndex = 6;
            btnRemovePlot.Text = "Remove";
            btnRemovePlot.UseVisualStyleBackColor = true;
            btnRemovePlot.Click += btnCustomPlot;
            // 
            // numHoursSelected
            // 
            numHoursSelected.DecimalPlaces = 1;
            numHoursSelected.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numHoursSelected.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numHoursSelected.Location = new Point(65, 168);
            numHoursSelected.Name = "numHoursSelected";
            numHoursSelected.Size = new Size(74, 30);
            numHoursSelected.TabIndex = 5;
            numHoursSelected.Value = new decimal(new int[] { 80, 0, 0, 65536 });
            // 
            // numAgeSelected
            // 
            numAgeSelected.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numAgeSelected.Location = new Point(65, 85);
            numAgeSelected.Name = "numAgeSelected";
            numAgeSelected.Size = new Size(74, 30);
            numAgeSelected.TabIndex = 4;
            numAgeSelected.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(62, 128);
            label2.Name = "label2";
            label2.Size = new Size(81, 37);
            label2.TabIndex = 3;
            label2.Text = "Hours";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(72, 45);
            label1.Name = "label1";
            label1.Size = new Size(60, 37);
            label1.TabIndex = 2;
            label1.Text = "Age";
            // 
            // btnIncreaseSize
            // 
            btnIncreaseSize.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIncreaseSize.Location = new Point(709, 696);
            btnIncreaseSize.Name = "btnIncreaseSize";
            btnIncreaseSize.Size = new Size(94, 54);
            btnIncreaseSize.TabIndex = 3;
            btnIncreaseSize.Text = "+";
            btnIncreaseSize.TextAlign = ContentAlignment.TopCenter;
            btnIncreaseSize.UseVisualStyleBackColor = true;
            btnIncreaseSize.Click += ChangePlotSize;
            // 
            // btnDecreaseSize
            // 
            btnDecreaseSize.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecreaseSize.Location = new Point(609, 696);
            btnDecreaseSize.Name = "btnDecreaseSize";
            btnDecreaseSize.Size = new Size(94, 54);
            btnDecreaseSize.TabIndex = 4;
            btnDecreaseSize.Text = "-";
            btnDecreaseSize.TextAlign = ContentAlignment.TopCenter;
            btnDecreaseSize.UseVisualStyleBackColor = true;
            btnDecreaseSize.Click += ChangePlotSize;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1192, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(133, 26);
            closeToolStripMenuItem.Text = "Exit";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1192, 778);
            Controls.Add(btnDecreaseSize);
            Controls.Add(btnIncreaseSize);
            Controls.Add(groupBox1);
            Controls.Add(pnlGraph);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sleep Quality Data";
            pnlGraph.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHoursSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAgeSelected).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlGraph;
        private Button btnAddPlot;
        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numAgeSelected;
        private Label label2;
        private NumericUpDown numHoursSelected;
        private Button btnIncreaseSize;
        private Button btnDecreaseSize;
        private Button btnRemovePlot;
        private Button btnReloadData;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolTip toolTip;
    }
}