﻿using System;

namespace MonitorizareVot.Domain.Ong.Models
{
    public partial class Answer
    {
        public int IdObserver { get; set; }
        public int IdOptionToQuestion { get; set; }
        public int IdPollingStation { get; set; }
        public DateTime LastModified { get; set; }
        public string Value { get; set; }

        public string CountyCode { get; set; }

        public int PollingStationNumber { get; set; }

        public virtual Observator Observer { get; set; }
        public virtual RaspunsDisponibil OptionAnswered { get; set; }
        public virtual SectieDeVotare PollingStation { get; set; }
    }
}
