
namespace Kirtasiye_App
{
    partial class MalzemeEkleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeEkleFrm));
            this.ad_txt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.stok_txt = new DevExpress.XtraEditors.TextEdit();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ad_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(167, 34);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_txt.Properties.Appearance.Options.UseFont = true;
            this.ad_txt.Size = new System.Drawing.Size(114, 24);
            this.ad_txt.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(62, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Malzeme Adı";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(115, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Stok";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Kategori Adı";
            // 
            // stok_txt
            // 
            this.stok_txt.Location = new System.Drawing.Point(167, 74);
            this.stok_txt.Name = "stok_txt";
            this.stok_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_txt.Properties.Appearance.Options.UseFont = true;
            this.stok_txt.Size = new System.Drawing.Size(114, 24);
            this.stok_txt.TabIndex = 9;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.kaydetBtn.Location = new System.Drawing.Point(167, 157);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(114, 42);
            this.kaydetBtn.TabIndex = 11;
            this.kaydetBtn.Text = "KAYDET";
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // MalzemeEkleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.stok_txt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ad_txt);
            this.Name = "MalzemeEkleFrm";
            this.Text = "MalzemeEkleFrm";
            this.Load += new System.EventHandler(this.MalzemeEkleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ad_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ad_txt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit stok_txt;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}