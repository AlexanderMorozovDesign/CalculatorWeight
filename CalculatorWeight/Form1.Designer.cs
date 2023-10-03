namespace CalculatorWeight
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
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelShelfThickness = new System.Windows.Forms.Label();
            this.numericUpDownShelfThickness = new System.Windows.Forms.NumericUpDown();
            this.labelWidthOutside = new System.Windows.Forms.Label();
            this.numericUpDownWidthOutside = new System.Windows.Forms.NumericUpDown();
            this.labelHeightOutside = new System.Windows.Forms.Label();
            this.numericUpDownHeightOutside = new System.Windows.Forms.NumericUpDown();
            this.labelWallThickness = new System.Windows.Forms.Label();
            this.numericUpDownWallThickness = new System.Windows.Forms.NumericUpDown();
            this.labelDiameter = new System.Windows.Forms.Label();
            this.numericUpDownDiameter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDensity = new System.Windows.Forms.NumericUpDown();
            this.buttonResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShelfThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidthOutside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightOutside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Масса кг";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(16, 241);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(257, 29);
            this.textBoxResult.TabIndex = 34;
            // 
            // labelShelfThickness
            // 
            this.labelShelfThickness.AutoSize = true;
            this.labelShelfThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShelfThickness.Location = new System.Drawing.Point(290, 218);
            this.labelShelfThickness.Name = "labelShelfThickness";
            this.labelShelfThickness.Size = new System.Drawing.Size(152, 20);
            this.labelShelfThickness.TabIndex = 33;
            this.labelShelfThickness.Text = "Толщина полки мм";
            this.labelShelfThickness.Visible = false;
            // 
            // numericUpDownShelfThickness
            // 
            this.numericUpDownShelfThickness.DecimalPlaces = 2;
            this.numericUpDownShelfThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownShelfThickness.Location = new System.Drawing.Point(294, 241);
            this.numericUpDownShelfThickness.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownShelfThickness.MinimumSize = new System.Drawing.Size(228, 0);
            this.numericUpDownShelfThickness.Name = "numericUpDownShelfThickness";
            this.numericUpDownShelfThickness.Size = new System.Drawing.Size(258, 29);
            this.numericUpDownShelfThickness.TabIndex = 32;
            this.numericUpDownShelfThickness.Visible = false;
            // 
            // labelWidthOutside
            // 
            this.labelWidthOutside.AutoSize = true;
            this.labelWidthOutside.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidthOutside.Location = new System.Drawing.Point(289, 79);
            this.labelWidthOutside.Name = "labelWidthOutside";
            this.labelWidthOutside.Size = new System.Drawing.Size(233, 20);
            this.labelWidthOutside.TabIndex = 31;
            this.labelWidthOutside.Text = "Ширина по внешней грани мм";
            this.labelWidthOutside.Visible = false;
            // 
            // numericUpDownWidthOutside
            // 
            this.numericUpDownWidthOutside.DecimalPlaces = 2;
            this.numericUpDownWidthOutside.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownWidthOutside.Location = new System.Drawing.Point(292, 102);
            this.numericUpDownWidthOutside.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownWidthOutside.Name = "numericUpDownWidthOutside";
            this.numericUpDownWidthOutside.Size = new System.Drawing.Size(258, 29);
            this.numericUpDownWidthOutside.TabIndex = 30;
            this.numericUpDownWidthOutside.Visible = false;
            // 
            // labelHeightOutside
            // 
            this.labelHeightOutside.AutoSize = true;
            this.labelHeightOutside.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeightOutside.Location = new System.Drawing.Point(290, 9);
            this.labelHeightOutside.Name = "labelHeightOutside";
            this.labelHeightOutside.Size = new System.Drawing.Size(232, 20);
            this.labelHeightOutside.TabIndex = 29;
            this.labelHeightOutside.Text = "Высота по внешней грани мм";
            this.labelHeightOutside.Visible = false;
            // 
            // numericUpDownHeightOutside
            // 
            this.numericUpDownHeightOutside.DecimalPlaces = 2;
            this.numericUpDownHeightOutside.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHeightOutside.Location = new System.Drawing.Point(294, 32);
            this.numericUpDownHeightOutside.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownHeightOutside.Name = "numericUpDownHeightOutside";
            this.numericUpDownHeightOutside.Size = new System.Drawing.Size(258, 29);
            this.numericUpDownHeightOutside.TabIndex = 28;
            this.numericUpDownHeightOutside.Visible = false;
            // 
            // labelWallThickness
            // 
            this.labelWallThickness.AutoSize = true;
            this.labelWallThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWallThickness.Location = new System.Drawing.Point(290, 148);
            this.labelWallThickness.Name = "labelWallThickness";
            this.labelWallThickness.Size = new System.Drawing.Size(159, 20);
            this.labelWallThickness.TabIndex = 27;
            this.labelWallThickness.Text = "Толщина стенки мм";
            // 
            // numericUpDownWallThickness
            // 
            this.numericUpDownWallThickness.DecimalPlaces = 2;
            this.numericUpDownWallThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownWallThickness.Location = new System.Drawing.Point(294, 171);
            this.numericUpDownWallThickness.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownWallThickness.MinimumSize = new System.Drawing.Size(228, 0);
            this.numericUpDownWallThickness.Name = "numericUpDownWallThickness";
            this.numericUpDownWallThickness.Size = new System.Drawing.Size(258, 29);
            this.numericUpDownWallThickness.TabIndex = 26;
            // 
            // labelDiameter
            // 
            this.labelDiameter.AutoSize = true;
            this.labelDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiameter.Location = new System.Drawing.Point(288, 9);
            this.labelDiameter.Name = "labelDiameter";
            this.labelDiameter.Size = new System.Drawing.Size(103, 20);
            this.labelDiameter.TabIndex = 25;
            this.labelDiameter.Text = "Диаметр мм";
            // 
            // numericUpDownDiameter
            // 
            this.numericUpDownDiameter.DecimalPlaces = 2;
            this.numericUpDownDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDiameter.Location = new System.Drawing.Point(294, 32);
            this.numericUpDownDiameter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDiameter.MinimumSize = new System.Drawing.Size(228, 0);
            this.numericUpDownDiameter.Name = "numericUpDownDiameter";
            this.numericUpDownDiameter.Size = new System.Drawing.Size(258, 29);
            this.numericUpDownDiameter.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Тип профиля";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Круглая полая",
            "Круглая сплошная",
            "Прямоугольная полая",
            "Прямоугольная сплошная"});
            this.comboBoxType.Location = new System.Drawing.Point(16, 171);
            this.comboBoxType.MinimumSize = new System.Drawing.Size(228, 0);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(258, 32);
            this.comboBoxType.TabIndex = 22;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Длина м";
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.DecimalPlaces = 2;
            this.numericUpDownLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownLength.Location = new System.Drawing.Point(16, 102);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownLength.MinimumSize = new System.Drawing.Size(228, 0);
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(258, 29);
            this.numericUpDownLength.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Плотность кг/м³";
            // 
            // numericUpDownDensity
            // 
            this.numericUpDownDensity.DecimalPlaces = 2;
            this.numericUpDownDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDensity.Location = new System.Drawing.Point(16, 32);
            this.numericUpDownDensity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDensity.MinimumSize = new System.Drawing.Size(228, 0);
            this.numericUpDownDensity.Name = "numericUpDownDensity";
            this.numericUpDownDensity.Size = new System.Drawing.Size(258, 29);
            this.numericUpDownDensity.TabIndex = 18;
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(16, 287);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(257, 35);
            this.buttonResult.TabIndex = 36;
            this.buttonResult.Text = "Расчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 341);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelShelfThickness);
            this.Controls.Add(this.numericUpDownShelfThickness);
            this.Controls.Add(this.labelWidthOutside);
            this.Controls.Add(this.numericUpDownWidthOutside);
            this.Controls.Add(this.labelHeightOutside);
            this.Controls.Add(this.numericUpDownHeightOutside);
            this.Controls.Add(this.labelWallThickness);
            this.Controls.Add(this.numericUpDownWallThickness);
            this.Controls.Add(this.labelDiameter);
            this.Controls.Add(this.numericUpDownDiameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDensity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(580, 380);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор веса";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShelfThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidthOutside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightOutside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelShelfThickness;
        private System.Windows.Forms.NumericUpDown numericUpDownShelfThickness;
        private System.Windows.Forms.Label labelWidthOutside;
        private System.Windows.Forms.NumericUpDown numericUpDownWidthOutside;
        private System.Windows.Forms.Label labelHeightOutside;
        private System.Windows.Forms.NumericUpDown numericUpDownHeightOutside;
        private System.Windows.Forms.Label labelWallThickness;
        private System.Windows.Forms.NumericUpDown numericUpDownWallThickness;
        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.NumericUpDown numericUpDownDiameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDensity;
        private System.Windows.Forms.Button buttonResult;
    }
}

