namespace WindowsApplication1
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
            this.myTreeList1 = new WindowsApplication1.MyTreeList();
            ((System.ComponentModel.ISupportInitialize)(this.myTreeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // myTreeList1
            // 
            this.myTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTreeList1.Location = new System.Drawing.Point(0, 0);
            this.myTreeList1.Name = "myTreeList1";
            this.myTreeList1.Size = new System.Drawing.Size(763, 593);
            this.myTreeList1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 593);
            this.Controls.Add(this.myTreeList1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myTreeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyTreeList myTreeList1;
    }
}

