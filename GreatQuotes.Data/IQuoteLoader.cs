using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatQuotes.Data
{
    public interface IQuoteLoader
    {
        IEnumerable<GreatQuote> Load();
        void Save(IEnumerable<GreatQuote> quotes);

    }
}
