﻿namespace ReportGeneration_Kylosov.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdGroup { get; set; }
        public Discipline(int Id, string Name, int IdGroup)
        {
            this.Id = Id;
            this.Name = Name;
            this.IdGroup = IdGroup;
        }
    }
}
