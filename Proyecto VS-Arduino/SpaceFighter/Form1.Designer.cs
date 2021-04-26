namespace SpaceFighter
{
    partial class Window_Background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window_Background));
            this.ScoreTxt = new System.Windows.Forms.Label();
            this.ScorePoints = new System.Windows.Forms.Label();
            this.Meteor1 = new System.Windows.Forms.Panel();
            this.Lazer = new System.Windows.Forms.Panel();
            this.SpaceShip = new System.Windows.Forms.Panel();
            this.Blast = new System.Windows.Forms.Panel();
            this.GameOver = new System.Windows.Forms.Label();
            this.StartMsg = new System.Windows.Forms.Label();
            this.Meteor2 = new System.Windows.Forms.Panel();
            this.Meteor3 = new System.Windows.Forms.Panel();
            this.Meteor4 = new System.Windows.Forms.Panel();
            this.Meteor5 = new System.Windows.Forms.Panel();
            this.Meteor6 = new System.Windows.Forms.Panel();
            this.Meteor7 = new System.Windows.Forms.Panel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.x_value_txt = new System.Windows.Forms.Label();
            this.x_txt = new System.Windows.Forms.Label();
            this.y_txt = new System.Windows.Forms.Label();
            this.y_value_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.AutoSize = true;
            this.ScoreTxt.BackColor = System.Drawing.Color.Transparent;
            this.ScoreTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTxt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ScoreTxt.Location = new System.Drawing.Point(0, 725);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(101, 32);
            this.ScoreTxt.TabIndex = 1;
            this.ScoreTxt.Text = "Score:";
            // 
            // ScorePoints
            // 
            this.ScorePoints.AutoSize = true;
            this.ScorePoints.BackColor = System.Drawing.Color.Transparent;
            this.ScorePoints.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePoints.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ScorePoints.Location = new System.Drawing.Point(110, 726);
            this.ScorePoints.Name = "ScorePoints";
            this.ScorePoints.Size = new System.Drawing.Size(31, 32);
            this.ScorePoints.TabIndex = 2;
            this.ScorePoints.Text = "0";
            // 
            // Meteor1
            // 
            this.Meteor1.BackColor = System.Drawing.Color.Transparent;
            this.Meteor1.BackgroundImage = global::SpaceFighter.Properties.Resources.asteroid;
            this.Meteor1.Location = new System.Drawing.Point(370, 20);
            this.Meteor1.Name = "Meteor1";
            this.Meteor1.Size = new System.Drawing.Size(60, 60);
            this.Meteor1.TabIndex = 3;
            this.Meteor1.Visible = false;
            // 
            // Lazer
            // 
            this.Lazer.BackColor = System.Drawing.Color.Transparent;
            this.Lazer.BackgroundImage = global::SpaceFighter.Properties.Resources.lazer1;
            this.Lazer.Location = new System.Drawing.Point(390, 660);
            this.Lazer.Name = "Lazer";
            this.Lazer.Size = new System.Drawing.Size(20, 60);
            this.Lazer.TabIndex = 4;
            this.Lazer.Visible = false;
            // 
            // SpaceShip
            // 
            this.SpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShip.BackgroundImage = global::SpaceFighter.Properties.Resources.spaceship;
            this.SpaceShip.Location = new System.Drawing.Point(370, 680);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(60, 60);
            this.SpaceShip.TabIndex = 0;
            // 
            // Blast
            // 
            this.Blast.BackColor = System.Drawing.Color.Transparent;
            this.Blast.BackgroundImage = global::SpaceFighter.Properties.Resources.blast;
            this.Blast.Location = new System.Drawing.Point(370, 680);
            this.Blast.Name = "Blast";
            this.Blast.Size = new System.Drawing.Size(60, 60);
            this.Blast.TabIndex = 5;
            this.Blast.Visible = false;
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GameOver.Location = new System.Drawing.Point(257, 360);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(286, 58);
            this.GameOver.TabIndex = 6;
            this.GameOver.Text = "Game Over";
            this.GameOver.Visible = false;
            // 
            // StartMsg
            // 
            this.StartMsg.AutoSize = true;
            this.StartMsg.BackColor = System.Drawing.Color.Transparent;
            this.StartMsg.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMsg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StartMsg.Location = new System.Drawing.Point(22, 360);
            this.StartMsg.Name = "StartMsg";
            this.StartMsg.Size = new System.Drawing.Size(750, 58);
            this.StartMsg.TabIndex = 7;
            this.StartMsg.Text = "Press The Button To Start";
            this.StartMsg.Visible = false;
            // 
            // Meteor2
            // 
            this.Meteor2.BackColor = System.Drawing.Color.Transparent;
            this.Meteor2.BackgroundImage = global::SpaceFighter.Properties.Resources.asteroid;
            this.Meteor2.Location = new System.Drawing.Point(483, 20);
            this.Meteor2.Name = "Meteor2";
            this.Meteor2.Size = new System.Drawing.Size(60, 60);
            this.Meteor2.TabIndex = 4;
            this.Meteor2.Visible = false;
            // 
            // Meteor3
            // 
            this.Meteor3.BackColor = System.Drawing.Color.Transparent;
            this.Meteor3.BackgroundImage = global::SpaceFighter.Properties.Resources.asteroid;
            this.Meteor3.Location = new System.Drawing.Point(596, 20);
            this.Meteor3.Name = "Meteor3";
            this.Meteor3.Size = new System.Drawing.Size(60, 60);
            this.Meteor3.TabIndex = 8;
            this.Meteor3.Visible = false;
            // 
            // Meteor4
            // 
            this.Meteor4.BackColor = System.Drawing.Color.Transparent;
            this.Meteor4.BackgroundImage = global::SpaceFighter.Properties.Resources.asteroid;
            this.Meteor4.Location = new System.Drawing.Point(703, 20);
            this.Meteor4.Name = "Meteor4";
            this.Meteor4.Size = new System.Drawing.Size(60, 60);
            this.Meteor4.TabIndex = 4;
            this.Meteor4.Visible = false;
            // 
            // Meteor5
            // 
            this.Meteor5.BackColor = System.Drawing.Color.Transparent;
            this.Meteor5.BackgroundImage = global::SpaceFighter.Properties.Resources.asteroid;
            this.Meteor5.Location = new System.Drawing.Point(255, 20);
            this.Meteor5.Name = "Meteor5";
            this.Meteor5.Size = new System.Drawing.Size(60, 60);
            this.Meteor5.TabIndex = 4;
            this.Meteor5.Visible = false;
            // 
            // Meteor6
            // 
            this.Meteor6.BackColor = System.Drawing.Color.Transparent;
            this.Meteor6.BackgroundImage = global::SpaceFighter.Properties.Resources.asteroid;
            this.Meteor6.Location = new System.Drawing.Point(147, 20);
            this.Meteor6.Name = "Meteor6";
            this.Meteor6.Size = new System.Drawing.Size(60, 60);
            this.Meteor6.TabIndex = 4;
            this.Meteor6.Visible = false;
            // 
            // Meteor7
            // 
            this.Meteor7.BackColor = System.Drawing.Color.Transparent;
            this.Meteor7.BackgroundImage = global::SpaceFighter.Properties.Resources.asteroid;
            this.Meteor7.Location = new System.Drawing.Point(32, 20);
            this.Meteor7.Name = "Meteor7";
            this.Meteor7.Size = new System.Drawing.Size(60, 60);
            this.Meteor7.TabIndex = 4;
            this.Meteor7.Visible = false;
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // x_value_txt
            // 
            this.x_value_txt.AutoSize = true;
            this.x_value_txt.BackColor = System.Drawing.Color.Transparent;
            this.x_value_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_value_txt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.x_value_txt.Location = new System.Drawing.Point(61, 560);
            this.x_value_txt.Name = "x_value_txt";
            this.x_value_txt.Size = new System.Drawing.Size(31, 32);
            this.x_value_txt.TabIndex = 9;
            this.x_value_txt.Text = "0";
            // 
            // x_txt
            // 
            this.x_txt.AutoSize = true;
            this.x_txt.BackColor = System.Drawing.Color.Transparent;
            this.x_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_txt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.x_txt.Location = new System.Drawing.Point(0, 560);
            this.x_txt.Name = "x_txt";
            this.x_txt.Size = new System.Drawing.Size(39, 32);
            this.x_txt.TabIndex = 10;
            this.x_txt.Text = "X:";
            // 
            // y_txt
            // 
            this.y_txt.AutoSize = true;
            this.y_txt.BackColor = System.Drawing.Color.Transparent;
            this.y_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_txt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.y_txt.Location = new System.Drawing.Point(0, 592);
            this.y_txt.Name = "y_txt";
            this.y_txt.Size = new System.Drawing.Size(40, 32);
            this.y_txt.TabIndex = 11;
            this.y_txt.Text = "Y:";
            // 
            // y_value_txt
            // 
            this.y_value_txt.AutoSize = true;
            this.y_value_txt.BackColor = System.Drawing.Color.Transparent;
            this.y_value_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_value_txt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.y_value_txt.Location = new System.Drawing.Point(61, 592);
            this.y_value_txt.Name = "y_value_txt";
            this.y_value_txt.Size = new System.Drawing.Size(31, 32);
            this.y_value_txt.TabIndex = 12;
            this.y_value_txt.Text = "0";
            // 
            // Window_Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.y_value_txt);
            this.Controls.Add(this.y_txt);
            this.Controls.Add(this.x_txt);
            this.Controls.Add(this.x_value_txt);
            this.Controls.Add(this.ScorePoints);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.Meteor7);
            this.Controls.Add(this.Meteor6);
            this.Controls.Add(this.Meteor5);
            this.Controls.Add(this.Meteor4);
            this.Controls.Add(this.Meteor3);
            this.Controls.Add(this.Meteor2);
            this.Controls.Add(this.StartMsg);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.SpaceShip);
            this.Controls.Add(this.Blast);
            this.Controls.Add(this.Lazer);
            this.Controls.Add(this.Meteor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window_Background";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Fighter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_Background_FormClosing);
            this.Load += new System.EventHandler(this.Window_Background_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SpaceShip;
        private System.Windows.Forms.Label ScoreTxt;
        private System.Windows.Forms.Label ScorePoints;
        private System.Windows.Forms.Panel Meteor1;
        private System.Windows.Forms.Panel Lazer;
        private System.Windows.Forms.Panel Blast;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label StartMsg;
        private System.Windows.Forms.Panel Meteor2;
        private System.Windows.Forms.Panel Meteor3;
        private System.Windows.Forms.Panel Meteor4;
        private System.Windows.Forms.Panel Meteor5;
        private System.Windows.Forms.Panel Meteor6;
        private System.Windows.Forms.Panel Meteor7;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label x_value_txt;
        private System.Windows.Forms.Label x_txt;
        private System.Windows.Forms.Label y_txt;
        private System.Windows.Forms.Label y_value_txt;
    }
}

