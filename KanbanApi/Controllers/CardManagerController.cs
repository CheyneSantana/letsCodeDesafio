using KanbanApi.Model;
using KanbanApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KanbanApi.Controllers
{
    [ApiController]
    public class CardManagerController : ControllerBase
    {
        private readonly Context _context;

        public CardManagerController(Context context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet, Route("cards")]
        public async Task<IActionResult> getCards()
        {
            List<Card> cards = await this._context.Cards.ToListAsync();

            return Ok(cards);
        }

        [Authorize]
        [HttpPost, Route("cards")]
        public async Task<IActionResult> addCard(Card card)
        {
            try
            {
                AdicionarCardService service = new AdicionarCardService(this._context, card);

                return Ok(service.Adicionar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpDelete, Route("cards/{id}")]
        public async Task<IActionResult> deleteCard(Guid id)
        {
            try
            {
                DeletarCardService service = new DeletarCardService(_context, id);
                service.Deletar();

                return Ok("Card removido com sucesso");
            }
            catch (Exception)
            {
                return NotFound("Card não encontrado");
            }
        }

        [Authorize]
        [HttpPut, Route("cards/{id}")]
        public async Task<IActionResult> updateCard(Guid id, [FromBody] Card card)
        {
            try
            {
                AtualizarCardService service = new AtualizarCardService(this._context, id, card);
                service.Atualizar();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
