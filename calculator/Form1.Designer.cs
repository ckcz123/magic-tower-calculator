using System;
using System.Windows.Forms;

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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_hero_atk = new System.Windows.Forms.TextBox();
            this.textbox_hero_def = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_all = new System.Windows.Forms.Panel();
            this.button_add_item = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "勇士攻击";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "勇士防御";
            // 
            // textbox_hero_atk
            // 
            this.textbox_hero_atk.Location = new System.Drawing.Point(83, 20);
            this.textbox_hero_atk.Name = "textbox_hero_atk";
            this.textbox_hero_atk.Size = new System.Drawing.Size(61, 20);
            this.textbox_hero_atk.TabIndex = 0;
            this.textbox_hero_atk.Text = "10";
            this.textbox_hero_atk.TextChanged += new System.EventHandler(calculate);
            // 
            // textbox_hero_def
            // 
            this.textbox_hero_def.Location = new System.Drawing.Point(226, 20);
            this.textbox_hero_def.Name = "textbox_hero_def";
            this.textbox_hero_def.Size = new System.Drawing.Size(62, 20);
            this.textbox_hero_def.TabIndex = 1;
            this.textbox_hero_def.Text = "10";
            this.textbox_hero_def.TextChanged += new System.EventHandler(calculate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "防御";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "攻击";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "怪物生命";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "伤害";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "临界";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "属性";
            // 
            // panel_all
            // 
            this.panel_all.AutoSize = true;
            this.panel_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_all.Location = new System.Drawing.Point(13, 87);
            this.panel_all.Margin = new System.Windows.Forms.Padding(20, 0, 20, 10);
            this.panel_all.Name = "panel_all";
            this.panel_all.Size = new System.Drawing.Size(0, 0);
            this.panel_all.TabIndex = 121;
            // 
            // button_add_item
            // 
            this.button_add_item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_add_item.Location = new System.Drawing.Point(313, 18);
            this.button_add_item.Name = "button_add_item";
            this.button_add_item.Size = new System.Drawing.Size(92, 22);
            this.button_add_item.TabIndex = 108;
            this.button_add_item.Text = "添加新怪物";
            this.button_add_item.UseVisualStyleBackColor = true;
            this.button_add_item.Click += new System.EventHandler(this.button_add_item_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_save.Location = new System.Drawing.Point(413, 18);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(116, 22);
            this.button_save.TabIndex = 109;
            this.button_save.Text = "保存怪物数据";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_load.Location = new System.Drawing.Point(537, 18);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(116, 22);
            this.button_load.TabIndex = 120;
            this.button_load.Text = "读取怪物数据";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(672, 261);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_add_item);
            this.Controls.Add(this.panel_all);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_hero_def);
            this.Controls.Add(this.textbox_hero_atk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "伤害和临界值计算器 By Sky_天空的梦";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_hero_atk;
        private System.Windows.Forms.TextBox textbox_hero_def;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_all;
        private System.Windows.Forms.Button button_add_item;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
    }
}

