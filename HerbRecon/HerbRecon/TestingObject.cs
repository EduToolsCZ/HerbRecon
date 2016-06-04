using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerbLib;

namespace HerbRecon
{
    public class TestingObject
    {
        public Herb Object { get; set; }

        /// <summary>
        ///     The number of times this testing object was guessed
        /// </summary>
        public int TimesGuessed { get; private set; } = 0;

        /// <summary>
        ///     The number of times the user failed to guess this testing object
        /// </summary>
        public int TimesFailed { get; private set; } = 0;

        /// <summary>
        ///     The number of times the herb was guessed in a row
        /// </summary>
        public int SuccessfulGuessesInRow { get; private set; } = 0;

        /// <summary>
        ///     Checks if the user guessed the herb, returns true if so
        /// </summary>
        /// <param name="ts">The <see cref="TestingSession"/> in which the current herb is being guessed</param>
        /// <param name="tip">The user's guess</param>
        /// <param name="familyTip">User's family guess</param>
        /// <returns></returns>
        public bool Guess(TestingSession ts, string tip, string familyTip = "")
        {
            var tipNormalized = tip.ToLower().RemoveDiacritics().Trim();
            var targetNormalized = ts.TestSpecies ? Object.ToString().ToLower().RemoveDiacritics() : Object.Genus.ToLower().RemoveDiacritics();
            var distance = tipNormalized.LevenshteinDistance(targetNormalized);
            
            if (ts.TestFamilies)
            {
                var familyTipNormalized = familyTip.ToLower().RemoveDiacritics().Trim();
                var familyNormalized = Object.Family.ToLower().RemoveDiacritics();
                var familyDistance = familyTipNormalized.LevenshteinDistance(familyNormalized);
                if (familyDistance > 2)
                {
                    TimesFailed++;
                    SuccessfulGuessesInRow = 0;
                    return false;
                }
            }
            if (distance <= 2)
            {
                TimesGuessed++;
                SuccessfulGuessesInRow++;
                return true;
            }
            TimesFailed++;
            SuccessfulGuessesInRow = 0;
            return false;
        }
    }
}
