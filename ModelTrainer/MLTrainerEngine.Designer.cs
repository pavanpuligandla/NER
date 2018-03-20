namespace ModelTrainer
{
    partial class MLTrainerEngine
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
            this.btnTrain = new System.Windows.Forms.Button();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtUploadTextFile = new System.Windows.Forms.TextBox();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnTrain.Location = new System.Drawing.Point(541, 65);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(64, 27);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Browse ";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(78, 13);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(531, 20);
            this.txtModelName.TabIndex = 1;
            // 
            // txtUploadTextFile
            // 
            this.txtUploadTextFile.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtUploadTextFile.Location = new System.Drawing.Point(79, 39);
            this.txtUploadTextFile.Name = "txtUploadTextFile";
            this.txtUploadTextFile.ReadOnly = true;
            this.txtUploadTextFile.Size = new System.Drawing.Size(530, 20);
            this.txtUploadTextFile.TabIndex = 32;
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(6, 18);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(70, 13);
            this.lblModelName.TabIndex = 33;
            this.lblModelName.Text = "Model Name ";
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.Location = new System.Drawing.Point(6, 44);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(47, 13);
            this.lblBrowse.TabIndex = 34;
            this.lblBrowse.Text = "Text File";
            // 
            // MLTrainerEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 102);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.txtUploadTextFile);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.btnTrain);
            this.Name = "MLTrainerEngine";
            this.Text = "ML Trainer ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtUploadTextFile;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblBrowse;
    }
}

