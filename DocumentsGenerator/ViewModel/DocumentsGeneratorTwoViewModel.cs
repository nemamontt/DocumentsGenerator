using DocumentsGenerator.Model;
using DocumentsGenerator.StructResours;

namespace DocumentsGenerator.ViewModel
{
    internal class DocumentsGeneratorTwoViewModel
    {
        private List<TextBox> _textBoxs;
        public DocumentsGeneratorTwoViewModel(ref SubstitutionInDocument subDoc, TextBox fioOtherAuthorTextBox, TextBox dateOfBirthOtherAuthorsTextBox, 
            TextBox locationOtherAuthorTextBox, TextBox creativeInputOtherAuthorTextBox, TextBox passportDetailsTextBox)
        {
            for (int i = 0; i < dateOfBirthOtherAuthorsTextBox.Text.Length; i++)
            {
                if (dateOfBirthOtherAuthorsTextBox.Text[i] is '|' || dateOfBirthOtherAuthorsTextBox.Text[i] is '.')
                    continue;
                if (!char.IsNumber(dateOfBirthOtherAuthorsTextBox.Text[i]) || dateOfBirthOtherAuthorsTextBox.Text[i] is ' ')
                    throw new Exception("Неверно указана дата рождения,\nформат: дд.мм.гггг");
            }
                
            _textBoxs = new List<TextBox>()
            {
                fioOtherAuthorTextBox,
                dateOfBirthOtherAuthorsTextBox,
                locationOtherAuthorTextBox,
                creativeInputOtherAuthorTextBox,
                passportDetailsTextBox
            };

            foreach (var item in _textBoxs) 
            {
                int counter = 0;
                for (int i = 0; i < item.Text.Length; i++)
                {
                    if (item.Text[i] is '|')
                        counter++;
                }
                if (counter + 1 < Convert.ToInt32(subDoc.CountAuthor))
                    throw new Exception($"Вы забыли указать разделитель в поле \"{item.AccessibleDescription}\"");
                else if (counter + 1 > Convert.ToInt32(subDoc.CountAuthor))
                    throw new Exception($"Вы указали больше разделителей в поле \"{item.AccessibleDescription}\"");
            }

            foreach (var item in _textBoxs)
                item.Text = DocumentsGeneratorModel.RemovingSpaces(item.Text);

            string[] splitStringFIO = fioOtherAuthorTextBox.Text.Split(new char[] { '|' });
            string[] splitStringDateOfBirth = dateOfBirthOtherAuthorsTextBox.Text.Split(new char[] { '|' });
            string[] splitStringLocation = locationOtherAuthorTextBox.Text.Split(new char[] { '|' });
            string[] splitStringCreativeInput = creativeInputOtherAuthorTextBox.Text.Split(new char[] { '|' });
            string[] splitStringPassportDetails = passportDetailsTextBox.Text.Split(new char[] { '|' });

            subDoc.FioAuthors = new List<string>();
            subDoc.DateOfBirthAuthors = new List<string>();
            subDoc.LocationAuthor = new List<string>();
            subDoc.ContributionDescriptionAuthors = new List<string>();
            subDoc.ShortFioAuthors = new List<string>();
            subDoc.PassportDataAuthor = new List<string>();

            subDoc.FioAuthors.AddRange(splitStringFIO);
            subDoc.DateOfBirthAuthors.AddRange(splitStringDateOfBirth);
            subDoc.LocationAuthor.AddRange(splitStringLocation);
            subDoc.ContributionDescriptionAuthors.AddRange(splitStringCreativeInput);
            subDoc.PassportDataAuthor.AddRange(splitStringPassportDetails);

            subDoc.FullStringFioAuthors = string.Join(", ", subDoc.FioAuthors.ToArray());

            foreach (var item in subDoc.FioAuthors)
            {
                int countSpace = default;
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == ' ')
                        countSpace++;
                }
                if (countSpace != 2)
                    throw new Exception($"Неверно заполнено поле \"ФИО автора(ов)\"");
            }
            string[]? splitStringDate = default;

            for (int i = 0; i < splitStringDateOfBirth.Length; i++)
            {
                splitStringDate = splitStringDateOfBirth[i].Split(new char[] { '.' });
                if (splitStringDate.Length is not 3)
                    throw new Exception($"Неверна указана дата рождения {i + 1}-го автора,\nформат: дд.мм.гггг"); 
                if(i is 0)
                {
                    subDoc.DateOfBirthYear = splitStringDate[2];
                    subDoc.DateOfBirtMonth = splitStringDate[1];
                    subDoc.DateOfBirtNumber = splitStringDate[0];
                }
            }
            
            foreach (var item in subDoc.FioAuthors)
            {
                string shortFioAuthors = string.Empty;
                bool flagFirstSpace = true;

                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] is ' ' && flagFirstSpace)
                    {
                        flagFirstSpace = false;
                        for (int j = 0; j < i; j++)
                            shortFioAuthors += item[j];
                        shortFioAuthors += ' ';
                        shortFioAuthors += item[i + 1];
                        continue;
                    }
                    if(item[i] is ' ' && !flagFirstSpace)
                    {
                        shortFioAuthors += $".{item[i + 1]}.";
                        break;
                    }                                              
                }

                if(shortFioAuthors != string.Empty)
                    subDoc.ShortFioAuthors.Add(shortFioAuthors);
                else
                    subDoc.ShortFioAuthors.Add(item);
            }
            subDoc.FullStringShortFioAuthors = string.Join(", ", subDoc.ShortFioAuthors.ToArray());
            subDoc.FullNameTransfer = subDoc.FullStringShortFioAuthors.Replace(", ", "^p");
        }
    }
}