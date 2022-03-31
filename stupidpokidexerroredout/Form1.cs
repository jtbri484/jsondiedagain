using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stupidpokidexerroredout
{
    public partial class Form1 : Form
    
       
        {
            ArrayList pokés = new ArrayList();
            int m_current = 0;

            

            private void saveButton_Click(object sender, EventArgs e)
            {
                save();
            }

            private void pokemonPictureBox_Click(object sender, EventArgs e)
            {
                openFileDialog1.ShowDialog();
                
                if (System.IO.File.Exists(openFileDialog1.FileName))
                {
                    pokemonPictureBox.Load(openFileDialog1.FileName);
                }
            }

            void save()
            {
                Pokemon p = new Pokemon(nameTextBox.Text,
                                        categoryTextBox.Text,
                                        int.Parse(heightTextBox.Text),
                                        int.Parse(weightTextBox.Text),
                                        moveTextBox.Text,
                                        weaknessesTextBox.Text,
                                        genderTextBox.Text,
                                        int.Parse(hpTextBox.Text),
                                        descTextBox.Text,
                                        pokemonPictureBox.ImageLocation);
                pokés.Add(p);

                foreach (Pokemon item in pokés)
                {
                    item.save();
                }
            }

            private void addButton_Click(object sender, EventArgs e)
            {
                save();
                clear();
            }

            private void clear()
            {
                nameTextBox.Clear();
                categoryTextBox.Clear();
                heightTextBox.Clear();
                weightTextBox.Clear();
                moveTextBox.Clear();
                weaknessesTextBox.Clear();
                genderTextBox.Clear();
                hpTextBox.Clear();
                descTextBox.Clear();
                pokemonPictureBox.Image = null;
            }

            private void deleteButton_Click(object sender, EventArgs e)
            {

            }

            private void show(int index)
            {
                if (index >= 0 && index < pokés.Count)
                {
                    Pokemon p = (Pokemon)pokés[index];
                    nameTextBox.Text = p.getName();
                    categoryTextBox.Text = p.getCategory();
                    heightTextBox.Text = p.getHeight().ToString();
                    weightTextBox.Text = p.getWeight().ToString();
                    moveTextBox.Text = p.getMove();
                    weaknessesTextBox.Text = p.getWeaknesses();
                    genderTextBox.Text = p.getGender();
                    hpTextBox.Text = p.getHP().ToString();
                    descTextBox.Text = p.getDesc();
                    pokemonPictureBox.Load(p.getPicture());
                }
            }

            private void firstButton_Click(object sender, EventArgs e)
            {
                show(0);
            }

            private void lastButton_Click(object sender, EventArgs e)
            {
                show(pokés.Count - 1);
            }

            private void previousButton_Click(object sender, EventArgs e)
            {
                if (m_current > 0)
                {
                    m_current--;
                    show(m_current);
                }
            }

            private void nextButton_Click(object sender, EventArgs e)
            {
                if (m_current < pokés.Count)
                {
                    m_current++;
                    show(m_current);
                }
            }

       
    }
    }



