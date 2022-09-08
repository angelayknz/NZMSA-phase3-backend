using System;

namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var resposne = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (resposne != null && resposne.Data != null)
                Categories = resposne.Data;
        }
    }
}

