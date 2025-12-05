using Azure;
using Microsoft.AspNetCore.Mvc;
using VFProyect_BACK.Models;
using VFProyect_BACK.Repositories;
using VFProyect_BACK.Models.REQUESTS;
using VFProyect_BACK.Custom;
using VFProyect_BACK.Models.RESPONSES;
using System.Drawing;
using System.Collections.Generic;

namespace VFProyect_BACK.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IUsuarioService usuarioService;
        private readonly Utilidades UTILS;
        public ServiceController(IUsuarioService usuarioService, Utilidades utilidades)
        {
            this.usuarioService = usuarioService;
            this.UTILS = utilidades;
        }

        [HttpGet("GET_LIST_CLIENTES")]
        public async Task<IActionResult> GetClientes()
        {
            try {
            
                var response = await usuarioService.GetClientes();
                if (response == null) return null;
                return Ok(new
                {
                    detail = response
                });
            }
            catch { throw; }
        }

        [HttpGet("GET_LIST_ENTRENADORES")]
        public async Task<IActionResult> GetEntrenadores()
        {
            try
            {

                var response = await usuarioService.GetEntrenadores();
                if (response == null) return null;
                return Ok(new
                {
                    detail = response
                });
            }
            catch { throw; }
        }

        [HttpGet("GET_LIST_CLASES")]
        public async Task<IActionResult> GetClases()
        {
            try
            {

                var response = await usuarioService.GetClases();
                if (response == null) return null;
                return Ok(new
                {
                    detail = response
                });
            }
            catch { throw; }
        }

        [HttpGet("GET_USER_BY_ID")]
        public async Task<IActionResult> GetUsuarioByIdAsync(int ID)
        {
            try
            {
                var response = await usuarioService.GetUsuarioByIdAsync(ID);
                if (response == null) return null;
                return Ok(new
                {
                    detail = response
                });
            }
            catch { throw; }
        }

        [HttpPost("LOGIN")]
        public async Task<IActionResult> Login(LoginUserRequest USUARIO)
        {
            if (USUARIO == null) return BadRequest();
            try
            {
                var RESPONSE = await usuarioService.Login(USUARIO);

                string wMESSAGE = "";
                if (RESPONSE.Count() > 0) wMESSAGE = "SUCCESFULL";

                return Ok(new
                {
                    SUCCESS = true,
                    DETAIL = RESPONSE,
                    MESSAGE = wMESSAGE,
                    TOKEN = UTILS.generarJWT(RESPONSE[0])

                }); 
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    SUCCESS = false,
                    TOKEN = "",
                    MESSAGE = ex.Message

                });
            }
        }

        [HttpGet("VALIDATION_TOKEN")]
        public IActionResult ValidarToken([FromQuery]String TOKEN)
        {

            bool RESPONSE = UTILS.validarToken(TOKEN);

            string wMESSAGE = "";
            if (RESPONSE) wMESSAGE = "SUCCESFULL";

            return Ok(new
            {
                SUCCESS = RESPONSE,
                MESSAGE = wMESSAGE
            });
        }

    }
}
