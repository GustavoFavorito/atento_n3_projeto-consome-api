using atento_n3_projeto_consome_api.Pages.Api.Models;
using atento_n3_projeto_consome_api.Pages.Api.Service;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace atento_n3_projeto_consome_api.Pages.Api
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _apiService;

        public IndexModel(ApiService apiService)
        {
            _apiService = apiService;
            Pessoas = new List<Pessoa>();
        }

        public List<Pessoa> Pessoas { get; set; }

        public async Task OnGetAsync()
        {
            Pessoas = await _apiService.GetData<List<Pessoa>>("http://localhost:5097/api/pessoa");
        }
    }
}
