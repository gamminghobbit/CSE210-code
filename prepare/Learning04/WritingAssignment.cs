public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
    public string GetStudentName()
    {
        return GetSummary().Split(" - ")[0]; // Grabs just the student name
    }
}