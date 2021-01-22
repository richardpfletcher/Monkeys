namespace MvcRichard.Models
{
    public class DocumentModel
    {
        public string FullName;
        public string ShortName;
        public string PathName;
        public string HttpPathName;

        public DocumentModel(string fullName, string shortName, string pathName, string httpPathName)
        {
            FullName = fullName;
            ShortName = shortName;
            PathName = pathName;
            HttpPathName = httpPathName;
        }
    }
}