namespace CatiaApi
{
    partial class CentralCatiaControl
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
            this.btnCreatePartDoc = new System.Windows.Forms.Button();
            this.btnGetActiveDocType = new System.Windows.Forms.Button();
            this.btnCreateProductDoc = new System.Windows.Forms.Button();
            this.btnCreateDwgDoc = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.btnStartCatia = new System.Windows.Forms.Button();
            this.btnCloseCatia = new System.Windows.Forms.Button();
            this.lblApplication = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCloseActiveDoc = new System.Windows.Forms.Button();
            this.lblSaveFunctions = new System.Windows.Forms.Label();
            this.btnSaveActiveDoc = new System.Windows.Forms.Button();
            this.btnSaveActiveDocAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePartDoc
            // 
            this.btnCreatePartDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePartDoc.Location = new System.Drawing.Point(334, 32);
            this.btnCreatePartDoc.Name = "btnCreatePartDoc";
            this.btnCreatePartDoc.Size = new System.Drawing.Size(160, 35);
            this.btnCreatePartDoc.TabIndex = 2;
            this.btnCreatePartDoc.Text = "Create Part Document";
            this.btnCreatePartDoc.UseVisualStyleBackColor = true;
            this.btnCreatePartDoc.Click += new System.EventHandler(this.btnCreatePartDoc_Click);
            // 
            // btnGetActiveDocType
            // 
            this.btnGetActiveDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetActiveDocType.Location = new System.Drawing.Point(524, 32);
            this.btnGetActiveDocType.Name = "btnGetActiveDocType";
            this.btnGetActiveDocType.Size = new System.Drawing.Size(163, 35);
            this.btnGetActiveDocType.TabIndex = 3;
            this.btnGetActiveDocType.Text = "Get Active Document Type";
            this.btnGetActiveDocType.UseVisualStyleBackColor = true;
            this.btnGetActiveDocType.Click += new System.EventHandler(this.btnGetActiveDocType_Click);
            // 
            // btnCreateProductDoc
            // 
            this.btnCreateProductDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProductDoc.Location = new System.Drawing.Point(334, 71);
            this.btnCreateProductDoc.Name = "btnCreateProductDoc";
            this.btnCreateProductDoc.Size = new System.Drawing.Size(160, 35);
            this.btnCreateProductDoc.TabIndex = 4;
            this.btnCreateProductDoc.Text = "Create Product Document";
            this.btnCreateProductDoc.UseVisualStyleBackColor = true;
            this.btnCreateProductDoc.Click += new System.EventHandler(this.btnCreateProductDoc_Click);
            // 
            // btnCreateDwgDoc
            // 
            this.btnCreateDwgDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDwgDoc.Location = new System.Drawing.Point(334, 112);
            this.btnCreateDwgDoc.Name = "btnCreateDwgDoc";
            this.btnCreateDwgDoc.Size = new System.Drawing.Size(160, 35);
            this.btnCreateDwgDoc.TabIndex = 5;
            this.btnCreateDwgDoc.Text = "Create Drawing";
            this.btnCreateDwgDoc.UseVisualStyleBackColor = true;
            this.btnCreateDwgDoc.Click += new System.EventHandler(this.btnCreateDwgDoc_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAll.Location = new System.Drawing.Point(524, 112);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(163, 35);
            this.btnCloseAll.TabIndex = 6;
            this.btnCloseAll.Text = "Close all documents";
            this.btnCloseAll.UseMnemonic = false;
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // btnStartCatia
            // 
            this.btnStartCatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCatia.Location = new System.Drawing.Point(198, 32);
            this.btnStartCatia.Name = "btnStartCatia";
            this.btnStartCatia.Size = new System.Drawing.Size(115, 35);
            this.btnStartCatia.TabIndex = 7;
            this.btnStartCatia.Text = "Start CATIA V5";
            this.btnStartCatia.UseVisualStyleBackColor = true;
            this.btnStartCatia.Click += new System.EventHandler(this.btnStartCatia_Click);
            // 
            // btnCloseCatia
            // 
            this.btnCloseCatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCatia.Location = new System.Drawing.Point(198, 71);
            this.btnCloseCatia.Name = "btnCloseCatia";
            this.btnCloseCatia.Size = new System.Drawing.Size(115, 35);
            this.btnCloseCatia.TabIndex = 8;
            this.btnCloseCatia.Text = "Close CATIA V5";
            this.btnCloseCatia.UseVisualStyleBackColor = true;
            this.btnCloseCatia.Click += new System.EventHandler(this.btnCloseCatia_Click);
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication.Location = new System.Drawing.Point(213, 13);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(85, 16);
            this.lblApplication.TabIndex = 10;
            this.lblApplication.Text = "Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Document creation";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(547, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(109, 16);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Other functions";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CatiaAPI.Properties.Resources.CatiaLogo3;
            this.pbLogo.Location = new System.Drawing.Point(13, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(160, 125);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // btnCloseActiveDoc
            // 
            this.btnCloseActiveDoc.Location = new System.Drawing.Point(524, 71);
            this.btnCloseActiveDoc.Name = "btnCloseActiveDoc";
            this.btnCloseActiveDoc.Size = new System.Drawing.Size(162, 35);
            this.btnCloseActiveDoc.TabIndex = 13;
            this.btnCloseActiveDoc.Text = "Close Active Document";
            this.btnCloseActiveDoc.UseVisualStyleBackColor = true;
            this.btnCloseActiveDoc.Click += new System.EventHandler(this.btnCloseActiveDoc_Click);
            // 
            // lblSaveFunctions
            // 
            this.lblSaveFunctions.AutoSize = true;
            this.lblSaveFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveFunctions.Location = new System.Drawing.Point(735, 13);
            this.lblSaveFunctions.Name = "lblSaveFunctions";
            this.lblSaveFunctions.Size = new System.Drawing.Size(120, 16);
            this.lblSaveFunctions.TabIndex = 14;
            this.lblSaveFunctions.Text = "Saving functions";
            // 
            // btnSaveActiveDoc
            // 
            this.btnSaveActiveDoc.Location = new System.Drawing.Point(724, 32);
            this.btnSaveActiveDoc.Name = "btnSaveActiveDoc";
            this.btnSaveActiveDoc.Size = new System.Drawing.Size(158, 35);
            this.btnSaveActiveDoc.TabIndex = 15;
            this.btnSaveActiveDoc.Text = "Save Active Document";
            this.btnSaveActiveDoc.UseVisualStyleBackColor = true;
            this.btnSaveActiveDoc.Click += new System.EventHandler(this.btnSaveActiveDoc_Click);
            // 
            // btnSaveActiveDocAs
            // 
            this.btnSaveActiveDocAs.Location = new System.Drawing.Point(724, 71);
            this.btnSaveActiveDocAs.Name = "btnSaveActiveDocAs";
            this.btnSaveActiveDocAs.Size = new System.Drawing.Size(158, 35);
            this.btnSaveActiveDocAs.TabIndex = 16;
            this.btnSaveActiveDocAs.Text = "Save Active Document As";
            this.btnSaveActiveDocAs.UseVisualStyleBackColor = true;
            this.btnSaveActiveDocAs.Click += new System.EventHandler(this.btnSaveActiveDocAs_Click);
            // 
            // CentralCatiaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 160);
            this.Controls.Add(this.btnSaveActiveDocAs);
            this.Controls.Add(this.btnSaveActiveDoc);
            this.Controls.Add(this.lblSaveFunctions);
            this.Controls.Add(this.btnCloseActiveDoc);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnCloseCatia);
            this.Controls.Add(this.btnStartCatia);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnCreateDwgDoc);
            this.Controls.Add(this.btnCreateProductDoc);
            this.Controls.Add(this.btnGetActiveDocType);
            this.Controls.Add(this.btnCreatePartDoc);
            this.Name = "CentralCatiaControl";
            this.Text = "Central CATIA control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreatePartDoc;
        private System.Windows.Forms.Button btnGetActiveDocType;
        private System.Windows.Forms.Button btnCreateProductDoc;
        private System.Windows.Forms.Button btnCreateDwgDoc;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button btnStartCatia;
        private System.Windows.Forms.Button btnCloseCatia;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCloseActiveDoc;
        private System.Windows.Forms.Label lblSaveFunctions;
        private System.Windows.Forms.Button btnSaveActiveDoc;
        private System.Windows.Forms.Button btnSaveActiveDocAs;
    }
}

