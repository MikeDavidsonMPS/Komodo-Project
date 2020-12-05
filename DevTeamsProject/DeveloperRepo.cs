using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void AddContentToList(Developer content)
        {
            _developerDirectory.Add(content);
        }

        //Developer Read
        public List<Developer> FindDevelopers()
        {
            return _developerDirectory;
        }

        //Developer Update
        public bool UpdateContent(string originalDeveloperName, Developer newContent)
        {
            Developer existingContent = GetContentByDeveloperName(originalDeveloperName);
            if(existingContent != null)
            {
                existingContent.DeveloperName = newContent.DeveloperName;
                existingContent.IdNumber = newContent.IdNumber;
                existingContent.Manager = newContent.Manager;
                existingContent.SoftwareLicense = newContent.SoftwareLicense; 

                return true; 
            }
            else
            {
                return false;
            }
        }
        //Developer Delete
        public bool RemoveContentFromList(string developerName)
        {
            Developer content = GetContentByDeveloperName(developerName);

            if(content == null)
            {
                return false;
            }

            int intialCount = _developerDirectory.Count;
            _developerDirectory.Remove(content);

            if(intialCount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Developer GetContentByDeveloperName(string developerName)
        {
            foreach(Developer content in _developerDirectory)
            {
                if(content.DeveloperName.ToLower() == developerName.ToLower())
                {
                    return content;
                }
            }

            return null;
        }

      
    }
}
