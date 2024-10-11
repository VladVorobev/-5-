namespace модуль_5_воробьёв
{
    partial class DrawingAppForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button btnDrawRectangle;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.btnDrawRectangle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(9, 10);
            this.canvas.Margin = new System.Windows.Forms.Padding(2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(375, 325);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackColor = System.Drawing.Color.LightBlue;
            this.btnDrawLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawLine.FlatAppearance.BorderSize = 0;
            this.btnDrawLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawLine.ForeColor = System.Drawing.Color.Black;
            this.btnDrawLine.Location = new System.Drawing.Point(398, 24);
            this.btnDrawLine.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(90, 24);
            this.btnDrawLine.TabIndex = 1;
            this.btnDrawLine.Text = "Нарисовать линию";
            this.btnDrawLine.UseVisualStyleBackColor = false;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.BackColor = System.Drawing.Color.LightGreen;
            this.btnDrawCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawCircle.FlatAppearance.BorderSize = 0;
            this.btnDrawCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawCircle.ForeColor = System.Drawing.Color.Black;
            this.btnDrawCircle.Location = new System.Drawing.Point(398, 65);
            this.btnDrawCircle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(90, 24);
            this.btnDrawCircle.TabIndex = 2;
            this.btnDrawCircle.Text = "Нарисовать круг";
            this.btnDrawCircle.UseVisualStyleBackColor = false;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // btnDrawRectangle
            // 
            this.btnDrawRectangle.BackColor = System.Drawing.Color.LightCoral;
            this.btnDrawRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawRectangle.FlatAppearance.BorderSize = 0;
            this.btnDrawRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawRectangle.ForeColor = System.Drawing.Color.Black;
            this.btnDrawRectangle.Location = new System.Drawing.Point(398, 106);
            this.btnDrawRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrawRectangle.Name = "btnDrawRectangle";
            this.btnDrawRectangle.Size = new System.Drawing.Size(90, 24);
            this.btnDrawRectangle.TabIndex = 3;
            this.btnDrawRectangle.Text = "Нарисовать прямоугольник";
            this.btnDrawRectangle.UseVisualStyleBackColor = false;
            this.btnDrawRectangle.Click += new System.EventHandler(this.btnDrawRectangle_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(398, 146);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить холст";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DrawingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::модуль_5_воробьёв.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 350);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDrawRectangle);
            this.Controls.Add(this.btnDrawCircle);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DrawingAppForm";
            this.Text = "Приложение для рисования";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }
    }
}