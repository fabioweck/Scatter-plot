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
            pnlGraph = new Panel();
            btnAddPlot = new Button();
            groupBox1 = new GroupBox();
            btnRemovePlot = new Button();
            numHoursSelected = new NumericUpDown();
            numAgeSelected = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btnIncreaseSize = new Button();
            btnDecreaseSize = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHoursSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAgeSelected).BeginInit();
            SuspendLayout();
            // 
            // pnlGraph
            // 
            pnlGraph.BackColor = SystemColors.ScrollBar;
            pnlGraph.Location = new Point(260, 71);
            pnlGraph.Name = "pnlGraph";
            pnlGraph.Size = new Size(910, 610);
            pnlGraph.TabIndex = 0;
            // 
            // btnAddPlot
            // 
            btnAddPlot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPlot.ForeColor = SystemColors.ControlDarkDark;
            btnAddPlot.Location = new Point(62, 213);
            btnAddPlot.Name = "btnAddPlot";
            btnAddPlot.Size = new Size(94, 29);
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
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(27, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 292);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Custom plot";
            // 
            // btnRemovePlot
            // 
            btnRemovePlot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemovePlot.ForeColor = SystemColors.ControlDarkDark;
            btnRemovePlot.Location = new Point(62, 248);
            btnRemovePlot.Name = "btnRemovePlot";
            btnRemovePlot.Size = new Size(94, 29);
            btnRemovePlot.TabIndex = 6;
            btnRemovePlot.Text = "Remove";
            btnRemovePlot.UseVisualStyleBackColor = true;
            btnRemovePlot.Click += btnCustomPlot;
            // 
            // numHoursSelected
            // 
            numHoursSelected.DecimalPlaces = 1;
            numHoursSelected.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numHoursSelected.Location = new Point(66, 168);
            numHoursSelected.Name = "numHoursSelected";
            numHoursSelected.Size = new Size(74, 27);
            numHoursSelected.TabIndex = 5;
            numHoursSelected.Value = new decimal(new int[] { 80, 0, 0, 65536 });
            // 
            // numAgeSelected
            // 
            numAgeSelected.Location = new Point(66, 85);
            numAgeSelected.Name = "numAgeSelected";
            numAgeSelected.Size = new Size(74, 27);
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
            btnIncreaseSize.Location = new Point(711, 687);
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
            btnDecreaseSize.Location = new Point(611, 687);
            btnDecreaseSize.Name = "btnDecreaseSize";
            btnDecreaseSize.Size = new Size(94, 54);
            btnDecreaseSize.TabIndex = 4;
            btnDecreaseSize.Text = "-";
            btnDecreaseSize.TextAlign = ContentAlignment.TopCenter;
            btnDecreaseSize.UseVisualStyleBackColor = true;
            btnDecreaseSize.Click += ChangePlotSize;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1182, 753);
            Controls.Add(btnDecreaseSize);
            Controls.Add(btnIncreaseSize);
            Controls.Add(groupBox1);
            Controls.Add(pnlGraph);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHoursSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAgeSelected).EndInit();
            ResumeLayout(false);
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
    }
}