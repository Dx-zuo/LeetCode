/**
    Given two strings s and t which consist of only lowercase letters.

    String t is generated by random shuffling string s and then add one more letter at a random position.

    Find the letter that was added in t.

    Example:

        Input:
        s = "abcd"
        t = "abcde"

        Output:
        e

        Explanation:
        'e' is the letter that was added.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithm;

namespace Solution {

    public class Solution {
        public char FindTheDifference(string s, string t) {
            var d = new Dictionary<char, int>();
            foreach (var c in s) {
                if (d.ContainsKey(c)) d[c]++;
                else d[c] = 1;
            }
            foreach (var c in t) {
                if (d.ContainsKey(c)) d[c]++;
                else d[c] = 1;
            }
            foreach (var i in d.Keys) {
                if (d[i] % 2 != 0) {
                    return i;
                }
            }
            return ' ';
        }
    }

    class Program {
        static void Main(string[] args) {
            Solution s = new Solution();
            var res = s.FindTheDifference("abcdef", "abcde");
            Console.WriteLine(res);
        }
    }
}