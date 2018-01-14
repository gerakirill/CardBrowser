using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardBrowser.BLL.Models;
using CardBrowser.DAL;

namespace CardBrowser.Infrastructure.Interfaces
{
    public interface ICardService
    {
        CardBase GetCardById(int id);
        IEnumerable<CardBase> GetAllCards();
        void CreateCard(CardBase card);
        void UpdateCard(CardBase card);
        void DeleteCard(CardBase card);
    }
}
