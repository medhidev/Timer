
namespace Timer
{
    partial class window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.restart = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timerlabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(231, 232);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 0;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(150, 232);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 1;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(192, 261);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timerlabel
            // 
            this.timerlabel.AutoSize = true;
            this.timerlabel.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.ForeColor = System.Drawing.Color.Red;
            this.timerlabel.Location = new System.Drawing.Point(126, 90);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(207, 75);
            this.timerlabel.TabIndex = 3;
            this.timerlabel.Text = "00:00";
            this.timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerlabel.Click += new System.EventHandler(this.timerlabel_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // setting
            // 
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(424, 12);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(26, 23);
            this.setting.TabIndex = 4;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(462, 296);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.restart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "window";
            this.Text = "timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button setting;
    }
}

