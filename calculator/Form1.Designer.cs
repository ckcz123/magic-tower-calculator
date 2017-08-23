namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_hero_hp = new System.Windows.Forms.TextBox();
            this.textbox_hero_atk = new System.Windows.Forms.TextBox();
            this.textbox_hero_def = new System.Windows.Forms.TextBox();
            this.textbox_monster_hp = new System.Windows.Forms.TextBox();
            this.textbox_monster_atk = new System.Windows.Forms.TextBox();
            this.textbox_monster_def = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_damage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "勇士生命";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "勇士攻击";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "勇士防御";
            // 
            // textbox_hero_hp
            // 
            this.textbox_hero_hp.Location = new System.Drawing.Point(25, 45);
            this.textbox_hero_hp.Name = "textbox_hero_hp";
            this.textbox_hero_hp.Size = new System.Drawing.Size(59, 20);
            this.textbox_hero_hp.TabIndex = 0;
            this.textbox_hero_hp.Text = "1000";
            this.textbox_hero_hp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbox_hero_atk
            // 
            this.textbox_hero_atk.Location = new System.Drawing.Point(108, 45);
            this.textbox_hero_atk.Name = "textbox_hero_atk";
            this.textbox_hero_atk.Size = new System.Drawing.Size(61, 20);
            this.textbox_hero_atk.TabIndex = 1;
            this.textbox_hero_atk.Text = "10";
            this.textbox_hero_atk.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textbox_hero_def
            // 
            this.textbox_hero_def.Location = new System.Drawing.Point(192, 45);
            this.textbox_hero_def.Name = "textbox_hero_def";
            this.textbox_hero_def.Size = new System.Drawing.Size(62, 20);
            this.textbox_hero_def.TabIndex = 2;
            this.textbox_hero_def.Text = "10";
            this.textbox_hero_def.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textbox_monster_hp
            // 
            this.textbox_monster_hp.Location = new System.Drawing.Point(25, 105);
            this.textbox_monster_hp.Name = "textbox_monster_hp";
            this.textbox_monster_hp.Size = new System.Drawing.Size(62, 20);
            this.textbox_monster_hp.TabIndex = 3;
            this.textbox_monster_hp.Text = "1000";
            this.textbox_monster_hp.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textbox_monster_atk
            // 
            this.textbox_monster_atk.Location = new System.Drawing.Point(108, 105);
            this.textbox_monster_atk.Name = "textbox_monster_atk";
            this.textbox_monster_atk.Size = new System.Drawing.Size(61, 20);
            this.textbox_monster_atk.TabIndex = 4;
            this.textbox_monster_atk.Text = "10";
            this.textbox_monster_atk.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textbox_monster_def
            // 
            this.textbox_monster_def.Location = new System.Drawing.Point(192, 105);
            this.textbox_monster_def.Name = "textbox_monster_def";
            this.textbox_monster_def.Size = new System.Drawing.Size(59, 20);
            this.textbox_monster_def.TabIndex = 5;
            this.textbox_monster_def.Text = "10";
            this.textbox_monster_def.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "怪物防御";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "怪物攻击";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "怪物生命";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "先攻";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(108, 137);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(50, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "魔攻";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(192, 137);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "坚固";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "伤害";
            // 
            // textbox_damage
            // 
            this.textbox_damage.Location = new System.Drawing.Point(59, 170);
            this.textbox_damage.Name = "textbox_damage";
            this.textbox_damage.ReadOnly = true;
            this.textbox_damage.Size = new System.Drawing.Size(192, 20);
            this.textbox_damage.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "临界";
            // 
            // textbox_output
            // 
            this.textbox_output.Location = new System.Drawing.Point(59, 205);
            this.textbox_output.Name = "textbox_output";
            this.textbox_output.ReadOnly = true;
            this.textbox_output.Size = new System.Drawing.Size(192, 20);
            this.textbox_output.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textbox_output);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox_damage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textbox_monster_hp);
            this.Controls.Add(this.textbox_monster_atk);
            this.Controls.Add(this.textbox_monster_def);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_hero_def);
            this.Controls.Add(this.textbox_hero_atk);
            this.Controls.Add(this.textbox_hero_hp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "临界值计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_hero_hp;
        private System.Windows.Forms.TextBox textbox_hero_atk;
        private System.Windows.Forms.TextBox textbox_hero_def;
        private System.Windows.Forms.TextBox textbox_monster_hp;
        private System.Windows.Forms.TextBox textbox_monster_atk;
        private System.Windows.Forms.TextBox textbox_monster_def;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_damage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_output;
    }
}

