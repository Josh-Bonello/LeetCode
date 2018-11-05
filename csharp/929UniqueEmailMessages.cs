public class Solution {
    public int NumUniqueEmails(string[] emails) {
        //Initialize array of unique emails to count
        HashSet<string> uniqueEmails = new HashSet<string>();
        //Loop through each email and apply techniques
        foreach (string address in emails) {
            string uniqueAddress = address;
            string[] splitAddress = uniqueAddress.Split('@'); 
            string localName = splitAddress[0];
            string domainName = splitAddress[1];
            //Check and shorten
            if(localName.Contains(".") == true){
                Console.WriteLine("Contains .");
                uniqueAddress = uniqueAddress.Replace(".", "");
                localName = localName.Replace(".","");
                Console.WriteLine(localName);
            }
            //Check and ignore
            if(localName.Contains("+") == true){
                Console.WriteLine("Contains +");
                int startIndex = localName.IndexOf('+');
                localName = localName.Remove(startIndex);
                Console.WriteLine(localName);
            }
            //insert into unique email array if doesn't already exist
            uniqueEmails.Add(localName + "@" + domainName);
            

        }
        return uniqueEmails.Count;
    }
}
