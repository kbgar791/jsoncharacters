using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections;
using System.IO;

namespace NewJson
{
    public partial class Form1 : Form
    {
        int current;
        private ArrayList characs = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            var characters = new Chars
            {
                Name = NameText.Text,
                Type = TypeText.Text,
                HP = int.Parse(HPText.Text),
                Infection = int.Parse(InfText.Text),
                Desc = DescText.Text,
                Profile = HeadshotBox.ImageLocation
            };

            string jsonString = JsonSerializer.Serialize(characters);
            characs.Add(characters);
            StreamWriter outFile = File.CreateText("characters.json");
            foreach (var item in characs)
            {
                outFile.WriteLine(JsonSerializer.Serialize(item));
            }
            outFile.Close();
        }

        private void HeadshotBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (System.IO.File.Exists(openFileDialog1.FileName))
                HeadshotBox.Load(openFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inFile = File.OpenText("characters.json");

            while (inFile.Peek() != -1)
            {
                string cString = inFile.ReadLine();
                Chars c = JsonSerializer.Deserialize<Chars>(cString);
                characs.Add(c);
            }
                inFile.Close();
            show();

            label1.Text = current.ToString();
        }

        public void show()
        {
            Chars c = (Chars)characs[current];
            NameText.Text = c.Name;
            TypeText.Text = c.Type;
            HPText.Text = c.HP.ToString();
            InfText.Text = c.Infection.ToString();
            DescText.Text = c.Desc;
            HeadshotBox.ImageLocation = c.Profile;
          
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (current + 1 <= characs.Count - 1)
            {
                current = current + 1;
                show();
            }

            label1.Text = current.ToString();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            NameText.Text = null;
            TypeText.Text = null;
            HPText.Text = null;
            InfText.Text = null;
            DescText.Text = null;
            HeadshotBox.ImageLocation = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (characs.Count == 0)
            {
                current = characs.Count - 1;
                show();
            }
            else
            {
                current--;
                show();
            }

            label1.Text = current.ToString();
        }
    }
}
