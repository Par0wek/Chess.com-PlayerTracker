using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApi.Models
{
    public class ApiResponse
    {
        public string username { get; set; }
        public string avatar { get; set; }
        public string league { get; set; }
        public string followers { get; set; }
        public long joined { get; set; }
        public Bullet chess_bullet { get; set; }
        public Blitz chess_blitz { get; set; }
        public Rapid chess_rapid { get; set; }
        public Puzzle tactics { get; set; }
    }
    public class Bullet
    {
        public Last Last { get; set; }
        public Record Record { get; set; }
    }
    public class Blitz
    {
        public Last Last { get; set; }
        public Record Record { get; set; }
    }
    public class Rapid
    {
        public Last Last { get; set; }
        public Record Record { get; set; }
    }
    public class Puzzle
    {
        public Highest Highest { get; set; }
    }
    public class Last
    {
        public int rating { get; set; }
    }
    public class Record
    {
        public int win { get; set; }
        public int loss { get; set; }
        public int draw { get; set; }
    }
    public class Highest
    {
        public int rating { get; set; }
    }
}
