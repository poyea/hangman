using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hangman
{
    public class Word
    {
        private static List<string> WordList = new List<string>();

        /* We can add new words to WordList below.
         * Each time the player starts a new game,
         * a random word is taken from WordList.
         * Take one word when the game starts.
         */
        private static Word wordPack;
        public static Word WordPack
        {
            get {
                if (wordPack == null)
                    wordPack = new Word();
                return wordPack;
            }
        }

        private string theWord;   
        public string TheWord
        {
            get { return theWord; }
        }
<<<<<<< HEAD

=======
        
>>>>>>> 1eaec723a4fb9de27a853950699054d9d8958a94
        /*
         * Static constructor for loading all
         * the words into the static List<string> 
         * WordList.
<<<<<<< HEAD
         */

        private Word()
        {
            StreamReader sr = new StreamReader("word_list.txt");
            while (!sr.EndOfStream)
            {
=======
         */ 

        static Word() {
            StreamReader sr = new StreamReader("word_list.txt");
            while (!sr.EndOfStream) {
>>>>>>> 1eaec723a4fb9de27a853950699054d9d8958a94
                WordList.Add(sr.ReadLine());
            }
        }

        public void LoadWord()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, WordList.Count);
            theWord = WordList[num];
        }                 
        
    }
}
