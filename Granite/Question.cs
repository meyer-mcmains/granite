﻿namespace Granite
{
    internal class Question
    {
        private string text { get; set; }
        private string answer { get; set; }
        private string creator { get; set; }

        public Question()
        {
            this.text = "";
            this.answer = "";
            this.creator = "";
        }

        public Question(string text, string answer, string creator)
        {
            this.text = text;
            this.answer = answer;
            this.creator = creator;
        }
    }
}