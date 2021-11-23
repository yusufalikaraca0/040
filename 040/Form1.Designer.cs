
namespace _040
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxKafa = new System.Windows.Forms.PictureBox();
            this.picBoxGovde = new System.Windows.Forms.PictureBox();
            this.picBoxSolEl = new System.Windows.Forms.PictureBox();
            this.picBoxSagEl = new System.Windows.Forms.PictureBox();
            this.picBoxSagBacak = new System.Windows.Forms.PictureBox();
            this.picBoxSolBacak = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGovde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSolEl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSagEl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSagBacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSolBacak)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxKafa
            // 
            this.picBoxKafa.Image = ((System.Drawing.Image)(resources.GetObject("picBoxKafa.Image")));
            this.picBoxKafa.Location = new System.Drawing.Point(104, 7);
            this.picBoxKafa.Name = "picBoxKafa";
            this.picBoxKafa.Size = new System.Drawing.Size(165, 159);
            this.picBoxKafa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKafa.TabIndex = 0;
            this.picBoxKafa.TabStop = false;
            this.picBoxKafa.Visible = false;
            // 
            // picBoxGovde
            // 
            this.picBoxGovde.Image = ((System.Drawing.Image)(resources.GetObject("picBoxGovde.Image")));
            this.picBoxGovde.Location = new System.Drawing.Point(155, 162);
            this.picBoxGovde.Name = "picBoxGovde";
            this.picBoxGovde.Size = new System.Drawing.Size(59, 339);
            this.picBoxGovde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGovde.TabIndex = 1;
            this.picBoxGovde.TabStop = false;
            this.picBoxGovde.Visible = false;
            // 
            // picBoxSolEl
            // 
            this.picBoxSolEl.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSolEl.Image")));
            this.picBoxSolEl.Location = new System.Drawing.Point(12, 162);
            this.picBoxSolEl.Name = "picBoxSolEl";
            this.picBoxSolEl.Size = new System.Drawing.Size(152, 145);
            this.picBoxSolEl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSolEl.TabIndex = 2;
            this.picBoxSolEl.TabStop = false;
            this.picBoxSolEl.Visible = false;
            // 
            // picBoxSagEl
            // 
            this.picBoxSagEl.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSagEl.Image")));
            this.picBoxSagEl.Location = new System.Drawing.Point(206, 162);
            this.picBoxSagEl.Name = "picBoxSagEl";
            this.picBoxSagEl.Size = new System.Drawing.Size(152, 145);
            this.picBoxSagEl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSagEl.TabIndex = 3;
            this.picBoxSagEl.TabStop = false;
            this.picBoxSagEl.Visible = false;
            // 
            // picBoxSagBacak
            // 
            this.picBoxSagBacak.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSagBacak.Image")));
            this.picBoxSagBacak.Location = new System.Drawing.Point(184, 488);
            this.picBoxSagBacak.Name = "picBoxSagBacak";
            this.picBoxSagBacak.Size = new System.Drawing.Size(152, 145);
            this.picBoxSagBacak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSagBacak.TabIndex = 4;
            this.picBoxSagBacak.TabStop = false;
            this.picBoxSagBacak.Visible = false;
            // 
            // picBoxSolBacak
            // 
            this.picBoxSolBacak.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSolBacak.Image")));
            this.picBoxSolBacak.Location = new System.Drawing.Point(35, 488);
            this.picBoxSolBacak.Name = "picBoxSolBacak";
            this.picBoxSolBacak.Size = new System.Drawing.Size(152, 145);
            this.picBoxSolBacak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSolBacak.TabIndex = 5;
            this.picBoxSolBacak.TabStop = false;
            this.picBoxSolBacak.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoxSagEl);
            this.groupBox1.Controls.Add(this.picBoxSolBacak);
            this.groupBox1.Controls.Add(this.picBoxSolEl);
            this.groupBox1.Controls.Add(this.picBoxSagBacak);
            this.groupBox1.Controls.Add(this.picBoxGovde);
            this.groupBox1.Controls.Add(this.picBoxKafa);
            this.groupBox1.Location = new System.Drawing.Point(733, -34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 633);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adam";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Kelime Tahmin Et";
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tahmin Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(602, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGovde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSolEl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSagEl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSagBacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSolBacak)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxKafa;
        private System.Windows.Forms.PictureBox picBoxGovde;
        private System.Windows.Forms.PictureBox picBoxSolEl;
        private System.Windows.Forms.PictureBox picBoxSagEl;
        private System.Windows.Forms.PictureBox picBoxSagBacak;
        private System.Windows.Forms.PictureBox picBoxSolBacak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

