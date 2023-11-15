namespace PrijsOfferteApp
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            button14 = new Button();
            button7 = new Button();
            button5 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            dataGridView4 = new DataGridView();
            btn_zoek = new Button();
            tb_zoek = new TextBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button4 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            label5 = new Label();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button6 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(254, 169);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(650, 267);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-3, 1);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1229, 943);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientActiveCaption;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button14);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(dataGridView4);
            tabPage1.Controls.Add(btn_zoek);
            tabPage1.Controls.Add(tb_zoek);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1221, 910);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Offertes";
            tabPage1.Click += tabPage1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(528, 508);
            label3.Name = "label3";
            label3.Size = new Size(139, 35);
            label3.TabIndex = 16;
            label3.Text = "Event Tabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(518, 41);
            label2.Name = "label2";
            label2.Size = new Size(152, 35);
            label2.TabIndex = 15;
            label2.Text = "Alle Offertes";
            // 
            // button14
            // 
            button14.Location = new Point(975, 349);
            button14.Margin = new Padding(3, 4, 3, 4);
            button14.Name = "button14";
            button14.Size = new Size(128, 75);
            button14.TabIndex = 14;
            button14.Text = "Tel aantal Offertes";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button7
            // 
            button7.Location = new Point(975, 267);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(128, 75);
            button7.TabIndex = 13;
            button7.Text = "Grootste totaal bedrag";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Location = new Point(975, 184);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(128, 75);
            button5.TabIndex = 2;
            button5.Text = "Verwijderen";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 585);
            label1.Name = "label1";
            label1.Size = new Size(422, 28);
            label1.TabIndex = 12;
            label1.Text = "Toon alle offertes met Totaal Bedrag groter dan";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(598, 585);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(795, 587);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(109, 31);
            button3.TabIndex = 10;
            button3.Text = "Toon Offertes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(254, 643);
            dataGridView4.Margin = new Padding(3, 4, 3, 4);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(650, 199);
            dataGridView4.TabIndex = 9;
            // 
            // btn_zoek
            // 
            btn_zoek.Location = new Point(633, 111);
            btn_zoek.Margin = new Padding(3, 4, 3, 4);
            btn_zoek.Name = "btn_zoek";
            btn_zoek.Size = new Size(214, 31);
            btn_zoek.TabIndex = 4;
            btn_zoek.Text = "Zoek Offerte Titel";
            btn_zoek.UseVisualStyleBackColor = true;
            btn_zoek.Click += btn_zoek_Click;
            // 
            // tb_zoek
            // 
            tb_zoek.Location = new Point(295, 112);
            tb_zoek.Margin = new Padding(3, 4, 3, 4);
            tb_zoek.Name = "tb_zoek";
            tb_zoek.Size = new Size(301, 27);
            tb_zoek.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientActiveCaption;
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1221, 910);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bedrijven";
            tabPage2.Click += tabPage2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(469, 28);
            label4.Name = "label4";
            label4.Size = new Size(165, 35);
            label4.TabIndex = 16;
            label4.Text = "Alle Bedrijven";
            // 
            // button10
            // 
            button10.Location = new Point(954, 476);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(128, 75);
            button10.TabIndex = 11;
            button10.Text = "Tel aantal Bedrijven";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(954, 393);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(128, 75);
            button9.TabIndex = 10;
            button9.Text = "Order by Bedrijfnamen     Asc";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(954, 311);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(128, 75);
            button8.TabIndex = 9;
            button8.Text = "Order by Bedrijfnamen Desc";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.Location = new Point(954, 228);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(128, 75);
            button4.TabIndex = 8;
            button4.Text = "Verwijderen";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(635, 105);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(214, 31);
            button1.TabIndex = 7;
            button1.Text = "Zoek Bedrijfnaam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 107);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 27);
            textBox1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(160, 171);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(741, 427);
            dataGridView2.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.GradientActiveCaption;
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(button13);
            tabPage3.Controls.Add(button12);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1221, 910);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Klanten";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(472, 23);
            label5.Name = "label5";
            label5.Size = new Size(146, 35);
            label5.TabIndex = 16;
            label5.Text = "Alle Klanten";
            // 
            // button13
            // 
            button13.Location = new Point(978, 493);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(128, 75);
            button13.TabIndex = 14;
            button13.Text = "Tel aantal Klanten";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(978, 328);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(128, 75);
            button12.TabIndex = 13;
            button12.Text = "Order by Bedrijfnamen Desc";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(978, 411);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(128, 75);
            button11.TabIndex = 12;
            button11.Text = "Order by Bedrijfnamen    Asc";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button6
            // 
            button6.Location = new Point(978, 245);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(128, 75);
            button6.TabIndex = 9;
            button6.Text = "Verwijderen";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(635, 105);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(214, 31);
            button2.TabIndex = 7;
            button2.Text = "Zoek Klantnaam";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 107);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 27);
            textBox2.TabIndex = 6;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(184, 179);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(738, 453);
            dataGridView3.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1215, 939);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Tabellen";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox tb_zoek;
        private Button btn_zoek;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Button button2;
        private TextBox textBox2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Button button3;
        private TextBox textBox3;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button9;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button14;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}