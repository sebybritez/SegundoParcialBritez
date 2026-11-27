namespace Presentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.dgvCuerpos = new System.Windows.Forms.DataGridView();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.lblSatelite = new System.Windows.Forms.Label();
            this.cmbSatelite = new System.Windows.Forms.ComboBox();
            this.btnAltaSatelite = new System.Windows.Forms.Button();
            this.dgvSatelites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuerpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatelites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 19);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 56);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(80, 53);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(220, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(325, 17);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(122, 42);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(464, 17);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 42);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(325, 65);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(122, 42);
            this.btnBaja.TabIndex = 6;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // dgvCuerpos
            // 
            this.dgvCuerpos.AllowUserToAddRows = false;
            this.dgvCuerpos.AllowUserToDeleteRows = false;
            this.dgvCuerpos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuerpos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuerpos.Location = new System.Drawing.Point(23, 120);
            this.dgvCuerpos.MultiSelect = false;
            this.dgvCuerpos.Name = "dgvCuerpos";
            this.dgvCuerpos.ReadOnly = true;
            this.dgvCuerpos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuerpos.Size = new System.Drawing.Size(622, 175);
            this.dgvCuerpos.TabIndex = 8;
            this.dgvCuerpos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuerpos_CellClick);
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(23, 315);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(46, 13);
            this.lblPlaneta.TabIndex = 9;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(80, 312);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(180, 21);
            this.cmbPlaneta.TabIndex = 10;
            // 
            // lblSatelite
            // 
            this.lblSatelite.AutoSize = true;
            this.lblSatelite.Location = new System.Drawing.Point(275, 315);
            this.lblSatelite.Name = "lblSatelite";
            this.lblSatelite.Size = new System.Drawing.Size(45, 13);
            this.lblSatelite.TabIndex = 11;
            this.lblSatelite.Text = "Satélite:";
            // 
            // cmbSatelite
            // 
            this.cmbSatelite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatelite.FormattingEnabled = true;
            this.cmbSatelite.Location = new System.Drawing.Point(330, 312);
            this.cmbSatelite.Name = "cmbSatelite";
            this.cmbSatelite.Size = new System.Drawing.Size(180, 21);
            this.cmbSatelite.TabIndex = 12;
            // 
            // btnAltaSatelite
            // 
            this.btnAltaSatelite.Location = new System.Drawing.Point(525, 309);
            this.btnAltaSatelite.Name = "btnAltaSatelite";
            this.btnAltaSatelite.Size = new System.Drawing.Size(120, 27);
            this.btnAltaSatelite.TabIndex = 13;
            this.btnAltaSatelite.Text = "Alta Satélite";
            this.btnAltaSatelite.UseVisualStyleBackColor = true;
            this.btnAltaSatelite.Click += new System.EventHandler(this.btnAltaSatelite_Click);
            // 
            // dgvSatelites
            // 
            this.dgvSatelites.AllowUserToAddRows = false;
            this.dgvSatelites.AllowUserToDeleteRows = false;
            this.dgvSatelites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatelites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatelites.Location = new System.Drawing.Point(23, 348);
            this.dgvSatelites.MultiSelect = false;
            this.dgvSatelites.Name = "dgvSatelites";
            this.dgvSatelites.ReadOnly = true;
            this.dgvSatelites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatelites.Size = new System.Drawing.Size(622, 165);
            this.dgvSatelites.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 530);
            this.Controls.Add(this.dgvSatelites);
            this.Controls.Add(this.btnAltaSatelite);
            this.Controls.Add(this.cmbSatelite);
            this.Controls.Add(this.lblSatelite);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.dgvCuerpos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuerpos Celestes y Satélites (4 Capas)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuerpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatelites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridView dgvCuerpos;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Label lblSatelite;
        private System.Windows.Forms.ComboBox cmbSatelite;
        private System.Windows.Forms.Button btnAltaSatelite;
        private System.Windows.Forms.DataGridView dgvSatelites;
    }
}
