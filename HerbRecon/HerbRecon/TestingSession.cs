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
        /// <summary>
        ///     RNG used to pull herbs from the list
        /// </summary>
        private readonly Random _random = new Random();

        public TestingSession(List<TestingObject> testingObjects, bool testSpecies = true, bool testFamilies = false)
        {
            TestingObjects = testingObjects;
            TestSpecies = testSpecies;
            TestFamilies = testFamilies;
        }

        /// <summary>
        ///     The collection of testing objects the user is being tested from
        /// </summary>
        public List<TestingObject> TestingObjects { get; }

        /// <summary>
        ///     Indicates if the testing ended
        /// </summary>
        private bool _ended;

        /// <summary>
        ///     Indicates when the testing started
        /// </summary>
        public DateTime StartedDateTime { get; private set; }

        /// <summary>
        ///     Indicates when the testing ended
        /// </summary>
        public DateTime EndedDateTime { get; private set; }

        /// <summary>
        ///     Indicates how long the testing took until now
        /// </summary>
        public TimeSpan TestingTime => EndedDateTime - StartedDateTime;

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
        public int SuccessesInRowRequired { get; set; } = 3;

        /// <summary>
        ///     Indicates whether <see cref="SuccessesInRowRequired"/> have to be in a row or in total
        /// </summary>
        public bool SuccessesHaveToBeInRow { get; set; } = true;

        private TestingObject LastTestingObject { get; set; } = null;

        public int TotalSuccesses { get; private set; }
        public int TotalFails { get; private set; }
        /// <summary>
        ///     The current testing object in the testing session
        /// </summary>
        public TestingObject CurrentTestingObject { get; private set; } = null;

        public bool GuessCurrent(string tip, string familyTip = "")
        {
            var guessed = CurrentTestingObject.Guess(this, tip, familyTip);

            if (guessed) TotalSuccesses++;
            else TotalFails++;

            if (!guessed) return false;
            if ((SuccessesHaveToBeInRow && CurrentTestingObject.SuccessfulGuessesInRow >= SuccessesInRowRequired) ||
                (!SuccessesHaveToBeInRow && CurrentTestingObject.TimesGuessed >= SuccessesInRowRequired)) {
                TestingObjects.Remove(CurrentTestingObject);
            }
            return true;
        }

        /// <summary>
        ///     Returns the next testing object
        /// </summary>
        /// <returns></returns>
        public TestingObject Next()
        {
            if (_ended) return null;
            if (TestingObjects == null || TestingObjects.Count <= 0) {
                CurrentTestingObject = null;
                _ended = true;
                EndedDateTime = DateTime.Now;
                return CurrentTestingObject;
            }
            do {
                CurrentTestingObject = TestingObjects[_random.Next(TestingObjects.Count)];
                // break out if this is the first testing object provided
                if (LastTestingObject == null) {
                    StartedDateTime = DateTime.Now;
                    break;
                }
            } while (CurrentTestingObject == LastTestingObject);

            LastTestingObject = CurrentTestingObject;
            return CurrentTestingObject;
        }
    }
}