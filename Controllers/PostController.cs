using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace alhnn_api.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {

        // GET api/posts
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string path = Directory.GetCurrentDirectory();//

            string fullPath = path + "\\md";
            string [] fileEntries = Directory.GetFiles(fullPath);

            List<string> responses = new List<string>();

            foreach(string fileName in fileEntries){
                responses.Add(System.IO.File.ReadAllText(fileName));
            }
            //string text = System.IO.File.ReadAllText(fullPath);


            return  responses;//new string[] { fullPath, text};
        }

        // GET api/posts/5
        [HttpGet("{post}")]
        public string Get(string post)
        {
            string path = Directory.GetCurrentDirectory();//

            string fullPath = path + "\\md";
            string [] fileEntries = Directory.GetFiles(fullPath);
            string temp = "";
            int pos = 0;
            string returnStr = "";

            foreach(string fileName in fileEntries){
                temp = fileName.Remove(fileName.Length-3);
                pos = temp.LastIndexOf("\\") + 1;
                temp = temp.Substring(pos, temp.Length - pos);
                if(temp == post)
                {
                    returnStr = System.IO.File.ReadAllText(fileName);
                }
            }

            return returnStr;
        }

        // POST api/posts
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
