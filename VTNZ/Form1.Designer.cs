namespace VTNZForm
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
            this.labelHeadrer = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelDetailsHeader = new System.Windows.Forms.Label();
            this.labelTotalPriceHeader = new System.Windows.Forms.Label();
            this.labelCountHeader = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonRequestInspection = new System.Windows.Forms.Button();
            this.listBoxInspections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelHeadrer
            // 
            this.labelHeadrer.AutoSize = true;
            this.labelHeadrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadrer.Location = new System.Drawing.Point(376, 53);
            this.labelHeadrer.Name = "labelHeadrer";
            this.labelHeadrer.Size = new System.Drawing.Size(78, 17);
            this.labelHeadrer.TabIndex = 0;
            this.labelHeadrer.Text = "lblHeader";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(112, 121);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(60, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "lblMessage";
            // 
            // labelDetailsHeader
            // 
            this.labelDetailsHeader.AutoSize = true;
            this.labelDetailsHeader.Location = new System.Drawing.Point(109, 358);
            this.labelDetailsHeader.Name = "labelDetailsHeader";
            this.labelDetailsHeader.Size = new System.Drawing.Size(96, 13);
            this.labelDetailsHeader.TabIndex = 2;
            this.labelDetailsHeader.Text = "labelDetailsHeader";
            // 
            // labelTotalPriceHeader
            // 
            this.labelTotalPriceHeader.AutoSize = true;
            this.labelTotalPriceHeader.Location = new System.Drawing.Point(344, 358);
            this.labelTotalPriceHeader.Name = "labelTotalPriceHeader";
            this.labelTotalPriceHeader.Size = new System.Drawing.Size(112, 13);
            this.labelTotalPriceHeader.TabIndex = 3;
            this.labelTotalPriceHeader.Text = "labelTotalPriceHeader";
            // 
            // labelCountHeader
            // 
            this.labelCountHeader.AutoSize = true;
            this.labelCountHeader.Location = new System.Drawing.Point(611, 358);
            this.labelCountHeader.Name = "labelCountHeader";
            this.labelCountHeader.Size = new System.Drawing.Size(92, 13);
            this.labelCountHeader.TabIndex = 4;
            this.labelCountHeader.Text = "labelCountHeader";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelDetails.Location = new System.Drawing.Point(112, 396);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(49, 13);
            this.labelDetails.TabIndex = 5;
            this.labelDetails.Text = "lblDetails";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTotalPrice.Location = new System.Drawing.Point(344, 396);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(65, 13);
            this.labelTotalPrice.TabIndex = 6;
            this.labelTotalPrice.Text = "lblTotalPrice";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCount.Location = new System.Drawing.Point(611, 396);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(45, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "lblCount";
            // 
            // buttonRequestInspection
            // 
            this.buttonRequestInspection.Location = new System.Drawing.Point(112, 164);
            this.buttonRequestInspection.Name = "buttonRequestInspection";
            this.buttonRequestInspection.Size = new System.Drawing.Size(154, 23);
            this.buttonRequestInspection.TabIndex = 8;
            this.buttonRequestInspection.Text = "Request Inspection";
            this.buttonRequestInspection.UseVisualStyleBackColor = true;
            this.buttonRequestInspection.Click += new System.EventHandler(this.buttonRequestInspection_Click);
            // 
            // listBoxInspections
            // 
            this.listBoxInspections.FormattingEnabled = true;
            this.listBoxInspections.Location = new System.Drawing.Point(347, 121);
            this.listBoxInspections.Name = "listBoxInspections";
            this.listBoxInspections.Size = new System.Drawing.Size(271, 160);
            this.listBoxInspections.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 559);
            this.Controls.Add(this.listBoxInspections);
            this.Controls.Add(this.buttonRequestInspection);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelCountHeader);
            this.Controls.Add(this.labelTotalPriceHeader);
            this.Controls.Add(this.labelDetailsHeader);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelHeadrer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeadrer;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelDetailsHeader;
        private System.Windows.Forms.Label labelTotalPriceHeader;
        private System.Windows.Forms.Label labelCountHeader;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonRequestInspection;
        private System.Windows.Forms.ListBox listBoxInspections;
    }
}

