using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatQuotes.Data
{
    public static class QuoteLoaderFactory
    {
        // This must be assigned to a method which creates a new quote loader.
        public static Func<IQuoteLoader> Create { set; get; }
    }
}
