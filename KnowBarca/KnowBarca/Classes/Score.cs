using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KnowBarca.Classes
{
    public class Score
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        public string Nickname
        {
            get;
            set;
        }
        
        public int ScoreVal
        {
            get;
            set;
        }
        
        public Score()
        {

        }
    }
}
