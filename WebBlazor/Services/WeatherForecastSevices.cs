using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static Web_Blazor.Pages.FetchData;

namespace BlazorServices
{
    public class WeatherForecastServices : IWeatherForecastServices 
    {
        //Constructor para Nuneable
        public WeatherForecastServices(HttpClient http)
        {
            Http = http;
        }

        //Metodo para HTTP
        public HttpClient Http {get; set;}

         //Metodo Ansincronico para Inyección de Dependecias
        public async Task<WeatherForecast[]> GetWeatherForecasts()
        {
            return await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");        
        }
    }
         //Interfaz para invocar dependecia
    public interface IWeatherForecastServices
    {
        Task<WeatherForecast[]> GetWeatherForecasts();    
    }
}