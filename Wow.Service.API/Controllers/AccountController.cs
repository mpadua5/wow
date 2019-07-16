using System;
using Microsoft.AspNetCore.Mvc;
using Wow.Application.Interface;
using Wow.Domain.Entities;

namespace Wow.Service.API.Controllers
{
    [Route("/accepts")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] Account account)
        {
            try
            {
                _accountService.Add(account);
                return Ok("Account - Inserido com Sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Buscar()
        {
            try
            {
                return Ok(_accountService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{guid}")]
        public ActionResult BuscarPorGuid([FromRoute] Guid guid)
        {
            try
            {
                return Ok(_accountService.GetByGuid(guid));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{guid}")]
        public ActionResult Deletar([FromRoute] Guid guid)
        {
            try
            {
                _accountService.Remove(guid);
                return Ok("Account - Deletado com Sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }

        [HttpPut("{guid}")]
        public ActionResult Atualizar([FromRoute] Guid guid, [FromBody] Account account)
        {
            try
            {
                account.Guid = guid;
                _accountService.Update(account);
                return Ok("ACCOUNT - Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }
    }
}