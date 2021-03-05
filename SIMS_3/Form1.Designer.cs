
namespace SIMS_3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeValueLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.weightLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(598, 55);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(156, 35);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Пауза";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timeValueLabel
            // 
            this.timeValueLabel.AutoSize = true;
            this.timeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeValueLabel.Location = new System.Drawing.Point(456, 38);
            this.timeValueLabel.Name = "timeValueLabel";
            this.timeValueLabel.Size = new System.Drawing.Size(96, 25);
            this.timeValueLabel.TabIndex = 9;
            this.timeValueLabel.Text = "0.00.000";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(377, 38);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(82, 25);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Время:";
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runButton.Location = new System.Drawing.Point(598, 11);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(156, 35);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Полетели";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(93, 70);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(96, 20);
            this.edSpeed.TabIndex = 6;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(93, 43);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(96, 20);
            this.edHeight.TabIndex = 5;
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(93, 14);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(96, 20);
            this.edAngle.TabIndex = 4;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.sizeLabel);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.weightLabel);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.timeValueLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.speedLabel);
            this.panel1.Controls.Add(this.heightLabel);
            this.panel1.Controls.Add(this.angleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 101);
            this.panel1.TabIndex = 2;
            // 
            // edSize
            // 
            this.edSize.DecimalPlaces = 2;
            this.edSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.edSize.Location = new System.Drawing.Point(271, 43);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(96, 20);
            this.edSize.TabIndex = 14;
            this.edSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(214, 45);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(45, 13);
            this.sizeLabel.TabIndex = 13;
            this.sizeLabel.Text = "Объём:";
            // 
            // edWeight
            // 
            this.edWeight.DecimalPlaces = 2;
            this.edWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.edWeight.Location = new System.Drawing.Point(271, 14);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(96, 20);
            this.edWeight.TabIndex = 12;
            this.edWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(214, 16);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(29, 13);
            this.weightLabel.TabIndex = 11;
            this.weightLabel.Text = "Вес:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(36, 72);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(58, 13);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "Скорость:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(36, 45);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(48, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Высота:";
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(36, 16);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(35, 13);
            this.angleLabel.TabIndex = 0;
            this.angleLabel.Text = "Угол:";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea19.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea19);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 101);
            this.chart1.Name = "chart1";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Name = "Series1";
            this.chart1.Series.Add(series19);
            this.chart1.Size = new System.Drawing.Size(800, 349);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label timeValueLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.Label weightLabel;
    }
}

