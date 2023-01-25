namespace API_Call_ServerSide.Models
{
    public class CommentsData
    {
        public int postId { get; set; }
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }


        List<CommentsData> data = new List<CommentsData>();


        public List<CommentsData> GetCommentsData()
        {
            string url = "https://jsonplaceholder.typicode.com/comments";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear(); //different browser has default data format eg. IE 6 uses XML, winforms uses binary
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var callService = client.GetAsync(url); //this will make a call

            var response = callService.Result;

            if (response.IsSuccessStatusCode)
            {
                var readData = response.Content.ReadAsAsync<List<CommentsData>>();
                readData.Wait();
                data = readData.Result;
                return data;
            }
            else
            {
                throw new Exception("Something went wrong" + response.StatusCode);
            }

        }
    }
}
