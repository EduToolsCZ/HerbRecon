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
            // the user's tip
            var tipNormalized = tip.ToLower().RemoveDiacritics().Trim().RemoveChar(' ');
            // the target string that the user should guess
            var targetNormalized = Object.ToString().ToLower().RemoveDiacritics().RemoveChar(' ');
            // the target genus - if the user tests only from genus
            var targetGenusNormalized = Object.Genus.ToLower().RemoveDiacritics();

            // distance of the user's tip from the herb full name
            var distance = tipNormalized.LevenshteinDistance(targetNormalized);
            // distance of the user's tip from the herb genus
            var genusDistance = tipNormalized.LevenshteinDistance(targetGenusNormalized);

            if (ts.TestFamilies) {
                var familyTipNormalized = familyTip.ToLower().RemoveDiacritics().Trim();
                var familyNormalized = Object.Family.ToLower().RemoveDiacritics();
                var familyDistance = familyTipNormalized.LevenshteinDistance(familyNormalized);
                if (familyDistance > 2) {
                    TimesFailed++;
                    SuccessfulGuessesInRow = 0;
                    return false;
                }
            }
            /* (there needs to be species as well as genus) or (species is optional, genus is required though) */
            if ((ts.TestSpecies && distance <= 2) || (!ts.TestSpecies && (distance <= 2 || genusDistance <= 2))) {
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
