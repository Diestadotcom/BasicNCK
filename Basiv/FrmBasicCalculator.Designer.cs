
namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button btnCompute;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BASIC CALCULATOR";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum1
            // 
            this.lblNum1.Location = new System.Drawing.Point(50, 100);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(110, 25);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "First Number:";
            // 
            // lblNum2
            // 
            this.lblNum2.Location = new System.Drawing.Point(50, 200);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(110, 25);
            this.lblNum2.TabIndex = 5;
            this.lblNum2.Text = "Second Number:";
            // 
            // lblOperator
            // 
            this.lblOperator.Location = new System.Drawing.Point(50, 150);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(110, 25);
            this.lblOperator.TabIndex = 3;
            this.lblOperator.Text = "Operator:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(50, 310);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(320, 35);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total: 0";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(170, 97);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(200, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(170, 197);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(200, 20);
            this.txtNum2.TabIndex = 6;
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Location = new System.Drawing.Point(170, 147);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(200, 21);
            this.cmbOperator.TabIndex = 4;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(170, 245);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(200, 40);
            this.btnCompute.TabIndex = 7;
            this.btnCompute.Text = "COMPUTE";
            // 
            // FrmBasicCalculator
            // 
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblTotal);
            this.Name = "FrmBasicCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
