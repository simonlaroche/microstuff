using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroStuff.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MicroStuff.Data
{
    public interface ISessions
    {
        Task<IList<Session>> Get();
    }
    
    public class Sessions : ISessions
    {
        private HttpClient _client;
        public Sessions()
        {
            _client = new HttpClient(); 
            
        }
        
        public async Task<IList<Session>> Get()
        {
            var json = await _client.GetStringAsync("http://localhost:5001/sessions");
            
            return JsonConvert.DeserializeObject<List<Session>>(json);
        }
    }
}
