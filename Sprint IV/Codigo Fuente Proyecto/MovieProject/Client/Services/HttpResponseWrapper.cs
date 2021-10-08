using System;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Net.Http;
namespace MovieProject.Client.Services
{
    public class HttpResponseWrapper<T>
    {
        public bool Error{get;set;}
        public T Response{get;set;}
        public HttpResponseMessage HttpResponseMessage {get;set;}
        
        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage){
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }        
    }
}