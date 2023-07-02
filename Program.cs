using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJM_methodology_picker
{
    internal static class Program
    {
        // List of object that holds the data locally
        private static List<ProjectModel> projectsList = new List<ProjectModel>();
        private static Methodology projData;

        // helper function to populate the array lists    
        public static void populateArraylist<T>(IMongoCollection<T> collection, List<T> list)
        {
            foreach (T obj in collection.AsQueryable().ToList())
            {
                list.Add(obj);
            }
        }

        // return static member variable 
        public static List<ProjectModel> getProjectList()
        {
            return projectsList;
        }

        // clear for static method
        public static void clearList<T>(List<T> list)
        {
            list.Clear();
        }

        // return local temp project data
        public static Methodology getProjecData() 
        {
            return projData;
        }

        // set local temp project data
        public static void setProjectData(Methodology proj)
        {
            projData = proj;
        }

        // delete object data
        public static void deleteProjectObject()
        { 
            projData = null;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
