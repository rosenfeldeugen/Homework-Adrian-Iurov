﻿namespace EmailManager
{
    //CR: Concept of a DTO not required here.
    public class Message
    {
        public string To { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
