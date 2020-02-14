using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSON_Record_Creator
{
    public partial class Form1 : Form
    {
        private string _id;
        private int _lessonNumber;
        private string _englishTranslation;

        private string _chinese1;
        private string _romanized1;
        private bool _isImportant1;

        private string _chinese2;
        private string _romanized2;
        private bool _isImportant2;

        private string _chinese3;
        private string _romanized3;
        private bool _isImportant3;

        private string _chinese4;
        private string _romanized4;
        private bool _isImportant4;

        private string _chinese5;
        private string _romanized5;
        private bool _isImportant5;

        private List<string> chineseList;
        private List<string> romanizedList;
        private List<int> importantCharacterList;
        private List<string> mainGraphicsList;
        private List<string> strokePngList;
        private List<string> strokeAudioList;

        private int strokes;

        private string audioPath = "audio/";
        private string imagePath = "images/";
        private string _characterAnimated = "character-animated/";

        public Form1()
        {
            InitializeComponent();
        }

        private void Id_textBox_TextChanged(object sender, EventArgs e)
        {
            _id = id_textBox.Text;
        }

        private void BuildChineseList()
        {
            chineseList = new List<string>();
            if (_chinese1 != null)
            {
                chineseList.Add(_chinese1);
            }

            if (_chinese2 != null)
            {
                chineseList.Add(_chinese2);
            }

            if (_chinese3 != null)
            {
                chineseList.Add(_chinese3);
            }

            if (_chinese4 != null)
            {
                chineseList.Add(_chinese4);
            }

            if (_chinese5 != null)
            {
                chineseList.Add(_chinese5);
            }
        }

        private void BuildRomanizedList()
        {
            romanizedList = new List<string>();
            if (_romanized1 != null)
            {
                romanizedList.Add(_romanized1);
            }

            if (_romanized2 != null)
            {
                romanizedList.Add(_romanized2);
            }

            if (_romanized3 != null)
            {
                romanizedList.Add(_romanized3);
            }

            if (_romanized4 != null)
            {
                romanizedList.Add(_romanized4);
            }

            if (_romanized5 != null)
            {
                romanizedList.Add(_romanized5);
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
            string[] suffix = new[] { "-a", "-b", "-c", "-d", "-e" };
            mainGraphicsList = new List<string>();
            if (chineseList.Count > 1)
            {
                for (int i = 0; i < chineseList.Count; i++)
                {
                    string path = imagePath + _id + suffix[i] + ".png";
                    mainGraphicsList.Add(path);
                }
            }
            else
            {
                string path = imagePath + _id + ".png";
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
                string path = imagePath + _id + "-" + ints[i] + ".png";
                strokePngList.Add(path);
            }
        }

        private void BuildStrokeAudioList()
        {
            string[] ints = new[]
            {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30","31", "32", "33", "34", "35", "36", "37", "38", "39", "40"};
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
            Directory.CreateDirectory(folderPath + "\\" + _id);
            Directory.CreateDirectory(folderPath + "\\" + _id + "\\audio");
            Directory.CreateDirectory(folderPath + "\\" + _id + "\\images");
            Directory.CreateDirectory(folderPath + "\\" + _id + "\\animation");
            MessageBox.Show(folderPath);
            BuildChineseList();
            BuildRomanizedList();
            BuildImportantCharacterList();
            BuildMainGraphicsList();
            BuildStrokePngList();
            BuildStrokeAudioList();

            ChineseCharacter character = new ChineseCharacter
            {
                id = _id,
                chinese = chineseList,
                romanized = romanizedList,
                importantCharacters = importantCharacterList,
                englishTranslation = englishTranslation_textBox.Text,
                mainGraphics = mainGraphicsList,
                strokeAudio = strokeAudioList,
                strokePng = strokePngList,
                characterAnimated = _characterAnimated

            };

            string json = JsonConvert.SerializeObject(character, Formatting.Indented);
            string jsonPath = folderPath + "\\" + _id + "\\" + _id + ".json";
            File.WriteAllText(jsonPath, json);
        }

        private void Lesson_textBox_TextChanged(object sender, EventArgs e)
        {
            _lessonNumber = Convert.ToInt32(lesson_textBox.Text);
        }

        private void EnglishTranslation_textBox_TextChanged(object sender, EventArgs e)
        {
            _englishTranslation = englishTranslation_textBox.Text;
        }

        private void NumStrokes_textBox_TextChanged(object sender, EventArgs e)
        {
            strokes = Convert.ToInt32(numStrokes_textBox.Text);
        }

        private void ChineseCharacter1_textBox_TextChanged(object sender, EventArgs e)
        {
            _chinese1 = chineseCharacter1_textBox.Text;
        }

        private void ChineseCharacter2_textBox_TextChanged(object sender, EventArgs e)
        {
            _chinese2 = chineseCharacter2_textBox.Text;
        }

        private void ChineseCharacter3_textBox_TextChanged(object sender, EventArgs e)
        {
            _chinese3 = chineseCharacter3_textBox.Text;
        }

        private void ChineseCharacter4_textBox_TextChanged(object sender, EventArgs e)
        {
            _chinese4 = chineseCharacter4_textBox.Text;
        }

        private void ChineseCharacter5_textBox_TextChanged(object sender, EventArgs e)
        {
            _chinese5 = chineseCharacter5_textBox.Text;
        }

        private void RomanizedCharacter1_textBox_TextChanged(object sender, EventArgs e)
        {
            _romanized1 = romanizedCharacter1_textBox.Text;
        }

        private void RomanizedCharacter2_textBox_TextChanged(object sender, EventArgs e)
        {
            _romanized2 = romanizedCharacter2_textBox.Text;
        }

        private void RomanizedCharacter3_textBox_TextChanged(object sender, EventArgs e)
        {
            _romanized3 = romanizedCharacter3_textBox.Text;
        }

        private void RomanizedCharacter4_textBox_TextChanged(object sender, EventArgs e)
        {
            _romanized4 = romanizedCharacter4_textBox.Text;
        }

        private void RomanizedCharacter5_textBox_TextChanged(object sender, EventArgs e)
        {
            _romanized5 = romanizedCharacter5_textBox.Text;
        }
    }
}