using System;
using System.Windows;
using System.Data;
namespace PracticalWork_9
{
    public partial class MainWindow : Window
    {
        DataRow row = res.NewRow();
        Questionnaire firstResponden = new Questionnaire("Смирнова Виктория Иосифовна", "ж", 1967, "г. Ленинград", "русская");
        Questionnaire secondResponden = new Questionnaire("Шельмах Адам Васильевич", "м", 1993, "г. Ульяновск", "немец");
        Questionnaire thirdResponden = new Questionnaire("Мичурина Нина Арсеньевна", "ж", 1986, "г. Есентуки", "русская");
        Questionnaire fourthResponden = new Questionnaire("Дюженкова Пелагея Тимофеевна", "ж", 1995, "г. Севастополь", "украинка");
        Questionnaire fifthResponden = new Questionnaire("Боброва Лидия Юлиановна", "ж", 1981, "г. Казань", "татарка");
        public static DataTable res = new DataTable();
        private Questionnaire respondent;
        int allAge = 0;
        private void FillQuestionnaire_Click(object sender, RoutedEventArgs e)
        {
            res.Columns.Add("ФИО");
            res.Columns.Add("пол");
            res.Columns.Add("Год рождения");
            res.Columns.Add("Место рождения");
            res.Columns.Add("Национальность");
            questionnaire.ItemsSource = res.DefaultView;
            for (int i = 0; i < 5; i++)
            {
                if (i == 0) respondent = firstResponden; 
                if (i == 1)  respondent = secondResponden; 
                if (i == 2)  respondent = thirdResponden; 
                if (i == 3) respondent = fourthResponden; 
                if (i == 4) respondent = fifthResponden;
                row[0] = respondent.FullName;
                row[1] = respondent.Gender;
                row[2] = respondent.YearBirth;
                row[3] = respondent.Birthplace;
                row[4] = respondent.Nationality;
                res.Rows.Add(row);
                row = res.NewRow();
                allAge += (2021 - Convert.ToInt32(respondent.YearBirth));
            }
            questionnaire.ItemsSource = res.DefaultView;
        }

        private void AverageAge_Click(object sender, RoutedEventArgs e)
        {
            if (allAge == 10105) { MessageBox.Show("Анкета не заполнена", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); return; }
            averageAgeOut.Text = Convert.ToString(allAge/5); 
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самсаков Андрей Александрович ИСП-31\nПрактическая работа №9\nСоздать интерфейс - человек. Создать классы – студент и студент-отец семейства. Классы должны включать конструкторы, функцию для формирования строки информации о студенте. Сравнение производить по фамилии. ", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
