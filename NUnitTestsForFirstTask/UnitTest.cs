using First_task;
namespace NUnit_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Voditeli_Mat_tochki_negative_IndexOutOfRangeException()
        {
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            vodit_test.Append(vodit_test, new Mat_tochki(0, 0, "v1"));
            vodit_test.Append(vodit_test, new Mat_tochki(3, 1, "v2"));
            vodit_test.Append(vodit_test, new Mat_tochki(19, 19, "v3"));
            vodit_test.Append(vodit_test, new Mat_tochki(0, 19, "v4"));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[-1].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[-1].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[-1].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[-1].X) + " " + Convert.ToString(vodit_test[-1].Y) + " " + Convert.ToString(vodit_test[-1].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[-10].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[-10].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[-10].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[-10].X) + " " + Convert.ToString(vodit_test[-10].Y) + " " + Convert.ToString(vodit_test[-10].ID)));
        }
        [Test]
        public void Voditeli_Mat_tochki_positive_IndexOutOfRangeException()
        {
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            vodit_test.Append(vodit_test, new Mat_tochki(0, 0, "v1"));
            vodit_test.Append(vodit_test, new Mat_tochki(3, 1, "v2"));
            vodit_test.Append(vodit_test, new Mat_tochki(19, 19, "v3"));
            vodit_test.Append(vodit_test, new Mat_tochki(0, 19, "v4"));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[4].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[4].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[4].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[4].X) + " " + Convert.ToString(vodit_test[4].Y) + " " + Convert.ToString(vodit_test[4].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[10].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[10].Y) + " " + Convert.ToString(vodit_test[0].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[10].ID)));
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(Convert.ToString(vodit_test[10].X) + " " + Convert.ToString(vodit_test[10].Y) + " " + Convert.ToString(vodit_test[10].ID)));
        }
        [Test]
        public void Voditeli_Mat_tochki_positive()
        {
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            vodit_test.Append(vodit_test, new Mat_tochki(0, 0, "v1"));
            vodit_test.Append(vodit_test, new Mat_tochki(3, 1, "v2"));
            vodit_test.Append(vodit_test, new Mat_tochki(19, 19, "v3"));
            vodit_test.Append(vodit_test, new Mat_tochki(0, 19, "v4"));
            Console.WriteLine(Convert.ToString(vodit_test[0].X) + " " + Convert.ToString(vodit_test[0].Y) + " " + Convert.ToString(vodit_test[0].ID));
            Console.WriteLine(Convert.ToString(vodit_test[1].X) + " " + Convert.ToString(vodit_test[1].Y) + " " + Convert.ToString(vodit_test[1].ID));
            Console.WriteLine(Convert.ToString(vodit_test[2].X) + " " + Convert.ToString(vodit_test[2].Y) + " " + Convert.ToString(vodit_test[2].ID));
            Console.WriteLine(Convert.ToString(vodit_test[3].X) + " " + Convert.ToString(vodit_test[3].Y) + " " + Convert.ToString(vodit_test[3].ID));
            Assert.Pass();
        }
        [Test]
        public void Voditeli_Append_positive_ArgumentOutOfRangeException()
        {
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(1, 20, "v3")));
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(20, 1, "v3")));
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(20, 20, "v3")));
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(1, 100, "v3")));
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(100, 1, "v3")));
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(100, 100, "v3")));
        }
        [Test]
        public void Voditeli_Append_negative_ArgumentOutOfRangeException()
        {
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(1, -19, "v3")));
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(-1, 19, "v3")));
            Assert.Throws<ArgumentOutOfRangeException>(() => vodit_test.Append(vodit_test, new Mat_tochki(-1, -19, "v3")));
        }
        [Test]
        public void Voditeli_Append_positive()
        {
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            vodit_test.Append(vodit_test, new Mat_tochki(0, 0, "v1"));
            vodit_test.Append(vodit_test, new Mat_tochki(3, 1, "v2"));
            vodit_test.Append(vodit_test, new Mat_tochki(19, 19, "v3"));
            vodit_test.Append(vodit_test, new Mat_tochki(0, 19, "v4"));
            Assert.Pass();
        }
        [Test]
        public void Voditeli_direct_choice_10()
        {
            int i = 0;
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            var zakaz_test = new Mat_tochki.Zakazi(5, 7);
            vodit_test.Append(vodit_test, new Mat_tochki(0, 0, "v1"));
            vodit_test.Append(vodit_test, new Mat_tochki(3, 1, "v2"));
            vodit_test.Append(vodit_test, new Mat_tochki(2, 7, "v3"));
            vodit_test.Append(vodit_test, new Mat_tochki(5, 3, "v4"));
            vodit_test.Append(vodit_test, new Mat_tochki(11, 7, "v5"));
            vodit_test.Append(vodit_test, new Mat_tochki(10, 1, "v6"));
            vodit_test.Append(vodit_test, new Mat_tochki(9, 5, "v7"));
            vodit_test.Append(vodit_test, new Mat_tochki(7, 10, "v8"));
            vodit_test.Append(vodit_test, new Mat_tochki(4, 7, "v9"));
            vodit_test.Append(vodit_test, new Mat_tochki(4, 6, "v10"));
            while (i < vodit_test.Len(vodit_test))
            {
                vodit_test[i].X = vodit_test[i].X - zakaz_test.X;
                vodit_test[i].Y = vodit_test[i].Y - zakaz_test.Y;
                i++;
            }

            vodit_test.Sort_direct_choice(vodit_test, vodit_test.Len(vodit_test));

            Assert.That(vodit_test[0].ID, Is.EqualTo("v9"));
            Assert.That(vodit_test[1].ID, Is.EqualTo("v10"));
            Assert.That(vodit_test[2].ID, Is.EqualTo("v3"));
            Assert.That(vodit_test[3].ID, Is.EqualTo("v8"));
            Assert.That(vodit_test[4].ID, Is.EqualTo("v4"));
        }
        [Test]
        public void Voditeli_bubble_10()
        {
            int i = 0;
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            var zakaz_test = new Mat_tochki.Zakazi(5, 7);
            vodit_test.Append(vodit_test, new Mat_tochki(0, 0, "v1"));
            vodit_test.Append(vodit_test, new Mat_tochki(3, 1, "v2"));
            vodit_test.Append(vodit_test, new Mat_tochki(2, 7, "v3"));
            vodit_test.Append(vodit_test, new Mat_tochki(5, 3, "v4"));
            vodit_test.Append(vodit_test, new Mat_tochki(11, 7, "v5"));
            vodit_test.Append(vodit_test, new Mat_tochki(10, 1, "v6"));
            vodit_test.Append(vodit_test, new Mat_tochki(9, 5, "v7"));
            vodit_test.Append(vodit_test, new Mat_tochki(7, 10, "v8"));
            vodit_test.Append(vodit_test, new Mat_tochki(4, 7, "v9"));
            vodit_test.Append(vodit_test, new Mat_tochki(4, 6, "v10"));
            while (i < vodit_test.Len(vodit_test))
            {
                vodit_test[i].X = vodit_test[i].X - zakaz_test.X;
                vodit_test[i].Y = vodit_test[i].Y - zakaz_test.Y;
                i++;
            }

            vodit_test.Sort_bubble(vodit_test, vodit_test.Len(vodit_test));

            Assert.That(vodit_test[0].ID, Is.EqualTo("v9"));
            Assert.That(vodit_test[1].ID, Is.EqualTo("v10"));
            Assert.That(vodit_test[2].ID, Is.EqualTo("v3"));
            Assert.That(vodit_test[3].ID, Is.EqualTo("v8"));
            Assert.That(vodit_test[4].ID, Is.EqualTo("v4"));
        }
        [Test]
        public void Voditeli_Shella_10()
        {
            int i = 0;
            var vodit_test = new Mat_tochki.Voditeli();
            vodit_test.N = 20; vodit_test.M = 20;
            var zakaz_test = new Mat_tochki.Zakazi(5, 7);
            vodit_test.Append(vodit_test, new Mat_tochki(0, 0, "v1"));
            vodit_test.Append(vodit_test, new Mat_tochki(3, 1, "v2"));
            vodit_test.Append(vodit_test, new Mat_tochki(2, 7, "v3"));
            vodit_test.Append(vodit_test, new Mat_tochki(5, 3, "v4"));
            vodit_test.Append(vodit_test, new Mat_tochki(11, 7, "v5"));
            vodit_test.Append(vodit_test, new Mat_tochki(10, 1, "v6"));
            vodit_test.Append(vodit_test, new Mat_tochki(9, 5, "v7"));
            vodit_test.Append(vodit_test, new Mat_tochki(7, 10, "v8"));
            vodit_test.Append(vodit_test, new Mat_tochki(4, 7, "v9"));
            vodit_test.Append(vodit_test, new Mat_tochki(4, 6, "v10"));
            while (i < vodit_test.Len(vodit_test))
            {
                vodit_test[i].X = vodit_test[i].X - zakaz_test.X;
                vodit_test[i].Y = vodit_test[i].Y - zakaz_test.Y;
                i++;
            }

            vodit_test.Sort_Shella(vodit_test, vodit_test.Len(vodit_test));

            Assert.That(vodit_test[0].ID, Is.EqualTo("v9"));
            Assert.That(vodit_test[1].ID, Is.EqualTo("v10"));
            Assert.That(vodit_test[2].ID, Is.EqualTo("v3"));
            Assert.That(vodit_test[3].ID, Is.EqualTo("v8"));
            Assert.That(vodit_test[4].ID, Is.EqualTo("v4"));
        }
    }
}