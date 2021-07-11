namespace Task1
{
    public class Anagram
    {
        private string newSentence = "";
        public string Reverse(string sentence)
        {
            if (!string.IsNullOrEmpty(sentence))
            {
                string[] sentenceArray =  sentence.Split(' ');
                int j = sentenceArray.Length - 1;

                for(int i = 0; i <j; i++)
                {
                    newSentence = newSentence + ReverseWord(sentenceArray[i]) + " ";
                    }
                newSentence = newSentence + ReverseWord(sentenceArray[j]);
                return newSentence;
            }
            return null;
        }

        private string ReverseWord(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                char[] wordArray = word.ToCharArray();
                char[] newWordArray = new char[wordArray.Length];
                int right = wordArray.Length - 1;
                int left = 0;

                while (left < right)
                {
                    if (!char.IsLetter(wordArray[left]))
                        left++;
                    else if (!char.IsLetter(wordArray[right]))
                        right--;
                    else
                    {
                        char tmp = wordArray[left];
                        wordArray[left] = wordArray[right];
                        wordArray[right] = tmp;
                        left++;
                        right--;
                    }
                }
                newWordArray = wordArray;
                return new string(newWordArray);
            }
            return null;
        }
    }
}
