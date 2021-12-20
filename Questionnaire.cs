namespace PracticalWork_9
{
    struct Questionnaire
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int YearBirth { get; set; }
        public string Nationality { get; set; }
        public string Birthplace { get; set; }

        public Questionnaire(string fullName, string gender, int yearBirth, string nationality, string birthplace)
        {
            FullName = fullName;
            Gender = gender;
            YearBirth = yearBirth;
            Birthplace = birthplace;
            Nationality = nationality;
        }
    }
}
