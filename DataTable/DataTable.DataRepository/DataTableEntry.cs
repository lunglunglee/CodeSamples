// // Breeze Project
// // Created by Bartosz Rachwal. 
// // Copyright (c) 2016 Bartosz Rachwal. The National Institute of Advanced Industrial Science and Technology, Japan. All rights reserved.

namespace DataTable.DataRepository
{
    public class DataTableEntry
    {
        public DataTableEntry()
        {
        }

        public DataTableEntry(string renderingEngine, string browser, string platforms, string engineVersion,
            string cssGrade)
        {
            RenderingEngine = renderingEngine;
            Browser = browser;
            Platforms = platforms;
            EngineVersion = engineVersion;
            CssGrade = cssGrade;
        }

        public string RenderingEngine { get; set; }
        public string Browser { get; set; }
        public string Platforms { get; set; }
        public string EngineVersion { get; set; }
        public string CssGrade { get; set; }
    }
}