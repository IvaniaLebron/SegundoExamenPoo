
namespace SegundoExamenLabPoo
{
    partial class ParaLlevar
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
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.Text = "0.00";
            // 
            // menucomida
            // 
            /*this.menucomida.Items.AddRange(new object[] {
            "Combo de hamburguesa......$5.60",
            "Pizza con soda......$7.00",
            "Orden de tacos......$3.50",
            "Torta con queso......$5.10",
            "Papas fritas......$1.25",
            "Hot Dog......$2.00",
            "Soda......$0.50",
            "Licuado......$0.75",
           });*/
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(493, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sucursal de entrega";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(493, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 28);
            this.comboBox1.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(493, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Para Llevar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(127, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 27);
            this.label9.TabIndex = 45;
            this.label9.Text = "$";
            // 
            // ParaLlevar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 568);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Name = "ParaLlevar";
            this.Text = "ParaLlevar";
            this.Load += new System.EventHandler(this.ParaLlevar_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.menucomida, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.txtham, 0);
            this.Controls.SetChildIndex(this.textBox8, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.Controls.SetChildIndex(this.textBox16, 0);
            this.Controls.SetChildIndex(this.textBox15, 0);
            this.Controls.SetChildIndex(this.txtpizza, 0);
            this.Controls.SetChildIndex(this.txttaco, 0);
            this.Controls.SetChildIndex(this.txttorta, 0);
            this.Controls.SetChildIndex(this.txtpapa, 0);
            this.Controls.SetChildIndex(this.txthotdog, 0);
            this.Controls.SetChildIndex(this.txtsoda, 0);
            this.Controls.SetChildIndex(this.txtlicuado, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label9;
    }
}