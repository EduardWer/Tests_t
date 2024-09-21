using System;
using NUnit.Framework;
using PasswordCheck;

namespace PasswordChecker.Tests
{
    [TestFixture]
    public class ParoliCheckersTests
    {
        [Test]
        public void Checkpassward_AJLHK_1exepted()
        {
            string passwaord = "AJLHK";
            int score = 1;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_AAAass_2exepted()
        {
            string passwaord = "AAAass";
            int score = 2;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_gdAA12_3exepted()
        {
            string passwaord = "gdAA12";
            int score = 3;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        [Test]
        public void Checkpassward_AAa32Spech_4exepted()
        {
            string passwaord = "Aa32*#";
            int score = 4;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_1010SpechASDDAfsdfsf101010_5exepted() {
            string passwaord = "1010^^%ASDDAfsdfsf101010";
            int score = 5;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_null_0exepted()
        {
            string passwaord = "";
            int score = 0;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }



        


    }
}