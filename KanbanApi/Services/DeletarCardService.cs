using KanbanApi.Model;
using System;

namespace KanbanApi.Services
{
    public class DeletarCardService
    {
        private Context _context;
        private Guid _id;

        public DeletarCardService(Context context, Guid id)
        {
            _context = context;
            _id = id;
        }

        public void Deletar()
        {
            Card card = this._context.Cards.Find(_id);
            if (card == null)
                throw new Exception();

            this._context.Remove(card);
            this._context.SaveChanges();
        }
    }
}
