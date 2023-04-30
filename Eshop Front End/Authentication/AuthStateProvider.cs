using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Json;
using System.Net.Http;
using Eshop_Front_End.Models;
using Eshop_Front_End.ClientServices;

namespace Eshop_Front_End.Authentication
{
    //public class AuthStateProvider : AuthenticationStateProvider
    //{
    //    private readonly HttpClient _httpClient;
    //    private readonly ILocalStorageService _localStorage;


    //    public AuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
    //    {
    //        _httpClient = httpClient;
    //        _localStorage = localStorage;
    //    }


    //    //public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    //    //{

    //    //    var state = new AuthenticationState(new ClaimsPrincipal());

    //    //    string localUsername = await _localStorage.GetItemAsStringAsync("username");






    //    //}


    //}



    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;


        public AuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());

            string localUsername = await _localStorage.GetItemAsStringAsync("username");

            string apiUsername = await _localStorage.GetItemAsStringAsync("apiUsername");

            if (localUsername == apiUsername)
            {
                Console.WriteLine($"Hello {localUsername}");

                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, localUsername)
                }, "test authentication type");

               state = new AuthenticationState(new ClaimsPrincipal(identity));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;

        }


    }





}