using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CarRentalManagement.Client.IServices;
using Microsoft.Extensions.Logging;

namespace CarRentalManagement.Client.Services
{
    /// <summary>
    /// Not compelete yet.from theory
    /// </summary>
    public class HttpService : IHttpService
    {
        private readonly ILogger logger;
        private readonly HttpClient client;
        private string baseAddress;

        public HttpService (ILogger logger , HttpClient client , string baseAddress)
        {
            this.logger = logger;
            this.client = client;
            this.baseAddress = baseAddress;
        }

        void IHttpService.SetBaseAddress (string baseAddress)
        {
            this.baseAddress = baseAddress;
        }

        public async Task<bool> Delete (int id)
        {
            try
            {
                var result = await client.DeleteAsync ($"{baseAddress}/{id}");

                logger.LogDebug ($"Delete {baseAddress}/{id}" , result);

                return result.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                logger.LogError (ex.Message , ex);
                throw;
            }
        }

        public async Task<TResult> Get<TResult> (int entityId)
        {
            try
            {
                var result = await client.GetFromJsonAsync<TResult> ($"{baseAddress}/{entityId}");

                return result;
            }
            catch (Exception ex)
            {
                logger.LogError (ex.Message , ex);
                throw;
            }
        }

        public async Task<IEnumerable<TResult>> GetAll<TResult> ( )
        {
            try
            {
                var result = await client.GetFromJsonAsync<IEnumerable<TResult>> ($"{baseAddress}");

                return result;
            }
            catch (Exception ex)
            {
                logger.LogError (ex.Message , ex);
                throw;
            }
        }

        public async Task<TResult> Post<T, TResult> (T entity)
        {
            HttpResponseMessage result;
            try
            {
                result = await client.PostAsJsonAsync (baseAddress , entity);

                return await result.Content.ReadFromJsonAsync<TResult> ();
            }
            catch (Exception ex)
            {
                logger.LogError (ex.Message , ex);
                throw;
            }

            
        }

        public async Task<bool> Put<T> (T entity)
        {
            HttpResponseMessage result;
            try
            {
                result = await client.PutAsJsonAsync (baseAddress , entity);

                return result.IsSuccessStatusCode ? true : false;
            }
            catch (Exception ex)
            {
                logger.LogError (ex.Message , ex);
                throw;
            }
        }
    }
}
