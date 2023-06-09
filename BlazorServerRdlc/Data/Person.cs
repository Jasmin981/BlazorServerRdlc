﻿namespace BlazorServerRdlc.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }

        public ICollection<Attachment> Attachments { get; set; }
    }
}
