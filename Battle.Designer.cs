
namespace A_cock_and_bull_adventure
{
    partial class Battle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSpell = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(944, 316);
            this.textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAttack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDefend, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMulti, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSpell, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 411);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAttack.Location = new System.Drawing.Point(3, 3);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(466, 44);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefend.Location = new System.Drawing.Point(475, 3);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(466, 44);
            this.btnDefend.TabIndex = 1;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMulti.Location = new System.Drawing.Point(3, 53);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(466, 44);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "Multi";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnSpell
            // 
            this.btnSpell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpell.Location = new System.Drawing.Point(475, 53);
            this.btnSpell.Name = "btnSpell";
            this.btnSpell.Size = new System.Drawing.Size(466, 44);
            this.btnSpell.TabIndex = 3;
            this.btnSpell.Text = "Spell";
            this.btnSpell.UseVisualStyleBackColor = true;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Battle";
            this.Text = "Battle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSpell;
    }
}

