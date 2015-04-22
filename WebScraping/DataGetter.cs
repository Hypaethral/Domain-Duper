using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace WebScraping
{
    static class DataGetter {
        const string FAVORITE_PATH_REST = "favorites-rest.txt";
        const string FAVORITE_PATH_SCRAPE = "favorites-scrape.txt";
        const char DELIMETER = '|';

        public static Dictionary<string, string> retrieveFavorites( string favType ) {
            Dictionary<string,string> dict = new Dictionary<string,string>();
            string[] lines;
            switch(favType.ToLower() ) {
                case("rest"):
                    lines = System.IO.File.ReadAllLines(FAVORITE_PATH_REST);
                    break;
                case("scrape"):
                    lines = System.IO.File.ReadAllLines(FAVORITE_PATH_SCRAPE);
                    break;
                default:
                    lines = new [] {""};
                    break;
            }
            foreach (string line in lines) {
                //name, url
                string[] guys = line.Split(DELIMETER);
                dict.Add(guys[0], guys[1]);
            }
            return dict;
        }
    }
}
