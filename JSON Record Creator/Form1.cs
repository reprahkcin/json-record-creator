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

namespace JSON_Record_Creator
{
    public partial class Form1 : Form
    {
        private string id;
        private string lessonNumber;
        private string englishTranslation;

        private string chinese1;
        private string romanized1;
        private bool isImportant1;

        private string chinese2;
        private string romanized2;
        private bool isImportant2;

        private string chinese3;
        private string romanized3;
        private bool isImportant3;

        private string chinese4;
        private string romanized4;
        private bool isImportant4;

        private string chinese5;
        private string romanized5;
        private bool isImportant5;



        private List<string> chineseList;
        private List<string> romanizedList;
        private List<int> importantCharacterList;
        private List<string> mainGraphicsList;
        private List<string> strokePngList;
        private List<string> strokeAudioList;
 
        private int strokes;

        private string audioPath = "audio/";
        private string imagePath = "images/";
        private string characterAnimated = "character-animated/";


        public Form1()
        {
            InitializeComponent();
        }

        private void Id_textBox_TextChanged(object sender, EventArgs e)
        {
            id = id_textBox.Text;
        }
        private void BuildChineseList()
            {
                chineseList = new List<string>();
                if (chinese1 != null)
                {
                    chineseList.Add(chinese1);
                }

                if (chinese2 != null)
                {
                    chineseList.Add(chinese2);
                }

                if (chinese3 != null)
                {
                    chineseList.Add(chinese3);
                }

                if (chinese4 != null)
                {
                    chineseList.Add(chinese4);
                }

                if (chinese5 != null)
                {
                    chineseList.Add(chinese5);
                }
            }

        private void BuildRomanizedList()
        {
            romanizedList = new List<string>();
            if (romanized1 != null)
            {
                romanizedList.Add(romanized1);
            }

            if (romanized2 != null)
            {
                romanizedList.Add(romanized2);
            }

            if (romanized3 != null)
            {
                romanizedList.Add(romanized3);
            }

            if (romanized4 != null)
            {
                romanizedList.Add(romanized4);
            }

            if (romanized5 != null)
            {
                romanizedList.Add(romanized5);
            }
        }

        private void BuildImportantCharacterList()
        {
            importantCharacterList = new List<int>();
            if (isImportant1_chk.Checked)
            {
                importantCharacterList.Add(0);
            }
            if (isImportant2_chk.Checked)
            {
                importantCharacterList.Add(1);
            }
            if (isImportant3_chk.Checked)
            {
                importantCharacterList.Add(2);
            }
            if (isImportant4_chk.Checked)
            {
                importantCharacterList.Add(3);
            }
            if (isImportant5_chk.Checked)
            {
                importantCharacterList.Add(4);
            }
        }

        private void BuildMainGraphicsList()
        {
            string[] suffix = new[] {"-a", "-b", "-c","-d","-e"};
            mainGraphicsList = new List<string>();
            if (chineseList.Count > 1)
            {
                for (int i = 0; i < chineseList.Count; i++)
                {
                    string path = imagePath + id + suffix[i] + ".png";
                    mainGraphicsList.Add(path);
                }
            }
            else
            {
                string path = imagePath + id + ".png";
                mainGraphicsList.Add(path);
            }

        }

        private void BuildStrokePngList()
        {
            string[] ints = new[]
            {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17",
                "18", "19", "20", "21", "22", "23", "24", "25", "26", "27",
                "28", "29", "30","31", "32", "33", "34", "35", "36", "37",
                "38", "39", "40"};
            strokePngList = new List<string>();
            for (int i = 0; i < strokes; i++)
            {
                string path = imagePath + id + "-" + ints[i] + ".png";
                strokePngList.Add(path);
            }
        }

        private void BuildStrokeAudioList()
        {
            string[] ints = new[]
            {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17",
                "18", "19", "20", "21", "22", "23", "24", "25", "26", "27",
                "28", "29", "30","31", "32", "33", "34", "35", "36", "37",
                "38", "39", "40"};
            strokeAudioList = new List<string>();
            for (int i = 0; i < strokes; i++)
            {
                string path = audioPath + ints[i] + ".mp3";
                strokeAudioList.Add(path);
            }
        }

        private void CreateJSON_btn_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            Directory.CreateDirectory(folderPath + "\\" + id);
            Directory.CreateDirectory(folderPath + "\\" + id + "\\audio");
            Directory.CreateDirectory(folderPath + "\\" + id + "\\images");
            Directory.CreateDirectory(folderPath + "\\" + id + "\\animation");
            MessageBox.Show(folderPath);
            BuildChineseList();
            BuildRomanizedList();
            BuildImportantCharacterList();
            BuildMainGraphicsList();
            BuildStrokePngList();
            BuildStrokeAudioList();
        }

        private void Lesson_textBox_TextChanged(object sender, EventArgs e)
        {
            lessonNumber = lesson_textBox.Text;
        }

        private void EnglishTranslation_textBox_TextChanged(object sender, EventArgs e)
        {
            englishTranslation = englishTranslation_textBox.Text;
        }

        private void NumStrokes_textBox_TextChanged(object sender, EventArgs e)
        {
            strokes = Convert.ToInt32(numStrokes_textBox.Text);
        }

        private void ChineseCharacter1_textBox_TextChanged(object sender, EventArgs e)
        {
            chinese1 = chineseCharacter1_textBox.Text;
        }

        private void ChineseCharacter2_textBox_TextChanged(object sender, EventArgs e)
        {
            chinese2 = chineseCharacter2_textBox.Text;
        }

        private void ChineseCharacter3_textBox_TextChanged(object sender, EventArgs e)
        {
            chinese3 = chineseCharacter3_textBox.Text;
        }

        private void ChineseCharacter4_textBox_TextChanged(object sender, EventArgs e)
        {
            chinese4 = chineseCharacter4_textBox.Text;
        }

        private void ChineseCharacter5_textBox_TextChanged(object sender, EventArgs e)
        {
            chinese5 = chineseCharacter5_textBox.Text;
        }

        private void RomanizedCharacter1_textBox_TextChanged(object sender, EventArgs e)
        {
            romanized1 = romanizedCharacter1_textBox.Text;
        }

        private void RomanizedCharacter2_textBox_TextChanged(object sender, EventArgs e)
        {
            romanized2 = romanizedCharacter2_textBox.Text;
        }

        private void RomanizedCharacter3_textBox_TextChanged(object sender, EventArgs e)
        {
            romanized3 = romanizedCharacter3_textBox.Text;
        }

        private void RomanizedCharacter4_textBox_TextChanged(object sender, EventArgs e)
        {
            romanized4 = romanizedCharacter4_textBox.Text;
        }

        private void RomanizedCharacter5_textBox_TextChanged(object sender, EventArgs e)
        {
            romanized5 = romanizedCharacter5_textBox.Text;
        }

    }
}
