using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;


namespace WebApplication2.Controllers
{
    public class ProjectMetaData
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public bool IsActive { get; set; }

        public string ProjectType { get; set; }

    }
    public class CreateFileController : ApiController
    {
        // GET: CreateFile
        // POST api/values
        public string Post(ProjectMetaData value)
        {
            string fileName = @"C:\Users\hp\Desktop\ccc\MetaData.txt";

            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            // Create a new file     
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("Title: {0}",value.Title);
                sw.WriteLine("Description: {0}", value.Description);
                sw.WriteLine("Active: {0}", value.IsActive);
                sw.WriteLine("Project Type: {0}", value.ProjectType);

            }


            return "File was created successfully.";
        }
    }
}