using System;
using System.Net;
using CarRentalManagement.Client.Interfaces;
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
            Console.WriteLine (sender);
            Console.WriteLine (e);

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
                throw new Exception(nextUrl);
                //navigationManager.NavigateTo ($"/{nextUrl}");
            }
        }
    }
}
