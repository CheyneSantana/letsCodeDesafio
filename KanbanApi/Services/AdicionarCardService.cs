using KanbanApi.Model;
using System;

namespace KanbanApi.Services
{
    public class AdicionarCardService
    {
        private Card _card;
        private string erro = string.Empty;
        private Context _context;

        public AdicionarCardService(Context context, Card card)
        {
            this._card = card;
            this._context = context;
        }

        public Card Adicionar()
        {
            if (string.IsNullOrEmpty(this._card.Titulo) && string.IsNullOrEmpty(this._card.Lista))
                throw new Exception("Titulo e lista são obrigatórios");

            this._context.Add(this._card);
            this._context.SaveChanges();

            return _card;
        }
    }
}
