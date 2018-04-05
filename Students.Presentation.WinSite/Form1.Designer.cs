namespace Students.Presentation.WinSite
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbID = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.txDNI = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btTXT = new System.Windows.Forms.Button();
            this.btJSON = new System.Windows.Forms.Button();
            this.btXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(139, 53);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(16, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Id";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(142, 99);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(35, 13);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(145, 147);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 2;
            this.lbSurname.Text = "Surname";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(145, 182);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 3;
            this.lbDNI.Text = "DNI";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(148, 215);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(30, 13);
            this.lbDOB.TabIndex = 4;
            this.lbDOB.Text = "DOB";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(254, 53);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 20);
            this.txID.TabIndex = 5;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(254, 99);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 6;
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(254, 139);
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(100, 20);
            this.txSurname.TabIndex = 7;
            // 
            // txDNI
            // 
            this.txDNI.Location = new System.Drawing.Point(254, 174);
            this.txDNI.Name = "txDNI";
            this.txDNI.Size = new System.Drawing.Size(100, 20);
            this.txDNI.TabIndex = 8;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(254, 207);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(116, 20);
            this.dtDate.TabIndex = 9;
            // 
            // btTXT
            // 
            this.btTXT.Location = new System.Drawing.Point(118, 307);
            this.btTXT.Name = "btTXT";
            this.btTXT.Size = new System.Drawing.Size(75, 23);
            this.btTXT.TabIndex = 10;
            this.btTXT.Text = "TXT";
            this.btTXT.UseVisualStyleBackColor = true;
            this.btTXT.Click += new System.EventHandler(this.btTXT_Click);
            // 
            // btJSON
            // 
            this.btJSON.Location = new System.Drawing.Point(309, 307);
            this.btJSON.Name = "btJSON";
            this.btJSON.Size = new System.Drawing.Size(75, 23);
            this.btJSON.TabIndex = 11;
            this.btJSON.Text = "JSON";
            this.btJSON.UseVisualStyleBackColor = true;
            this.btJSON.Click += new System.EventHandler(this.btJSON_Click);
            // 
            // btXML
            // 
            this.btXML.Location = new System.Drawing.Point(532, 307);
            this.btXML.Name = "btXML";
            this.btXML.Size = new System.Drawing.Size(75, 23);
            this.btXML.TabIndex = 12;
            this.btXML.Text = "XML";
            this.btXML.UseVisualStyleBackColor = true;
            this.btXML.Click += new System.EventHandler(this.btXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btXML);
            this.Controls.Add(this.btJSON);
            this.Controls.Add(this.btTXT);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txDNI);
            this.Controls.Add(this.txSurname);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txSurname;
        private System.Windows.Forms.TextBox txDNI;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btTXT;
        private System.Windows.Forms.Button btJSON;
        private System.Windows.Forms.Button btXML;
    }
}

