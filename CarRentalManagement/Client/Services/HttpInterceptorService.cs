using System;
using System.Net;
using System.Threading.Tasks;
using CarRentalManagement.Client.IServices;
using Microsoft.AspNetCore.Components;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService : IHttpInterceptorService
    {
        private readonly NavigationManager navigationManager;
        private readonly HttpClientInterceptor interceptor;

        public HttpInterceptorService (NavigationManager navigationManager , HttpClientInterceptor interceptor)
        {
            this.navigationManager = navigationManager;
            this.interceptor = interceptor;
        }

        public void MonitorEvent ( ) => interceptor.AfterSend += InterceptResponse;
        public void DisposeEvent ( ) => interceptor.AfterSend -= InterceptResponse;

        private void InterceptResponse (object sender , HttpClientInterceptorEventArgs e)
        {
            if (!e.Response.IsSuccessStatusCode)
            {
                string nextUrl = e.Response.StatusCode switch
                {
                    HttpStatusCode.BadRequest => "bad-request",
                    HttpStatusCode.NotFound => "not-found",
                    HttpStatusCode.Unauthorized => "Unauthorized",
                    HttpStatusCode.Forbidden => "Forbidden",
                    HttpStatusCode.InternalServerError => "server-error",
                    _ => "unknown-error"
                };

                navigationManager.NavigateTo ($"/{nextUrl}");
            }
        }
    }
}
