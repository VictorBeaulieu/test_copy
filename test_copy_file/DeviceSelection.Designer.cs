namespace test_copy_file
{
    partial class DeviceSelection
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.listUniteLogic = new System.Windows.Forms.ComboBox();
            this.btn_valid = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_format = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(161, 155);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // listUniteLogic
            // 
            this.listUniteLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUniteLogic.FormattingEnabled = true;
            this.listUniteLogic.Location = new System.Drawing.Point(12, 12);
            this.listUniteLogic.Name = "listUniteLogic";
            this.listUniteLogic.Size = new System.Drawing.Size(133, 24);
            this.listUniteLogic.TabIndex = 2;
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(12, 155);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(75, 23);
            this.btn_valid.TabIndex = 3;
            this.btn_valid.Text = "Valider";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.Btn_valid_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(151, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(85, 23);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Rafraichir";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_format
            // 
            this.btn_format.Location = new System.Drawing.Point(84, 92);
            this.btn_format.Name = "btn_format";
            this.btn_format.Size = new System.Drawing.Size(75, 23);
            this.btn_format.TabIndex = 5;
            this.btn_format.Text = "Formater";
            this.btn_format.UseVisualStyleBackColor = true;
            this.btn_format.Click += new System.EventHandler(this.Btn_format_Click);
            // 
            // DeviceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 190);
            this.Controls.Add(this.btn_format);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.listUniteLogic);
            this.Controls.Add(this.btn_exit);
            this.Name = "DeviceSelection";
            this.Text = "DeviceSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox listUniteLogic;
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_format;
    }
}