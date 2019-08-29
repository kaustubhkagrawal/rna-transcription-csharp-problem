using System;
using System.Text;
/*using RNATranscription*/
/*using RNATranscription.Tests;*/
using System.Collections.Generic;



namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {

        static readonly IReadOnlyDictionary<char, char> TranslateTable = new Dictionary<char, char>
        {
            ['G'] = 'C',
            ['C'] = 'G',
            ['T'] = 'A',
            ['A'] = 'U',
        };

        public static string ToRna(string nucleotide)
        {




            /*StringBuilder sb = new StringBuilder(nucleotide);
            for (int i = 0; i < sb.Length; i++)
            {
                switch (sb[i])
                {
                    case 'A':
                        sb[i] = 'U';
                        break;
                    case 'T':
                        sb[i] = 'A';
                        break;
                    case 'G':
                        sb[i] = 'C';
                        break;
                    case 'C':
                        sb[i] = 'G';
                        break;
                    default:
                        break;
                }
            }
            return sb.ToString();*/

            StringBuilder sb = new StringBuilder(nucleotide);
            for (int i = 0; i < sb.Length; i++)
            {
                sb[i] = TranslateTable[sb[i]];
            }
            return sb.ToString();
            //Console.WriteLine(nucleotide);





        }
        public static void Main(string[] args)
        {
/*
            test.Rna_complement_of_cytosine_is_guanine();
            test.Rna_complement_of_guanine_is_cytosine();
            test.Rna_complement_of_thymine_is_adenine();
            test.Rna_complement_of_adenine_is_uracil();
            test.Rna_complement();*/
        }
    }
}
