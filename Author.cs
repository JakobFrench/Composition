namespace Composition
{
    public class Author
    {
        private string name {get;set;}
        private char gender {get;set;}
        private string email;

        public Author(string name, char gender, string email)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }
        public override string ToString()
        {
            return "name = " + name + ",email = " + email + "gender = " + gender;
        }
    }
}