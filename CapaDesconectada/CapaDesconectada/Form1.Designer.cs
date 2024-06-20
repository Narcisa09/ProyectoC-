namespace CapaDesconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarNT = new System.Windows.Forms.Button();
            this.btnInsertarNT = new System.Windows.Forms.Button();
            this.btnBuscarNT = new System.Windows.Forms.Button();
            this.txtBusquedaNT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerNT = new System.Windows.Forms.Button();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.Tipado = new System.Windows.Forms.GroupBox();
            this.btnActualizarT = new System.Windows.Forms.Button();
            this.btnInsertarT = new System.Windows.Forms.Button();
            this.btnBuscarT = new System.Windows.Forms.Button();
            this.txtBuscarT = new System.Windows.Forms.TextBox();
            this.btnObtenerT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactTittle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarNT = new System.Windows.Forms.Button();
            this.btnEliminarT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.Tipado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarNT);
            this.groupBox1.Controls.Add(this.btnActualizarNT);
            this.groupBox1.Controls.Add(this.btnInsertarNT);
            this.groupBox1.Controls.Add(this.btnBuscarNT);
            this.groupBox1.Controls.Add(this.txtBusquedaNT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnObtenerNT);
            this.groupBox1.Controls.Add(this.gridNoTipado);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No Tipado";
            // 
            // btnActualizarNT
            // 
            this.btnActualizarNT.Location = new System.Drawing.Point(116, 351);
            this.btnActualizarNT.Name = "btnActualizarNT";
            this.btnActualizarNT.Size = new System.Drawing.Size(144, 23);
            this.btnActualizarNT.TabIndex = 6;
            this.btnActualizarNT.Text = "Actualizar Cliente";
            this.btnActualizarNT.UseVisualStyleBackColor = true;
            this.btnActualizarNT.Click += new System.EventHandler(this.btnActualizarNT_Click);
            // 
            // btnInsertarNT
            // 
            this.btnInsertarNT.Location = new System.Drawing.Point(6, 352);
            this.btnInsertarNT.Name = "btnInsertarNT";
            this.btnInsertarNT.Size = new System.Drawing.Size(104, 23);
            this.btnInsertarNT.TabIndex = 5;
            this.btnInsertarNT.Text = "Insertar Cliente";
            this.btnInsertarNT.UseVisualStyleBackColor = true;
            this.btnInsertarNT.Click += new System.EventHandler(this.btnInsertarNT_Click);
            // 
            // btnBuscarNT
            // 
            this.btnBuscarNT.Location = new System.Drawing.Point(238, 323);
            this.btnBuscarNT.Name = "btnBuscarNT";
            this.btnBuscarNT.Size = new System.Drawing.Size(144, 23);
            this.btnBuscarNT.TabIndex = 4;
            this.btnBuscarNT.Text = "Buscar Cliente";
            this.btnBuscarNT.UseVisualStyleBackColor = true;
            this.btnBuscarNT.Click += new System.EventHandler(this.btnBuscarNT_Click);
            // 
            // txtBusquedaNT
            // 
            this.txtBusquedaNT.Location = new System.Drawing.Point(101, 325);
            this.txtBusquedaNT.Name = "txtBusquedaNT";
            this.txtBusquedaNT.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaNT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Cliente";
            // 
            // btnObtenerNT
            // 
            this.btnObtenerNT.Location = new System.Drawing.Point(7, 250);
            this.btnObtenerNT.Name = "btnObtenerNT";
            this.btnObtenerNT.Size = new System.Drawing.Size(342, 40);
            this.btnObtenerNT.TabIndex = 1;
            this.btnObtenerNT.Text = "Obtener Datos";
            this.btnObtenerNT.UseVisualStyleBackColor = true;
            this.btnObtenerNT.Click += new System.EventHandler(this.btnObtenerNT_Click);
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(7, 31);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.Size = new System.Drawing.Size(346, 168);
            this.gridNoTipado.TabIndex = 0;
            // 
            // Tipado
            // 
            this.Tipado.Controls.Add(this.btnEliminarT);
            this.Tipado.Controls.Add(this.btnActualizarT);
            this.Tipado.Controls.Add(this.btnInsertarT);
            this.Tipado.Controls.Add(this.btnBuscarT);
            this.Tipado.Controls.Add(this.txtBuscarT);
            this.Tipado.Controls.Add(this.btnObtenerT);
            this.Tipado.Controls.Add(this.label2);
            this.Tipado.Controls.Add(this.gridTipado);
            this.Tipado.Location = new System.Drawing.Point(458, 3);
            this.Tipado.Name = "Tipado";
            this.Tipado.Size = new System.Drawing.Size(391, 396);
            this.Tipado.TabIndex = 1;
            this.Tipado.TabStop = false;
            this.Tipado.Text = "Tipado";
            // 
            // btnActualizarT
            // 
            this.btnActualizarT.Location = new System.Drawing.Point(158, 367);
            this.btnActualizarT.Name = "btnActualizarT";
            this.btnActualizarT.Size = new System.Drawing.Size(102, 23);
            this.btnActualizarT.TabIndex = 8;
            this.btnActualizarT.Text = "Actualizar Cliente";
            this.btnActualizarT.UseVisualStyleBackColor = true;
            this.btnActualizarT.Click += new System.EventHandler(this.btnActualizarT_Click);
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(8, 367);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(144, 23);
            this.btnInsertarT.TabIndex = 6;
            this.btnInsertarT.Text = "Insertar Cliente";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // btnBuscarT
            // 
            this.btnBuscarT.Location = new System.Drawing.Point(232, 339);
            this.btnBuscarT.Name = "btnBuscarT";
            this.btnBuscarT.Size = new System.Drawing.Size(144, 23);
            this.btnBuscarT.TabIndex = 7;
            this.btnBuscarT.Text = "Buscar Cliente";
            this.btnBuscarT.UseVisualStyleBackColor = true;
            this.btnBuscarT.Click += new System.EventHandler(this.btnBuscarT_Click);
            // 
            // txtBuscarT
            // 
            this.txtBuscarT.Location = new System.Drawing.Point(95, 341);
            this.txtBuscarT.Name = "txtBuscarT";
            this.txtBuscarT.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarT.TabIndex = 6;
            // 
            // btnObtenerT
            // 
            this.btnObtenerT.Location = new System.Drawing.Point(7, 250);
            this.btnObtenerT.Name = "btnObtenerT";
            this.btnObtenerT.Size = new System.Drawing.Size(342, 40);
            this.btnObtenerT.TabIndex = 2;
            this.btnObtenerT.Text = "Obtener Datos";
            this.btnObtenerT.UseVisualStyleBackColor = true;
            this.btnObtenerT.Click += new System.EventHandler(this.btnObtenerT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Cliente";
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(7, 31);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(346, 168);
            this.gridTipado.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(425, 444);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CompanyName";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(425, 466);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 20);
            this.txtContactName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ContactName";
            // 
            // txtContactTittle
            // 
            this.txtContactTittle.Location = new System.Drawing.Point(425, 488);
            this.txtContactTittle.Name = "txtContactTittle";
            this.txtContactTittle.Size = new System.Drawing.Size(100, 20);
            this.txtContactTittle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ContactTile";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(425, 418);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CustomerID";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(425, 514);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // btnEliminarNT
            // 
            this.btnEliminarNT.Location = new System.Drawing.Point(266, 352);
            this.btnEliminarNT.Name = "btnEliminarNT";
            this.btnEliminarNT.Size = new System.Drawing.Size(104, 23);
            this.btnEliminarNT.TabIndex = 7;
            this.btnEliminarNT.Text = "Eliminar Cliente";
            this.btnEliminarNT.UseVisualStyleBackColor = true;
            this.btnEliminarNT.Click += new System.EventHandler(this.btnEliminarNT_Click);
            // 
            // btnEliminarT
            // 
            this.btnEliminarT.Location = new System.Drawing.Point(270, 367);
            this.btnEliminarT.Name = "btnEliminarT";
            this.btnEliminarT.Size = new System.Drawing.Size(106, 23);
            this.btnEliminarT.TabIndex = 9;
            this.btnEliminarT.Text = "Eliminar Cliente";
            this.btnEliminarT.UseVisualStyleBackColor = true;
            this.btnEliminarT.Click += new System.EventHandler(this.btnEliminarT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 547);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContactTittle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tipado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.Tipado.ResumeLayout(false);
            this.Tipado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Tipado;
        private System.Windows.Forms.Button btnObtenerNT;
        private System.Windows.Forms.DataGridView gridNoTipado;
        private System.Windows.Forms.Button btnObtenerT;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnBuscarNT;
        private System.Windows.Forms.TextBox txtBusquedaNT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarT;
        private System.Windows.Forms.TextBox txtBuscarT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarNT;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactTittle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertarT;
        private System.Windows.Forms.Button btnActualizarNT;
        private System.Windows.Forms.Button btnActualizarT;
        private System.Windows.Forms.Button btnEliminarNT;
        private System.Windows.Forms.Button btnEliminarT;
    }
}

