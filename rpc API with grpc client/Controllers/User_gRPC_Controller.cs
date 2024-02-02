using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grpc.Net.Client;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rpc_API_with_grpc_client.Controllers
{
    [ApiController]
    [Route("gRPC-api/user")]
    public class UserGRPCController : Controller
    {
        //GrpcChannel grpcClient = new GrpcChannel.
            //ForAddress("http://localhost:8095");


        private readonly ILogger<UserGRPCController> _logger;

        public UserGRPCController(ILogger<UserGRPCController> logger)
        {
            _logger = logger;
            // grpcClient = new GrpcChannel.ForAddress("http://localhost:8095");
        }

        // GET: api/values
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            //_logger.Log(100, "Hello");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

