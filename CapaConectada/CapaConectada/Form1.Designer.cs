namespace CapaConectada
{
    partial class Form1
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
            System.Windows.Forms.Button btnBuscar;
            System.Windows.Forms.Button btnAgregar;
            System.Windows.Forms.Button btnActualizar;
            System.Windows.Forms.Button btnEliminar;
            this.btnCargar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCutomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            btnBuscar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(879, 132);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(843, 363);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(109, 23);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 373);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(152, 65);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar informacion";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 62);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(776, 273);
            this.dataGrid.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(947, 94);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer ID";
            // 
            // txtCutomerId
            // 
            this.txtCutomerId.Location = new System.Drawing.Point(947, 184);
            this.txtCutomerId.Name = "txtCutomerId";
            this.txtCutomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCutomerId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(947, 214);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact Title";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(947, 243);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(100, 20);
            this.txtContactTitle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(947, 298);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(947, 324);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(853, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contact Name";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(947, 269);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 20);
            this.txtContactName.TabIndex = 17;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new System.Drawing.Point(958, 363);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(109, 23);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar Cliente";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(899, 392);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(109, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar Cliente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnActualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCutomerId);
            this.Controls.Add(btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCutomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactName;
    }
}

