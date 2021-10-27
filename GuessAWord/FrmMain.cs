// Author : Chavela Rios
// Date   : 2020-12-10
// GuessAWord with online word of the day

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media; // Needed for SoundPlayer
using System.IO; // Need this for file I/O
using System.Net; // Need for WebClient

namespace GuessAWord
{
    public partial class FrmMain : Form
    {
        /*string[] words = {"pizza", "chartruese", "coffee", "friday",
                           "croissant", "september", "program", "executable"};*/

        List<string> words = new List<string>();

        Random randomNumber = new Random(); // Remove seed later... // Removed
        string word, hiddenWord;
        int countTries;

        SoundPlayer audio = new SoundPlayer(GuessAWord.Properties.Resources.crowd5);
        SoundPlayer audio1 = new SoundPlayer(GuessAWord.Properties.Resources.tada);

        // variables for log 
        const string FILENAMELOG = "GuessAWord.csv";
        const string DELIM = ",";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            string myLetter;
            char[] arrayHiddenWord = hiddenWord.ToCharArray();
            //myLetter = TxtLetterGuess.Text;

            try
            {
                myLetter = GetLetter(TxtLetterGuess.Text);
                if (LblUsedLetters.Text.Contains(myLetter))
                {
                    LblStatus.Text = "You have already used that letter!";
                }
                else
                {// Letter has not been used yet
                    LblUsedLetters.Text += myLetter;
                    countTries++;

                    bool found = false;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word.Substring(i, 1) == myLetter)
                        {// A match was found. Replace the astericks with the letter
                            arrayHiddenWord[i] = Convert.ToChar(myLetter);
                            found = true;
                        }
                    }

                    if (found)
                    {
                        LblStatus.Text = "Clap clap clap";
                        if (ChkSoundEffects.Checked) audio.Play(); ;
                    }
                    else
                    {
                        LblStatus.Text = "Sigh :(";
                    }

                    hiddenWord = new string(arrayHiddenWord);
                    LblHiddenWord.Text = hiddenWord;
                    TxtNumTries.Text = Convert.ToString(countTries);

