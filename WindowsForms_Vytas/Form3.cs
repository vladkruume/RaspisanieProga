using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms_Vytas
{
    public partial class Form3 : Form
    {
        ListBox lbox1, lbox2;
        Button btn;
        string x;
        public Form3()
        {
            this.Text = "Расписание";
            this.Size = new Size { Height = 800, Width = 800 };
            this.BackColor = Color.Yellow;
            lbox1 = new ListBox();
            lbox1.BackColor = Color.Red;
            lbox1.Items.Add("Понедельник");
            lbox1.Items.Add("Вторник");
            lbox1.Items.Add("Среда");
            lbox1.Items.Add("Четверг");
            lbox1.Items.Add("Пятница");
            lbox1.Items.Add("Суббота");
            lbox1.Items.Add("Воскресение");
            lbox1.Location = new Point(100, 200);
            lbox1.Height = 75;
            lbox1.SelectedIndexChanged += new EventHandler(Lbox_SelectedIndexChanged);
            lbox2 = new ListBox();
            
            lbox2.Location = new Point(400, 200);
            lbox2.Items.Add("урок");
            lbox2.Items.Add("урок");
            lbox2.Items.Add("урок");
            lbox2.Items.Add("урок");
            lbox2.Items.Add("урок");
            lbox2.Height = 75;
            btn = new Button();
            btn.Click += Btn_Click;
            btn.Location = new Point(600,200);
            btn.Text = "Сохранить";
            Controls.Add(btn);
            Controls.Add(lbox1);
            Controls.Add(lbox2);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            StreamWriter vastused = new StreamWriter("TextFile.txt");
            foreach (var item in lbox2.Items)
            {
                vastused.WriteLine(item.ToString());
            }
            vastused.Close();

            MessageBox.Show("Programs saved!");

        }

        private void Lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbox1.SelectedIndex)
            {
                case (0): lbox2.Items[0] = "Eesti keel"; lbox2.Items[1] = "Multimeedia"; lbox2.Items[2] = "Inglise keel"; lbox2.Items[3] = "füüsika"; lbox2.Items[4] = ""; break;
                case (1): lbox2.Items[0] = "Programeeri"; lbox2.Items[1] = "Keemia"; lbox2.Items[2] = "Kirjandus"; lbox2.Items[3] = "Inglise Keel"; lbox2.Items[4] = ""; break;
                case (2): lbox2.Items[0] = "Multimeedia"; lbox2.Items[1] = "Keemia"; lbox2.Items[2] = "Matemaatika"; lbox2.Items[3] = "Veebirakendus"; lbox2.Items[4] = ""; break;
                case (3): lbox2.Items[0] = "Ajalugu"; lbox2.Items[1] = "Keemia"; lbox2.Items[2] = "Eesti keel"; lbox2.Items[3] = "Inglise keel"; lbox2.Items[4] = "Mobili Rakendus"; break;
                case (4): lbox2.Items[0] = "Füüsika"; lbox2.Items[1] = "Eesti keel"; lbox2.Items[2] = "Bioloogia"; lbox2.Items[3] = "Ajalugu"; lbox2.Items[4] = "Veeburakendus"; break;
                case (5): lbox2.Items[0] = ""; lbox2.Items[1] = ""; lbox2.Items[2] = ""; lbox2.Items[3] = ""; lbox2.Items[4] = ""; break;
                case (6): lbox2.Items[0] = ""; lbox2.Items[1] = ""; lbox2.Items[2] = ""; lbox2.Items[3] = ""; lbox2.Items[4] = ""; break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

}
