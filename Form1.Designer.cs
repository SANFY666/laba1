namespace laba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPage7 = new TabPage();
            btnClear1 = new Button();
            btnStart1 = new Button();
            label2 = new Label();
            txtX = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnClear2 = new Button();
            listBox1 = new ListBox();
            txtboxY = new TextBox();
            txtboxA = new TextBox();
            txtboxB = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnStart2 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            btnClear3 = new Button();
            listBox2 = new ListBox();
            txtBox3D = new TextBox();
            txtBox3C = new TextBox();
            txtBox3B = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtBox3A = new TextBox();
            btnStart3 = new Button();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            btnClear4 = new Button();
            btnStart4 = new Button();
            listBox3 = new ListBox();
            txtBox4B = new TextBox();
            txtBox4C = new TextBox();
            txtBox4A = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            tabPage4 = new TabPage();
            listBox4 = new ListBox();
            btnStart5 = new Button();
            label16 = new Label();
            tabPage5 = new TabPage();
            btnClear6 = new Button();
            txtBox6B = new TextBox();
            txtBox6A = new TextBox();
            listBox5 = new ListBox();
            btnStart6 = new Button();
            label18 = new Label();
            label17 = new Label();
            pictureBox4 = new PictureBox();
            tabPage6 = new TabPage();
            btnClear7 = new Button();
            listBox6 = new ListBox();
            btnStart7 = new Button();
            txtBox7A = new TextBox();
            label20 = new Label();
            label19 = new Label();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.LightGray;
            tabPage7.Controls.Add(btnClear1);
            tabPage7.Controls.Add(btnStart1);
            tabPage7.Controls.Add(label2);
            tabPage7.Controls.Add(txtX);
            tabPage7.Controls.Add(lblResult);
            tabPage7.Controls.Add(label1);
            tabPage7.Controls.Add(pictureBox1);
            tabPage7.Location = new Point(4, 30);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(859, 452);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Завдання 1";
            // 
            // btnClear1
            // 
            btnClear1.BackColor = Color.LightCoral;
            btnClear1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear1.Location = new Point(322, 354);
            btnClear1.Name = "btnClear1";
            btnClear1.Size = new Size(96, 40);
            btnClear1.TabIndex = 10;
            btnClear1.Text = "Clear";
            btnClear1.UseVisualStyleBackColor = false;
            btnClear1.Click += btnClear1_Click;
            // 
            // btnStart1
            // 
            btnStart1.BackColor = Color.PaleGreen;
            btnStart1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart1.Location = new Point(322, 308);
            btnStart1.Name = "btnStart1";
            btnStart1.Size = new Size(96, 40);
            btnStart1.TabIndex = 9;
            btnStart1.Text = "Start";
            btnStart1.UseVisualStyleBackColor = false;
            btnStart1.Click += btnStart1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(853, 54);
            label2.TabIndex = 8;
            label2.Text = "Обчислити значення виразу за формулою (усі змінні приймають дійсні значення): \r\n\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtX
            // 
            txtX.Location = new Point(324, 255);
            txtX.Name = "txtX";
            txtX.Size = new Size(94, 29);
            txtX.TabIndex = 4;
            txtX.TextChanged += txtX_TextChanged;
            txtX.KeyPress += txtX_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Times New Roman", 20.25F);
            lblResult.Location = new Point(453, 253);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(90, 31);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result:";
            lblResult.TextChanged += txtX_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(243, 253);
            label1.Name = "label1";
            label1.Size = new Size(55, 31);
            label1.TabIndex = 1;
            label1.Text = "X =";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(867, 486);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(btnClear2);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(txtboxY);
            tabPage1.Controls.Add(txtboxA);
            tabPage1.Controls.Add(txtboxB);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btnStart2);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(859, 452);
            tabPage1.TabIndex = 7;
            tabPage1.Text = "Завдання 2";
            // 
            // btnClear2
            // 
            btnClear2.BackColor = Color.Salmon;
            btnClear2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear2.Location = new Point(356, 377);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(99, 43);
            btnClear2.TabIndex = 10;
            btnClear2.Text = "Clear";
            btnClear2.UseVisualStyleBackColor = false;
            btnClear2.Click += btnClear2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(488, 305);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(285, 118);
            listBox1.TabIndex = 9;
            // 
            // txtboxY
            // 
            txtboxY.Location = new Point(224, 388);
            txtboxY.Name = "txtboxY";
            txtboxY.Size = new Size(100, 29);
            txtboxY.TabIndex = 8;
            // 
            // txtboxA
            // 
            txtboxA.Location = new Point(224, 303);
            txtboxA.Name = "txtboxA";
            txtboxA.Size = new Size(100, 29);
            txtboxA.TabIndex = 7;
            // 
            // txtboxB
            // 
            txtboxB.Location = new Point(224, 343);
            txtboxB.Name = "txtboxB";
            txtboxB.Size = new Size(100, 29);
            txtboxB.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F);
            label6.Location = new Point(185, 386);
            label6.Name = "label6";
            label6.Size = new Size(33, 31);
            label6.TabIndex = 5;
            label6.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20.25F);
            label5.Location = new Point(186, 343);
            label5.Name = "label5";
            label5.Size = new Size(28, 31);
            label5.TabIndex = 4;
            label5.Text = "b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F);
            label4.Location = new Point(188, 295);
            label4.Name = "label4";
            label4.Size = new Size(26, 31);
            label4.TabIndex = 3;
            label4.Text = "a";
            // 
            // btnStart2
            // 
            btnStart2.BackColor = Color.PaleGreen;
            btnStart2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart2.Location = new Point(356, 303);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(99, 39);
            btnStart2.TabIndex = 2;
            btnStart2.Text = "Start";
            btnStart2.UseVisualStyleBackColor = false;
            btnStart2.Click += btnStart2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(757, 221);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(52, 17);
            label3.Name = "label3";
            label3.Size = new Size(753, 23);
            label3.TabIndex = 0;
            label3.Text = "Знайти площу трикутника, дві сторони якого рівні a й b, а кут між цими сторонами y";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(btnClear3);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(txtBox3D);
            tabPage2.Controls.Add(txtBox3C);
            tabPage2.Controls.Add(txtBox3B);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtBox3A);
            tabPage2.Controls.Add(btnStart3);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(859, 452);
            tabPage2.TabIndex = 8;
            tabPage2.Text = "Завдання 3";
            // 
            // btnClear3
            // 
            btnClear3.BackColor = Color.Coral;
            btnClear3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear3.Location = new Point(683, 384);
            btnClear3.Name = "btnClear3";
            btnClear3.Size = new Size(109, 45);
            btnClear3.TabIndex = 12;
            btnClear3.Text = "Clear";
            btnClear3.UseVisualStyleBackColor = false;
            btnClear3.Click += btnClear3_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(620, 259);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(224, 55);
            listBox2.TabIndex = 11;
            // 
            // txtBox3D
            // 
            txtBox3D.Location = new Point(683, 204);
            txtBox3D.Name = "txtBox3D";
            txtBox3D.Size = new Size(100, 29);
            txtBox3D.TabIndex = 10;
            // 
            // txtBox3C
            // 
            txtBox3C.Location = new Point(683, 169);
            txtBox3C.Name = "txtBox3C";
            txtBox3C.Size = new Size(100, 29);
            txtBox3C.TabIndex = 9;
            // 
            // txtBox3B
            // 
            txtBox3B.Location = new Point(683, 136);
            txtBox3B.Name = "txtBox3B";
            txtBox3B.Size = new Size(100, 29);
            txtBox3B.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20.25F);
            label11.Location = new Point(646, 195);
            label11.Name = "label11";
            label11.Size = new Size(28, 31);
            label11.TabIndex = 7;
            label11.Text = "d";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 20.25F);
            label10.Location = new Point(646, 160);
            label10.Name = "label10";
            label10.Size = new Size(26, 31);
            label10.TabIndex = 6;
            label10.Text = "c";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 20.25F);
            label9.Location = new Point(646, 128);
            label9.Name = "label9";
            label9.Size = new Size(28, 31);
            label9.TabIndex = 5;
            label9.Text = "b";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 20.25F);
            label8.Location = new Point(646, 93);
            label8.Name = "label8";
            label8.Size = new Size(26, 31);
            label8.TabIndex = 4;
            label8.Text = "a";
            // 
            // txtBox3A
            // 
            txtBox3A.Location = new Point(683, 101);
            txtBox3A.Name = "txtBox3A";
            txtBox3A.Size = new Size(100, 29);
            txtBox3A.TabIndex = 3;
            // 
            // btnStart3
            // 
            btnStart3.BackColor = Color.PaleGreen;
            btnStart3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart3.Location = new Point(683, 335);
            btnStart3.Name = "btnStart3";
            btnStart3.Size = new Size(109, 43);
            btnStart3.TabIndex = 2;
            btnStart3.Text = "Start";
            btnStart3.UseVisualStyleBackColor = false;
            btnStart3.Click += btnStart3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(582, 320);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(22, 19);
            label7.Name = "label7";
            label7.Size = new Size(792, 57);
            label7.TabIndex = 0;
            label7.Text = resources.GetString("label7.Text");
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightGray;
            tabPage3.Controls.Add(btnClear4);
            tabPage3.Controls.Add(btnStart4);
            tabPage3.Controls.Add(listBox3);
            tabPage3.Controls.Add(txtBox4B);
            tabPage3.Controls.Add(txtBox4C);
            tabPage3.Controls.Add(txtBox4A);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(859, 452);
            tabPage3.TabIndex = 9;
            tabPage3.Text = "Завдання 4";
            // 
            // btnClear4
            // 
            btnClear4.BackColor = Color.Salmon;
            btnClear4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear4.Location = new Point(243, 320);
            btnClear4.Name = "btnClear4";
            btnClear4.Size = new Size(90, 43);
            btnClear4.TabIndex = 9;
            btnClear4.Text = "Clear";
            btnClear4.UseVisualStyleBackColor = false;
            btnClear4.Click += btnClear4_Click;
            // 
            // btnStart4
            // 
            btnStart4.BackColor = Color.LightGreen;
            btnStart4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart4.Location = new Point(243, 272);
            btnStart4.Name = "btnStart4";
            btnStart4.Size = new Size(90, 42);
            btnStart4.TabIndex = 8;
            btnStart4.Text = "Start";
            btnStart4.UseVisualStyleBackColor = false;
            btnStart4.Click += btnStart4_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(414, 130);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(344, 235);
            listBox3.TabIndex = 7;
            // 
            // txtBox4B
            // 
            txtBox4B.Location = new Point(233, 170);
            txtBox4B.Name = "txtBox4B";
            txtBox4B.Size = new Size(100, 29);
            txtBox4B.TabIndex = 6;
            // 
            // txtBox4C
            // 
            txtBox4C.Location = new Point(233, 213);
            txtBox4C.Name = "txtBox4C";
            txtBox4C.Size = new Size(100, 29);
            txtBox4C.TabIndex = 5;
            // 
            // txtBox4A
            // 
            txtBox4A.Location = new Point(233, 130);
            txtBox4A.Name = "txtBox4A";
            txtBox4A.Size = new Size(100, 29);
            txtBox4A.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 20.25F);
            label15.Location = new Point(47, 205);
            label15.Name = "label15";
            label15.Size = new Size(153, 31);
            label15.TabIndex = 3;
            label15.Text = "Третє число";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 20.25F);
            label14.Location = new Point(44, 162);
            label14.Name = "label14";
            label14.Size = new Size(156, 31);
            label14.TabIndex = 2;
            label14.Text = "Друге число";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 20.25F);
            label13.Location = new Point(44, 121);
            label13.Name = "label13";
            label13.Size = new Size(166, 31);
            label13.TabIndex = 1;
            label13.Text = "Перше число";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(31, 20);
            label12.Name = "label12";
            label12.Size = new Size(742, 62);
            label12.TabIndex = 0;
            label12.Text = "Написати програму, яка за заданими трьома числами визначає, \r\nчи є сума яких-небудь двох з них позитивною.";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightGray;
            tabPage4.Controls.Add(listBox4);
            tabPage4.Controls.Add(btnStart5);
            tabPage4.Controls.Add(label16);
            tabPage4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(859, 452);
            tabPage4.TabIndex = 10;
            tabPage4.Text = "Завдання 5";
            // 
            // listBox4
            // 
            listBox4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(23, 160);
            listBox4.Name = "listBox4";
            listBox4.RightToLeft = RightToLeft.No;
            listBox4.Size = new Size(809, 172);
            listBox4.TabIndex = 2;
            // 
            // btnStart5
            // 
            btnStart5.BackColor = Color.LightGreen;
            btnStart5.Location = new Point(23, 357);
            btnStart5.Name = "btnStart5";
            btnStart5.Size = new Size(809, 42);
            btnStart5.TabIndex = 1;
            btnStart5.Text = "Start";
            btnStart5.UseVisualStyleBackColor = false;
            btnStart5.Click += btnStart5_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(23, 16);
            label16.Name = "label16";
            label16.Size = new Size(688, 124);
            label16.TabIndex = 0;
            label16.Text = "Довгожитель (вік не менше 100 років) виявив одного разу, \r\nщо якщо до суми квадратів цифр його віку додати число \r\nдня його народження, так само вийде його вік. \r\nСкільки років довгожителеві?";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.LightGray;
            tabPage5.Controls.Add(btnClear6);
            tabPage5.Controls.Add(txtBox6B);
            tabPage5.Controls.Add(txtBox6A);
            tabPage5.Controls.Add(listBox5);
            tabPage5.Controls.Add(btnStart6);
            tabPage5.Controls.Add(label18);
            tabPage5.Controls.Add(label17);
            tabPage5.Controls.Add(pictureBox4);
            tabPage5.Location = new Point(4, 30);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(859, 452);
            tabPage5.TabIndex = 11;
            tabPage5.Text = "Завдання 6";
            // 
            // btnClear6
            // 
            btnClear6.BackColor = Color.Salmon;
            btnClear6.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear6.Location = new Point(452, 270);
            btnClear6.Name = "btnClear6";
            btnClear6.Size = new Size(97, 49);
            btnClear6.TabIndex = 7;
            btnClear6.Text = "Clear";
            btnClear6.UseVisualStyleBackColor = false;
            btnClear6.Click += btnClear6_Click;
            // 
            // txtBox6B
            // 
            txtBox6B.Location = new Point(289, 213);
            txtBox6B.Name = "txtBox6B";
            txtBox6B.Size = new Size(100, 29);
            txtBox6B.TabIndex = 6;
            // 
            // txtBox6A
            // 
            txtBox6A.Location = new Point(289, 158);
            txtBox6A.Name = "txtBox6A";
            txtBox6A.Size = new Size(100, 29);
            txtBox6A.TabIndex = 5;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.Location = new Point(452, 149);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(238, 88);
            listBox5.TabIndex = 4;
            // 
            // btnStart6
            // 
            btnStart6.BackColor = Color.LightGreen;
            btnStart6.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart6.Location = new Point(289, 270);
            btnStart6.Name = "btnStart6";
            btnStart6.Size = new Size(100, 49);
            btnStart6.TabIndex = 3;
            btnStart6.Text = "Start";
            btnStart6.UseVisualStyleBackColor = false;
            btnStart6.Click += btnStart6_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 20.25F);
            label18.Location = new Point(27, 205);
            label18.Name = "label18";
            label18.Size = new Size(241, 31);
            label18.TabIndex = 2;
            label18.Text = "array 2 (b1, b2,.. bn)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 20.25F);
            label17.Location = new Point(27, 149);
            label17.Name = "label17";
            label17.Size = new Size(228, 31);
            label17.TabIndex = 1;
            label17.Text = "array 1 (a1, a2,..an)";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(853, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.LightGray;
            tabPage6.Controls.Add(btnClear7);
            tabPage6.Controls.Add(listBox6);
            tabPage6.Controls.Add(btnStart7);
            tabPage6.Controls.Add(txtBox7A);
            tabPage6.Controls.Add(label20);
            tabPage6.Controls.Add(label19);
            tabPage6.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage6.Location = new Point(4, 30);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(859, 452);
            tabPage6.TabIndex = 12;
            tabPage6.Text = "Завдання 7";
            // 
            // btnClear7
            // 
            btnClear7.BackColor = Color.Salmon;
            btnClear7.Location = new Point(453, 194);
            btnClear7.Name = "btnClear7";
            btnClear7.Size = new Size(139, 42);
            btnClear7.TabIndex = 5;
            btnClear7.Text = "Clear";
            btnClear7.UseVisualStyleBackColor = false;
            btnClear7.Click += btnClear7_Click;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.Location = new Point(271, 266);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(380, 128);
            listBox6.TabIndex = 4;
            // 
            // btnStart7
            // 
            btnStart7.BackColor = Color.LightGreen;
            btnStart7.Location = new Point(308, 193);
            btnStart7.Name = "btnStart7";
            btnStart7.Size = new Size(139, 44);
            btnStart7.TabIndex = 3;
            btnStart7.Text = "Start";
            btnStart7.UseVisualStyleBackColor = false;
            btnStart7.Click += btnStart7_Click;
            // 
            // txtBox7A
            // 
            txtBox7A.Location = new Point(308, 148);
            txtBox7A.Name = "txtBox7A";
            txtBox7A.Size = new Size(284, 39);
            txtBox7A.TabIndex = 2;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(56, 35);
            label20.Name = "label20";
            label20.Size = new Size(761, 31);
            label20.TabIndex = 1;
            label20.Text = "Дано рядок. Визначити, скільки раз входить у неї група букв abc.";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(309, 35);
            label19.Name = "label19";
            label19.Size = new Size(0, 31);
            label19.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 509);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Лабораторна 1 (Зубко 201-ТК) 9 варіант";
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage7;
        private TextBox txtX;
        private Label lblResult;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtboxY;
        private TextBox txtboxA;
        private TextBox txtboxB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnStart2;
        private ListBox listBox1;
        private TabPage tabPage2;
        private Label label7;
        private ListBox listBox2;
        private TextBox txtBox3D;
        private TextBox txtBox3C;
        private TextBox txtBox3B;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtBox3A;
        private Button btnStart3;
        private PictureBox pictureBox3;
        private TabPage tabPage3;
        private ListBox listBox3;
        private TextBox txtBox4B;
        private TextBox txtBox4C;
        private TextBox txtBox4A;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button btnStart4;
        private TabPage tabPage4;
        private Label label16;
        private ListBox listBox4;
        private Button btnStart5;
        private TabPage tabPage5;
        private PictureBox pictureBox4;
        private TextBox txtBox6B;
        private TextBox txtBox6A;
        private ListBox listBox5;
        private Button btnStart6;
        private Label label18;
        private Label label17;
        private TabPage tabPage6;
        private Label label20;
        private Label label19;
        private ListBox listBox6;
        private Button btnStart7;
        private TextBox txtBox7A;
        private Button btnClear2;
        private Button btnStart1;
        private Button btnClear1;
        private Button btnClear3;
        private Button btnClear4;
        private Button btnClear7;
        private Button btnClear6;
    }
}
