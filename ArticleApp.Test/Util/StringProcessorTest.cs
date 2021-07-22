using System;
using System.Linq;

namespace ArticleApp.Test.Util
{
    public class StringProcessorTest
    {
        [TestMethod]
        public void StringProcessorTesting()
        {
            string sentence = "Programando meu primeiro teste unitario";

            string d = StringProcessorTest.ToUpperCase(sentence);

            foreach(char c in d)
            {
                if(c != ' ')
                    Assert.IsTrue(char.IsUpper(c));
            }
        }
    }
}