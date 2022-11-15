namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        StudentService studentService = new StudentService();
        Student student = new Student();
        [TestMethod]
        public void WhenScore_IsEight_ShouldReturn_A()
        {
            student.Score = 8;
            char letter = student.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void WhenScore_Is7_ShouldReturn_B()
        {
            student.Score = 7;
            char letter = student.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void WhenScore_Is5_ShouldReturn_C()
        {
            student.Score = 6;
            char letter = student.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void WhenScore_Is4_ShouldReturn_D()
        {
            student.Score = 4;
            char letter = student.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void WhenScore_Is2_ShouldReturn_E()
        {
            student.Score = 2;
            char letter = student.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        public void Add_Student_Should_BeSuccess()
        {
            student.Score = 8;
            student.Id = 18;
            student.Name = "TrinhCamMinh";
            student.Age = 20;
            Boolean result = studentService.addStudent(student);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Find_StudentByAge_Should_BeSuccess()
        {
            Student result = studentService.findStudentByAge(20);
            Assert.AreEqual("TrinhCamMinh", result.Name);
        }

        [TestMethod]
        public void Find_StudentByAge_Should_BeFail()
        {
            Student result = studentService.findStudentByAge(70);
            Assert.AreEqual(null, result.Name);
        }

        [TestMethod]
        public void Get_StudentAverage_Should_Be18()
        {
            double result = studentService.getAverageScore();
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void Find_StudentMinScore_Should_Be18()
        {
            Student result = studentService.findStudentWithMinScore();
            Assert.AreEqual("TrinhCamMinh", result.Name);
        }

    }
}