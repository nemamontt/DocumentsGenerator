namespace DocumentsGenerator.WordsWorks
{
    internal class WordsWork
    {
        public static string RemovingSpaces(string originalString)
        {
            if (string.IsNullOrEmpty(originalString))
                return originalString;

            string resultString = originalString;
            for (int i = 0; i < resultString.Length; i++)
            {
                if (resultString[0] == ' ')
                {
                    for (int j = 0; j < resultString.Length; j++)
                    {
                        if (resultString[j] != ' ')
                        {
                            resultString = resultString.Remove(0, j);
                            i = 0;
                            break;
                        }
                    }
                }
                if (resultString[i] == ' ')
                {
                    for (int j = i + 1; j < resultString.Length; j++)
                    {
                        if (resultString[j] != ' ')
                        {
                            resultString = resultString.Remove(i, j - i - 1);
                            break;
                        }
                    }
                    break;
                }
            }
            while (resultString[^1] == ' ')
            {
                resultString = resultString.Remove(resultString.Length - 1, 1);
            }
            return resultString;
        }
        public static void CheckingEmptyElement(Control.ControlCollection controlCollectionFORM)
        {
            for (int i = 0; i < controlCollectionFORM.Count; i++)
            {
                if (controlCollectionFORM[i] is TextBox && controlCollectionFORM[i].Text == string.Empty)
                    throw new Exception($"Заполните поле \"{controlCollectionFORM[i].AccessibleDescription}\"");
            }
        }
        public static bool NameVerification(string str, int bestCountPoint)
        {
            int countSign = default;
            for (int i = 0; i < str.Length; i++)
                if (str[i] is '.')
                    countSign++;
            if (countSign != bestCountPoint)
                return false;
            else
                return true;
        }
    }
}

