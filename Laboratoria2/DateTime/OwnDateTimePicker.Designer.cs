namespace DateTime
{
    partial class OwnDateTimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.tvCurrentDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(16, 16);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(95, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(117, 16);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(79, 20);
            this.timePicker.TabIndex = 1;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // tvCurrentDateTime
            // 
            this.tvCurrentDateTime.Location = new System.Drawing.Point(16, 43);
            this.tvCurrentDateTime.Name = "tvCurrentDateTime";
            this.tvCurrentDateTime.Size = new System.Drawing.Size(180, 20);
            this.tvCurrentDateTime.TabIndex = 2;
            // 
            // OwnDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tvCurrentDateTime);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Name = "OwnDateTimePicker";
            this.Size = new System.Drawing.Size(213, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox tvCurrentDateTime;
    }
}
