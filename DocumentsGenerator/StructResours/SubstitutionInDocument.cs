namespace DocumentsGenerator.StructResours
{
    internal struct SubstitutionInDocument
    {
        public string CountAuthor { get; set; }
        public string FIOAuthor { get; set; }
        public string POName { get; set; }
        public string ContributionDescription { get; set; }
        public string DateOfDisk { get; set; }
        public string Location { get; set; }
        public string Addres { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfBirthYear { get; set; }
        public string DateOfBirtNumber { get; set; }
        public string DateOfBirtMonth { get; set; }
        public string FIOApplicant { get; set; }
        public string DateOfSigning { get; set; }
        public string YearСreationProgram { get; set; }
        public string ProgramAnnotation { get; set; }
        public string TypeOfСomputer { get; set; }
        public string ProgramLanguage { get; set; }
        public string ProgramSize { get; set; }
        public string OperatingSystem { get; set; }
        public List<string> FioOtherAuthors { get; set; }
        public List<string> DateOfBirthOtherAuthors { get; set; }
        public List<string> ContributionDescriptionOtherAuthors { get; set; }
        public List<string> LocationOtherAuthor { get; set; }
        public List<string> PassportDataAuthor { get; set; }
    }
}
