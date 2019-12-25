using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chord.IO.Service.Controllers
{
    //[Route("api/bulks")]
    //[ApiController]
    //public class BulkController : ControllerBase
    //{
    //    [HttpPost("dispatch")]
    //    public async Task<ActionResult<Dictionary<string, HttpResponseMessage>>> Dispatch([FromBody] Dictionary<string, HttpRequestMessage> messages)
    //    {
    //        var responses = new Dictionary<string, HttpResponseMessage>();

    //        using (var client = new HttpClient())
    //        {
    //            foreach (var (name, request) in messages)
    //            {
    //                var uri = new UriBuilder(request.RequestUri)
    //                {
    //                    Host = "localhost",
    //                    Port = 80,
    //                    Scheme = "http"
    //                };

    //                request.RequestUri = uri.Uri;

    //                var response = await client.SendAsync(request);
    //                responses.Add(name, response);
    //            }
    //        }

    //        return responses;
    //    }
    //}
}