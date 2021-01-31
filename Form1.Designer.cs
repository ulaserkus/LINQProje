
namespace LINQProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_all_numbers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_negative = new System.Windows.Forms.Button();
            this.btn_positive = new System.Windows.Forms.Button();
            this.btn_even = new System.Windows.Forms.Button();
            this.btn_odd = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_names_asc = new System.Windows.Forms.Button();
            this.btn_names_desc = new System.Windows.Forms.Button();
            this.btn_names_length = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_first_A = new System.Windows.Forms.Button();
            this.btn_orders_all = new System.Windows.Forms.Button();
            this.btn_date = new System.Windows.Forms.Button();
            this.btn_top_5 = new System.Windows.Forms.Button();
            this.btn_last_5 = new System.Windows.Forms.Button();
            this.btn_john = new System.Windows.Forms.Button();
            this.btn_orders_count = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_all_numbers
            // 
            this.btn_all_numbers.Location = new System.Drawing.Point(12, 12);
            this.btn_all_numbers.Name = "btn_all_numbers";
            this.btn_all_numbers.Size = new System.Drawing.Size(211, 79);
            this.btn_all_numbers.TabIndex = 0;
            this.btn_all_numbers.Text = "Tüm Sayılar";
            this.btn_all_numbers.UseVisualStyleBackColor = true;
            this.btn_all_numbers.Click += new System.EventHandler(this.btn_all_numbers_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(15, 329);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 329);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1552, 328);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_negative
            // 
            this.btn_negative.Location = new System.Drawing.Point(229, 12);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(211, 79);
            this.btn_negative.TabIndex = 3;
            this.btn_negative.Text = "Negatif Sayılar";
            this.btn_negative.UseVisualStyleBackColor = true;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // btn_positive
            // 
            this.btn_positive.Location = new System.Drawing.Point(446, 12);
            this.btn_positive.Name = "btn_positive";
            this.btn_positive.Size = new System.Drawing.Size(211, 79);
            this.btn_positive.TabIndex = 4;
            this.btn_positive.Text = "Pozitif Sayılar";
            this.btn_positive.UseVisualStyleBackColor = true;
            this.btn_positive.Click += new System.EventHandler(this.btn_positive_Click);
            // 
            // btn_even
            // 
            this.btn_even.Location = new System.Drawing.Point(663, 12);
            this.btn_even.Name = "btn_even";
            this.btn_even.Size = new System.Drawing.Size(211, 79);
            this.btn_even.TabIndex = 5;
            this.btn_even.Text = "Çift Sayılar";
            this.btn_even.UseVisualStyleBackColor = true;
            this.btn_even.Click += new System.EventHandler(this.btn_even_Click);
            // 
            // btn_odd
            // 
            this.btn_odd.Location = new System.Drawing.Point(880, 12);
            this.btn_odd.Name = "btn_odd";
            this.btn_odd.Size = new System.Drawing.Size(211, 79);
            this.btn_odd.TabIndex = 6;
            this.btn_odd.Text = "Tek Sayılar";
            this.btn_odd.UseVisualStyleBackColor = true;
            this.btn_odd.Click += new System.EventHandler(this.btn_odd_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(1097, 12);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(211, 79);
            this.btn_max.TabIndex = 7;
            this.btn_max.Text = "En Büyük Sayı";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(1314, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(211, 79);
            this.btn_min.TabIndex = 8;
            this.btn_min.Text = "En Küçük Sayı";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(12, 97);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(211, 79);
            this.btn_count.TabIndex = 9;
            this.btn_count.Text = " Sayı Miktarı";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_names_asc
            // 
            this.btn_names_asc.Location = new System.Drawing.Point(229, 97);
            this.btn_names_asc.Name = "btn_names_asc";
            this.btn_names_asc.Size = new System.Drawing.Size(211, 79);
            this.btn_names_asc.TabIndex = 10;
            this.btn_names_asc.Text = "Alfabetik";
            this.btn_names_asc.UseVisualStyleBackColor = true;
            this.btn_names_asc.Click += new System.EventHandler(this.btn_names_asc_Click);
            // 
            // btn_names_desc
            // 
            this.btn_names_desc.Location = new System.Drawing.Point(446, 97);
            this.btn_names_desc.Name = "btn_names_desc";
            this.btn_names_desc.Size = new System.Drawing.Size(211, 79);
            this.btn_names_desc.TabIndex = 11;
            this.btn_names_desc.Text = "Ters Alfabetik";
            this.btn_names_desc.UseVisualStyleBackColor = true;
            this.btn_names_desc.Click += new System.EventHandler(this.btn_names_desc_Click);
            // 
            // btn_names_length
            // 
            this.btn_names_length.Location = new System.Drawing.Point(663, 97);
            this.btn_names_length.Name = "btn_names_length";
            this.btn_names_length.Size = new System.Drawing.Size(211, 79);
            this.btn_names_length.TabIndex = 12;
            this.btn_names_length.Text = "Uzunluk Sıralama";
            this.btn_names_length.UseVisualStyleBackColor = true;
            this.btn_names_length.Click += new System.EventHandler(this.btn_names_length_Click);
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(880, 97);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(211, 79);
            this.btn_A.TabIndex = 13;
            this.btn_A.Text = "A Harfi İçerenler";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_first_A
            // 
            this.btn_first_A.Location = new System.Drawing.Point(1097, 97);
            this.btn_first_A.Name = "btn_first_A";
            this.btn_first_A.Size = new System.Drawing.Size(211, 79);
            this.btn_first_A.TabIndex = 14;
            this.btn_first_A.Text = "A Harfi İle Başlayanlar";
            this.btn_first_A.UseVisualStyleBackColor = true;
            this.btn_first_A.Click += new System.EventHandler(this.btn_first_A_Click);
            // 
            // btn_orders_all
            // 
            this.btn_orders_all.Location = new System.Drawing.Point(12, 182);
            this.btn_orders_all.Name = "btn_orders_all";
            this.btn_orders_all.Size = new System.Drawing.Size(211, 79);
            this.btn_orders_all.TabIndex = 15;
            this.btn_orders_all.Text = "Tüm Siparişleri Getir";
            this.btn_orders_all.UseVisualStyleBackColor = true;
            this.btn_orders_all.Click += new System.EventHandler(this.btn_orders_all_Click);
            // 
            // btn_date
            // 
            this.btn_date.Location = new System.Drawing.Point(229, 182);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(211, 79);
            this.btn_date.TabIndex = 16;
            this.btn_date.Text = "Sadece Tarihler";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // btn_top_5
            // 
            this.btn_top_5.Location = new System.Drawing.Point(446, 182);
            this.btn_top_5.Name = "btn_top_5";
            this.btn_top_5.Size = new System.Drawing.Size(211, 79);
            this.btn_top_5.TabIndex = 17;
            this.btn_top_5.Text = "İlk 5 Kayıt";
            this.btn_top_5.UseVisualStyleBackColor = true;
            this.btn_top_5.Click += new System.EventHandler(this.btn_top_5_Click);
            // 
            // btn_last_5
            // 
            this.btn_last_5.Location = new System.Drawing.Point(663, 182);
            this.btn_last_5.Name = "btn_last_5";
            this.btn_last_5.Size = new System.Drawing.Size(211, 79);
            this.btn_last_5.TabIndex = 18;
            this.btn_last_5.Text = "Son 5 Kayıt";
            this.btn_last_5.UseVisualStyleBackColor = true;
            this.btn_last_5.Click += new System.EventHandler(this.btn_last_5_Click);
            // 
            // btn_john
            // 
            this.btn_john.Location = new System.Drawing.Point(880, 182);
            this.btn_john.Name = "btn_john";
            this.btn_john.Size = new System.Drawing.Size(211, 79);
            this.btn_john.TabIndex = 19;
            this.btn_john.Text = "John Steel Kullanıcısı";
            this.btn_john.UseVisualStyleBackColor = true;
            this.btn_john.Click += new System.EventHandler(this.btn_john_Click);
            // 
            // btn_orders_count
            // 
            this.btn_orders_count.Location = new System.Drawing.Point(1097, 182);
            this.btn_orders_count.Name = "btn_orders_count";
            this.btn_orders_count.Size = new System.Drawing.Size(211, 79);
            this.btn_orders_count.TabIndex = 20;
            this.btn_orders_count.Text = "Sipariş Sayısı";
            this.btn_orders_count.UseVisualStyleBackColor = true;
            this.btn_orders_count.Click += new System.EventHandler(this.btn_orders_count_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 706);
            this.Controls.Add(this.btn_orders_count);
            this.Controls.Add(this.btn_john);
            this.Controls.Add(this.btn_last_5);
            this.Controls.Add(this.btn_top_5);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.btn_orders_all);
            this.Controls.Add(this.btn_first_A);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.btn_names_length);
            this.Controls.Add(this.btn_names_desc);
            this.Controls.Add(this.btn_names_asc);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_odd);
            this.Controls.Add(this.btn_even);
            this.Controls.Add(this.btn_positive);
            this.Controls.Add(this.btn_negative);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_all_numbers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_all_numbers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.Button btn_positive;
        private System.Windows.Forms.Button btn_even;
        private System.Windows.Forms.Button btn_odd;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_names_asc;
        private System.Windows.Forms.Button btn_names_desc;
        private System.Windows.Forms.Button btn_names_length;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_first_A;
        private System.Windows.Forms.Button btn_orders_all;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.Button btn_top_5;
        private System.Windows.Forms.Button btn_last_5;
        private System.Windows.Forms.Button btn_john;
        private System.Windows.Forms.Button btn_orders_count;
    }
}

