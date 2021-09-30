
namespace Factories
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_M = new System.Windows.Forms.TextBox();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.comboBox_Factory = new System.Windows.Forms.ComboBox();
            this.button_add_Factory = new System.Windows.Forms.Button();
            this.label_M = new System.Windows.Forms.Label();
            this.label_N = new System.Windows.Forms.Label();
            this.label_factory = new System.Windows.Forms.Label();
            this.comboBox_Weight = new System.Windows.Forms.ComboBox();
            this.label_Weight = new System.Windows.Forms.Label();
            this.button_Add_Weight = new System.Windows.Forms.Button();
            this.button_Add_Truck = new System.Windows.Forms.Button();
            this.label_Truck = new System.Windows.Forms.Label();
            this.comboBox_Truck = new System.Windows.Forms.ComboBox();
            this.label_Product = new System.Windows.Forms.Label();
            this.button_Add_Product = new System.Windows.Forms.Button();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.button_Result = new System.Windows.Forms.Button();
            this.richTextBox_Result1 = new System.Windows.Forms.RichTextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_M
            // 
            this.textBox_M.Location = new System.Drawing.Point(12, 58);
            this.textBox_M.Name = "textBox_M";
            this.textBox_M.Size = new System.Drawing.Size(125, 27);
            this.textBox_M.TabIndex = 0;
            this.textBox_M.Text = "100";
            this.textBox_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_M_KeyPress);
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(13, 130);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(125, 27);
            this.textBox_N.TabIndex = 1;
            this.textBox_N.Text = "60";
            this.textBox_N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_N_KeyPress);
            // 
            // comboBox_Factory
            // 
            this.comboBox_Factory.FormattingEnabled = true;
            this.comboBox_Factory.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox_Factory.Location = new System.Drawing.Point(258, 57);
            this.comboBox_Factory.Name = "comboBox_Factory";
            this.comboBox_Factory.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Factory.TabIndex = 4;
            this.comboBox_Factory.TextChanged += new System.EventHandler(this.comboBox_Factory_TextChanged);
            // 
            // button_add_Factory
            // 
            this.button_add_Factory.Enabled = false;
            this.button_add_Factory.Location = new System.Drawing.Point(430, 56);
            this.button_add_Factory.Name = "button_add_Factory";
            this.button_add_Factory.Size = new System.Drawing.Size(148, 28);
            this.button_add_Factory.TabIndex = 5;
            this.button_add_Factory.Text = "Add";
            this.button_add_Factory.UseVisualStyleBackColor = true;
            this.button_add_Factory.Click += new System.EventHandler(this.button_add_Factory_Click);
            // 
            // label_M
            // 
            this.label_M.AutoSize = true;
            this.label_M.Location = new System.Drawing.Point(13, 35);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(84, 20);
            this.label_M.TabIndex = 6;
            this.label_M.Text = "M (>= 100)";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Location = new System.Drawing.Point(13, 107);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(226, 20);
            this.label_N.TabIndex = 7;
            this.label_N.Text = "Объем продукции в час (>=50)";
            // 
            // label_factory
            // 
            this.label_factory.AutoSize = true;
            this.label_factory.Location = new System.Drawing.Point(258, 26);
            this.label_factory.Name = "label_factory";
            this.label_factory.Size = new System.Drawing.Size(50, 20);
            this.label_factory.TabIndex = 8;
            this.label_factory.Text = "Завод";
            // 
            // comboBox_Weight
            // 
            this.comboBox_Weight.FormattingEnabled = true;
            this.comboBox_Weight.Items.AddRange(new object[] {
            "12",
            "23",
            "22",
            "20"});
            this.comboBox_Weight.Location = new System.Drawing.Point(258, 129);
            this.comboBox_Weight.Name = "comboBox_Weight";
            this.comboBox_Weight.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Weight.TabIndex = 9;
            this.comboBox_Weight.TextChanged += new System.EventHandler(this.comboBox_Weight_TextChanged);
            this.comboBox_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Weight_KeyPress);
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Location = new System.Drawing.Point(258, 107);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(100, 20);
            this.label_Weight.TabIndex = 10;
            this.label_Weight.Text = "Вес продукта";
            // 
            // button_Add_Weight
            // 
            this.button_Add_Weight.Enabled = false;
            this.button_Add_Weight.Location = new System.Drawing.Point(430, 128);
            this.button_Add_Weight.Name = "button_Add_Weight";
            this.button_Add_Weight.Size = new System.Drawing.Size(148, 29);
            this.button_Add_Weight.TabIndex = 11;
            this.button_Add_Weight.Text = "Add";
            this.button_Add_Weight.UseVisualStyleBackColor = true;
            this.button_Add_Weight.Click += new System.EventHandler(this.button_Add_Weight_Click);
            // 
            // button_Add_Truck
            // 
            this.button_Add_Truck.Enabled = false;
            this.button_Add_Truck.Location = new System.Drawing.Point(775, 127);
            this.button_Add_Truck.Name = "button_Add_Truck";
            this.button_Add_Truck.Size = new System.Drawing.Size(148, 29);
            this.button_Add_Truck.TabIndex = 17;
            this.button_Add_Truck.Text = "Add";
            this.button_Add_Truck.UseVisualStyleBackColor = true;
            this.button_Add_Truck.Click += new System.EventHandler(this.button_Add_Truck_Click);
            // 
            // label_Truck
            // 
            this.label_Truck.AutoSize = true;
            this.label_Truck.Location = new System.Drawing.Point(603, 106);
            this.label_Truck.Name = "label_Truck";
            this.label_Truck.Size = new System.Drawing.Size(174, 20);
            this.label_Truck.TabIndex = 16;
            this.label_Truck.Text = "Вместимость грузовика";
            // 
            // comboBox_Truck
            // 
            this.comboBox_Truck.FormattingEnabled = true;
            this.comboBox_Truck.Items.AddRange(new object[] {
            "120"});
            this.comboBox_Truck.Location = new System.Drawing.Point(603, 128);
            this.comboBox_Truck.Name = "comboBox_Truck";
            this.comboBox_Truck.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Truck.TabIndex = 15;
            this.comboBox_Truck.TextChanged += new System.EventHandler(this.comboBox_Truck_TextChanged);
            this.comboBox_Truck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Truck_KeyPress);
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(603, 25);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(66, 20);
            this.label_Product.TabIndex = 14;
            this.label_Product.Text = "Продукт";
            // 
            // button_Add_Product
            // 
            this.button_Add_Product.Enabled = false;
            this.button_Add_Product.Location = new System.Drawing.Point(775, 55);
            this.button_Add_Product.Name = "button_Add_Product";
            this.button_Add_Product.Size = new System.Drawing.Size(148, 28);
            this.button_Add_Product.TabIndex = 13;
            this.button_Add_Product.Text = "Add";
            this.button_Add_Product.UseVisualStyleBackColor = true;
            this.button_Add_Product.Click += new System.EventHandler(this.button_Add_Product_Click);
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Items.AddRange(new object[] {
            "aa",
            "bb",
            "cc",
            "dd"});
            this.comboBox_Product.Location = new System.Drawing.Point(603, 56);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Product.TabIndex = 12;
            this.comboBox_Product.TextChanged += new System.EventHandler(this.comboBox_Product_TextChanged);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(12, 257);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(911, 163);
            this.richTextBox_Result.TabIndex = 18;
            this.richTextBox_Result.Text = "Один завод выпускает одну продукцию, у каждой продукции свой вес\nКоличество завод" +
    "ов = количество продуктов = количество вес продукта = 4\nКоличество грузовиков = " +
    "3\n";
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(12, 187);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(148, 29);
            this.button_Result.TabIndex = 19;
            this.button_Result.Text = "Result";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // richTextBox_Result1
            // 
            this.richTextBox_Result1.Location = new System.Drawing.Point(13, 440);
            this.richTextBox_Result1.Name = "richTextBox_Result1";
            this.richTextBox_Result1.Size = new System.Drawing.Size(910, 164);
            this.richTextBox_Result1.TabIndex = 20;
            this.richTextBox_Result1.Text = "";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(258, 187);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(94, 29);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 615);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.richTextBox_Result1);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.button_Add_Truck);
            this.Controls.Add(this.label_Truck);
            this.Controls.Add(this.comboBox_Truck);
            this.Controls.Add(this.label_Product);
            this.Controls.Add(this.button_Add_Product);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.button_Add_Weight);
            this.Controls.Add(this.label_Weight);
            this.Controls.Add(this.comboBox_Weight);
            this.Controls.Add(this.label_factory);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.label_M);
            this.Controls.Add(this.button_add_Factory);
            this.Controls.Add(this.comboBox_Factory);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.textBox_M);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_M;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.ComboBox comboBox_Factory;
        private System.Windows.Forms.Button button_add_Factory;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Label label_factory;
        private System.Windows.Forms.ComboBox comboBox_Weight;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.Button button_Add_Weight;
        private System.Windows.Forms.Button button_Add_Truck;
        private System.Windows.Forms.Label label_Truck;
        private System.Windows.Forms.ComboBox comboBox_Truck;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Button button_Add_Product;
        private System.Windows.Forms.ComboBox comboBox_Product;
        public System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.RichTextBox richTextBox_Result1;
        private System.Windows.Forms.Button button_Clear;
    }
}

