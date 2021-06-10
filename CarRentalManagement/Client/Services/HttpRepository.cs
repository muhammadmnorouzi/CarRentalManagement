using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Interfaces;

namespace CarRentalManagement.Client.Services
{
    public class HttpRepository<T> : IDisposable, IHttpRepository<T> where T : class
    {
        private readonly HttpClient httpClient;
        private readonly IHttpInterceptorService httpInterceptor;

        public HttpRepository (HttpClient httpClient , IHttpInterceptorService httpInterceptor)
        {
            this.httpClient = httpClient;
            this.httpInterceptor = httpInterceptor;
        }

        public void Dispose ( )
        {
            httpInterceptor.DisposeEvent ();
        }

        public async Task Create (string url , T obj)
        {
            httpInterceptor.MonitorEvent ();
            await httpClient.PostAsJsonAsync (url , obj);
        }

        public async Task Delete (string url , int id)
        {
            httpInterceptor.MonitorEvent ();
            await httpClient.DeleteAsync ($"{url}/{id}");
        }

        public async Task<T> Get (string url , int id)
        {
            httpInterceptor.MonitorEvent ();
            return await httpClient.GetFromJsonAsync<T> ($"{url}/{id}");
        }

        public async Task<IList<T>> GetAll (string url)
        {
            httpInterceptor.MonitorEvent ();
            return await httpClient.GetFromJsonAsync<IList<T>> (url);
        }

        public async Task Update (string url , T obj , int id)
        {
            httpInterceptor.MonitorEvent ();
            await httpClient.PutAsJsonAsync($"{url}/{id}", obj);
        }
    }
}
