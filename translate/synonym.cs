using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace translate
{
    class synonym
    {
        public async void getSynonym(string word)
        {
            string url = "http://words.bighugelabs.com/api/2/ebdf3ab5e3566e78cc1b0171d1c68653/";
            url += word + "/json";
            using (var client = new HttpClient())
            {
                using (var response =await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                    }
                }
            }

        }
    }
}
