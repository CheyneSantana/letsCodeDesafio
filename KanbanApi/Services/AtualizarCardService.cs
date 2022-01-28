using KanbanApi.Model;
using System;

namespace KanbanApi.Services
{
    public class AtualizarCardService
    {
        private Context _context;
        private Guid _id;
        private Card _card;

        public AtualizarCardService(Context context, Guid id, Card card)
        {
            this._context = context;
           this._id = id;
           this._card = card;
        }

        public void Atualizar()
        {
            if (string.IsNullOrEmpty(this._card.Titulo) && string.IsNullOrEmpty(this._card.Lista))
                throw new Exception("Titulo e lista são obrigatórios");

            this._card.Id = this._id;
            this._context.Update(this._card);
            this._context.SaveChanges();
        }
    }
}
