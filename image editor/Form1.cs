using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace image_editor
{
    public partial class Form1 : Form
    {
        int PreviousX = 0;
        int PreviousY = 0;

        bool mouseDown = false;
        public Form1()
        {
            InitializeComponent();

            saveButton.Enabled = false;
            clearButton.Enabled = false;
            modeGroupBox.Enabled = false;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewImage newImage = new NewImage(pictureBoxPanel);
            newImage.ShowDialog();

            if (newImage.DialogResult == DialogResult.OK)
            {
                Image image = new Bitmap(newImage.getWidth(), newImage.getHeight());

                Graphics g = Graphics.FromImage(image);
                g.Clear(Color.White);
                g.Dispose();

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose(); // освободим предыдущий объект Image
                }

                pictureBox1.Image = image; // поместим на PictureBox выбранное изображение

                saveButton.Enabled = true;
                clearButton.Enabled = true;
                modeGroupBox.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstFileName = saveFileDialog1.FileName;

            FileInfo fileInfo = new FileInfo(firstFileName);

            saveFileDialog1.FileName = fileInfo.Name;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string secondFileName = saveFileDialog1.FileName;

                if (secondFileName.ToUpper() == firstFileName.ToUpper())// если пытаемся сохранять изображение в тот же файл, из которого загружали
                {
                    //сохраним изображение во временный файл
                    firstFileName = Path.GetDirectoryName(firstFileName) + "\\($$##$$)";
                    pictureBox1.Image.Save(firstFileName);

                    //разрушим объект Bitmap, связанный с данным изображением 
                    pictureBox1.Image.Dispose();

                    // удалим исходный файл
                    File.Delete(secondFileName);

                    //имя временного файла заменим на имя исходного файла
                    File.Move(firstFileName, secondFileName);

                    // загрузим на PictureBox новый вариант файла
                    pictureBox1.Image = new Bitmap(secondFileName);
                }
                else if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(secondFileName);  //сохраним изображение в файл
                }

                Text = "Image Editor - " + secondFileName;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;

                try
                {
                    Image image = new Bitmap(fileName); // присоединим изображение из указанного файла к объекту Bitmap
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose(); // освободим предыдущий объект Image
                    }
                    pictureBox1.Image = image; // поместим на PictureBox выбранное изображение

                    saveButton.Enabled = true;
                    clearButton.Enabled = true;
                    modeGroupBox.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                Text = "Image Viewer - " + fileName;
                saveFileDialog1.FileName = fileName;
                openFileDialog1.FileName = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

            Graphics g = Graphics.FromImage(image);
            g.Clear(colorPictureBox2.BackColor);
            g.Dispose();

            pictureBox1.Image = image;
        }

        private void colorPictureBox_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = colorPictureBox.BackColor;
            colorDialog1.ShowDialog();
            colorPictureBox.BackColor = colorDialog1.Color;
        }

        private void colorPictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = colorPictureBox2.BackColor;
            colorDialog1.ShowDialog();
            colorPictureBox2.BackColor = colorDialog1.Color;
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textTextBox.Font = fontDialog1.Font;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (rulerRadioButton.Checked == true)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                Pen pen = new Pen(colorPictureBox.BackColor, (float)widthNumericUpDown.Value);

                g.DrawLine(pen, PreviousX, PreviousY, pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y);

                pictureBox1.Invalidate();

                g.Dispose();


            }
            else if (textRadioButton.Checked == true)
            {
                SolidBrush solidBrush = new SolidBrush(colorPictureBox.BackColor);

                Font f = fontDialog1.Font;

                Graphics g = Graphics.FromImage(pictureBox1.Image);

                Point p = pictureBox1.PointToClient(Cursor.Position);

                g.DrawString(textTextBox.Text, f, solidBrush, p);

                pictureBox1.Invalidate();

                g.Dispose();
            }
            else if (ellipseRadioButton.Checked == true || rectangleRadioButton.Checked == true)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                if (transparentCheckBox.Checked != true) //непрозрачный внутри
                {
                    SolidBrush solidBrush = new SolidBrush(colorPictureBox.BackColor);

                    if (ellipseRadioButton.Checked == true)
                    {
                        g.FillEllipse(solidBrush, pictureBox1.PointToClient(Cursor.Position).X - 50, pictureBox1.PointToClient(Cursor.Position).Y - 50, 100, 100);
                    }
                    else
                    {
                        g.FillRectangle(solidBrush, pictureBox1.PointToClient(Cursor.Position).X - 50, pictureBox1.PointToClient(Cursor.Position).Y - 50, 100, 100);
                    }
                }

                Pen pen = new Pen(colorPictureBox2.BackColor, (float)widthNumericUpDown.Value);

                if (ellipseRadioButton.Checked == true)
                {
                    g.DrawEllipse(pen, pictureBox1.PointToClient(Cursor.Position).X - 50, pictureBox1.PointToClient(Cursor.Position).Y - 50, 100, 100);
                }
                else
                {
                    g.DrawRectangle(pen, pictureBox1.PointToClient(Cursor.Position).X - 50, pictureBox1.PointToClient(Cursor.Position).Y - 50, 100, 100);
                }

                pictureBox1.Invalidate();

                g.Dispose();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            xyLabel.Text = "X,Y: " + pictureBox1.PointToClient(Cursor.Position).X + ", " + pictureBox1.PointToClient(Cursor.Position).Y;

            if (penRadioButton.Checked == true && mouseDown == true)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                SolidBrush solidBrush = new SolidBrush(colorPictureBox.BackColor);

                if ((float)widthNumericUpDown.Value != 1)
                {
                    g.FillEllipse(solidBrush, pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y, (float)widthNumericUpDown.Value, (float)widthNumericUpDown.Value);
                }
                else
                {
                    g.FillEllipse(solidBrush, pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y, 2, 2);
                }
                pictureBox1.Invalidate();

                g.Dispose();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rulerRadioButton.Checked == true)
            {
                PreviousX = pictureBox1.PointToClient(Cursor.Position).X;
                PreviousY = pictureBox1.PointToClient(Cursor.Position).Y;
            }
            if (penRadioButton.Checked == true)
            {
                mouseDown = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (penRadioButton.Checked == true)
            {
                mouseDown = false;
            }
        }

        private void colorPictureBox_BackColorChanged(object sender, EventArgs e)
        {
            previewPictureBox2.BackColor = colorPictureBox.BackColor;
        }

        private void colorPictureBox2_BackColorChanged(object sender, EventArgs e)
        {
            previewPictureBox.BackColor = colorPictureBox2.BackColor;
        }

        private void transparentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (transparentCheckBox.Checked == true)
            {
                previewPictureBox2.BackColor = Color.Empty;
            }
            else
            {
                previewPictureBox2.BackColor = colorPictureBox.BackColor;
            }
        }

        private void ellipseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ellipseRadioButton.Checked == true)
            {
                System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
                myPath.AddEllipse(0, 0, previewPictureBox.Width, previewPictureBox.Height);
                Region myRegion = new Region(myPath);
                previewPictureBox.Region = myRegion;

                System.Drawing.Drawing2D.GraphicsPath myPath2 = new System.Drawing.Drawing2D.GraphicsPath();
                myPath2.AddEllipse(0, 0, previewPictureBox2.Width, previewPictureBox2.Height);
                Region myRegion2 = new Region(myPath2);
                previewPictureBox2.Region = myRegion2;
            }
            else
            {
                System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
                Rectangle rectangle = new Rectangle(0, 0, previewPictureBox.Width, previewPictureBox.Height);
                myPath.AddRectangle(rectangle);
                Region myRegion = new Region(myPath);
                previewPictureBox.Region = myRegion;

                System.Drawing.Drawing2D.GraphicsPath myPath2 = new System.Drawing.Drawing2D.GraphicsPath();
                Rectangle rectangle2 = new Rectangle(0, 0, previewPictureBox2.Width, previewPictureBox2.Height);
                myPath2.AddRectangle(rectangle2);
                Region myRegion2 = new Region(myPath2);
                previewPictureBox2.Region = myRegion2;
            }
        }
    }
}