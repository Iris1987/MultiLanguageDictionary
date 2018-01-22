﻿using System;
using System.Collections.Generic;

namespace BaseEntities.Models
{
    public partial class PartOfSpeech
    {
        public PartOfSpeech()
        {
            TranslationEngEst = new HashSet<TranslationEngEst>();
            TranslationEngRus = new HashSet<TranslationEngRus>();
            TranslationRusEst = new HashSet<TranslationRusEst>();
        }

        public int IdPart { get; set; }
        public string Partname { get; set; }

        public ICollection<TranslationEngEst> TranslationEngEst { get; set; }
        public ICollection<TranslationEngRus> TranslationEngRus { get; set; }
        public ICollection<TranslationRusEst> TranslationRusEst { get; set; }
    }
}
