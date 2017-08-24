using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        class Monster
        {
            int hp, atk, def, special;
            public Monster(int _hp, int _atk, int _def, int _special)
            {
                hp = _hp; atk = _atk; def = _def; special = _special;
            }
            public string getDamage(int hero_atk, int hero_def)
            {
                // 魔攻
                if (special == 2) hero_def = 0;
                if (special == 3 && def < hero_atk - 1) def = hero_atk - 1;
                if (hero_atk <= def) return "不可战斗";
                if (hero_def >= atk) return "0";
                int damage = special == 1 ? atk - hero_def : 0;
                return Convert.ToString(damage + (hp - 1) / (hero_atk - def) * (atk - hero_def));
            }
            public string getCritical(int hero_atk)
            {
                if (special == 3) return "无临界";
                HashSet<int> set = new HashSet<int>();
                for (int i = 1; i <= hp; i++)
                {
                    int atk = (hp - 1) / i + 1 + def;
                    if (atk < hero_atk) break;
                    set.Add(atk);
                }
                List<int> list = new List<int>(set);
                list.Sort();
                if (list.Count > 20) list = list.GetRange(0, 20);
                return string.Join(",", list);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender=null, EventArgs e=null)
        {
            try
            {
                calculate(((Control) sender).Parent);
            }
            catch (Exception)
            {
                foreach (Control control in panel_all.Controls)
                {
                    calculate(control);
                }
            }


        }

        private void calculate(Control control)
        {

            if (!(control is Panel)) throw new Exception();

            try
            {
                int hero_atk = Convert.ToInt32(textbox_hero_atk.Text),
                    hero_def = Convert.ToInt32(textbox_hero_def.Text);
                Monster monster = new Monster(
                    Convert.ToInt32(control.Controls.Find("monster_hp", true)[0].Text),
                    Convert.ToInt32(control.Controls.Find("monster_atk", true)[0].Text),
                    Convert.ToInt32(control.Controls.Find("monster_def", true)[0].Text),
                    ((ComboBox)control.Controls.Find("monster_special", true)[0]).SelectedIndex
                );
                control.Controls.Find("monster_damage", true)[0].Text = monster.getDamage(hero_atk, hero_def);
                control.Controls.Find("monster_critical", true)[0].Text = monster.getCritical(hero_atk);
            }
            catch (Exception)
            {
            }

        }

        private void button_add_item_Click(object sender=null, EventArgs e=null)
        {
            int cnt = panel_all.Controls.Count;

            Panel panel = new Panel();
            panel.Size = new System.Drawing.Size(630, 37);
            panel.Location = new System.Drawing.Point(2,30*cnt-5);

            TextBox tb_hp = new TextBox();
            tb_hp.Location = new System.Drawing.Point(10, 8);
            tb_hp.Size = new System.Drawing.Size(63, 20);
            tb_hp.Text = "1000";
            tb_hp.TextChanged += calculate;
            tb_hp.Name = "monster_hp";
            tb_hp.TabIndex = 4 * cnt + 4;
            panel.Controls.Add(tb_hp);

            TextBox tb_atk = new TextBox();
            tb_atk.Location = new System.Drawing.Point(91, 8);
            tb_atk.Size = new System.Drawing.Size(43, 20);
            tb_atk.Text = "10";
            tb_atk.TextChanged += calculate;
            tb_atk.Name = "monster_atk";
            tb_atk.TabIndex = 4 * cnt + 5;
            panel.Controls.Add(tb_atk);

            TextBox tb_def = new TextBox();
            tb_def.Location = new System.Drawing.Point(154, 8);
            tb_def.Size = new System.Drawing.Size(43, 20);
            tb_def.Text = "10";
            tb_def.TextChanged += calculate;
            tb_def.Name = "monster_def";
            tb_def.TabIndex = 4 * cnt + 6;
            panel.Controls.Add(tb_def);

            ComboBox comboBox = new ComboBox();
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new[] {"无","先攻","魔攻","坚固"});
            comboBox.Location = new System.Drawing.Point(214, 7);
            comboBox.Name = "monster_special";
            comboBox.Size = new System.Drawing.Size(51, 18);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
            comboBox.TabIndex = 4 * cnt + 7;
            panel.Controls.Add(comboBox);

            TextBox tb_damage = new TextBox();
            tb_damage.Location = new System.Drawing.Point(280, 8);
            tb_damage.Size = new System.Drawing.Size(63, 20);
            tb_damage.ReadOnly = true;
            tb_damage.Name = "monster_damage";
            panel.Controls.Add(tb_damage);

            TextBox tb_critical = new TextBox();
            tb_critical.Location = new System.Drawing.Point(362, 8);
            tb_critical.Size = new System.Drawing.Size(260, 20);
            tb_critical.ReadOnly = true;
            tb_critical.Name = "monster_critical";
            panel.Controls.Add(tb_critical);

            panel_all.Controls.Add(panel);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            CenterToScreen();
            Pen pen=new Pen(Color.Black);
            pen.DashStyle = DashStyle.Solid;
            Graphics graphics = CreateGraphics();
            graphics.DrawLine(pen, 10, 50,((Control)sender).Width-28, 50);
            pen.Dispose();
            graphics.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_add_item_Click();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog=new SaveFileDialog();
            dialog.FileName = "save";
            dialog.RestoreDirectory = true;
            dialog.Filter = "怪物属性数据(*.moninfo)|*.moninfo";
            dialog.AddExtension = true;
            dialog.DefaultExt = ".moninfo";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string text = textbox_hero_atk.Text + "\n" + textbox_hero_def.Text+"\n";
                int cnt = panel_all.Controls.Count;
                text += cnt + "\n";
                foreach (Control control in panel_all.Controls)
                {
                    text += control.Controls.Find("monster_hp", true)[0].Text + " " +
                            control.Controls.Find("monster_atk", true)[0].Text + " " +
                            control.Controls.Find("monster_def", true)[0].Text + " " +
                            ((ComboBox) control.Controls.Find("monster_special", true)[0]).SelectedIndex + "\n";
                }
                File.WriteAllText(dialog.FileName, text);

                MessageBox.Show("文件保存至 "+dialog.FileName+"。", "保存成功！");
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog=new OpenFileDialog();
            dialog.Filter = "怪物属性数据(*.moninfo)|*.moninfo";
            dialog.FileName = "save";
            dialog.RestoreDirectory = true;
            dialog.Filter = "怪物属性数据(*.moninfo)|*.moninfo";
            dialog.AddExtension = true;
            dialog.DefaultExt = ".moninfo";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] text = File.ReadAllLines(dialog.FileName);
                textbox_hero_atk.Text = text[0];
                textbox_hero_def.Text = text[1];
                int cnt = Convert.ToInt32(text[2]);
                while (panel_all.Controls.Count<cnt) button_add_item_Click();
                for (int i = 0; i < cnt; i++)
                {
                    string[] strings = text[3 + i].Split(" ".ToCharArray());
                    Control control = panel_all.Controls[i];
                    Controls.Find("monster_hp", true)[0].Text = strings[0];
                    Controls.Find("monster_atk", true)[0].Text = strings[1];
                    Controls.Find("monster_def", true)[0].Text = strings[2];
                    ((ComboBox)control.Controls.Find("monster_special", true)[0]).SelectedIndex = Convert.ToInt32(strings[3]);
                }
                calculate();
            }
        }


    }
}
