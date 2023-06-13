using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciciosRestAPI.Controllers {
    [ApiController]
    [Route("Exercicio1Controller")]
    public class Exercicio1Controller : ControllerBase {
        [HttpGet("nome")]
        public string mostraMeuNome() {
            return "Luan";
        }
        [HttpGet("idade")]
        public int mostraMinhaIdade() {
            return 21;
        }
        [HttpGet("nome/{seuNome}")]
        public string seuNome([FromRoute] string seuNome) {
            return seuNome;
        }
        [HttpGet("idade/{suaIdade}")]
        public int suaIdade([FromRoute] int suaIdade) { 
            return suaIdade;
        }
    }
}
