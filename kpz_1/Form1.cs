using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace kpz_1
{
    public partial class Form1 : Form
    {   List<student> list;
        int countt = 0;
        Form2 vydal;
        string path;
        public Form1()//ініціалізування компонентів з ліста 
        {
            InitializeComponent();
            list = new List<student>();
            vydal = new Form2();
            path = " C:/Users/NOYT/Documents/Visual Studio 2013/Projects/kpz_1\\save(kpz1).txt";
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != ""))
            {
                student obj = new student();//створення нового обєкту + запис в нього нових даних + ощищення полів 
                obj.set_nomer(countt);
                obj.set_surname(textBox1.Text);
                obj.set_name(textBox2.Text);
                obj.set_subject(textBox3.Text);
                obj.set_rating(textBox4.Text);
                obj.set_vrating(textBox5.Text);
                obj.set_grupa(textBox6.Text);
                list.Add(obj);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                countt++;
            }
            else
                MessageBox.Show("Введіть всі данні в усі поля", "читай ниже");
        }

        private void ViewallStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                try
                {
                    student obj = list[i];
                    dataGridView1.Rows[i].Cells[0].Value = obj.get_nomer();
                    dataGridView1.Rows[i].Cells[1].Value = obj.get_surname();
                    dataGridView1.Rows[i].Cells[2].Value = obj.get_name();
                    dataGridView1.Rows[i].Cells[3].Value = obj.get_subject();
                    dataGridView1.Rows[i].Cells[4].Value = obj.get_rating();
                    dataGridView1.Rows[i].Cells[5].Value = obj.get_vrating();
                    dataGridView1.Rows[i].Cells[6].Value = obj.get_grupa();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {   FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            list = (List<student>)bf.Deserialize(fs);
            fs.Close();
        }

        private void DeleteDtudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vydal.Show();
            vydal.Activate();
            vydal.button1.Click += (senderSlave, eSlave) =>
            {
                list.RemoveAt(1);
            };
            student obj = new student();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // нова кнопка для створення нового commite
        }
        
    }
}
