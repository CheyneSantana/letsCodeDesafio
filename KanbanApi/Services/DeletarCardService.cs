using KanbanApi.Model;
using System;
using System.Diagnostics;

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

            Debug.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " - Card " + card.Id + " - " + card.Titulo + " - Removido");

            this._context.Remove(card);
            this._context.SaveChanges();
        }
    }
}
