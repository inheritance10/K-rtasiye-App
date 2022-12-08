
namespace Kirtasiye_App
{
    partial class MalzemelerForm
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
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kirtasiyeDBDataSet = new Kirtasiye_App.kirtasiyeDBDataSet();
            this.malzemeTableAdapter = new Kirtasiye_App.kirtasiyeDBDataSetTableAdapters.malzemeTableAdapter();
            this.kirtasiyeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirtasiyeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirtasiyeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataMember = "malzeme";
            this.malzemeBindingSource.DataSource = this.kirtasiyeDBDataSet;
            // 
            // kirtasiyeDBDataSet
            // 
            this.kirtasiyeDBDataSet.DataSetName = "kirtasiyeDBDataSet";
            this.kirtasiyeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemeTableAdapter
            // 
            this.malzemeTableAdapter.ClearBeforeFill = true;
            // 
            // kirtasiyeDBDataSetBindingSource
            // 
            this.kirtasiyeDBDataSetBindingSource.DataSource = this.kirtasiyeDBDataSet;
            this.kirtasiyeDBDataSetBindingSource.Position = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 211);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // MalzemelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.gridControl1);
            this.Name = "MalzemelerForm";
            this.Text = "MalzemelerForm";
            this.Load += new System.EventHandler(this.MalzemelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirtasiyeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirtasiyeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private kirtasiyeDBDataSet kirtasiyeDBDataSet;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private kirtasiyeDBDataSetTableAdapters.malzemeTableAdapter malzemeTableAdapter;
        private System.Windows.Forms.BindingSource kirtasiyeDBDataSetBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}