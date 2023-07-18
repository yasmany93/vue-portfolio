using System.Linq.Expressions;
using System.Text.Json;
using System.Text;
using DataAccessLayer.Contracts;
using Entities;

namespace DataAccessLayer
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        HttpClient _httpClient;
        JsonSerializerOptions _options;
        ConnectingTo _connectingTo;
        private readonly string ACCESS_TOKEN = ApiConnectionInfo.ACCESS_TOKEN;
        private readonly string URL = ApiConnectionInfo.URL;


        //Buscar en la API para implementar bien todas las funciones
        public BaseRepository(HttpClient httpClient, ConnectingTo connectingTo)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions();
            _connectingTo = connectingTo;
        }

        public async void CreateAsync(T entity)
        {
            using (_httpClient = new HttpClient())
            {
                _options.PropertyNamingPolicy = new ToLowerNamingPolicy();
                var json = JsonSerializer.Serialize<T>(entity, _options).ToString();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                await _httpClient.PostAsync($"{URL}/{_connectingTo}?access-token={ACCESS_TOKEN}", content);
            }
        }

        public async void DeleteAsync(T entity)
        {
            using (_httpClient = new HttpClient())
            {
                await _httpClient.DeleteAsync($"{URL}/{_connectingTo}/{entity.Id}?access-token={ACCESS_TOKEN}");
            }
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            IEnumerable<T>? collection;
            using (_httpClient = new HttpClient())
            {
                using (var response = await _httpClient.GetAsync($"{URL}/{_connectingTo}?access-token={ACCESS_TOKEN}"))
                {
                    _options.PropertyNameCaseInsensitive = true;
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    collection = apiResponse.Length > 0
                        ? JsonSerializer.Deserialize<IEnumerable<T>>(apiResponse, _options)
                        : new List<T>();
                }
            }

            return collection;
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            IEnumerable<T>? collection;
            using (_httpClient = new HttpClient())
            {
                using (var response = await _httpClient.GetAsync($"{URL}/{_connectingTo}?access-token={ACCESS_TOKEN}"))
                {
                    _options.PropertyNameCaseInsensitive = true;
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    collection = apiResponse.Length > 0
                        ? JsonSerializer.Deserialize<IEnumerable<T>>(apiResponse, _options).Where(expression.Compile())
                        : new List<T>();
                }
            }

            return collection;
        }

        public async void UpdateAsync(T entity)
        {
            using (_httpClient = new HttpClient())
            {
                using (var response = await _httpClient.GetAsync($"{URL}/{_connectingTo}/{entity.Id}?access-token={ACCESS_TOKEN}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse.Length > 0)
                    {
                        _options.PropertyNamingPolicy = new ToLowerNamingPolicy();
                        var json = JsonSerializer.Serialize<T>(entity, _options).ToString();
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        await _httpClient.PutAsync($"{URL}/{_connectingTo}/{entity.Id}?access-token={ACCESS_TOKEN}", content);
                    }
                }
            }
        }

        public async Task<T> FindByIdAsync(int id)
        {
            T entity;
            using (_httpClient = new HttpClient())
            {
                using (var response = await _httpClient.GetAsync($"{URL}/{_connectingTo}/{id}?access-token={ACCESS_TOKEN}"))
                {
                    _options.PropertyNameCaseInsensitive = true;
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    entity = apiResponse.Length > 0 ? JsonSerializer.Deserialize<T>(apiResponse, _options): null;
                }
            }

            return entity;
        }


    }
}