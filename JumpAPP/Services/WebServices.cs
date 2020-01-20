using JumpAPP.Models.WebRequest;
using JumpAPP.Models.WebResponse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JumpAPP.Services
{
    public class WebServices
    {

        public static string LoginUrl = "https://demojump.coore.it/xamarin_ws/token";
        public static string GetCompany = "https://demojump.coore.it/XAMARIN_WS/api/Anagrafica/Aziende/GetAziende";
        public static string GetContact = "https://demojump.coore.it/XAMARIN_WS/api/Anagrafica/Aziende/GetContattiAziende";
        public static string GetCompanyNote = "https://demojump.coore.it/XAMARIN_WS/api/Anagrafica/Aziende/GetNoteAziende";
        public static string GetAppointment = "https://demojump.coore.it/XAMARIN_WS/api/Agenda/Appuntamenti/GetAppuntamenti";
        public static string ContactFilter = "https://demojump.coore.it/XAMARIN_WS/api/Contatti/GetContatti";
        public static string UserInfo = "https://demojump.coore.it/XAMARIN_WS/api/Account/userinfo";
        public static string PostAppointment = "https://demojump.coore.it/XAMARIN_WS/api/Utenti";



        public HttpClient _client = null;
        public static string accesstoken = "";

        public static int ID;

        public static HttpClient _clientGlobal = new HttpClient();
        public WebServices()
        {
            _client = _clientGlobal;
            if (App.accesstoken != "")
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("JWT", App.accesstoken);

            }
        }

        public async Task<HttpResponseMessage> LoginApi(string grant_type, string username, string password)
        {
            try
            {


                //HttpContent content = 
                //content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(LoginUrl),
                    Content = new StringContent("grant_type=password" + "&username=" + username + "&password=" + password) // , System.Text.Encoding.UTF8, "raw")
                };
                var response = await _client.SendAsync(request).ConfigureAwait(false);
                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return response;

            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public async Task<List<CompanyResponseModel>> Company()
        {
            try
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + App.accesstoken);
                var response = await _client.GetAsync(GetCompany);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CompanyResponseModel>>(responseBody);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<List<ContactResponseModel>> ContactDetail()
        {
            try
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + App.accesstoken);
                var response = await _client.GetAsync(GetContact);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<ContactResponseModel>>(responseBody);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public async Task<List<CompanyNoteResponseModel>> GetNote()
        {
            try
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + App.accesstoken);
                var response = await _client.GetAsync(GetCompanyNote);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CompanyNoteResponseModel>>(responseBody);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<UserResponseModel> GetUser()
        {
            try
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + App.accesstoken);
                var response = await _client.GetAsync(UserInfo);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    responseBody = await response.Content.ReadAsStringAsync();
                    DataContractJsonSerializer ser1 = new DataContractJsonSerializer(typeof(UserResponseModel));
                    MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(responseBody));
                    var alert = (UserResponseModel)ser1.ReadObject(stream1);
                    return alert;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<AppointmentResponseModel>> GetAppoint()
        {
            try
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + App.accesstoken);
                var response = await _client.GetAsync(GetAppointment);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<AppointmentResponseModel>>(responseBody);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<ContactFilterResponse>> GetfilterContact()
        {
            try
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + App.accesstoken);
                var response = await _client.GetAsync(ContactFilter);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<ContactFilterResponse>>(responseBody);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<OrganiserFormResponseModel> PostAgendaApi(OrganiserFormRequestModel organiserFormRequestModel)
        {
            try
            {
                var json = JsonConstant.OrganiserRequest(organiserFormRequestModel);
                _client.DefaultRequestHeaders.Clear();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + App.accesstoken);
                var response = await _client.PostAsync(PostAppointment, content);
                string editdatabody = string.Empty; 
                editdatabody = await response.Content.ReadAsStringAsync();
                DataContractJsonSerializer ser1 = new DataContractJsonSerializer(typeof(OrganiserFormResponseModel));
                MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(editdatabody));
                var agenda = (OrganiserFormResponseModel)ser1.ReadObject(stream1);
                return agenda;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
