namespace Fog_Clicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clickertoggle = new System.Windows.Forms.Button();
            this.clickerbind = new System.Windows.Forms.Button();
            this.cpsvalue = new System.Windows.Forms.Label();
            this.cpstb = new System.Windows.Forms.TrackBar();
            this.clicker = new System.Windows.Forms.Timer(this.components);
            this.randomizer = new System.Windows.Forms.Timer(this.components);
            this.binds = new System.Windows.Forms.Timer(this.components);
            this.aclickerbind = new System.Windows.Forms.Button();
            this.actoggle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a_clicker = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ac = new System.Windows.Forms.Panel();
            this.ac_options = new System.Windows.Forms.ComboBox();
            this.des = new System.Windows.Forms.Button();
            this.ac_controller = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpstb)).BeginInit();
            this.panel1.SuspendLayout();
            this.ac.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickertoggle
            // 
            this.clickertoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickertoggle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickertoggle.ForeColor = System.Drawing.Color.Crimson;
            this.clickertoggle.Location = new System.Drawing.Point(6, 30);
            this.clickertoggle.Name = "clickertoggle";
            this.clickertoggle.Size = new System.Drawing.Size(156, 26);
            this.clickertoggle.TabIndex = 0;
            this.clickertoggle.Text = "Disabled";
            this.clickertoggle.UseVisualStyleBackColor = true;
            this.clickertoggle.TextChanged += new System.EventHandler(this.clickertoggle_TextChanged);
            this.clickertoggle.Click += new System.EventHandler(this.clickertoggle_Click);
            // 
            // clickerbind
            // 
            this.clickerbind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickerbind.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickerbind.ForeColor = System.Drawing.Color.Crimson;
            this.clickerbind.Location = new System.Drawing.Point(168, 30);
            this.clickerbind.Name = "clickerbind";
            this.clickerbind.Size = new System.Drawing.Size(80, 26);
            this.clickerbind.TabIndex = 1;
            this.clickerbind.Text = "None";
            this.clickerbind.UseVisualStyleBackColor = true;
            // 
            // cpsvalue
            // 
            this.cpsvalue.AutoSize = true;
            this.cpsvalue.Font = new System.Drawing.Font("Consolas", 12F);
            this.cpsvalue.ForeColor = System.Drawing.Color.Crimson;
            this.cpsvalue.Location = new System.Drawing.Point(121, 8);
            this.cpsvalue.Name = "cpsvalue";
            this.cpsvalue.Size = new System.Drawing.Size(54, 19);
            this.cpsvalue.TabIndex = 2;
            this.cpsvalue.Text = "CPS:6";
            // 
            // cpstb
            // 
            this.cpstb.AutoSize = false;
            this.cpstb.Location = new System.Drawing.Point(0, 62);
            this.cpstb.Maximum = 20;
            this.cpstb.Minimum = 6;
            this.cpstb.Name = "cpstb";
            this.cpstb.Size = new System.Drawing.Size(251, 19);
            this.cpstb.TabIndex = 3;
            this.cpstb.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cpstb.Value = 6;
            this.cpstb.Scroll += new System.EventHandler(this.cpstb_Scroll);
            // 
            // clicker
            // 
            this.clicker.Tick += new System.EventHandler(this.clicker_Tick);
            // 
            // randomizer
            // 
            this.randomizer.Enabled = true;
            this.randomizer.Tick += new System.EventHandler(this.randomizer_Tick);
            // 
            // binds
            // 
            this.binds.Enabled = true;
            this.binds.Interval = 10;
            // 
            // aclickerbind
            // 
            this.aclickerbind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aclickerbind.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aclickerbind.ForeColor = System.Drawing.Color.Crimson;
            this.aclickerbind.Location = new System.Drawing.Point(168, 30);
            this.aclickerbind.Name = "aclickerbind";
            this.aclickerbind.Size = new System.Drawing.Size(80, 26);
            this.aclickerbind.TabIndex = 6;
            this.aclickerbind.Text = "None";
            this.aclickerbind.UseVisualStyleBackColor = true;
            this.aclickerbind.Click += new System.EventHandler(this.aclickerbind_Click);
            this.aclickerbind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aclickerbind_KeyDown);
            this.aclickerbind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.aclickerbind_KeyUp);
            // 
            // actoggle
            // 
            this.actoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actoggle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actoggle.ForeColor = System.Drawing.Color.Crimson;
            this.actoggle.Location = new System.Drawing.Point(6, 30);
            this.actoggle.Name = "actoggle";
            this.actoggle.Size = new System.Drawing.Size(156, 26);
            this.actoggle.TabIndex = 5;
            this.actoggle.Text = "Disabled";
            this.actoggle.UseVisualStyleBackColor = true;
            this.actoggle.TextChanged += new System.EventHandler(this.actoggle_TextChanged);
            this.actoggle.Click += new System.EventHandler(this.actoggle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Basic Clicker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Advanced clicker";
            // 
            // a_clicker
            // 
            this.a_clicker.Tick += new System.EventHandler(this.a_clicker_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clickertoggle);
            this.panel1.Controls.Add(this.clickerbind);
            this.panel1.Controls.Add(this.cpsvalue);
            this.panel1.Controls.Add(this.cpstb);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 100);
            this.panel1.TabIndex = 11;
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ac.Controls.Add(this.ac_options);
            this.ac.Controls.Add(this.label3);
            this.ac.Controls.Add(this.actoggle);
            this.ac.Controls.Add(this.aclickerbind);
            this.ac.Location = new System.Drawing.Point(12, 118);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(251, 99);
            this.ac.TabIndex = 12;
            // 
            // ac_options
            // 
            this.ac_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ac_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ac_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_options.ForeColor = System.Drawing.Color.Crimson;
            this.ac_options.FormattingEnabled = true;
            this.ac_options.Items.AddRange(new object[] {
            "Basic",
            "Dope old",
            "Night clicker",
            "Mango",
            "Zoom"});
            this.ac_options.Location = new System.Drawing.Point(6, 63);
            this.ac_options.Name = "ac_options";
            this.ac_options.Size = new System.Drawing.Size(109, 24);
            this.ac_options.TabIndex = 9;
            this.ac_options.TabStop = false;
            this.ac_options.Text = "Basic";
            // 
            // des
            // 
            this.des.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.des.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.ForeColor = System.Drawing.Color.Crimson;
            this.des.Location = new System.Drawing.Point(137, 223);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(126, 26);
            this.des.TabIndex = 11;
            this.des.Text = "Self Destruct";
            this.des.UseVisualStyleBackColor = true;
            this.des.Click += new System.EventHandler(this.des_Click);
            // 
            // ac_controller
            // 
            this.ac_controller.Enabled = true;
            this.ac_controller.Interval = 200;
            this.ac_controller.Tick += new System.EventHandler(this.ac_controller_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(275, 261);
            this.Controls.Add(this.des);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Fog_Clickrr by erty";
            ((System.ComponentModel.ISupportInitialize)(this.cpstb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ac.ResumeLayout(false);
            this.ac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickertoggle;
        private System.Windows.Forms.Button clickerbind;
        private System.Windows.Forms.Label cpsvalue;
        private System.Windows.Forms.TrackBar cpstb;
        private System.Windows.Forms.Timer clicker;
        private System.Windows.Forms.Timer randomizer;
        private System.Windows.Forms.Timer binds;
        private System.Windows.Forms.Button aclickerbind;
        private System.Windows.Forms.Button actoggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer a_clicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ac;
        private System.Windows.Forms.Button des;
        private System.Windows.Forms.Timer ac_controller;
        private System.Windows.Forms.ComboBox ac_options;
    }
}