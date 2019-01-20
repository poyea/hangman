using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    public class Word
    {
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

        public void LoadWord()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, WordList.Count);
            theWord = WordList[num];
        }


        /* Add words below */
        private static List<string> WordList = new List<string>() {
            "CHRISTMAS" , "PLEASE", "MUSIC","HOPE","SOFTWARE",
            "COMPUTER","MISTAKE","POSITIVE","SECRET","WORD",
            "SCIENTIST","SUBSTANCE","WOODPECKER","SCRABBLE"
        };
        
    }
}
