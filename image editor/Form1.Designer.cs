namespace image_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.ellipseRadioButton = new System.Windows.Forms.RadioButton();
            this.rulerRadioButton = new System.Windows.Forms.RadioButton();
            this.penRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.colorPictureBox2 = new System.Windows.Forms.PictureBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.transparentLabel = new System.Windows.Forms.Label();
            this.transparentCheckBox = new System.Windows.Forms.CheckBox();
            this.fontButton = new System.Windows.Forms.Button();
            this.xyLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.previewPictureBox2 = new System.Windows.Forms.PictureBox();
            this.modeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.newButton.Location = new System.Drawing.Point(14, 13);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(136, 34);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.openButton.Location = new System.Drawing.Point(14, 53);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(136, 34);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.saveButton.Location = new System.Drawing.Point(14, 93);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 34);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.clearButton.Location = new System.Drawing.Point(14, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 34);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Controls.Add(this.rectangleRadioButton);
            this.modeGroupBox.Controls.Add(this.textRadioButton);
            this.modeGroupBox.Controls.Add(this.ellipseRadioButton);
            this.modeGroupBox.Controls.Add(this.rulerRadioButton);
            this.modeGroupBox.Controls.Add(this.penRadioButton);
            this.modeGroupBox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeGroupBox.Location = new System.Drawing.Point(14, 187);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Size = new System.Drawing.Size(136, 450);
            this.modeGroupBox.TabIndex = 4;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Mode";
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(7, 123);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(102, 23);
            this.rectangleRadioButton.TabIndex = 5;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.Text = "Rectangle";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Location = new System.Drawing.Point(7, 152);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(56, 23);
            this.textRadioButton.TabIndex = 4;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "Text";
            this.textRadioButton.UseVisualStyleBackColor = true;
            // 
            // ellipseRadioButton
            // 
            this.ellipseRadioButton.AutoSize = true;
            this.ellipseRadioButton.Location = new System.Drawing.Point(6, 92);
            this.ellipseRadioButton.Name = "ellipseRadioButton";
            this.ellipseRadioButton.Size = new System.Drawing.Size(71, 23);
            this.ellipseRadioButton.TabIndex = 2;
            this.ellipseRadioButton.TabStop = true;
            this.ellipseRadioButton.Text = "Ellipse";
            this.ellipseRadioButton.UseVisualStyleBackColor = true;
            this.ellipseRadioButton.CheckedChanged += new System.EventHandler(this.ellipseRadioButton_CheckedChanged);
            // 
            // rulerRadioButton
            // 
            this.rulerRadioButton.AutoSize = true;
            this.rulerRadioButton.Location = new System.Drawing.Point(7, 61);
            this.rulerRadioButton.Name = "rulerRadioButton";
            this.rulerRadioButton.Size = new System.Drawing.Size(64, 23);
            this.rulerRadioButton.TabIndex = 1;
            this.rulerRadioButton.TabStop = true;
            this.rulerRadioButton.Text = "Ruler";
            this.rulerRadioButton.UseVisualStyleBackColor = true;
            // 
            // penRadioButton
            // 
            this.penRadioButton.AutoSize = true;
            this.penRadioButton.Location = new System.Drawing.Point(7, 30);
            this.penRadioButton.Name = "penRadioButton";
            this.penRadioButton.Size = new System.Drawing.Size(56, 23);
            this.penRadioButton.TabIndex = 0;
            this.penRadioButton.TabStop = true;
            this.penRadioButton.Text = "Pen";
            this.penRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackColor = System.Drawing.Color.Black;
            this.previewPictureBox.Location = new System.Drawing.Point(18, 647);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(132, 81);
            this.previewPictureBox.TabIndex = 7;
            this.previewPictureBox.TabStop = false;
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.Controls.Add(this.pictureBox1);
            this.pictureBoxPanel.Location = new System.Drawing.Point(168, 13);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(1128, 624);
            this.pictureBoxPanel.TabIndex = 8;
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BackColor = System.Drawing.Color.White;
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPictureBox.Location = new System.Drawing.Point(182, 647);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(66, 61);
            this.colorPictureBox.TabIndex = 9;
            this.colorPictureBox.TabStop = false;
            this.colorPictureBox.BackColorChanged += new System.EventHandler(this.colorPictureBox_BackColorChanged);
            this.colorPictureBox.Click += new System.EventHandler(this.colorPictureBox_Click);
            // 
            // colorPictureBox2
            // 
            this.colorPictureBox2.BackColor = System.Drawing.Color.Black;
            this.colorPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPictureBox2.Location = new System.Drawing.Point(205, 667);
            this.colorPictureBox2.Name = "colorPictureBox2";
            this.colorPictureBox2.Size = new System.Drawing.Size(66, 61);
            this.colorPictureBox2.TabIndex = 10;
            this.colorPictureBox2.TabStop = false;
            this.colorPictureBox2.BackColorChanged += new System.EventHandler(this.colorPictureBox2_BackColorChanged);
            this.colorPictureBox2.Click += new System.EventHandler(this.colorPictureBox2_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(315, 684);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(55, 19);
            this.widthLabel.TabIndex = 11;
            this.widthLabel.Text = "Width:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(666, 684);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(39, 19);
            this.textLabel.TabIndex = 12;
            this.textLabel.Text = "Text:";
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.widthNumericUpDown.Location = new System.Drawing.Point(383, 681);
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(51, 24);
            this.widthNumericUpDown.TabIndex = 13;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(728, 681);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(114, 24);
            this.textTextBox.TabIndex = 14;
            // 
            // transparentLabel
            // 
            this.transparentLabel.AutoSize = true;
            this.transparentLabel.Location = new System.Drawing.Point(495, 686);
            this.transparentLabel.Name = "transparentLabel";
            this.transparentLabel.Size = new System.Drawing.Size(93, 19);
            this.transparentLabel.TabIndex = 15;
            this.transparentLabel.Text = "Transparent:";
            // 
            // transparentCheckBox
            // 
            this.transparentCheckBox.AutoSize = true;
            this.transparentCheckBox.Location = new System.Drawing.Point(587, 688);
            this.transparentCheckBox.Name = "transparentCheckBox";
            this.transparentCheckBox.Size = new System.Drawing.Size(18, 17);
            this.transparentCheckBox.TabIndex = 16;
            this.transparentCheckBox.UseVisualStyleBackColor = true;
            this.transparentCheckBox.CheckedChanged += new System.EventHandler(this.transparentCheckBox_CheckedChanged);
            // 
            // fontButton
            // 
            this.fontButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.fontButton.Location = new System.Drawing.Point(867, 680);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(114, 24);
            this.fontButton.TabIndex = 17;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // xyLabel
            // 
            this.xyLabel.AutoSize = true;
            this.xyLabel.Location = new System.Drawing.Point(1174, 687);
            this.xyLabel.Name = "xyLabel";
            this.xyLabel.Size = new System.Drawing.Size(37, 19);
            this.xyLabel.TabIndex = 18;
            this.xyLabel.Text = "X,Y: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png|*.gif|*.gif";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.White;
            this.colorDialog1.FullOpen = true;
            // 
            // previewPictureBox2
            // 
            this.previewPictureBox2.BackColor = System.Drawing.Color.White;
            this.previewPictureBox2.Location = new System.Drawing.Point(27, 655);
            this.previewPictureBox2.Name = "previewPictureBox2";
            this.previewPictureBox2.Size = new System.Drawing.Size(113, 65);
            this.previewPictureBox2.TabIndex = 19;
            this.previewPictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1308, 747);
            this.Controls.Add(this.previewPictureBox2);
            this.Controls.Add(this.xyLabel);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.transparentCheckBox);
            this.Controls.Add(this.transparentLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.colorPictureBox);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.modeGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.colorPictureBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Editor";
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.pictureBoxPanel.ResumeLayout(false);
            this.pictureBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton textRadioButton;
        private System.Windows.Forms.RadioButton ellipseRadioButton;
        private System.Windows.Forms.RadioButton rulerRadioButton;
        private System.Windows.Forms.RadioButton penRadioButton;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.PictureBox colorPictureBox2;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label transparentLabel;
        private System.Windows.Forms.CheckBox transparentCheckBox;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Label xyLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox previewPictureBox2;
    }
}

