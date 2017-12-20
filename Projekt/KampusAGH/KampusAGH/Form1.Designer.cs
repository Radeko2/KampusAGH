namespace KampusAGH
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.navigate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.aghMap = new System.Windows.Forms.Button();
            this.agh_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 13;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1063, 518);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 15D;
            this.gMapControl1.DoubleClick += new System.EventHandler(this.gMapControl1_DoubleClick);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // navigate
            // 
            this.navigate.Location = new System.Drawing.Point(1180, 95);
            this.navigate.Name = "navigate";
            this.navigate.Size = new System.Drawing.Size(75, 23);
            this.navigate.TabIndex = 1;
            this.navigate.Text = "Navigate";
            this.navigate.UseVisualStyleBackColor = true;
            this.navigate.Click += new System.EventHandler(this.navigate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1108, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1108, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 22);
            this.textBox2.TabIndex = 3;
            // 
            // aghMap
            // 
            this.aghMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aghMap.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.aghMap.Location = new System.Drawing.Point(1108, 474);
            this.aghMap.Name = "aghMap";
            this.aghMap.Size = new System.Drawing.Size(72, 56);
            this.aghMap.TabIndex = 4;
            this.aghMap.Text = "AHG Plan";
            this.aghMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aghMap.UseVisualStyleBackColor = true;
            this.aghMap.Click += new System.EventHandler(this.aghMap_Click);
            // 
            // agh_button
            // 
            this.agh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agh_button.BackgroundImage")));
            this.agh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agh_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.agh_button.Location = new System.Drawing.Point(1328, 427);
            this.agh_button.Name = "agh_button";
            this.agh_button.Size = new System.Drawing.Size(65, 103);
            this.agh_button.TabIndex = 5;
            this.agh_button.UseVisualStyleBackColor = true;
            this.agh_button.Click += new System.EventHandler(this.agh_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1063, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.agh_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.navigate);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.aghMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button navigate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button aghMap;
        private System.Windows.Forms.Button agh_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

