using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {

            try
            {

                int hero_hp = Convert.ToInt32(textbox_hero_hp.Text), hero_atk = Convert.ToInt32(textbox_hero_atk.Text),
                    hero_def = Convert.ToInt32(textbox_hero_def.Text);

                int monster_hp = Convert.ToInt32(textbox_monster_hp.Text), monster_atk = Convert.ToInt32(textbox_monster_atk.Text),
                    monster_def = Convert.ToInt32(textbox_monster_def.Text);

                // 魔攻
                if (checkBox2.Checked) hero_def = 0;
                // 坚固
                if (checkBox3.Checked && monster_def < hero_atk - 1) monster_def = hero_atk - 1;

                // 伤害
                if (hero_atk <= monster_def) textbox_damage.Text = "不可战斗";
                else if (hero_def >= monster_atk) textbox_damage.Text = "0";
                else
                {
                    int damage = checkBox1.Checked ? monster_atk - hero_def : 0;
                    textbox_damage.Text = Convert.ToString(damage + (monster_hp - 1) / (hero_atk - monster_def) * (monster_atk - hero_def));
                }

                // 临界
                if (checkBox3.Checked)
                {
                    textbox_output.Text = "无临界";
                }
                else
                {
                    HashSet<int> list = new HashSet<int>();
                    for (int i = 1; i <= monster_hp; i++)
                    {
                        int atk = monster_hp / i + monster_def;
                        if (atk < hero_atk) break;
                        list.Add(atk);
                    }
                    List<int> l = new List<int>(list);
                    l.Sort();

                    textbox_output.Text = String.Join(",", l);
                }

            }
            catch {

            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
