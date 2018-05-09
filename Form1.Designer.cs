namespace AshleysElevator
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
            this.btmRight = new System.Windows.Forms.Panel();
            this.btmLeft = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlpn1 = new System.Windows.Forms.Button();
            this.ctrlpnG = new System.Windows.Forms.Button();
            this.cartUp = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.topLeft = new System.Windows.Forms.Panel();
            this.topRight = new System.Windows.Forms.Panel();
            this.doorOpn = new System.Windows.Forms.Timer(this.components);
            this.doorCls = new System.Windows.Forms.Timer(this.components);
            this.cartDwn = new System.Windows.Forms.Timer(this.components);
            this.cartMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rqstTop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayWindow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ElevatorID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusLift = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btmRight
            // 
            this.btmRight.BackColor = System.Drawing.Color.Maroon;
            this.btmRight.Location = new System.Drawing.Point(298, 289);
            this.btmRight.Name = "btmRight";
            this.btmRight.Size = new System.Drawing.Size(70, 205);
            this.btmRight.TabIndex = 13;
            // 
            // btmLeft
            // 
            this.btmLeft.BackColor = System.Drawing.Color.Maroon;
            this.btmLeft.Location = new System.Drawing.Point(227, 289);
            this.btmLeft.Name = "btmLeft";
            this.btmLeft.Size = new System.Drawing.Size(65, 205);
            this.btmLeft.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ctrlpn1);
            this.panel4.Controls.Add(this.ctrlpnG);
            this.panel4.Location = new System.Drawing.Point(27, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 120);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // ctrlpn1
            // 
            this.ctrlpn1.BackgroundImage = global::AshleysElevator.Properties.Resources.Red_1_Button;
            this.ctrlpn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlpn1.ForeColor = System.Drawing.SystemColors.Control;
            this.ctrlpn1.Location = new System.Drawing.Point(3, 52);
            this.ctrlpn1.Name = "ctrlpn1";
            this.ctrlpn1.Size = new System.Drawing.Size(65, 65);
            this.ctrlpn1.TabIndex = 1;
            this.ctrlpn1.Text = "1";
            this.ctrlpn1.UseVisualStyleBackColor = true;
            this.ctrlpn1.Click += new System.EventHandler(this.ctrlpn1_Click);
            // 
            // ctrlpnG
            // 
            this.ctrlpnG.BackgroundImage = global::AshleysElevator.Properties.Resources.RED_G;
            this.ctrlpnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlpnG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlpnG.Location = new System.Drawing.Point(82, 52);
            this.ctrlpnG.Name = "ctrlpnG";
            this.ctrlpnG.Size = new System.Drawing.Size(65, 65);
            this.ctrlpnG.TabIndex = 0;
            this.ctrlpnG.UseVisualStyleBackColor = true;
            this.ctrlpnG.Click += new System.EventHandler(this.ctrlpnG_Click);
            // 
            // cartUp
            // 
            this.cartUp.Interval = 25;
            this.cartUp.Tick += new System.EventHandler(this.cartUp_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(195, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 62);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // topLeft
            // 
            this.topLeft.BackColor = System.Drawing.Color.Maroon;
            this.topLeft.Location = new System.Drawing.Point(225, 28);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(67, 201);
            this.topLeft.TabIndex = 0;
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.Maroon;
            this.topRight.Location = new System.Drawing.Point(298, 28);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(72, 201);
            this.topRight.TabIndex = 1;
            // 
            // doorOpn
            // 
            this.doorOpn.Interval = 50;
            this.doorOpn.Tick += new System.EventHandler(this.doorOpn_Tick);
            // 
            // doorCls
            // 
            this.doorCls.Interval = 50;
            this.doorCls.Tick += new System.EventHandler(this.doorCls_Tick);
            // 
            // cartDwn
            // 
            this.cartDwn.Interval = 25;
            this.cartDwn.Tick += new System.EventHandler(this.cartDwn_Tick);
            // 
            // cartMain
            // 
            this.cartMain.BackgroundImage = global::AshleysElevator.Properties.Resources.Elevator;
            this.cartMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartMain.Location = new System.Drawing.Point(228, 290);
            this.cartMain.Name = "cartMain";
            this.cartMain.Size = new System.Drawing.Size(139, 204);
            this.cartMain.TabIndex = 8;
            this.cartMain.Paint += new System.Windows.Forms.PaintEventHandler(this.cartMain_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 513);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rqstTop
            // 
            this.rqstTop.BackgroundImage = global::AshleysElevator.Properties.Resources.Arrow_Down;
            this.rqstTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rqstTop.Location = new System.Drawing.Point(433, 56);
            this.rqstTop.Name = "rqstTop";
            this.rqstTop.Size = new System.Drawing.Size(65, 65);
            this.rqstTop.TabIndex = 2;
            this.rqstTop.UseVisualStyleBackColor = true;
            this.rqstTop.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.BackgroundImage = global::AshleysElevator.Properties.Resources.Arrow_UP;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(433, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // DisplayWindow
            // 
            this.DisplayWindow.AutoSize = true;
            this.DisplayWindow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayWindow.Location = new System.Drawing.Point(535, 108);
            this.DisplayWindow.Name = "DisplayWindow";
            this.DisplayWindow.Size = new System.Drawing.Size(97, 13);
            this.DisplayWindow.TabIndex = 18;
            this.DisplayWindow.Text = "Display Window";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Control Panel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "Load Events";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ElevatorID,
            this.Status,
            this.StatusDate,
            this.StatusTime,
            this.StatusLift});
            this.listView1.Location = new System.Drawing.Point(433, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 232);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ElevatorID
            // 
            this.ElevatorID.Text = "ID";
            this.ElevatorID.Width = 56;
            // 
            // Status
            // 
            this.Status.Text = "Floor?";
            // 
            // StatusDate
            // 
            this.StatusDate.Text = "Date";
            // 
            // StatusTime
            // 
            this.StatusTime.Text = "Time";
            // 
            // StatusLift
            // 
            this.StatusLift.Text = "Lift Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 600);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DisplayWindow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rqstTop);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btmRight);
            this.Controls.Add(this.btmLeft);
            this.Controls.Add(this.cartMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btmRight;
        private System.Windows.Forms.Panel btmLeft;
        private System.Windows.Forms.Panel cartMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ctrlpnG;
        private System.Windows.Forms.Button ctrlpn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer cartUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel topLeft;
        private System.Windows.Forms.Panel topRight;
        private System.Windows.Forms.Timer doorOpn;
        private System.Windows.Forms.Timer doorCls;
        private System.Windows.Forms.Timer cartDwn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rqstTop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DisplayWindow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ElevatorID;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader StatusDate;
        private System.Windows.Forms.ColumnHeader StatusTime;
        private System.Windows.Forms.ColumnHeader StatusLift;
    }
}

