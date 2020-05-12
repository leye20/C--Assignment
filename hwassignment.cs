using System;

namespace hwassignment
{
    abstract class Painting
    {
        private string name;
        private string artist;
        private string medium;
        private string year;

        public virtual void paintingStyle()
        {
            Console.WriteLine( "Are styles essential?" );
        }
        
        public string MyName
        {
            get { return name; }
            set { name = value; }
        }
        public string MyArtist
        {
            get { return artist; }
            set { artist = value; }
        }
        public string MyMedium
        {
            get { return medium; }
            set { medium = value; }
        }
        public string MyYear
        {
            get { return year; }
            set { year = value; }
        }
    }
    
    class Master : Painting
        {
        public string name = "Monalisa";
        public string artist = "Leonardo da Vinci";
        public string medium = "Oil Paint";
        public string year = "1503";

        public override void paintingStyle()
        {
            Console.WriteLine( "From the grand Master, comes;" );
        }
        public void newStyles()
        {
            Console.WriteLine( "Trust you understand better now!" );
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Master newMaster = new Master();
            newMaster.paintingStyle();

            Console.WriteLine( "Name: " + newMaster.name );
            Console.WriteLine( "Artist: " + newMaster.artist );
            Console.WriteLine( "Medium: " + newMaster.medium );
            Console.WriteLine( "Year: " + newMaster.year );

            newMaster.newStyles();
            Console.WriteLine( newMaster.artist + " is a Master indeed!" );

        }
    }
}