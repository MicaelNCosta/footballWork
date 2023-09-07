
namespace projeto1
{
    partial class frmtimes
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
            this.dataGVtimes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVtimes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVtimes
            // 
            this.dataGVtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVtimes.Location = new System.Drawing.Point(12, 29);
            this.dataGVtimes.Name = "dataGVtimes";
            this.dataGVtimes.Size = new System.Drawing.Size(783, 391);
            this.dataGVtimes.TabIndex = 0;
            this.dataGVtimes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmtimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 460);
            this.Controls.Add(this.dataGVtimes);
            this.Name = "frmtimes";
            this.Text = "frmtimes";
            this.Load += new System.EventHandler(this.frmtimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVtimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVtimes;
    }
}