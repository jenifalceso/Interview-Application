using InterviewApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace InterviewApplicationTest
{
    [TestClass()]
    public class InterviewApplicationTest
    {
        Person p = new Person();
        string nullValueErrorMsg = "parameter cannot be null";
        string invalidErrorMsg = "Input entered doesn't match 3 character limit";
        string notFoundErrorMsg = "PIC not found.";

        [TestInitialize]
        public void Initialize()
        {
            p.PersonList = new List<Person>()
            {
                new Person("KUL","PEN","","Penny"),
                new Person("KUL","CHR","A22","Penny"),
                new Person("KUL","CHR","A23","Chen"),
                new Person("JHR","PEN","P18","Penny"),
                new Person("JHR","PEN","P18","Chen"),
                new Person("JHR","DOC","","Chen"),
                new Person("JHR","CAT","A22","Cath"),
                new Person("JHR","CAT","P19","Penny"),
                new Person("AMP","DOC","P17","Cath"),
                new Person("AMP","BOK","","Kent"),
                new Person("AMP","TBL","A23","Chen"),
                new Person("AMP","TBL","A22","Kent")
            };
        }

        [TestMethod]
        public void CheckForNullValues()
        {
            // arrange
            string area = "";
            string type = "";
            string code = "";

            // act
            string result = p.RetrieveUser(area, type, code);

            // assert
            Assert.AreEqual(nullValueErrorMsg, result);
        }

        [TestMethod]
        public void CheckForInvalidValues()
        {
            // arrange
            string area = "AMPAMP";
            string type = "PENPEN";
            string code = "";

            // act
            string result = p.RetrieveUser(area, type, code);

            // assert
            Assert.AreEqual(invalidErrorMsg, result);
        }

        [TestMethod]
        public void CheckForNotFoundValues()
        {
            // arrange
            string area = "AMP";
            string type = "DOC";
            string code = "";

            // act
            string result = p.RetrieveUser(area, type, code);

            // assert
            Assert.AreEqual(notFoundErrorMsg, result);
        }

        [TestMethod]
        public void CheckIfUserRetrievedWithValidValues()
        {
            // arrange
            string area = "AMP";
            string type = "DOC";
            string code = "P17";

            // act
            string result = p.RetrieveUser(area, type, code);

            // assert
            Assert.IsTrue(true, result);
        }
    }
}
