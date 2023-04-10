using Microsoft.AspNetCore.Mvc;

namespace ResetServer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculatorController : Controller
    {
        /* uri
         * 
         *  get vs post
         *      get -> server change nemishe
         *      post -> server chnage mishe
         *      
         *  get /calculator/add
         *  get /calculator/sub
         *  get /calculator/mul
         *  get /calculator/div
         *  
         *  
         *  
         */

        [HttpGet]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [HttpGet]
        public int Sub(int a, int b)
        {
            return a + b;
        }


    }
}
