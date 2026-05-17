namespace EstoqueAPP.Views.Register
{
    partial class RegisterForm
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
            label1 = new Label();
            txtBoxName = new TextBox();
            label2 = new Label();
            txtBoxBarCode = new TextBox();
            label3 = new Label();
            txtBoxAmount = new TextBox();
            label4 = new Label();
            dateTimeValidate = new DateTimePicker();
            btnRegisterProduct = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(12, 59);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(200, 23);
            txtBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Cod Barra";
            // 
            // txtBoxBarCode
            // 
            txtBoxBarCode.Location = new Point(12, 116);
            txtBoxBarCode.Name = "txtBoxBarCode";
            txtBoxBarCode.Size = new Size(200, 23);
            txtBoxBarCode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 41);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade";
            // 
            // txtBoxAmount
            // 
            txtBoxAmount.Location = new Point(283, 59);
            txtBoxAmount.Name = "txtBoxAmount";
            txtBoxAmount.Size = new Size(200, 23);
            txtBoxAmount.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 98);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Validade";
            // 
            // dateTimeValidate
            // 
            dateTimeValidate.Format = DateTimePickerFormat.Short;
            dateTimeValidate.Location = new Point(283, 116);
            dateTimeValidate.Name = "dateTimeValidate";
            dateTimeValidate.Size = new Size(200, 23);
            dateTimeValidate.TabIndex = 7;
            // 
            // btnRegisterProduct
            // 
            btnRegisterProduct.Location = new Point(408, 210);
            btnRegisterProduct.Name = "btnRegisterProduct";
            btnRegisterProduct.Size = new Size(75, 23);
            btnRegisterProduct.TabIndex = 8;
            btnRegisterProduct.Text = "Cadastrar";
            btnRegisterProduct.UseVisualStyleBackColor = true;
            btnRegisterProduct.Click += btnRegisterProduct_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 245);
            Controls.Add(btnRegisterProduct);
            Controls.Add(dateTimeValidate);
            Controls.Add(label4);
            Controls.Add(txtBoxAmount);
            Controls.Add(label3);
            Controls.Add(txtBoxBarCode);
            Controls.Add(label2);
            Controls.Add(txtBoxName);
            Controls.Add(label1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxName;
        private Label label2;
        private TextBox txtBoxBarCode;
        private Label label3;
        private TextBox txtBoxAmount;
        private Label label4;
        private DateTimePicker dateTimeValidate;
        private Button btnRegisterProduct;
    }
}