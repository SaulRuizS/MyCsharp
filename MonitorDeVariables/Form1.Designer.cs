namespace MonitorDeVariables
{
    partial class ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana));
            this.dist1 = new System.Windows.Forms.Label();
            this.dist2 = new System.Windows.Forms.Label();
            this.dist3 = new System.Windows.Forms.Label();
            this.anguloX = new System.Windows.Forms.Label();
            this.degree1 = new System.Windows.Forms.Label();
            this.textDist1 = new System.Windows.Forms.TextBox();
            this.textDist2 = new System.Windows.Forms.TextBox();
            this.textDist3 = new System.Windows.Forms.TextBox();
            this.textAnguloX = new System.Windows.Forms.TextBox();
            this.anguloY = new System.Windows.Forms.Label();
            this.anguloZ = new System.Windows.Forms.Label();
            this.textAnguloY = new System.Windows.Forms.TextBox();
            this.textAnguloZ = new System.Windows.Forms.TextBox();
            this.degree2 = new System.Windows.Forms.Label();
            this.degree3 = new System.Windows.Forms.Label();
            this.textDist4 = new System.Windows.Forms.TextBox();
            this.dist4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.com_port = new System.Windows.Forms.ComboBox();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.comPort = new System.Windows.Forms.Label();
            this.baudios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metros4 = new System.Windows.Forms.Label();
            this.metros3 = new System.Windows.Forms.Label();
            this.metros2 = new System.Windows.Forms.Label();
            this.metros1 = new System.Windows.Forms.Label();
            this.bateriaLvl = new System.Windows.Forms.Label();
            this.porcentajeBateria = new System.Windows.Forms.Label();
            this.bateria = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dist1
            // 
            this.dist1.AutoSize = true;
            this.dist1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dist1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dist1.Location = new System.Drawing.Point(7, 11);
            this.dist1.Name = "dist1";
            this.dist1.Size = new System.Drawing.Size(189, 39);
            this.dist1.TabIndex = 0;
            this.dist1.Text = "Distancia 1";
            // 
            // dist2
            // 
            this.dist2.AutoSize = true;
            this.dist2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dist2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dist2.Location = new System.Drawing.Point(7, 100);
            this.dist2.Name = "dist2";
            this.dist2.Size = new System.Drawing.Size(189, 39);
            this.dist2.TabIndex = 1;
            this.dist2.Text = "Distancia 2";
            // 
            // dist3
            // 
            this.dist3.AutoSize = true;
            this.dist3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dist3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dist3.Location = new System.Drawing.Point(8, 184);
            this.dist3.Name = "dist3";
            this.dist3.Size = new System.Drawing.Size(189, 39);
            this.dist3.TabIndex = 2;
            this.dist3.Text = "Distancia 3";
            // 
            // anguloX
            // 
            this.anguloX.AutoSize = true;
            this.anguloX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anguloX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anguloX.Location = new System.Drawing.Point(3, 356);
            this.anguloX.Name = "anguloX";
            this.anguloX.Size = new System.Drawing.Size(192, 37);
            this.anguloX.TabIndex = 3;
            this.anguloX.Text = "Angulo en X";
            // 
            // degree1
            // 
            this.degree1.AutoSize = true;
            this.degree1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.degree1.Location = new System.Drawing.Point(370, 351);
            this.degree1.Name = "degree1";
            this.degree1.Size = new System.Drawing.Size(33, 42);
            this.degree1.TabIndex = 8;
            this.degree1.Text = "°";
            // 
            // textDist1
            // 
            this.textDist1.BackColor = System.Drawing.Color.Silver;
            this.textDist1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDist1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDist1.Location = new System.Drawing.Point(202, 13);
            this.textDist1.MaxLength = 13;
            this.textDist1.Name = "textDist1";
            this.textDist1.ReadOnly = true;
            this.textDist1.Size = new System.Drawing.Size(162, 40);
            this.textDist1.TabIndex = 11;
            // 
            // textDist2
            // 
            this.textDist2.BackColor = System.Drawing.Color.Silver;
            this.textDist2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDist2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDist2.Location = new System.Drawing.Point(202, 99);
            this.textDist2.MaxLength = 13;
            this.textDist2.Name = "textDist2";
            this.textDist2.ReadOnly = true;
            this.textDist2.Size = new System.Drawing.Size(162, 40);
            this.textDist2.TabIndex = 12;
            // 
            // textDist3
            // 
            this.textDist3.BackColor = System.Drawing.Color.Silver;
            this.textDist3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDist3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDist3.Location = new System.Drawing.Point(202, 184);
            this.textDist3.MaxLength = 13;
            this.textDist3.Name = "textDist3";
            this.textDist3.ReadOnly = true;
            this.textDist3.Size = new System.Drawing.Size(162, 40);
            this.textDist3.TabIndex = 13;
            // 
            // textAnguloX
            // 
            this.textAnguloX.BackColor = System.Drawing.Color.Silver;
            this.textAnguloX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnguloX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textAnguloX.Location = new System.Drawing.Point(202, 352);
            this.textAnguloX.MaxLength = 13;
            this.textAnguloX.Name = "textAnguloX";
            this.textAnguloX.ReadOnly = true;
            this.textAnguloX.Size = new System.Drawing.Size(162, 40);
            this.textAnguloX.TabIndex = 14;
            // 
            // anguloY
            // 
            this.anguloY.AutoSize = true;
            this.anguloY.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anguloY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anguloY.Location = new System.Drawing.Point(3, 436);
            this.anguloY.Name = "anguloY";
            this.anguloY.Size = new System.Drawing.Size(193, 37);
            this.anguloY.TabIndex = 15;
            this.anguloY.Text = "Angulo en Y";
            // 
            // anguloZ
            // 
            this.anguloZ.AutoSize = true;
            this.anguloZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anguloZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anguloZ.Location = new System.Drawing.Point(3, 519);
            this.anguloZ.Name = "anguloZ";
            this.anguloZ.Size = new System.Drawing.Size(191, 37);
            this.anguloZ.TabIndex = 16;
            this.anguloZ.Text = "Angulo en Z";
            // 
            // textAnguloY
            // 
            this.textAnguloY.BackColor = System.Drawing.Color.Silver;
            this.textAnguloY.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnguloY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textAnguloY.Location = new System.Drawing.Point(202, 435);
            this.textAnguloY.MaxLength = 13;
            this.textAnguloY.Name = "textAnguloY";
            this.textAnguloY.ReadOnly = true;
            this.textAnguloY.Size = new System.Drawing.Size(162, 40);
            this.textAnguloY.TabIndex = 17;
            // 
            // textAnguloZ
            // 
            this.textAnguloZ.BackColor = System.Drawing.Color.Silver;
            this.textAnguloZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnguloZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textAnguloZ.Location = new System.Drawing.Point(202, 518);
            this.textAnguloZ.MaxLength = 13;
            this.textAnguloZ.Name = "textAnguloZ";
            this.textAnguloZ.ReadOnly = true;
            this.textAnguloZ.Size = new System.Drawing.Size(162, 40);
            this.textAnguloZ.TabIndex = 18;
            // 
            // degree2
            // 
            this.degree2.AutoSize = true;
            this.degree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.degree2.Location = new System.Drawing.Point(370, 436);
            this.degree2.Name = "degree2";
            this.degree2.Size = new System.Drawing.Size(33, 42);
            this.degree2.TabIndex = 19;
            this.degree2.Text = "°";
            // 
            // degree3
            // 
            this.degree3.AutoSize = true;
            this.degree3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.degree3.Location = new System.Drawing.Point(370, 516);
            this.degree3.Name = "degree3";
            this.degree3.Size = new System.Drawing.Size(33, 42);
            this.degree3.TabIndex = 20;
            this.degree3.Text = "°";
            // 
            // textDist4
            // 
            this.textDist4.BackColor = System.Drawing.Color.Silver;
            this.textDist4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDist4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDist4.Location = new System.Drawing.Point(202, 268);
            this.textDist4.MaxLength = 13;
            this.textDist4.Name = "textDist4";
            this.textDist4.ReadOnly = true;
            this.textDist4.Size = new System.Drawing.Size(162, 40);
            this.textDist4.TabIndex = 21;
            // 
            // dist4
            // 
            this.dist4.AutoSize = true;
            this.dist4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dist4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dist4.Location = new System.Drawing.Point(8, 268);
            this.dist4.Name = "dist4";
            this.dist4.Size = new System.Drawing.Size(189, 39);
            this.dist4.TabIndex = 22;
            this.dist4.Text = "Distancia 4";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.Location = new System.Drawing.Point(82, 261);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 60);
            this.startButton.TabIndex = 24;
            this.startButton.Text = "Inicio";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopButton.Location = new System.Drawing.Point(82, 363);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(158, 60);
            this.stopButton.TabIndex = 25;
            this.stopButton.Text = "Fin";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // com_port
            // 
            this.com_port.BackColor = System.Drawing.Color.Silver;
            this.com_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.com_port.FormattingEnabled = true;
            this.com_port.Location = new System.Drawing.Point(183, 14);
            this.com_port.Name = "com_port";
            this.com_port.Size = new System.Drawing.Size(121, 39);
            this.com_port.TabIndex = 26;
            this.com_port.DropDown += new System.EventHandler(this.com_port_SelectedIndexChanged);
            // 
            // baudRate
            // 
            this.baudRate.BackColor = System.Drawing.Color.Silver;
            this.baudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400"});
            this.baudRate.Location = new System.Drawing.Point(183, 94);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(121, 39);
            this.baudRate.TabIndex = 27;
            // 
            // comPort
            // 
            this.comPort.AutoSize = true;
            this.comPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comPort.Location = new System.Drawing.Point(1, 16);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(176, 33);
            this.comPort.TabIndex = 28;
            this.comPort.Text = "Puerto COM";
            // 
            // baudios
            // 
            this.baudios.AutoSize = true;
            this.baudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.baudios.Location = new System.Drawing.Point(26, 94);
            this.baudios.Name = "baudios";
            this.baudios.Size = new System.Drawing.Size(120, 33);
            this.baudios.TabIndex = 29;
            this.baudios.Text = "Baudios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.baudios);
            this.panel1.Controls.Add(this.comPort);
            this.panel1.Controls.Add(this.baudRate);
            this.panel1.Controls.Add(this.com_port);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(461, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 465);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.metros4);
            this.panel2.Controls.Add(this.metros3);
            this.panel2.Controls.Add(this.metros2);
            this.panel2.Controls.Add(this.metros1);
            this.panel2.Controls.Add(this.dist4);
            this.panel2.Controls.Add(this.textDist4);
            this.panel2.Controls.Add(this.degree3);
            this.panel2.Controls.Add(this.degree2);
            this.panel2.Controls.Add(this.textAnguloZ);
            this.panel2.Controls.Add(this.textAnguloY);
            this.panel2.Controls.Add(this.anguloZ);
            this.panel2.Controls.Add(this.anguloY);
            this.panel2.Controls.Add(this.textAnguloX);
            this.panel2.Controls.Add(this.textDist3);
            this.panel2.Controls.Add(this.textDist2);
            this.panel2.Controls.Add(this.textDist1);
            this.panel2.Controls.Add(this.degree1);
            this.panel2.Controls.Add(this.anguloX);
            this.panel2.Controls.Add(this.dist3);
            this.panel2.Controls.Add(this.dist2);
            this.panel2.Controls.Add(this.dist1);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 574);
            this.panel2.TabIndex = 31;
            // 
            // metros4
            // 
            this.metros4.AutoSize = true;
            this.metros4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metros4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metros4.Location = new System.Drawing.Point(367, 271);
            this.metros4.Name = "metros4";
            this.metros4.Size = new System.Drawing.Size(71, 37);
            this.metros4.TabIndex = 27;
            this.metros4.Text = "mm";
            // 
            // metros3
            // 
            this.metros3.AutoSize = true;
            this.metros3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metros3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metros3.Location = new System.Drawing.Point(370, 185);
            this.metros3.Name = "metros3";
            this.metros3.Size = new System.Drawing.Size(71, 37);
            this.metros3.TabIndex = 26;
            this.metros3.Text = "mm";
            // 
            // metros2
            // 
            this.metros2.AutoSize = true;
            this.metros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metros2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metros2.Location = new System.Drawing.Point(370, 100);
            this.metros2.Name = "metros2";
            this.metros2.Size = new System.Drawing.Size(71, 37);
            this.metros2.TabIndex = 25;
            this.metros2.Text = "mm";
            // 
            // metros1
            // 
            this.metros1.AutoSize = true;
            this.metros1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metros1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metros1.Location = new System.Drawing.Point(370, 16);
            this.metros1.Name = "metros1";
            this.metros1.Size = new System.Drawing.Size(71, 37);
            this.metros1.TabIndex = 24;
            this.metros1.Text = "mm";
            // 
            // bateriaLvl
            // 
            this.bateriaLvl.AutoSize = true;
            this.bateriaLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bateriaLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bateriaLvl.Location = new System.Drawing.Point(12, 6);
            this.bateriaLvl.Name = "bateriaLvl";
            this.bateriaLvl.Size = new System.Drawing.Size(127, 39);
            this.bateriaLvl.TabIndex = 4;
            this.bateriaLvl.Text = "Batería";
            // 
            // porcentajeBateria
            // 
            this.porcentajeBateria.AutoSize = true;
            this.porcentajeBateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentajeBateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.porcentajeBateria.Location = new System.Drawing.Point(241, 54);
            this.porcentajeBateria.Name = "porcentajeBateria";
            this.porcentajeBateria.Size = new System.Drawing.Size(48, 25);
            this.porcentajeBateria.TabIndex = 9;
            this.porcentajeBateria.Text = "100";
            // 
            // bateria
            // 
            this.bateria.Location = new System.Drawing.Point(11, 49);
            this.bateria.Name = "bateria";
            this.bateria.Size = new System.Drawing.Size(229, 30);
            this.bateria.TabIndex = 10;
            this.bateria.Value = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bateria);
            this.panel3.Controls.Add(this.porcentajeBateria);
            this.panel3.Controls.Add(this.bateriaLvl);
            this.panel3.Location = new System.Drawing.Point(461, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 94);
            this.panel3.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(303, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "%";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(805, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ventana";
            this.Text = "Monitor de variables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ventana_FormClosing);
            this.Load += new System.EventHandler(this.ventana_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dist1;
        private System.Windows.Forms.Label dist2;
        private System.Windows.Forms.Label dist3;
        private System.Windows.Forms.Label anguloX;
        private System.Windows.Forms.Label degree1;
        private System.Windows.Forms.TextBox textDist1;
        private System.Windows.Forms.TextBox textDist2;
        private System.Windows.Forms.TextBox textDist3;
        private System.Windows.Forms.TextBox textAnguloX;
        private System.Windows.Forms.Label anguloY;
        private System.Windows.Forms.Label anguloZ;
        private System.Windows.Forms.TextBox textAnguloY;
        private System.Windows.Forms.TextBox textAnguloZ;
        private System.Windows.Forms.Label degree2;
        private System.Windows.Forms.Label degree3;
        private System.Windows.Forms.TextBox textDist4;
        private System.Windows.Forms.Label dist4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox com_port;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Label comPort;
        private System.Windows.Forms.Label baudios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bateriaLvl;
        private System.Windows.Forms.Label porcentajeBateria;
        private System.Windows.Forms.ProgressBar bateria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label metros4;
        private System.Windows.Forms.Label metros3;
        private System.Windows.Forms.Label metros2;
        private System.Windows.Forms.Label metros1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
    }
}

