namespace AreaCalcuation.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleValidateTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        /// <summary>
        /// ��������� ������������� ������� ������������
        /// </summary>
        [Test]
        public void TrianglValidateTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(6, -3, 5));
            
        }

        /// <summary>
        /// ��������� ���������� ������� �����
        /// </summary>
        [Test]
        public void CircleAreaTest()
        {
            
            IFigure circle = new Circle(5);

            
            Assert.AreEqual(78.53982, circle.CalculateArea());
        }

        /// <summary>
        /// ��������� ���������� ������� �����������
        /// </summary>
        [Test]
        public void TriangleAreaTest()
        {
            
            var triangle = new Triangle(3, 4, 5);
           
            Assert.AreEqual(6, triangle.CalculateArea());
        }

        /// <summary>
        /// ��������� ������������� �����������
        /// </summary>
        [Test]
        public void TriangleRightAngledTest()
        {
           
            var triangle = new Triangle(3, 4, 5);

           

            
            Assert.AreEqual(true, triangle.CheckIsRightAngled());
        }

        
        [Test]
        public void NotTriangleRightAngledTest()
        {
            
            var triangle = new Triangle(3, 5, 7);

           
            Assert.AreEqual(false, triangle.CheckIsRightAngled());
        }
    }
}