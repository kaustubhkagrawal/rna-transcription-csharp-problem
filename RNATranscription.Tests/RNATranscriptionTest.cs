using System;
using Xunit;
using RNATranscriptionModule;

namespace RNATranscription.Tests
{
    public class RNATranscriptionTest
    {
        [Fact]
        public void Rna_complement_of_cytosine_is_guanine()
        {
            Assert.Equal("G", RnaTranscription.ToRna("C"));
        }

        [Fact]
        public void Rna_complement_of_guanine_is_cytosine()
        {
            Assert.Equal("C", RnaTranscription.ToRna("G"));
        }

        [Fact]
        public void Rna_complement_of_thymine_is_adenine()
        {
            Assert.Equal("A", RnaTranscription.ToRna("T"));
        }

        [Fact]
        public void Rna_complement_of_adenine_is_uracil()
        {
            Assert.Equal("U", RnaTranscription.ToRna("A"));
        }

        [Fact]
        public void Rna_complement()
        {
            Assert.Equal("UGCACCAGAAUU", RnaTranscription.ToRna("ACGTGGTCTTAA"));
        }


        
    }
}
