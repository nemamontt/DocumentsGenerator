namespace DocumentsGenerator.StructResours
{
    public struct SubstitutionInDocument
    {
        public string CountAuthor { get; set; }
        public string POName { get; set; }
        public string DateOfDisk { get; set; }
        public string DateOfBirthYear { get; set; }
        public string DateOfBirtNumber { get; set; }
        public string DateOfBirtMonth { get; set; }
        public string FIOApplicant { get; set; }
        public string DateOfSigning { get; set; }
        public string YearCreationProgram { get; set; }
        public string ProgramAnnotation { get; set; }
        public string TypeOfComputer { get; set; }
        public string ProgramLanguage { get; set; }
        public string ProgramSize { get; set; }
        public string OperatingSystem { get; set; }
        public string PositionOfSignatory { get; set; }   
        public string DateForDisk { get; set; }
        public string FullStringFioAuthors { get; set; }
        public string FullNameTransfer { get; set; }      
        public string FIOAddressee { get; set; }
        public string NumberPhoneAddressee { get; set; }
        public string PostSigningSeparately { get; set; }
        public string FIOSigningSeparately { get; set; }
        public string FullStringShortFioAuthors { get; set; }
        public List<string> ShortFioAuthors { get; set; }
        public List<string> FioAuthors { get; set; }
        public List<string> DateOfBirthAuthors { get; set; }
        public List<string> ContributionDescriptionAuthors { get; set; }
        public List<string> LocationAuthor { get; set; }
        public List<string> PassportDataAuthor { get; set; }
    }
}