                    // Determine if the entire word has been guessed.
                    if (!hiddenWord.Contains("*"))
                    {
                        LblStatus.Text = "You solved the word!";
                        if (ChkSoundEffects.Checked) audio1.Play();
                        BtnGuess.Enabled = false;
                        BtnPlayAgain.Visible = true;

                        // Writing the line from the found word
                        FileStream logFile = new FileStream(
                            FILENAMELOG, FileMode.Append, FileAccess.Write);
                        StreamWriter logPref = new StreamWriter(logFile);

                        logPref.WriteLine(DateTime.Now + DELIM + TxtPlayerName.Text +
                        DELIM + word + DELIM + countTries);

                        logPref.Close();
                        logFile.Close();
                    }
                } // end else letter has not been used yet
            } // End try
            catch (NonLetterException ex)
            {
                LblStatus.Text = "You have a bad character: "
                    + ex.OffendingCharacter;
            }

            TxtLetterGuess.Text = "";
            TxtLetterGuess.Focus();
        } // private void BtnGuess_Click(object sender, EventArgs e)

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            /*string[] words = {"pizza", "chartruese", "coffee", "friday",
                           "croissant", "september", "program", "executable"};*/

            // Read in our initial set up backup word list
            words.Add("pizza");
            words.Add("chartruese");
            words.Add("coffee");
            words.Add("friday");
            words.Add("croissant");
            words.Add("september");
            words.Add("program");
            words.Add("executable");

            const string FILENAME = "english_words_basic.txt";
            string lineIn;
            int lineCounter = 0;

            try
            {
                FileStream dictionaryFile = new FileStream(
                    FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(dictionaryFile);

                dictionaryFile.Position = 0;
                lineCounter = 0; // Not really needed. Was for debugging

                lineIn = reader.ReadLine();
                while (lineIn != null)
                {
                    words.Add(lineIn.ToLower());
                    lineCounter++;
                    lineIn = reader.ReadLine();
                }

                reader.Close();
                dictionaryFile.Close();

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Dictionary note found.",
                    "Reduced functionality", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Read in our preferences
            const string FILENAMEPREF = "preferences.txt";

            try
            {
                FileStream preferencesFile = new FileStream(
                    FILENAMEPREF, FileMode.Open, FileAccess.Read);
                StreamReader readerPref = new StreamReader(preferencesFile);

                TxtPlayerName.Text = readerPref.ReadLine();
                ChkSoundEffects.Checked = Convert.ToBoolean(readerPref.ReadLine());

                readerPref.Close();
                preferencesFile.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Preferences not set.", "Preferences Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Check if file is there for log 
            if (!File.Exists(FILENAMELOG))
            {
                // Creates file with header if file doesn't exist
                FileStream logFile = new FileStream(
                    FILENAMELOG, FileMode.Create, FileAccess.Write);
                StreamWriter logPref = new StreamWriter(logFile);

                logPref.WriteLine("Time Stamp, Player Name, Word, Number of Tries");

                logPref.Close();
                logFile.Close();
            }

            NewGame();
        }

        private void NewGame()
        {
            // Change from words.Length to words.Count
            word = words[randomNumber.Next(0, words.Count)];

            // Go out to the web and get a word.

            // Gong to the web could be troublesome. Use a try/catch
            try
            {
                // To show contents of webpage
                string content;
                Console.WriteLine("About to open website");
                using (WebClient client = new WebClient())
                {
                    string url = "https://randomword.com/";
                    content = client.DownloadString(url);
                    Console.WriteLine(content);
                }

                // <div id="random_word">uniphorous</div>
                string randomWordStart = @"<div id=""random_word"">";
                int startWord = content.IndexOf(randomWordStart) + 22;
                int stopWord = content.IndexOf("</div", startWord);

                if (content.IndexOf(randomWordStart) != -1)
                {
                    word = content.Substring(startWord, stopWord - startWord);
                    Console.WriteLine("startWord=" + startWord +
                        " stopWord=" + stopWord + " word=***" + word + "***");

                    //<div id="random_word_definition"> producing only one variety of musical note </div>
                    string randomWordDefinitionStart = @"<div id=""random_word_definition"">";
                    int startWordDefinition = content.IndexOf(randomWordDefinitionStart) + 33;
                    int stopWordDefinition = content.IndexOf("</div", startWordDefinition);

                    if (content.IndexOf(randomWordDefinitionStart) != -1)
                    {
                        LblDefinition.Text = content.Substring(startWordDefinition, stopWordDefinition - startWordDefinition);
                        Console.WriteLine("definition=***" + LblDefinition.Text + "***");
                    }
                    else
                    {
                        LblDefinition.Text = "Error with finding online definition.";
                    }
                }
                else
                {
                    LblDefinition.Text = "Error with finding online word.";
                }
            } // end try
            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
                LblDefinition.Text = "Online dictionary not found.";
            }

            hiddenWord = "";
            // Create the hiddenWord with the same number of asterisks 
            // as the chosen word.
            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord += "*";
            }

            LblHiddenWord.Text = hiddenWord;

            LblStatus.Text = "";
            TxtLetterGuess.Text = "";
            countTries = 0;
            TxtNumTries.Text = "";

            LblUsedLetters.Text = "";

            BtnPlayAgain.Visible = false;
            BtnGuess.Enabled = true;
        } // End NewGame

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Write user preferences to a file
            const string FILENAMEPREF = "preferences.txt"; // can make this global

            FileStream preferencesFile = new FileStream(
                    FILENAMEPREF, FileMode.Create, FileAccess.Write);
            StreamWriter writerPref = new StreamWriter(preferencesFile);

            writerPref.WriteLine(TxtPlayerName.Text);
            writerPref.WriteLine(Convert.ToString(ChkSoundEffects.Checked));

            writerPref.Close();
            preferencesFile.Close();
        }

        private string GetLetter(string myString)
        {// Sanitize the input. Make sure we have only a single character a-z
            char letter;

            if (char.TryParse(myString, out letter))
            {// We have exactly one character
                letter = Char.ToLower(letter);
                if (letter < 'a' || letter > 'z')
                {// Problem...
                    string badLetter = Convert.ToString(letter);
                    throw (new NonLetterException(badLetter));
                }

                string goodLetter = Convert.ToString(letter);
                return goodLetter;
            }
            else
            {// TryParse failed
                throw (new NonLetterException("null or multiple characters."));
            }
        }
    }// End public partial class FrmMain : Form

    // This is the custom exception class that the book
    // exercise is asking us to create
    public class NonLetterException : Exception
    {
        private string offendingCharacter;

        public NonLetterException() : base("A non-letter was entered.")

        {
            // Nothing else we need to do...
        }

        public NonLetterException(string nonletter) : base
            ("The non-letter " + nonletter + " was entered.")

        {
            offendingCharacter = nonletter;
        }

        // Using built-in getter 
        public string OffendingCharacter
        {
            get
            {
                return offendingCharacter;
            }
        }

        /* public string GetOffendingCharacter()
         * {
         * return offendingCharacter;
         * }*/
    } // End public class NonLetterException : Exception
}