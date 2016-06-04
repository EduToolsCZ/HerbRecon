using System;
using System.Collections.Generic;
using HerbLib;

namespace HerbRecon
{
    /// <summary>
    ///     Represents one testing session, contains data about the user's success rate and mistakes
    /// </summary>
    public class TestingSession
    {
        public delegate void TestingEndedDelegate(TestingSession sender);

        /// <summary>
        ///     RNG used to pull herbs from the list
        /// </summary>
        private readonly Random _random = new Random();

        public TestingSession(List<TestingObject> testingObjects, bool testSpecies = true, bool testFamilies = true)
        {
            TestingEnded += TestingSession_TestingEnded;
            TestingObjects = testingObjects;
            TestSpecies = testSpecies;
            TestFamilies = testFamilies;
        }

        private List<TestingObject> TestingObjects { get; }

        /// <summary>
        ///     Indicates whether the user wants to learn species of the herb
        /// </summary>
        public bool TestSpecies { get; }

        /// <summary>
        ///     Indicates whether the user wants to learn families of the herb
        /// </summary>
        public bool TestFamilies { get; }

        /// <summary>
        ///     Indicates how many successful tries are required to remove the actual Herb from the tested list
        /// </summary>
        public int SuccessInRowRequired { get; set; }

        /// <summary>
        ///     Indicates whether <see cref="SuccessInRowRequired"/> have to be in a row or in total
        /// </summary>
        public bool SccuessesHaveToBeInRow { get; set; }

        /// <summary>
        ///     Indicates whether the testing has already started
        /// </summary>
        private bool HasTestingStarted { get; set; }

        /// <summary>
        ///     Indicates whether the testing has already ended
        /// </summary>
        private bool HasTestingEnded { get; set; }

        /// <summary>
        ///     Time when the first testing object was required
        /// </summary>
        public DateTime TimeStarted { get; private set; }

        /// <summary>
        ///     Time when the testing ended, i.e. the last herb was required
        /// </summary>
        public DateTime TimeEnded { get; private set; }

        /// <summary>
        ///     Tells how long the testing took until now
        /// </summary>
        public TimeSpan TestingLength
        {
            get
            {
                if (!HasTestingStarted) throw new InvalidOperationException("The testing has not started yet");
                if (HasTestingEnded) return TimeEnded - TimeStarted;
                return DateTime.Now - TimeStarted;
            }
        }

        /// <summary>
        ///     Triggers when the testing ends
        /// </summary>
        public event TestingEndedDelegate TestingEnded;

        /// <summary>
        ///     Occurs when the testng ends
        /// </summary>
        /// <param name="sender"></param>
        private void TestingSession_TestingEnded(TestingSession sender)
        {
            HasTestingEnded = true;
            TimeEnded = DateTime.Now;
        }

        /// <summary>
        ///     Starts the testing session and returns the first herb
        /// </summary>
        /// <returns></returns>
        public Herb Start()
        {
            if (HasTestingEnded) throw new InvalidOperationException("The testing has already ended");
            HasTestingStarted = true;
            TimeStarted = DateTime.Now;
            return Next();
        }

        /// <summary>
        ///     Finds the next herb for you, returns null if there is nothing more
        /// </summary>
        /// <returns></returns>
        public Herb Next()
        {
            if (!HasTestingStarted)
                throw new InvalidOperationException("The testing has to start before getting the next herb");
            if (HasTestingEnded) throw new InvalidOperationException("The testing has already ended");
            if (TestingObjects.Count <= 0)
            {
                TestingEnded?.Invoke(this);
                return null;
            }
            //todo: make a better testing object chooser
            var selectedIndex = _random.Next(TestingObjects.Count);
            var selectedObject = TestingObjects[selectedIndex].Object;
            TestingObjects.RemoveAt(selectedIndex);
            return selectedObject;
        }

        /// <summary>
        ///     Call if the actual herb has been successfuly guessed
        /// </summary>
        public void Guessed()
        {
            
        }


        /// <summary>
        ///     Call if the acutal herb has been wrongly guessed
        /// </summary>
        public void Failed()
        {
            
        }
    }
}