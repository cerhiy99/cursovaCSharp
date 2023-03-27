namespace cursovaCSharp.forms
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserWhoLivesInHotelTheLongest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelSelectUsersWhoBookMore2HotelRoom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nUpDownCountPlace = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nUpDownCountWindow = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nUpDwnArea = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nUpDwnCountRoom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nUpDwnCountStar = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCountPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCountWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnCountRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnCountStar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Користувач який проживає в готелі найдовше:";
            // 
            // labelUserWhoLivesInHotelTheLongest
            // 
            this.labelUserWhoLivesInHotelTheLongest.AutoSize = true;
            this.labelUserWhoLivesInHotelTheLongest.Location = new System.Drawing.Point(33, 69);
            this.labelUserWhoLivesInHotelTheLongest.Name = "labelUserWhoLivesInHotelTheLongest";
            this.labelUserWhoLivesInHotelTheLongest.Size = new System.Drawing.Size(35, 13);
            this.labelUserWhoLivesInHotelTheLongest.TabIndex = 1;
            this.labelUserWhoLivesInHotelTheLongest.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.labelSelectUsersWhoBookMore2HotelRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(36, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Користувачі які забронювали біше двох номерів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "повна інформація про вибраного користувача";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 148);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelSelectUsersWhoBookMore2HotelRoom
            // 
            this.labelSelectUsersWhoBookMore2HotelRoom.AutoSize = true;
            this.labelSelectUsersWhoBookMore2HotelRoom.Location = new System.Drawing.Point(15, 223);
            this.labelSelectUsersWhoBookMore2HotelRoom.Name = "labelSelectUsersWhoBookMore2HotelRoom";
            this.labelSelectUsersWhoBookMore2HotelRoom.Size = new System.Drawing.Size(0, 16);
            this.labelSelectUsersWhoBookMore2HotelRoom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dateFinish);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateStart);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nUpDownCountPlace);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nUpDownCountWindow);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nUpDownPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nUpDwnArea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nUpDwnCountRoom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nUpDwnCountStar);
            this.groupBox2.Location = new System.Drawing.Point(636, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 483);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "добавити вільний номер";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(30, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "побутова техніка";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(471, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "добавити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateRoomButton);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(30, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "список додаткових зручностей.";
            this.label11.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // dateFinish
            // 
            this.dateFinish.Location = new System.Drawing.Point(289, 303);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(200, 20);
            this.dateFinish.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(29, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "кіннцева дата";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(29, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "початкова дата";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(289, 259);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "кількість місця";
            // 
            // nUpDownCountPlace
            // 
            this.nUpDownCountPlace.Location = new System.Drawing.Point(287, 219);
            this.nUpDownCountPlace.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDownCountPlace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownCountPlace.Name = "nUpDownCountPlace";
            this.nUpDownCountPlace.Size = new System.Drawing.Size(120, 20);
            this.nUpDownCountPlace.TabIndex = 10;
            this.nUpDownCountPlace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(29, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "кількість вікон";
            // 
            // nUpDownCountWindow
            // 
            this.nUpDownCountWindow.Location = new System.Drawing.Point(287, 178);
            this.nUpDownCountWindow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDownCountWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownCountWindow.Name = "nUpDownCountWindow";
            this.nUpDownCountWindow.Size = new System.Drawing.Size(120, 20);
            this.nUpDownCountWindow.TabIndex = 8;
            this.nUpDownCountWindow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "ціна";
            // 
            // nUpDownPrice
            // 
            this.nUpDownPrice.Location = new System.Drawing.Point(287, 140);
            this.nUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownPrice.Name = "nUpDownPrice";
            this.nUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.nUpDownPrice.TabIndex = 6;
            this.nUpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "площа";
            // 
            // nUpDwnArea
            // 
            this.nUpDwnArea.Location = new System.Drawing.Point(287, 100);
            this.nUpDwnArea.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDwnArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDwnArea.Name = "nUpDwnArea";
            this.nUpDwnArea.Size = new System.Drawing.Size(120, 20);
            this.nUpDwnArea.TabIndex = 4;
            this.nUpDwnArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "кількість кімнат";
            // 
            // nUpDwnCountRoom
            // 
            this.nUpDwnCountRoom.Location = new System.Drawing.Point(287, 59);
            this.nUpDwnCountRoom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDwnCountRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDwnCountRoom.Name = "nUpDwnCountRoom";
            this.nUpDwnCountRoom.Size = new System.Drawing.Size(120, 20);
            this.nUpDwnCountRoom.TabIndex = 2;
            this.nUpDwnCountRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "кількість зірок";
            // 
            // nUpDwnCountStar
            // 
            this.nUpDwnCountStar.Location = new System.Drawing.Point(287, 21);
            this.nUpDwnCountStar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUpDwnCountStar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDwnCountStar.Name = "nUpDwnCountStar";
            this.nUpDwnCountStar.Size = new System.Drawing.Size(120, 20);
            this.nUpDwnCountStar.TabIndex = 0;
            this.nUpDwnCountStar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDwnCountStar.ValueChanged += new System.EventHandler(this.nUpDwnCountStar_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(14, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "найпопулярніші запити:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(36, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 112);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "середня мінімальна кількість зірок:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(216, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(216, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "середня мінімальна вартість:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(314, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "середня максимальна ціна";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(314, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "label20";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUserWhoLivesInHotelTheLongest);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCountPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCountWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnCountRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnCountStar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserWhoLivesInHotelTheLongest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelSelectUsersWhoBookMore2HotelRoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUpDwnCountStar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateFinish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUpDownCountPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUpDownCountWindow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUpDownPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUpDwnArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUpDwnCountRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}