namespace WebApplication1.Models
{
    public class Student
    {
        public Student(string emri,string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
        public int Emri { get; set; }
        public int Mbiemri { get; set; }

    }
}
