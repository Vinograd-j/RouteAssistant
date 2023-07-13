namespace RouteAssistant
{
    partial class ApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.TitleText = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Label();
            this.CityField = new System.Windows.Forms.TextBox();
            this.SearchCoords = new System.Windows.Forms.Button();
            this.InfoCityCordsText = new System.Windows.Forms.Label();
            this.CoordsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(12, 98);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 2;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(1335, 594);
            this.Map.TabIndex = 0;
            this.Map.Zoom = 0D;
            this.Map.Load += new System.EventHandler(this.GmapInitialize);
            this.Map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MapDoubleClick);
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.BackColor = System.Drawing.Color.Transparent;
            this.TitleText.Font = new System.Drawing.Font("Microsoft YaHei", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TitleText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleText.Location = new System.Drawing.Point(575, 9);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(432, 70);
            this.TitleText.TabIndex = 1;
            this.TitleText.Text = "RouteAssistant\r\n";
            this.TitleText.Click += new System.EventHandler(this.TitleText_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1353, 112);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(205, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Сбросить все маршруты и маркеры";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.OnResetButtonClicked);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(9, 9);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(291, 13);
            this.author.TabIndex = 4;
            this.author.Text = "Developed by Vinograd (Egor) for Cumputer Science Lesson";
            // 
            // CityField
            // 
            this.CityField.Location = new System.Drawing.Point(1368, 261);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(166, 20);
            this.CityField.TabIndex = 5;
            // 
            // SearchCoords
            // 
            this.SearchCoords.Location = new System.Drawing.Point(1414, 287);
            this.SearchCoords.Name = "SearchCoords";
            this.SearchCoords.Size = new System.Drawing.Size(75, 23);
            this.SearchCoords.TabIndex = 6;
            this.SearchCoords.Text = "Узнать";
            this.SearchCoords.UseVisualStyleBackColor = true;
            this.SearchCoords.Click += new System.EventHandler(this.OnSearchCoordsButtonClick);
            // 
            // InfoCityCordsText
            // 
            this.InfoCityCordsText.AutoSize = true;
            this.InfoCityCordsText.Location = new System.Drawing.Point(1379, 234);
            this.InfoCityCordsText.Name = "InfoCityCordsText";
            this.InfoCityCordsText.Size = new System.Drawing.Size(146, 13);
            this.InfoCityCordsText.TabIndex = 7;
            this.InfoCityCordsText.Text = "Узнать координаты города";
            // 
            // CoordsOutput
            // 
            this.CoordsOutput.AutoSize = true;
            this.CoordsOutput.Location = new System.Drawing.Point(1365, 328);
            this.CoordsOutput.Name = "CoordsOutput";
            this.CoordsOutput.Size = new System.Drawing.Size(0, 13);
            this.CoordsOutput.TabIndex = 8;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1570, 722);
            this.Controls.Add(this.CoordsOutput);
            this.Controls.Add(this.InfoCityCordsText);
            this.Controls.Add(this.SearchCoords);
            this.Controls.Add(this.CityField);
            this.Controls.Add(this.author);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.Map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationForm";
            this.Text = "RouteAssistant";
            this.Load += new System.EventHandler(this.LoadForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.Button SearchCoords;
        private System.Windows.Forms.Label InfoCityCordsText;
        private System.Windows.Forms.Label CoordsOutput;
    }
}

