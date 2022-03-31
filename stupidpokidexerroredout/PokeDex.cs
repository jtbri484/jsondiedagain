using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stupidpokidexerroredout
{
    class Pokemon
    {
        string m_picture;
        string m_name;
        string m_category;
        int m_height;
        int m_weight;
        string m_move;
        string m_weaknesses;
        string m_gender;
        int m_hp;
        string m_desc;

        public Pokemon(string name,
                       string category,
                       int height,
                       int weight,
                       string move,
                       string weaknesses,
                       string gender,
                       int hp,
                       string desc,
                       string picture)
        {
            m_name = name;
            m_category = category;
            m_height = height;
            m_weight = weight;
            m_move = move;
            m_weaknesses = weaknesses;
            m_gender = gender;
            m_hp = hp;
            m_desc = desc;
            m_picture = picture;
        }

        public Pokemon(string line)
        {
            if (line.Length > 0)
            {
                string[] fields = line.Split(',');

                string name = fields[0];
                string category = fields[1];
                int height = int.Parse(fields[2]);
                int weight = int.Parse(fields[3]);
                string move = fields[4];
                string weaknesses = fields[5];
                string gender = fields[6];
                int hp = int.Parse(fields[7]);
                string desc = fields[8];
                string picture = fields[9];
            }
        }

        public string getName() { return m_name; }
        public void setName(string name) { m_name = name; }

        public string getCategory() { return m_category; }
        public void setCategory(string category) { m_category = category; }

        public int getHeight() { return m_height; }
        public void setHeight(int height) { m_height = height; }

        public int getWeight() { return m_weight; }
        public void setWeight(int weight) { m_weight = weight; }

        public string getMove() { return m_move; }
        public void setMove(string move) { m_move = move; }

        public string getWeaknesses() { return m_weaknesses; }
        public void setWeaknesses(string weaknesses) { m_weaknesses = weaknesses; }

        public string getGender() { return m_gender; }
        public void setGender(string gender) { m_gender = gender; }

        public int getHP() { return m_hp; }
        public void setHP(int hp) { m_hp = hp; }

        public string getDesc() { return m_desc; }
        public void setDesc(string desc) { m_desc = desc; }

        public string getPicture() { return m_picture; }
        public void setPicture(string picture) { m_picture = picture; }

        public void save()
        {
            StreamWriter outFile = File.AppendText("Pokemon.txt");
            outFile.Write(m_name);
            outFile.Write(", ");
            outFile.Write(m_category);
            outFile.Write(", ");
            outFile.Write(m_height);
            outFile.Write(", ");
            outFile.Write(m_weight);
            outFile.Write(", ");
            outFile.Write(m_move);
            outFile.Write(", ");
            outFile.Write(m_weaknesses);
            outFile.Write(", ");
            outFile.Write(m_gender);
            outFile.Write(", ");
            outFile.Write(m_hp);
            outFile.Write(", ");
            outFile.Write(m_desc);
            outFile.Write(", ");
            outFile.Write(m_picture);
            outFile.WriteLine();
            outFile.Close();
        }
    }
}


