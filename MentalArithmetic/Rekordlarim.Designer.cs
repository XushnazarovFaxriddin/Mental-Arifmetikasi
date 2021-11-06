using MentalArithmetic.Scripts;
namespace MentalArithmetic
{
    partial class Rekordlarim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rekordlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rekordlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaqt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umumiyHisob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hisob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rekordlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rekordlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.vaqt,
            this.xato,
            this.umumiyHisob,
            this.hisob,
            this.foizDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.rekordlarBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(897, 500);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // rekordlarBindingSource1
            // 
            this.rekordlarBindingSource1.DataSource = typeof(Rekordlar);
            // 
            // rekordlarBindingSource
            // 
            this.rekordlarBindingSource.DataSource = typeof(Rekordlar);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // vaqt
            // 
            this.vaqt.DataPropertyName = "vaqt";
            this.vaqt.HeaderText = "Vaqt";
            this.vaqt.Name = "vaqt";
            this.vaqt.Width = 200;
            // 
            // xato
            // 
            this.xato.DataPropertyName = "xato";
            this.xato.HeaderText = "Xato ishlanganlar";
            this.xato.Name = "xato";
            this.xato.Width = 150;
            // 
            // umumiyHisob
            // 
            this.umumiyHisob.DataPropertyName = "umumiyHisob";
            this.umumiyHisob.HeaderText = "Jami misollar";
            this.umumiyHisob.Name = "umumiyHisob";
            this.umumiyHisob.Width = 150;
            // 
            // hisob
            // 
            this.hisob.DataPropertyName = "hisob";
            this.hisob.HeaderText = "To\'g\'ri ishlanganlar";
            this.hisob.Name = "hisob";
            this.hisob.Width = 150;
            // 
            // foizDataGridViewTextBoxColumn
            // 
            this.foizDataGridViewTextBoxColumn.DataPropertyName = "foiz";
            this.foizDataGridViewTextBoxColumn.HeaderText = "Foizlar";
            this.foizDataGridViewTextBoxColumn.Name = "foizDataGridViewTextBoxColumn";
            this.foizDataGridViewTextBoxColumn.Width = 150;
            // 
            // Rekordlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Rekordlarim";
            this.Text = "Rekordlarim";
            this.Load += new System.EventHandler(this.Rekordlarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rekordlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rekordlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource rekordlarBindingSource;
        private System.Windows.Forms.BindingSource rekordlarBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaqtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hisobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umumiyHisobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaqt;
        private System.Windows.Forms.DataGridViewTextBoxColumn xato;
        private System.Windows.Forms.DataGridViewTextBoxColumn umumiyHisob;
        private System.Windows.Forms.DataGridViewTextBoxColumn hisob;
        private System.Windows.Forms.DataGridViewTextBoxColumn foizDataGridViewTextBoxColumn;
    }
}